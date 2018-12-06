/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 15/03/2015
 * Time: 11:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TesterBuddy
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			MainForm mf;
		/*	
			if(args.Length>0)
			{
				if(File.Exists(args[0]))
				{
					mf=MainForm.DeserializeFromFile("TesterBuddy.Serialized.bin");
				}
			}
			if(File.Exists("TesterBuddy.Serialized.bin"))
			{
				mf=MainForm.DeserializeFromFile("TesterBuddy.Serialized.bin");
			}
			else
			{
				mf=new MainForm();
			}
			*/
			
			mf=new MainForm();
			Application.Run(mf);
			
			//mf.SerializeToFile("TesterBuddy.Serialized.bin");
		}
		
	}
}
