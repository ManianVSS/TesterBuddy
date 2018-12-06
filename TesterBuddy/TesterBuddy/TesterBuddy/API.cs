/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 11/19/2014
 * Time: 12:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace TesterBuddy
{
	/// <summary>
	/// Description of API.
	/// </summary>
	/// 
	[Serializable]
	public class APIE
	{
		public string name, input, template;
		public List<string> criteria=new List<string>();
		//public bool incrementCounters,repeat;
		//public int nRepeat;
		
		public APIE()
		{
		}
		
		public void LoadAPIXML(string xml)
		{
		 	XmlDocument xmldoc=new XmlDocument();
		 	xmldoc.LoadXml(xml);
		 	
		 	if(!xmldoc.DocumentElement.Name.Equals("api"))
		 	{
		 		//ERROR
		 		return;
		 	}
		 	
		 	string temp=xmldoc.DocumentElement.GetAttribute("name");
		 	
		 	if(string.IsNullOrEmpty(temp))
		 	{
		 		return;
		 	}
		 	
		 	name=temp;
		 	
		 	XmlNodeList inputelementlist=xmldoc.GetElementsByTagName("input");
		 	
		 	if((inputelementlist==null)||(inputelementlist.Count!=1))
		 	{
		 		return;
		 	}
		 	
		 	input=inputelementlist[0].InnerXml;
		 	
	 		XmlNodeList templateelementlist=xmldoc.GetElementsByTagName("template");
		 	
		 	if((templateelementlist==null)||(templateelementlist.Count!=1))
		 	{
		 		template="";
		 	}
		 	else
		 	{
		 		template=templateelementlist[0].InnerXml;
		 	}
		 	
		 	criteria.Clear();
		 	XmlNodeList criteriaValueElementList=xmldoc.GetElementsByTagName("criteriavalue");
		 	
		 	if(!((criteriaValueElementList==null)||(criteriaValueElementList.Count==0)))
		 	{	
		 		foreach(XmlElement critvalueelement in criteriaValueElementList)
		 		{
		 			string critvalue=critvalueelement.GetAttribute("value");
		 			
		 			if(!string.IsNullOrEmpty(critvalue))
		 			{
		 				criteria.Add(critvalue);
		 			}
		 		}
		 	}
		 	
		}
		
		public string GetAPIXML()
		{
			string rxml= "<api name=\""+name+"\" >\n"
				+ "\t<input>\n"
				+"\t\t"+input+"\n"
				+ "\t</input>\n"
				+ "\t<template>\n"
				+"\t\t"+template+"\n"
				+ "\t</template>\n";
			
			foreach(string icri in criteria)
			{
				rxml=rxml+"\t<criteriavalue value=\""+icri+"\" />\n";
			}
			
				//+"\t\t"+XMLUtils.XMLFormatter.XmlEscape(GetCriteriaString())+"\n"
			rxml=rxml+"</api>";
			
			return XMLUtils.XMLFormatter.IndentXML(rxml);
		}
		
		public APIE(TreeNode tn)
		{
			if(tn==null)
			{
				return;
			}
			
			name=tn.Text;
			
			if((tn.Nodes==null)||(tn.Nodes.Count==0))
			{
				return ;
				
			}
			
			input=tn.Nodes[0].Text;
			
			if(tn.Nodes.Count>1)
			{
				template=tn.Nodes[1].Text;
			
				criteria.Clear();
				
				if(tn.Nodes.Count>2)
				{					
					SetCriteria(tn.Nodes[2].Text);
				}
			}
		}
		
		public void SetCriteria(string textcriteria)
		{
			if(string.IsNullOrEmpty(textcriteria))
			{
				criteria.Clear();
				return;
			}
			
			textcriteria=textcriteria.Replace("\r","");
			string []critarry=textcriteria.Split('\n');
			
			criteria.Clear();
			
			foreach(string s in critarry)
			{
				if(!string.IsNullOrEmpty(s))
				{
					if(!criteria.Contains(s))
					{
						criteria.Add(s);
					}
				}
			}
		}
		
		public string GetCriteriaString()
		{
			string s="";
			
			foreach(string cr in criteria)
			{
				s=s+cr+"\n";
			}			
			return s;
		}
		
		public TreeNode GetTreeNode()
		{
			TreeNode tn=new TreeNode();
			tn.Text=name;
			tn.Nodes.Add(input);
			tn.Nodes.Add(template);
			tn.Nodes.Add(GetCriteriaString());
			return tn;
		}
		
	 	public void SerializeToFile(string fileName)
        {
    	    //Do serialization
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
        }
	 	
	 	public void SaveToXMLFile(string filename)
	 	{
	 		File.WriteAllText(filename,GetAPIXML());
	 	}
	 	
	 	public bool LoadFromXMLFile(string filename)
	 	{
	 		if(!File.Exists(filename))
	 		{
	 			return false;
	 		}
	 		
	 		LoadAPIXML(File.ReadAllText(filename));
	 		return true;
	 	}
	}
	
	[Serializable]
	public class APISequence
	{
		public List<APIE> apiList=new List<APIE>();
		
		public APISequence()
		{
		
		}
		
		public string GetAPISequenceXML()
		{
			string rxml= "<apisequence>\n";
			
			foreach(APIE api in apiList)
			{
				rxml=rxml+api.GetAPIXML()+"\n";
			}
			
			rxml=rxml+"</apisequence>";
			
			return XMLUtils.XMLFormatter.IndentXML(rxml);
		}
	
		public void LoadAPISequenceXML(string xml)
		{			
		 	XmlDocument xmldoc=new XmlDocument();
		 	xmldoc.LoadXml(xml);
		 	
		 	if(!xmldoc.DocumentElement.Name.Equals("apisequence"))
		 	{
		 		//ERROR
		 		return;
		 	}
		
		 	XmlNodeList inputelementlist=xmldoc.GetElementsByTagName("api");
		 	
		 	apiList.Clear();
		 	
		 	foreach(XmlNode xn in inputelementlist)
		 	{
		 		APIE api=new APIE();
		 		api.LoadAPIXML(xn.OuterXml);
		 		apiList.Add(api);
		 	}
		}
		
				
	 	public void SaveToXMLFile(string filename)
	 	{
	 		File.WriteAllText(filename,GetAPISequenceXML());
	 	}
	 	
	 	public bool LoadFromXMLFile(string filename)
	 	{
	 		if(!File.Exists(filename))
	 		{
	 			return false;
	 		}
	 		
	 		LoadAPISequenceXML(File.ReadAllText(filename));
	 		return true;
	 	}
		
		public APISequence(TreeNodeCollection tnc)
		{
			if((tnc==null)||(tnc.Count<1))
			{
				return;
			}
			foreach(TreeNode tn in tnc)
			{
				if(tn.Nodes.Count>0)
				{
					apiList.Add(new APIE(tn));
				}
			}
		}
					
		public void SerializeToFile(string fileName)
        {
    	    //Do serialization
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
        }
		
		public static APISequence LoadFromFile(string filename)
		{
		 	IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            
            APISequence rv= (APISequence)formatter.Deserialize(stream);
            stream.Close();
            return rv;
		}
	}
}
