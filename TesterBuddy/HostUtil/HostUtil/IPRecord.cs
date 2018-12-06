//Create by Manian VSS

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HostUtil
{
    /// <summary>
    /// This class provided methods to modify host file. (etc/hosts)
    /// </summary>
    [Serializable]
    public class IPRecord
    {
        public string hostname;
        public string alias;
        public string IP;
        public string comments;
        public static string hostfilecomments = "";

        public IPRecord()
        {
            IP = "0.0.0.0";
            hostname = "host.domain.com";
            alias = "host";
        }

        public IPRecord(string IP, string hostname, string alias)
        {
            this.IP = IP;
            this.hostname = hostname;
            this.alias = alias;
        }
        
        public void AddComments(string commentString)
        {
        	string []cmntarray=commentString.Split('\n');
        	
        	foreach(string cmnt in cmntarray)
        	{
        		comments=comments+"\r\n#["+hostname+"]:"+cmnt.Trim('\r',' ','\t');
        	}
        }

        public string GetComments()
        {
        	return comments;
        }
        
        public bool HostMathes(IPRecord a)
        {
            if (hostname.ToLower().Equals(a.hostname.ToLower()))
                return true;
            if (IP.Equals(a.IP))
                return true;
            return false;
        }

        private static string AlphanumericalTrim(string a)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in a)
            {
                if (char.IsLetterOrDigit(c) || (c == ' ') || (c == '.') || (c == '\t') || (c == '#'))
                    sb.Append(c, 1);
            }
            return sb.ToString();
        }
        
        public static IPRecord GetRecordByHostname(string hostname, string hostsfilename)
        {
        	IPRecord[] records=GetRecords(hostsfilename);
        	
        	foreach(IPRecord ipr in records)
        	{
        		if(ipr.HostMathes(new IPRecord("",hostname,"")))
        		{
        			return ipr;
        		}
        	}
        	
        	return null;
        }

        public static IPRecord[] GetRecords(string fname)//="c:/Windows/System32/drivers/etc/hosts")
        {
            hostfilecomments = "";
            StringBuilder sb = new StringBuilder();
            byte[] buff = new byte[1024];
            List<IPRecord> ipl = new List<IPRecord>();
            ASCIIEncoding ae = new ASCIIEncoding();
            string filedata = File.ReadAllText(fname);

            //	Console.WriteLine("Records read.\n"+filedata);

            sb.Append(filedata);
            sb = sb.Replace("\r\n", "\n");
            sb = sb.Replace("\n\n", "\n");
            sb = sb.Replace("\t\t", "\t");
            sb = sb.Replace("\t", " ");
            
            while(sb.ToString().Contains("  "))
            {
            	sb.Replace("  "," ");
            }
            
            filedata = sb.ToString();
            string[] lines = filedata.Split('\n');

            foreach (string s in lines)
            {
                //IPV6 not handled by Host Util yet
                if ((s.StartsWith("#")) || (s.Length < 3) || (s.StartsWith(":")))
                {                
                    continue;
                }

                string str = s;
                str = AlphanumericalTrim(s);
                string[] feilds = str.Split(' ');

                if (feilds.Length >= 3)
                    ipl.Add(new IPRecord(feilds[0], feilds[1], feilds[2]));
                else if (feilds.Length == 2)
                    ipl.Add(new IPRecord(feilds[0], feilds[1], feilds[1]));
                else
                    continue;
            }
            
            foreach (string s in lines)
            {
                //IPV6 not handled by Host Util yet
                if ((s.StartsWith("#")) || (s.Length < 3) || (s.StartsWith(":")))
                {
                	foreach(IPRecord ip in ipl)
                	{
                		if(s.StartsWith("#["+ip.hostname+"]:")||s.StartsWith("#["+ip.alias+"]:")||s.StartsWith("#["+ip.IP+"]:"))
                		{
                			ip.AddComments(s.Substring(s.IndexOf(":")+1));
                			continue;
                		}
                	}
                	
                    hostfilecomments = hostfilecomments + s + "\r\n";
                }
            }

            return (IPRecord[])ipl.ToArray();
        }

        public string GetHostLine()
        {
            return IP + "\t" + hostname + "\t" + alias + "\r\n";
        }

        public static void DeleteHost(IPRecord host, string fname)
        {
            String fileData = "";
            IPRecord[] current = GetRecords(fname);

            foreach (IPRecord a in current)
            {
                if (a.HostMathes(host))
                {
                    //Don't put record
                }
                else
                {
                    //Console.WriteLine("I was here at else.\n");
                    fileData = fileData + a.GetHostLine();
                }
            }

            //Restore comments/IPV6 records to the host file
            if (!string.IsNullOrEmpty(hostfilecomments))
            {
                fileData = hostfilecomments + fileData;
            }

            File.WriteAllText(fname, fileData);
        }

        public static void DeleteHostByName(string host, string fname)
        {
            IPRecord check = new IPRecord("", host, "");

            String fileData = "";
            IPRecord[] current = GetRecords(fname);

            foreach (IPRecord a in current)
            {
                if (a.HostMathes(check))
                {
                    //Don't put record
                }
                else
                {
                    //Console.WriteLine("I was here at else.\n");
                    fileData = fileData + a.GetHostLine();
                }
            }

            //Restore comments/IPV6 records to the host file
            if (!string.IsNullOrEmpty(hostfilecomments))
            {
                fileData = hostfilecomments + fileData;
            }

            File.WriteAllText(fname, fileData);
        }

        public static void DeleteHostByIP(string ip, string fname)
        {
            IPRecord check = new IPRecord(ip, "", "");

            String fileData = "";
            IPRecord[] current = GetRecords(fname);

            foreach (IPRecord a in current)
            {
                if (a.HostMathes(check))
                {
                    //Don't put record
                }
                else
                {
                    //Console.WriteLine("I was here at else.\n");
                    fileData = fileData + a.GetHostLine();
                }
            }

            //Restore comments/IPV6 records to the host file
            if (!string.IsNullOrEmpty(hostfilecomments))
            {
                fileData = hostfilecomments + fileData;
            }

            File.WriteAllText(fname, fileData);
        }

        public static void AddRecords(IPRecord r, string fname)//="c:/Windows/System32/drivers/etc/hosts")
        {
            bool existingRecord = false;
            String fileData = "";
            IPRecord[] current = GetRecords(fname);

            foreach (IPRecord a in current)
            {
                if (!a.HostMathes(r))
                {
                    //Console.WriteLine("I was here at If.\n");
                    fileData= fileData + a.comments+"\r\n";
                    fileData = fileData + a.GetHostLine();
                }
                else
                {
                    //Console.WriteLine("I was here at else.\n");
                    
                    if(string.IsNullOrEmpty(r.comments))
                    {
                    	fileData= fileData + r.comments+"\r\n";
                    }
                    else
                    {
                    	fileData= fileData + a.comments+"\r\n";
                    }
                    
                    fileData = fileData + r.GetHostLine();
                    existingRecord = true;
                }
            }
            if (!existingRecord)
            {
            	fileData= fileData + r.comments+"\r\n";
                fileData = fileData + r.GetHostLine();
            }

            //Restore comments/IPV6 records to the host file
            if (!string.IsNullOrEmpty(hostfilecomments))
            {
                fileData = hostfilecomments + fileData;
            }

            File.WriteAllText(fname, fileData);
        }

        private static void SwapRecords(ref IPRecord a, ref IPRecord b)
        {
            IPRecord temp = new IPRecord(a.IP, a.hostname, a.alias);

            a.hostname = b.hostname;
            a.IP = b.IP;
            a.alias = b.alias;


            b.hostname = temp.hostname;
            b.IP = temp.IP;
            b.alias = temp.alias;
        }

        public static void SortRecordsBasedOnHostName(string fname)//="c:/Windows/System32/drivers/etc/hosts")
        {
            //bool existingRecord=false;
            String fileData = "";
            IPRecord[] current = GetRecords(fname);

            for (int i = 0; i < current.Length; i++)
            {
                for (int j = 0; j < (current.Length - 1); j++)
                {
                    if (current[j].hostname.CompareTo(current[i].hostname) > 0)
                    {
                        SwapRecords(ref current[i], ref current[j]);
                    }
                }
            }

            foreach (IPRecord a in current)
            {
            	fileData= fileData +a.comments+"\r\n";
                fileData = fileData + a.GetHostLine();
            }

            //Restore comments/IPV6 records to the host file
            if (!string.IsNullOrEmpty(hostfilecomments))
            {
                fileData = hostfilecomments + fileData;
            }


            File.WriteAllText(fname, fileData);
        }
    }
}