using System;
using System.Configuration;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using XMLUtils;

namespace SettinsNS
{	
	struct SettingNode
	{
		public bool hasDesc, ismultiple;
		public string name,Value,description;
		public List<String> Values;
		
		public SettingNode(string xname, string xvalue)
		{
			hasDesc=false;
			name=xname;
			Value=xvalue;
			description="";
			ismultiple=false;
			Values=new List<string>();
		}
		
		
		public SettingNode(string xname, string xvalue, string xdescription)
		{
			hasDesc=true;
			name=xname;
			Value=xvalue;
			description=xdescription;
			ismultiple=false;
			Values=new List<string>();
		}
		
		public SettingNode(string xname, List<string> xValues)
		{
			name=xname;
			ismultiple=true;
			Values=new List<string>();
			
			foreach(string val in xValues)
			{
				Values.Add(val);
			}
			
			hasDesc=false;
			description="";
			Value="";
		}
		
		public SettingNode(string xname, List<string> xValues, string xdescription)
		{
			name=xname;
			ismultiple=true;
			Values=new List<string>();
			
			foreach(string val in xValues)
			{
				Values.Add(val);
			}
			
			hasDesc=true;
			description=xdescription;
			Value="";
		}
	}
	
    public class Settings
    {
        //	public Hashtable settingHash =new Hashtable();
        List<SettingNode> settingList = new List<SettingNode>();
        //public SettingsAttributeDictionary settingHash2 = new SettingsAttributeDictionary();

        public string normalizeString(string s)
        {
            return s.Trim(' ', '\t', '\r', '\n');
        }

        public void AddSetting(string name, bool multiple=false)
        {
            if (!settingExists(name))
            {
            	if(!multiple)
            	{
            		SettingNode sn=new SettingNode(name, "");
                	this.settingList.Add(sn);
            	}
            	else
            	{
            		SettingNode sn=new SettingNode(name, new List<string>());
                	this.settingList.Add(sn);
            	}
            }
        }
        
        
        public void AddSettingAndDescription(string name, string description)
        {
            if (!settingExists(name))
            {
                this.settingList.Add(new SettingNode(name, "", description));
            }
            else
            {
            	
            }
        }                
        
        public void AddSetting(string name, string xvalue)
        {
        	AddSetting(name);
        	setSetting(name,xvalue);
        }
        
        public void AddSetting(string name, List<string> values)
        {
        	AddSetting(name);
        	setSettingValues(name,values);
        }
        
        public Settings()
        {

        }

        public void RemoveSetting(string name)
        {
            foreach(SettingNode svp in settingList)
            {
                if (svp.name.Equals(name))
                {
                    this.settingList.Remove(svp);
                    break;
                }
            }
        }

        public Settings(Settings s)
        {
            foreach (SettingNode kvp in s.settingList)
            {
                //this.settingHash.Add(kvp.name,kvp.Value);
                this.settingList.Add(new SettingNode(kvp.name, kvp.Value));
            }
        }

        public bool settingExists(string settingName)
        {
            foreach (SettingNode kvp in settingList)
            {
                if (kvp.name.Equals(settingName))
                {
                    return true;
                }
            }
            return false;
        }

