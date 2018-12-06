/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: Thursday/6/6/2013
 * Time: 4:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace ArchiveHelperNS
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class ArchiveHelper
	{
		public static string path_7zip;
		public static bool DelFiles=false;
		public static bool SaveContents=false;
		
		public static MyDirInfo GetArchiveDirectoryInfo(MyDirInfo mdi,string archiveFileName, string tempFolder)
		{
			string extractToDir=tempFolder+"\\"+GetTimeStamp();	
						
			if(!ExtractArchive(archiveFileName,extractToDir))
			{
				return null;
			}
										
			if(mdi==null)
			{
				mdi=new MyDirInfo();
				mdi.ParentDir=null;
				DirectoryInfo di=new DirectoryInfo(extractToDir);
				mdi.name="/";
				mdi.modified=di.LastWriteTime;
				mdi.created=di.CreationTime;
				mdi.size=0;		
				mdi.type=2;
				mdi.extractedFile=extractToDir;				
			}
			
			mdi.Children=GetDirectoryInfoRecursiveExpandArchives(mdi,extractToDir,tempFolder);
			
			
			//Delete created dir			
			if(DelFiles)
			{
				if(Directory.Exists(extractToDir))
				{
					Directory.Delete(extractToDir,true);
				}
			}
			return mdi;
		}
		
		public static bool IsArchive(string filename)
		{
			return filename.EndsWith(".ear") ||
				filename.EndsWith(".jar") ||
				filename.EndsWith(".war") ||
				filename.EndsWith(".zip") ||
				filename.EndsWith(".7z") ||
				filename.EndsWith(".tar") ||
				filename.EndsWith(".gz") ||
				filename.EndsWith(".gzip") ||
				filename.EndsWith(".bz") ||
				filename.EndsWith(".rar") ||
				filename.EndsWith(".sar") ||
				filename.EndsWith(".cab") ;
				
		}
		
		public static List<MyDirInfo> GetDirectoryInfoRecursiveExpandArchives(MyDirInfo mdi,string Folder, string tempFolder)
		{			
			List<MyDirInfo> mdiList=new List<MyDirInfo>();
			
			if(!Directory.Exists(Folder))
			{
				return mdiList;
			}
			
			/*
			mdi.ParentDir=null;
			DirectoryInfo di=new DirectoryInfo(Folder);
			mdi.name=di.Name;
			mdi.modified=di.LastWriteTime;
			mdi.created=di.CreationTime;
			mdi.type=1;		
			mdi.size=0;		
			*/	
			
			string []Files=Directory.GetFiles(Folder);
			
			//Add all child first
			foreach(string file in Files)
			{		
				if(IsArchive(file))
				{
					MyDirInfo mdiChildArchive=new MyDirInfo();
					mdiChildArchive.ParentDir=mdi;
					DirectoryInfo di=new DirectoryInfo(file);
					mdi.name="/";
					mdi.modified=di.LastWriteTime;
					mdi.created=di.CreationTime;
					mdi.size=0;		
					mdi.type=2;
					//mdi.extractedFile=extractToDir;		
				
					//mdi.Children=GetArchiveDirectoryInfo(null,file,tempFolder);
					
					mdiList.Add(mdiChildArchive);
				}
				else
				{
					MyDirInfo mdiChild=new MyDirInfo();
					FileInfo fi=new FileInfo(file);
					mdiChild.ParentDir=mdi;
					mdiChild.name=fi.Name;
					mdiChild.created=fi.CreationTime;
					mdiChild.modified=fi.LastWriteTime;
					mdiChild.Children=null;
					mdiChild.size=fi.Length;
					mdiChild.type=0;
					mdiChild.extractedFile=file;
					mdiList.Add(mdiChild);
					
					if(SaveContents)
					{
						mdiChild.Contents=File.ReadAllBytes(file);
					}
				}
			}
			
			string []dirs=Directory.GetDirectories(Folder);
			
			//Get all directories now
			foreach(string dir in dirs)
			{
				MyDirInfo mdiSubFolder=new MyDirInfo();
				DirectoryInfo di=new DirectoryInfo(dir);
				mdiSubFolder.name=di.Name;
				mdiSubFolder.created=di.CreationTime;
				mdiSubFolder.modified=di.LastWriteTime;
				mdiSubFolder.Children=GetDirectoryInfoRecursiveExpandArchives(mdiSubFolder,dir,tempFolder);
				mdiSubFolder.ParentDir=mdi;
				mdiSubFolder.extractedFile=dir;
				mdiList.Add(mdiSubFolder);
			}
			
			return mdiList;
		}
		
		
		public static string GetTimeStamp()
		{
			return ""+DateTime.Now.Ticks;
		}
		
		public static bool ExtractArchive(string archiveFileName, string directory)
		{
			try
			{
				Process p=new Process();
				p.StartInfo.FileName=path_7zip;
				p.StartInfo.Arguments="x "+archiveFileName+" -o"+directory;
				
				//p.StartInfo.UseShellExecute=false;
				//p.StartInfo.RedirectStandardInput=true;			
				//p.StartInfo.RedirectStandardOutput=true;
				p.StartInfo.CreateNoWindow=true;	
			
				p.Start();			
				p.WaitForExit();				
			}
			catch(Exception e)
			{
				Console.WriteLine("Exception occured : \n"+e.Message+"\n"+e.InnerException);
				return false;
			}
			
			return true;
		}
		
		/*public static void ExtractArchiveFile(ArchiveExtractOptions aeopts, bool firstcall=false)
		{
			
		}*/
	}
}