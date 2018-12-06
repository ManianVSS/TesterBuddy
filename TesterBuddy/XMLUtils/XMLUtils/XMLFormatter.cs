using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Xml;

namespace XMLUtils
{
    public class XMLFormatter
    {        
		public static string XmlEscape(string unescaped)
		{
		    /*XmlDocument doc = new XmlDocument();
		    XmlNode node = doc.CreateElement("root");
		    node.InnerText = unescaped;
		    doc.CreateTextNode(unescaped);
		    return doc.OuterXml;
		    */
		    /*
			    * "   &quot;
				'   &apos;
				<   &lt;
				>   &gt;
				&   &amp;
			*/
			
			string escaped=unescaped.Replace("&","&amp;");
			escaped=escaped.Replace("<","&lt;");
			escaped=escaped.Replace(">","&gt;");
			escaped=escaped.Replace("\'","&apos;");
			escaped=escaped.Replace("\"","&quot;");
			escaped=escaped.Replace("\n","&#xa;");//&#xa;
			return escaped;
		}
		
		public static string XmlUnescape(string escaped)
		{
		   /* XmlDocument doc = new XmlDocument();
		    XmlNode node = doc.CreateElement("root");
		    node.InnerXml = escaped;
		    return node.InnerText;*/
		    
		    
			string unescaped=escaped;
			
			unescaped=unescaped.Replace("&quot;","\"");
			unescaped=unescaped.Replace("&apos;","\'");
			unescaped=unescaped.Replace("&gt;",">");
			unescaped=unescaped.Replace("&lt;","<");
			unescaped=unescaped.Replace("&amp;","&");
			unescaped=unescaped.Replace("&#xa;","\n");//&#xa;
			
			return unescaped;
		}
		
    	public static string RemoveNullValueParameters(string XML)
    	{    		
    		ASCIIEncoding ae=new ASCIIEncoding();
    		string tempdirectory=Environment.GetEnvironmentVariable("TMP");
    		string tempxmlfile=tempdirectory+"TB_Temp.xml";   		
    		string tempxmlfile2=tempdirectory+"TB_Temp2.xml";   		
    		
    		Stream outstream=new MemoryStream();
    	    		
    		File.WriteAllText(tempxmlfile,XML);
    		File.WriteAllText(tempxmlfile2,"");
    		
    		
    		XmlTextReader xr=new XmlTextReader(tempxmlfile);
    		XmlTextWriter xtw=new XmlTextWriter(tempxmlfile2,Encoding.UTF8);
    		
    		string elementName, attrName, attrVal,comment;
			
			while(xr.Read())
			{
				switch (xr.NodeType) 
       			{				    
					case XmlNodeType.Element:
						elementName=xr.Name;
						xtw.WriteStartElement(elementName);						
						
						if(xr.HasAttributes)
						{							
							while(xr.MoveToNextAttribute())
							{														
								attrName=xr.LocalName;
								attrVal=xr.Value;
								
								if(!string.IsNullOrEmpty(attrVal))
								{
									xtw.WriteAttributeString(attrName,attrVal);						
								}		
								
							}
						}
						
						break;
					case XmlNodeType.EndElement:
						xtw.WriteEndElement();
						break;	
					/*case XmlNodeType.Attribute:												
						attrName=xr.GetAttribute("name");
						attrVal=xr.GetAttribute("value");
						
						
						if(!string.IsNullOrEmpty(attrVal))
						{
							xtw.WriteStartAttribute(attrName,attrVal);
							xtw.WriteEndAttribute();						
						}													
						break;
						*/
					case XmlNodeType.Comment:
						comment=xr.Value;
						xtw.WriteComment(comment);
						break;
					default:
						break;
				}
			}
			xr.Close();
			xtw.Close();
			
			return IndentXML(File.ReadAllText(tempxmlfile2));
    	}
    	
        public static string IndentXML(string XML)
        {
        	/*
        	if(!XML.TrimStart().StartsWith("<?xml"))
        	{
        		XML="<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n"+XML;
        	}*/
        	
            string FormattedXML="";

            MemoryStream mStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode);
            XmlDocument document = new XmlDocument();
           
            // Load the XmlDocument with the XML.
            document.LoadXml(XML);

            document.Normalize();
            
            writer.Formatting = Formatting.Indented;
            writer.IndentChar = '\t';
            writer.Indentation = 1;

            // Write the XML into a formatting XmlTextWriter
            document.WriteContentTo(writer);
            writer.Flush();
            mStream.Flush();

            // Have to rewind the MemoryStream in order to read
            // its contents.
            mStream.Position = 0;

            // Read MemoryStream contents into a StreamReader.
            StreamReader sReader = new StreamReader(mStream);

            // Extract the text from the StreamReader.
            FormattedXML = sReader.ReadToEnd();                
       
            mStream.Close();
            writer.Close();

            return FormattedXML;
        }
    }
}
