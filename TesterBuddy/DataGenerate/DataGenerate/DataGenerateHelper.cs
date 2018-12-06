/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 1/9/2013
 * Time: 3:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Threading;

namespace DataGenerate
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class DataGenerateHelper
	{
		public static void IncrementCounters(ref string instring, ref List<string> counters)
		{
			ASCIIEncoding ae=new ASCIIEncoding();
			
			//string []counters=counterString.Split('\n');
			
			for(int i=0;i<counters.Count;i++)
			{
				counters[i]=counters[i].Trim('\r',' ','\t');
				
				//Debug Messages
				//ProcessTextRTB2.AppendText("\n Counters["+i+"]="+counters[i]);
			}
			
			List<string> replaceCounters=new List<string>();
			
			foreach(string counter in counters)
			{
				replaceCounters.Add(counter);
			}
			
			//bool carry;
			char tempChar,tempchar2;
			
			for(int i=0;i<replaceCounters.Count;i++)
			{
				for(int j=replaceCounters[i].Length-1;j>=0;j--)
				{
					tempChar=replaceCounters[i][j];
					tempchar2=replaceCounters[i][j];
					tempchar2++;
					
					string str1=replaceCounters[i].Substring(0,j);
					string str2;
					
					if(char.IsDigit(replaceCounters[i][j]))
					{
						tempchar2=(char)( ((tempChar+1)-'0')%10+'0');
						str2=tempchar2.ToString();
					}
					else if(char.IsLetter(replaceCounters[i][j]))
					{
						char addchar;
						
						if(char.IsLower(replaceCounters[i][j]))
						{
							addchar='a';
						}
						else
						{
							addchar='A';
						}
						
						tempchar2=(char)( ((tempChar+1)-addchar)%26+addchar);
						str2=tempchar2.ToString();
					}
					else
					{
						//Don't have to increment on non alpha numerical character.
						//str2=((char)(replaceCounters[i][j]+1)).ToString();
						continue;
					}
					string str3=replaceCounters[i].Substring(j+1,replaceCounters[i].Length-j-1);
					
					//Debug messages
					//ProcessTextRTB2.AppendText("\n replaceCounters[i].Substring(0,j)="+str1);
					//ProcessTextRTB2.AppendText("\n ((char)replaceCounters[i][j]+1)).ToString()="+str2);
					//ProcessTextRTB2.AppendText("\n replaceCounters[i].Substring(j+1,replaceCounters[i].Length-j-1)="+str3);
					
					replaceCounters[i]=str1+str2+str3;
					
					//Debug messages
					//ProcessTextRTB2.AppendText("\n replaceCounters["+i+"]="+replaceCounters[i]);
					
					if(tempChar<tempchar2)
					{
						break;
					}
				}
			}
			
			for(int i=0;i<counters.Count;i++)
			{
				if(string.IsNullOrEmpty(replaceCounters[i]))
				{
					continue;
				}
				
				instring=instring.Replace(counters[i],replaceCounters[i]);
				counters[i]=replaceCounters[i];
			}
		}
		
		
		/*
		 * 
<datagen>
	<datagen-static>
		<datagen-static-line text="Static Header line example" />
	</datagen-static>

	<datagen-counter-criteria count="10" criteria="abc">
		<criteria value="def"/>
		<datagen-counter-criteria-line template="123abc" />
		<criteria value="ghi"/>
		<criteria value="jkl"/>
		<datagen-counter-criteria-line template="ghi" />
		<datagen-counter-criteria-line template="jkl" />
		<criteria value="123"/>
	</datagen-counter-criteria>
	
	
	<datagen-counter start="1" end="10" increment="1" symbol="~">
		<datagen-counter-line template="~: This is my line example ~" />
	</datagen-counter>
</datagen>
*/

		public static void StartProgressBarThread(ProgressBar pb)
		{
			float prevProgress=-1;
			
			if(pb==null)
			{
				return;
			}
			
			while(pb.Value<pb.Maximum)
			{
				float currentProgress=(float)pb.Value/pb.Maximum;
				if(currentProgress>prevProgress)
				{
					pb.Refresh();
					prevProgress=currentProgress;
				}
				Thread.Sleep(100);
			}
		}
		
		public static void GenerateDataFileFromXMLTemplate(string intemplate,string filename,ProgressBar pb=null)
		{
			//string []instructionsArray=textBox_GenTemplate.Text.Split('\r','\n');
			//string []template;
	
			if(File.Exists(filename))
			{
				File.Delete(filename);
			}
			
			ASCIIEncoding ae= new ASCIIEncoding();
			LinkedList<string> instructions=new LinkedList<string>();
	
			
			StringBuilder sb=new StringBuilder();
			//FileStream fs=new FileStream(filename,FileMode.Create);
			
			TextReader tr= new StringReader(intemplate);
			
			XmlTextReader xr=new XmlTextReader(tr);
			string elementName;//, settingName, attrName, attrVal;
			
			ulong start, end, increment;
			string symbol,template,towrite;
			
			while(xr.Read())
			{
				switch (xr.NodeType) 
       			{
				case XmlNodeType.Element:
					elementName=xr.Name;

					if(elementName.Equals("datagen"))
					{	
						break;
					}
					else if(elementName.Equals("datagen-static"))
					{
						//staticString="";
						
						bool proceed=false, staticlinefound=false;
						while(xr.Read())
						{
							switch(xr.NodeType)
							{
								case XmlNodeType.Element:
				       			{
									elementName=xr.Name;
				
									if(elementName.Equals("datagen-static-line"))
									{
										staticlinefound=true;
										//fs.Write(ae.GetBytes(xr.GetAttribute("text")+"\r\n"),0,ae.GetByteCount(xr.GetAttribute("text")+"\r\n"));
										//sb.AppendLine(xr.GetAttribute("text"));
										File.AppendAllText(filename,xr.GetAttribute("text")+"\r\n");
									}
									break;
								}
								case XmlNodeType.EndElement:
									if(staticlinefound)
									{
										proceed=true;
									}
									break;
								default:
									break;							
							}
							
							if(proceed)
							{
								break;
							}
						}
						//attrName=xr.GetAttribute("name");
						//attrVal=xr.GetAttribute("value");
						//settingList.AddLast(new KeyValuePair<string, string>(attrName,attrVal));
					}
					else if(elementName.Equals("datagen-counter-criteria"))
					{												
						int count=int.Parse(xr.GetAttribute("count"));
						string criteria=xr.GetAttribute("criteria");	
						List<string> criteriaList=new List<string>();
						
						template="";
						
						if(pb!=null)
						{
							pb.Value=0;
							pb.Minimum=0;
							pb.Maximum=count;
						}
						
						bool breakloop=false;
						while(xr.Read())
						{
							while(true)
							{
								switch(xr.NodeType)
								{
									case XmlNodeType.Element:
									elementName=xr.Name;
				       				if(elementName.Equals("datagen-counter-criteria-line"))
									{
										template=template+xr.GetAttribute("template")+"\r\n";
									}	
				       				else if(elementName.Equals("criteria"))
				       				{
				       					string temp=xr.GetAttribute("value");
				       					
				       					if(!string.IsNullOrEmpty(temp)&&!criteriaList.Contains(temp))
				       					{
				       						criteriaList.Add(temp);
				       					}
				       				}
				       				else
				       				{
				       					MessageBox.Show("Template has errors!!!","Error!");
				       					return;
				       				}
									break;
									
									case XmlNodeType.EndElement:
									elementName=xr.Name;
									if(elementName.Equals("datagen-counter-criteria"))
									{
										breakloop=true;
									}	
				       				break;
				       				
									default:
										break;
								}
								
								if(!xr.Read())
								{
									break;
								}
								
								if(breakloop)
								{
									break;
								}
							}
							
							if(breakloop)
							{
								break;
							}
						}
						
						if(!breakloop)
						{
							MessageBox.Show("Error parsing xml template!!!","Grr!!");
							return;
						}
						
						if(!string.IsNullOrEmpty(criteria)&&!criteriaList.Contains(criteria))
						{
							criteriaList.Add(criteria);
						}
						
						//ThreadStart dghst=delegate {StartProgressBarThread(pb);};
						//Thread progressBarThread=new Thread(dghst);
						//progressBarThread.Start();
						
						for(int i=0;i<count;i++)
						{															
							//fs.Write(ae.GetBytes(towrite),0,ae.GetByteCount(towrite));
							File.AppendAllText(filename,template);
							IncrementCounters(ref template, ref criteriaList);	
							
							if(pb!=null)
							{
								pb.Value++;		
								//pb.Refresh();
							}
						}
						
						//pb.Value=pb.Maximum;
						//progressBarThread=null;
						
						//File.WriteAllText(filename,sb.ToString());
					}
					else if(elementName.Equals("datagen-counter"))
					{						
						start=ulong.Parse(xr.GetAttribute("start"));
						end=ulong.Parse(xr.GetAttribute("end"));
						increment=ulong.Parse(xr.GetAttribute("increment"));
						symbol=xr.GetAttribute("symbol");
						
						if(pb!=null)
						{
							pb.Value=0;
							pb.Minimum=0;
							pb.Maximum=(int)(end-start+1);
						}
						
						template="";
						
						bool foundtemplate=false;
						while(xr.Read())
						{
							switch(xr.NodeType)
							{
								case XmlNodeType.Element:
								elementName=xr.Name;
			       				if(elementName.Equals("datagen-counter-line"))
								{
									template=template+xr.GetAttribute("template")+"\r\n";
									foundtemplate=true;
								}			       				
								break;
								
								case XmlNodeType.EndElement:
								if(foundtemplate)
								{
									break;
								}								
								break;
								
								default:
									break;
							}
							if(foundtemplate)
							{
								break;
							}
						}
						
						if(!foundtemplate)
						{
							MessageBox.Show("Error parsing xml template!!!","Grr!!");
							break;
						}
						
						//ThreadStart dghst=delegate {StartProgressBarThread(pb);};
						//Thread progressBarThread=new Thread(dghst);
						//progressBarThread.Start();
						
						for(ulong i=start;i<=end;i=i+increment)
						{
							towrite=template.Replace(symbol,i.ToString());
							
							//fs.Write(ae.GetBytes(towrite),0,ae.GetByteCount(towrite));
							//sb.Append(towrite);
							File.AppendAllText(filename,towrite);
							
							if(pb!=null)
							{
								pb.Value++;
								//pb.Refresh();
							}
						}
						
						//pb.Value=pb.Maximum;
						
						//progressBarThread=null;
						
						//File.WriteAllText(filename,sb.ToString());
					}
					else
					{
						MessageBox.Show("Error parsing xml template!!!","Grr!!");
						break;
					}
					break;
					
				case XmlNodeType.EndElement:
					break;
					
				default:
						break;
				}

			}
			
			if(pb!=null)
			{
				pb.Value=0;
				pb.Refresh();
			}
		}
	}
}