/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: Thursday/6/6/2013
 * Time: 4:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace ArchiveHelperNS
{
	/// <summary>
	/// Description of MyDirInfo.
	/// </summary>
	public class MyDirInfo
	{
		public MyDirInfo ParentDir=null;
		public List<MyDirInfo> Children=new List<MyDirInfo>();
		public string name;
		public int type=0; //0 for file, 1 for folder, 2 for zip
		public long size;
		public DateTime modified, created;
		public byte []Contents=null;
		public string extractedFile;
		
		public MyDirInfo()
		{			
		}						
	}
}
