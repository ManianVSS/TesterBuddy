/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 15/3/2015
 * Time: 10:20 AM
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
	/// Description of EditClientPropertiesForm.
	/// </summary>
	public partial class EditClientPropertiesForm : Form
	{
		List<KeyValuePair<String,String>> ClientProperties;
		
		public EditClientPropertiesForm(ref List<KeyValuePair<String,String>> cp)
		{
			
			if(cp!=null)
			{
				ClientProperties=cp;
			}
			else
			{
				ClientProperties=new List<KeyValuePair<string, string>>();
			}
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			RefreshListBox();
		}
		
		void RefreshListBox()
		{
			ClientPropertiesListBox.Items.Clear();
			foreach(KeyValuePair<string,string> kvp in ClientProperties)
			{
				ClientPropertiesListBox.Items.Add(kvp.Key+"="+kvp.Value);
			}
		}
		
		int IndexOf(string key)
		{
			for(int i=0;i<ClientProperties.Count;i++)
			{
				if(ClientProperties[i].Key.Equals(key))
				{
					return i;
				}
			}
			
			return -1;
		}
		
		void PropertyAddButtonClick(object sender, EventArgs e)
		{
			int index;
			if((index=IndexOf(ClientPropertyNameTextBox.Text))!=-1)
			{
				ClientProperties[index]=new KeyValuePair<string, string>(ClientPropertyNameTextBox.Text, ClientPropertyValueTextBox.Text);
			}
			else
			{
				ClientProperties.Add(new KeyValuePair<string, string>(ClientPropertyNameTextBox.Text, ClientPropertyValueTextBox.Text));
			}
			
			RefreshListBox();
		}
		
		void PropertyRemoveButtonClick(object sender, EventArgs e)
		{
			if(ClientPropertiesListBox.SelectedIndex!=-1)
			{
				ClientProperties.RemoveAt(ClientPropertiesListBox.SelectedIndex);
				RefreshListBox();
			}
		}
		
		void PropertySetButtonClick(object sender, EventArgs e)
		{
			if(ClientPropertiesListBox.SelectedIndex!=-1)
			{
				ClientProperties[ClientPropertiesListBox.SelectedIndex]=new KeyValuePair<string, string>(ClientPropertyNameTextBox.Text, ClientPropertyValueTextBox.Text);
				RefreshListBox();
			}
		}
	}
}
