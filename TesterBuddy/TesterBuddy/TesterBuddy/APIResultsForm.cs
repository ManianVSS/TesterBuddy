/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 8/9/2014
 * Time: 11:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace TesterBuddy
{
	/// <summary>
	/// Description of APIResultsForm.
	/// </summary>
	public partial class APIResultsForm : Form
	{
		//public List<API> resultsAPIList;
		
		public APIResultsForm(string input, string template, string output)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//resultsAPIList=new List<API>();
			//API a=new API(input,output,template);
			//resultsAPIList.Add(a);
			
			APIResults_APIInputTextBox.Text=input;
			APIResults_APIOutputTextBox.Text=output;
			APIResults_APITemplateTextBox.Text=template;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	    void KeyDownTextBoxes(object sender, KeyEventArgs e, TextBox tb)
        {
        	if(e.Control&&(e.KeyCode==Keys.A))
        	{
        		tb.SelectAll();
        	}
        }				
		
		void APIResults_APIInputTextBoxKeyDown(object sender, KeyEventArgs e)
		{
			KeyDownTextBoxes(sender,e,APIResults_APIInputTextBox);
		}
		
		void APIResults_APIOutputTextBoxKeyDown(object sender, KeyEventArgs e)
		{
			KeyDownTextBoxes(sender,e,APIResults_APIOutputTextBox);
		}
		
		void APIResults_APITemplateTextBoxKeyDown(object sender, KeyEventArgs e)
		{
			KeyDownTextBoxes(sender,e,APIResults_APITemplateTextBox);
		}
	}
}
