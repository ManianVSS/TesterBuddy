/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 1/29/2013
 * Time: 12:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace STAFAL
{
	public enum MachineType
	{
		UNIX,
		WINDOWS
	}
	
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class Machine
	{
		public string name, ip, alias;
		public MachineType machineType;
		
		public bool CheckStafConnection()
		{
			Process cmd=new Process();
			
			cmd.StartInfo.FileName=@"D:\staf\bin\staf.exe";
			cmd.StartInfo.Arguments=name+" PING PING ";
			cmd.StartInfo.RedirectStandardOutput=true;
			cmd.StartInfo.CreateNoWindow=true;
			cmd.StartInfo.UseShellExecute=false;
			
			cmd.Start();
			
			cmd.WaitForExit();
			
			StreamReader sr=cmd.StandardOutput;
			string output =sr.ReadToEnd();
			
			return output.Contains("PONG");
		}
		
		public string GetTrustLevel()
		{
			Process cmd=new Process();
			
			cmd.StartInfo.FileName=@"D:\staf\bin\staf.exe";
			cmd.StartInfo.Arguments=name+" FS COPY FILE c:/staf/bin/staf.cfg TODIRECTORY "+Environment.CurrentDirectory;
			cmd.StartInfo.RedirectStandardOutput=true;
			cmd.StartInfo.CreateNoWindow=true;
			cmd.StartInfo.UseShellExecute=false;
			
			cmd.Start();
			
			cmd.WaitForExit();
			
			StreamReader sr=cmd.StandardOutput;
			string output =sr.ReadToEnd();
			
			if(output.Contains("Error"))
				throw new Exception("STAF connection Exception:"+ output);
			
			string []trustlines=File.ReadAllLines("Staf.cfg");
			
			foreach(string trustline in trustlines)
			{
				if(trustline.StartsWith("#"))
				{
					continue;
				}
				
				if(trustline.ToLower().Contains("trust default level "))
				{
					return trustline;
				}
				
				if(trustline.ToLower().Contains("trust machine "+Environment.MachineName.ToLower()))
				{
					return trustline;
				}
			}
			
			return " Could not find trust level ";
		}
		
		public void SendFile(string fileToSend, string directoryToPlaceFileIn)
		{
			Process cmd=new Process();
			
			cmd.StartInfo.FileName=@"D:\staf\bin\staf.exe";
			cmd.StartInfo.Arguments="LOCAL FS COPY FILE "+fileToSend +" TOMACHINE "+name+" TODIRECTORY "+directoryToPlaceFileIn;
			cmd.StartInfo.RedirectStandardOutput=true;
			cmd.StartInfo.CreateNoWindow=true;
			cmd.StartInfo.UseShellExecute=false;
			
			cmd.Start();
			
			cmd.WaitForExit();
			
			StreamReader sr=cmd.StandardOutput;
			string output =sr.ReadToEnd();
			
			if(output.Contains("Error"))
				throw new Exception("STAF connection Exception:"+ output);				
		}
		
		public void GetFile(string fileToGet, string directoryToPlaceFileIn)
		{
			Process cmd=new Process();
			
			cmd.StartInfo.FileName=@"D:\staf\bin\staf.exe";
			cmd.StartInfo.Arguments=name+" FS COPY FILE "+fileToGet +" TOMACHINE "+Environment.MachineName+" TODIRECTORY "+directoryToPlaceFileIn;
			cmd.StartInfo.RedirectStandardOutput=true;
			cmd.StartInfo.CreateNoWindow=true;
			cmd.StartInfo.UseShellExecute=false;
			
			cmd.Start();
			
			cmd.WaitForExit();
			
			StreamReader sr=cmd.StandardOutput;
			string output =sr.ReadToEnd();
			
			if(output.Contains("Error"))
				throw new Exception("STAF connection Exception:"+ output);				
		}
		
		public string[] ListDirectory(string directory)
		{
			Process cmd=new Process();
			
			cmd.StartInfo.FileName=@"D:\staf\bin\staf.exe";
			cmd.StartInfo.Arguments=name+" FS LIST DIRECTORY "+directory;
			cmd.StartInfo.RedirectStandardOutput=true;
			cmd.StartInfo.CreateNoWindow=true;
			cmd.StartInfo.UseShellExecute=false;
			
			cmd.Start();
			
			cmd.WaitForExit();
			
			StreamReader sr=cmd.StandardOutput;
			string output =sr.ReadToEnd();
			
			if(output.Contains("Error"))
				throw new Exception("STAF connection Exception:"+ output);					
			
			List<string> file=new List<string>(output.Split('\n'));
			
			file.RemoveAt(0);
			file.RemoveAt(0);
			
			return file.ToArray();			
		}
	}
}