        public bool valueExists(string value)
        {
            foreach (SettingNode kvp in settingList)
            {
                if (kvp.Value.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public string getSettingValue(string settingName, string defaultValue)
        {
            foreach (SettingNode kvp in settingList)
            {
                if (kvp.name.Equals(settingName))
                {
                    return kvp.Value;
                }
            }
            return defaultValue;
        }
        
        public string getSettingValue(string settingName)
        {
            foreach (SettingNode kvp in settingList)
            {
                if (kvp.name.Equals(settingName))
                {
                    return kvp.Value;
                }
            }
            return "";
        }
        
        public List<string> getSettingValues(string settingName)
        {
            foreach (SettingNode kvp in settingList)
            {
                if (kvp.name.Equals(settingName))
                {
                    return kvp.Values;
                }
            }
            return new List<string>();
        }

        public bool setSetting(string settingName, string xvalue)
        {
            foreach (SettingNode kvp in settingList)
            {
                if (kvp.name.Equals(settingName))
                {
                    settingList.Remove(kvp);
                    settingList.Add(new SettingNode(settingName, xvalue));
                    return true;
                }
            }
            return false;
        }
        
        public bool setSettingValues(string settingName, List<string> values)
        {
            foreach (SettingNode kvp in settingList)
            {
                if (kvp.name.Equals(settingName))
                {
                    settingList.Remove(kvp);
                    settingList.Add(new SettingNode(settingName, values));
                    return true;
                }
            }
            return false;
        }
        
        public bool addSettingValue(string settingName, string value)
        {
            foreach (SettingNode kvp in settingList)
            {
                if (kvp.name.Equals(settingName))
                {                   
                	kvp.Values.Add(value);
                    return true;
                }
            }
            return false;
        }

        public void SaveSettingsToXMLFile(string xmlFileName)
        {
            string xmlFileData = "<Settings>";

            foreach (SettingNode setting in settingList)
            {
            	
            	
            	xmlFileData = xmlFileData + "<Setting name=\"" + XMLUtils.XMLFormatter.XmlEscape(setting.name) + "\"" ;
            	
            	if(setting.hasDesc)
            	{
            		xmlFileData=xmlFileData+" description=\""+XMLUtils.XMLFormatter.XmlEscape(setting.description)+"\"";
            	}
            	
            	if(!setting.ismultiple)
            	{
            		xmlFileData=xmlFileData+" value=\"" + XMLUtils.XMLFormatter.XmlEscape(setting.Value)+"\" />" ;
            	}
            	else
            	{
            		xmlFileData=xmlFileData+">\n";
            		
            		foreach(string val in setting.Values)
            		{
            			xmlFileData=xmlFileData+"\t<SettingValue value=\""+XMLUtils.XMLFormatter.XmlEscape(val)+"\"/>\n";
            		}
            		
            		xmlFileData=xmlFileData+"</Setting>";
            	}
            	
            }

            xmlFileData = xmlFileData + "</Settings>";

            File.WriteAllText(xmlFileName, XMLFormatter.IndentXML(xmlFileData));
        }


        public Settings(string fname)
        {
            getSettingsFromXML(fname);
        }


        public void getSetttingsFromXMLString(string xmlstring)
        {
            string tempfile = Environment.TickCount + ".tmp";

            File.WriteAllText(tempfile, xmlstring);

            getSettingsFromXML(tempfile);

            File.Delete(tempfile);
        }

        public void getSettingFromEncryptedXML(string XMLFileName)
        {
            File.Decrypt(XMLFileName);
            getSettingsFromXML(XMLFileName);
            File.Encrypt(XMLFileName);
        }

        /* Example of a xml settings file
<Settings>
	<Setting name="settingname" value="settingvalue"/>	
	<Setting name="settingname" value="settingvalue" description="description"/>
	<Setting name="settingname" description="Description is optional">
		<SettingValue value="value1"/>		
		<SettingValue value="value2"/>
		<SettingValue value="value3"/>
	</Setting>
</Settings>
         * */
        public void getSettingsFromXML(string XMLFileName)
        {
            if (!File.Exists(XMLFileName))
            {
                throw new FileNotFoundException("The xml settings file: " + XMLFileName + " was not found.\n");
            }
       
            //XmlTextReader xr = new XmlTextReader(XMLFileName);
            string attrName, attrVal,description="";

            XmlDocument xmldoc=new XmlDocument();
            xmldoc.Load(XMLFileName);
            
           /* 
            XmlNodeList settingsElementList=xmldoc.GetElementsByTagName("Settings");
            
            if(settingsElementList.Count!=1)
            {
            	Console.WriteLine("Error parsing "+XMLFileName+" Settings not correct.");
            	return;
            }
            
           if(!xmldoc.Name.Equals("Settings"))
           {
           		Console.WriteLine("Error parsing "+XMLFileName+" : Root element incorrect.");
            	return;
           }*/
           
           XmlNodeList settingElementList= xmldoc.GetElementsByTagName("Setting");
           
           foreach(XmlNode xn in settingElementList)
           {
           	attrName=xn.Attributes["name"].Value;
           	
           	XmlAttribute valueattribute=xn.Attributes["value"];
           	if(valueattribute!=null)
           	{
           		attrVal=valueattribute.Value;
           	}
           	else
           	{
           		attrVal="";
           	}
           	
       		XmlAttribute descAttribute=xn.Attributes["description"];
           	if(descAttribute!=null)
           	{
           		description=descAttribute.Value;
           	}
           	else
           	{
           		description="";
           	}
           	
           	//Delete if existing
           	RemoveSetting(attrName);
           	
           	List<String> attrValues=new List<string>();
           	
           	if(xn.HasChildNodes)
           	{
           		foreach(XmlNode vxn in xn.SelectNodes("SettingValue"))
           		{
           			attrValues.Add(vxn.Attributes["value"].Value);
           		}
           	}
           	
           	if(attrValues.Count>0)
           	{
           		if(string.IsNullOrEmpty(description))
           		{
           			settingList.Add(new SettingNode(attrName,attrValues));
           		}
           		else
           		{
           			settingList.Add(new SettingNode(attrName,attrValues,description));
           		}
           	}
           	else
           	{
           		if(string.IsNullOrEmpty(description))
           		{
           			settingList.Add(new SettingNode(attrName,attrVal));
           		}
           		else
           		{
           			settingList.Add(new SettingNode(attrName,attrVal,description));
           		}
           	}
           }        
        }
    }

}
