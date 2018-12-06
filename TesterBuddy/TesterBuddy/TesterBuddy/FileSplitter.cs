/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 04-Nov-16
 * Time: 12:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TesterBuddy
{
	/// <summary>
	/// Description of FileSplitter.
	/// </summary>
	public partial class FileSplitter : Form
	{
		public FileSplitter()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BrowseFileButtonClick(object sender, EventArgs e)
		{
			DialogResult dr=OpenFileDialog.ShowDialog();
			
			switch(dr)
			{
				case DialogResult.Abort:
				case DialogResult.Cancel:
				case DialogResult.Ignore:
				case DialogResult.No:
				case DialogResult.None:
				case DialogResult.Retry:
					break;
					
				case DialogResult.OK:
					SplitSourceFileNameTextBox.Text=OpenFileDialog.FileName;
					break;
			}
		}
		
		void SplitFileButtonClick(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(SplitSourceFileNameTextBox.Text)||!string.IsNullOrEmpty(SizeTextBox.Text))
			{
				int size=int.Parse(SizeTextBox.Text);
				
				if(!File.Exists(SplitSourceFileNameTextBox.Text))
				{
					MessageBox.Show("Source File can't be found", "Error!!!");
					return;
				}
				
				FileStream fs=File.Open(SplitSourceFileNameTextBox.Text,FileMode.Open);
				byte []buffer=new byte[1024];
				int splitcount=0;
				int readsofar=0;
				int readsize=0;
				
				FileStream wfs=File.Open(SplitSourceFileNameTextBox.Text+"."+(splitcount++),FileMode.Create);
				do
				{
					readsize=fs.Read(buffer,0,1024);
					
					if(readsize==0)
					{
						wfs.Close();
						break;
					}
					if((readsofar+readsize)>=size)
					{
						int bufsplit1=readsize-(size-readsofar);
						int bufsplit2=readsize-bufsplit1;
						
						if(bufsplit1==0)
						{
							bufsplit1=readsize;
							bufsplit2=0;
						}
						wfs.Write(buffer,0,bufsplit1);
						wfs.Close();
						wfs=File.Open(SplitSourceFileNameTextBox.Text+"."+(splitcount++),FileMode.Create);
						wfs.Write(buffer,bufsplit1,bufsplit2);
						readsofar=bufsplit2;
					}
					else
					{
						wfs.Write(buffer,0,readsize);
						readsofar+=readsize;
					}
				}while(true);
				
				wfs.Close();
				fs.Close();
			}
		}		
	}
}
