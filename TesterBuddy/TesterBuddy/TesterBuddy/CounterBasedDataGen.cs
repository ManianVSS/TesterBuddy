/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 4/1/2015
 * Time: 11:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DataGenerate;

namespace TesterBuddy
{
	/// <summary>
	/// Description of CounterBasedDataGen.
	/// </summary>
	[Serializable]
	public partial class CounterBasedDataGen : Form
	{
		public CounterBasedDataGen()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SaveTemplate_ButtonClick(object sender, EventArgs e)
		{
			string filename;	
			switch(SaveTemplateFileDialog.ShowDialog())
			{
				case DialogResult.OK:
				case DialogResult.Yes:
					
				filename= SaveTemplateFileDialog.FileName;
				File.WriteAllText(filename,Template_TextBox.Text);
				break;
				
			default:
				break;
			}
		}
		
		void LoadTempalte_ButtonClick(object sender, EventArgs e)
		{
			string filename;	
			switch(OpenTemplateFileDialog.ShowDialog())
			{
				case DialogResult.OK:
				case DialogResult.Yes:
					
				filename= OpenTemplateFileDialog.FileName;
				Template_TextBox.Text=File.ReadAllText(filename);
				break;
				
			default:
				break;
			}
		}
		
		void GenerateDataFile_ButtonClick(object sender, EventArgs e)
		{
			switch(SaveDataFileDialog.ShowDialog())
			{
				case DialogResult.OK:
				case DialogResult.Yes:
					
				DataGenerateHelper.GenerateDataFileFromXMLTemplate(Template_TextBox.Text,SaveDataFileDialog.FileName,DataGenerateProgressBar);
				break;
				
			default:
				break;
			}
		}
		
		void CounterBasedDataGenResize(object sender, EventArgs e)
		{
			
		}
		
		void Template_TextBoxKeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control&& (e.KeyCode==Keys.A))
			{
				Template_TextBox.SelectAll();
			}
		}
		
		void FormatXMLButtonClick(object sender, EventArgs e)
		{
			try
			{
				Template_TextBox.Text=XMLUtils.XMLFormatter.IndentXML(Template_TextBox.Text);
			}
			catch(Exception exp)
			{
				MessageBox.Show("Error with template xml",exp.Message+"\r"+exp.StackTrace);
			}
		}
		
		void EscapeSelectedXMLStringButtonClick(object sender, EventArgs e)
		{
			string selectiontext=Template_TextBox.SelectedText;
			
			if(!string.IsNullOrEmpty(selectiontext))
			{
				int selectionstart=Template_TextBox.SelectionStart;
				int selectionlength=Template_TextBox.SelectionLength;
				string template=Template_TextBox.Text;
				string prestring=template.Substring(0,selectionstart);
				string sufstring=template.Substring(selectionstart+selectionlength);
				
				selectiontext=XMLUtils.XMLFormatter.XmlEscape(selectiontext);
				
				Template_TextBox.Text=prestring+selectiontext+sufstring;
				Template_TextBox.Refresh();
				Template_TextBox.Select(selectionstart,selectiontext.Length);
			}
		}
	}
}
