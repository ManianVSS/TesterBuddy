/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 4/17/2015
 * Time: 2:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using SettinsNS;
using XMLUtils;
using HostUtil;

namespace TesterBuddy
{
	/*
	enum SettingHandlerType
	{
		SHT_TEXTBOX_TEXT,
		SHT_LISTBOX_TeXT,
		SHT_LISTBOX_VALUES,
		SHT_LIST_VALUES
	}
	
	public class SettingHandler
	{
		
	}
	*/
	
	
	public partial class MainForm : Form
	{
		void InitApplication()
		{			
			ipl=IPRecord.GetRecords(hostsFile);
			//TodayString=DateTime.Today.ToShortDateString();
			
			TodayString=DateTime.Today.Date.Day.ToString()+"_"+DateTime.Today.Date.Month.ToString()+"_"+DateTime.Today.Date.Year.ToString();
			
			//TreeNode a=new TreeNode();
			
			foreach(IPRecord ipr in ipl)
			{
				comboBox1.Items.Add(ipr.hostname);
				AddHostToComboBox(ipr.hostname);
			}

			LogFolders.Items.Clear();
			
			if(!Directory.Exists(LogsPathTextBox.Text))
				Directory.CreateDirectory(LogsPathTextBox.Text);
			
			string[] dirlist=Directory.GetDirectories(LogsPathTextBox.Text);
			
			foreach(string s in dirlist)
			{
				LogFolders.Items.Add(s.Remove(0,s.LastIndexOf("\\")+1));
			}
			
			if(!Directory.Exists(LogsPathTextBox.Text+TodayString))
			{
				Directory.CreateDirectory(LogsPathTextBox.Text+TodayString);
			}
			else
			{
				string[] filelist=Directory.GetFiles(LogsPathTextBox.Text+TodayString+"\\");
				
				foreach(string s in filelist)
					LogFiles.Items.Add(s.Remove(0,s.LastIndexOf("\\")+1));
			}
			ScreenShotDirectory.Text=LogsPathTextBox.Text+TodayString+"\\";
			
			/*
			//Directory for command templates.
			if(!Directory.Exists(CommandPathTextBox.Text))
				Directory.CreateDirectory(CommandPathTextBox.Text);
			else
			{
				cmdFiles=Directory.GetFiles(CommandPathTextBox.Text,"*.cmd");
				foreach(string fl in cmdFiles)
					CommandTreeView.Nodes.Add(fl);
			}
			 */
			tabControl1.SelectedIndex=2;
			
			//Code below gets the additional and selected hosts
		}
	
		
			
		void InitSettings(bool useDefSetting)
		{
			if((!useDefSetting)&&File.Exists(selectedhost+".TB.Settings.xml"))
			{
				InitSettings(selectedhost+".TB.Settings.xml");
			}
			else
			{
				//Load default settings first
				InitSettings(SettingsFileName);
				
				//Load selected host specific settings next
				CheckAndLoadNewSettings();
			}
			
		}
		
		void LoadBaseSetting(bool firstload)
		{
			Settings settings=new Settings(SettingsFileName);
			
			if(settings.settingExists("TesterBuddy_Additional_Hosts"))
			{
				additionalHosts=settings.getSettingValues("TesterBuddy_Additional_Hosts");
				
				foreach(string host in additionalHosts)
				{
					AddHostToComboBox(host);
				}
			}		
			
			//Selected host should be loaded only once
			if(firstload)
			{
				if(settings.settingExists("TesterBuddy_Selected_Host"))
				{
					HostNameComboBox.Text=settings.getSettingValue("TesterBuddy_Selected_Host");
					AddHostToComboBox(HostNameComboBox.Text);
					selectedhost=HostNameComboBox.Text;
					this.Text=appname+":"+appversion+":"+selectedhost;
				}
			}
			
			if(settings.settingExists("TesterBuddy_TempDir_Path"))
			{
				TesterBuddy_TempDir_Path=settings.getSettingValue("TesterBuddy_TempDir_Path");
			}
			if(settings.settingExists("System_hosts_file_path"))
			{
				hostsFile=settings.getSettingValue("System_hosts_file_path");
			}
		}
		
		void InitSettings(string settingsFile, bool firstLoad=false)
		{
			try
			{
				settings.getSettingsFromXML(settingsFile);
			}
			catch(Exception)
			{
				switch(MessageBox.Show("Settings xml "+settingsFile+" not found. Create one?","Warning!!!",MessageBoxButtons.YesNo))
				{
					case DialogResult.Yes:
						GatherSettings(true, true);
						break;
					case DialogResult.No:
						break;
					default:
						break;
				}
			}
			
			/*if(settings.settingExists("IP Prefix"))
			{
				
				List<string> ipPrefixes=settings.getSettingValues("IP Prefix");
				
				if(ipPrefixes.Count>0)
				{
					ipPrefix.Clear();
					foreach(string ipPre in ipPrefixes)
					{
						ipPrefix.Add(ipPre);
					}
				}
			}*/
			
			//Check bsae only settings first
			if(firstLoad)
			{
				LoadBaseSetting(firstLoad);
			}
			
			if(settings.settingExists("ie_path"))
			{
				IEPathTextBox.Text=settings.getSettingValue("ie_path");
			}
			if(settings.settingExists("firefox_path"))
			{
				FireFoxPathTextBox.Text=settings.getSettingValue("firefox_path");
			}
			if(settings.settingExists("google_chrome_path"))
			{
				ChromePathTextBox.Text=settings.getSettingValue("google_chrome_path");
			}
			
//			//Setting for other browsers
			
			if(settings.settingExists("other_browsers"))
			{
				List<string> otherBrowserNameList=settings.getSettingValues("other_browsers");
				
				otherBrowsers.Clear();
				otherBrowsersComboBox.Items.Clear();
				
				
				foreach(string otherbrowserName in otherBrowserNameList)
				{
					if(settings.settingExists("OtherBrowser_"+otherbrowserName+"_Path"))
					{
						otherBrowsers.Add(new KeyValuePair<string, string>(otherbrowserName,settings.getSettingValue("OtherBrowser_"+otherbrowserName+"_Path")));
						otherBrowsersComboBox.Items.Add(otherbrowserName);
					}
				}
				
				if(otherBrowsers.Count>0)
				{
					otherBrowserRadioButton.Enabled=true;
					otherBrowsersComboBox.Enabled=true;
				}
				else
				{
					otherBrowserRadioButton.Enabled=false;
					otherBrowsersComboBox.Enabled=false;
				}
			}
			
			string selectedBrowser="Firefox";
			
			if(settings.settingExists("selected_browser"))
			{
				selectedBrowser=settings.getSettingValue("selected_browser");
			}
			
			if(selectedBrowser.Equals("IE"))
			{
				OpenInIERadioButton.Checked=true;	
			}
			else if(selectedBrowser.Equals("Firefox"))
			{
				OpenInFireFoxRadioButton.Checked=true;
			}
			else if(selectedBrowser.Equals("Chrome"))
			{
				OpenInChromeRadioButton.Checked=true;
			}
			else if(selectedBrowser.Equals("EmbeddedIE"))
			{
				OpenInEmbeddedIERadioButton.Checked=true;
			}
			else
			{
				otherBrowserRadioButton.Checked=true;				
				otherBrowsersComboBox.Text=selectedBrowser;
			}
			
			if(settings.settingExists("putty_path"))
			{
				Putty_Path_textbox.Text=settings.getSettingValue("putty_path");
			}
			if(settings.settingExists("winscp_path"))
			{
				WinSCP_Path_textbox.Text=settings.getSettingValue("winscp_path");
			}
			if(settings.settingExists("vnc_path"))
			{
				VNC__Path_textbox.Text=settings.getSettingValue("vnc_path");
			}
			if(settings.settingExists("staf_path"))
			{
				StafpathTextBox.Text=settings.getSettingValue("staf_path");
			}
			if(settings.settingExists("ziptool_path"))
			{
				ZipToolPathTextBox.Text=settings.getSettingValue("ziptool_path");
			}			
			if(settings.settingExists("defaultVNCScreenNumber"))
			{
				vncScreenNumberTextBox.Text=settings.getSettingValue("defaultVNCScreenNumber");
			}			
			if(settings.settingExists("defaultHostUserName"))
			{
				HostUserNameTextBox.Text=settings.getSettingValue("defaulHostUserName");
			}
			if(settings.settingExists("defaultHostPassword"))
			{
				HostPasswordTextBox.Text=settings.getSettingValue("defaultHostPassword");
			}
		
			if(settings.settingExists("UserCredentials"))
			{
				List<string> credentialsList=settings.getSettingValues("UserCredentials");
				
				UserCredentialsComboBox.Items.Clear();
				
				if(credentialsList.Count==0)
				{
					UserCredentialsComboBox.Items.Add("user/user@123");
				}
				else
				{
					foreach(string credential in credentialsList)
					{
						if(credential.Contains("/"))
						{
							UserCredentialsComboBox.Items.Add(credential);
						}
					}
					
					HostUserNameTextBox.Text=credentialsList[0].Substring(0,credentialsList[0].IndexOf("/"));
					HostPasswordTextBox.Text=credentialsList[0].Substring(credentialsList[0].IndexOf("/")+1);
				}
				
				if(credentialsList.Count>0)
				{
					UserCredentialsComboBox.Text=credentialsList[0];
				}
			}			
			if(settings.settingExists("TesterBuddy_DefaultURL"))
			{
				Default_URL_TextBox.Text=settings.getSettingValue("TesterBuddy_DefaultURL");
			}
			if(settings.settingExists("TesterBuddy_Logs_Path"))
			{
				LogsPathTextBox.Text=settings.getSettingValue("TesterBuddy_Logs_Path");
			}
			if(settings.settingExists("TesterBuddy_ScreenShots_Path"))
			{
				ScreenShotDirectory.Text=settings.getSettingValue("TesterBuddy_ScreenShots_Path");
			}
			if(settings.settingExists("TesterBuddy_ScreenShots_Prefix"))
			{
				ScreenShotPrefixTextBox.Text=settings.getSettingValue("TesterBuddy_ScreenShots_Prefix");
			}
		/*	if(settings.settingExists("TesterBuddy_ScreenShots_X"))
			{
				ScreenShot_x1.Text=settings.getSettingValue("TesterBuddy_ScreenShots_X");
			}
			if(settings.settingExists("TesterBuddy_ScreenShots_Y"))
			{
				ScreenShot_y1.Text=settings.getSettingValue("TesterBuddy_ScreenShots_Y");
			}
			if(settings.settingExists("TesterBuddy_ScreenShots_Length"))
			{
				ScreenShot_Length.Text=settings.getSettingValue("TesterBuddy_ScreenShots_Length");
			}
			if(settings.settingExists("TesterBuddy_ScreenShots_Width"))
			{
				ScreenShot_Width.Text=settings.getSettingValue("TesterBuddy_ScreenShots_Width");
			}
			*/						
			if(settings.settingExists("webrequest_timeout"))
			{
				webrequest_timeout=int.Parse(settings.getSettingValue("webrequest_timeout"));
			}
			
			if(settings.settingExists("cmd_start_directory"))
			{
				//cmd_start_directory=settings.getSettingValue("cmd_start_directory");
				CommandLineStartDirectory_TextBox.Text=settings.getSettingValue("cmd_start_directory");
			}
			
			for(int i=0;i<CustomCommandPaths.Length;i++)
			{
				if(settings.settingExists("custom_command_"+(i+1)+"_path"))
				{
					CustomCommandPaths[i]=settings.getSettingValue("custom_command_"+(i+1)+"_path");
					
					CustomCommandArgs[i]="";
					if(settings.settingExists("custom_command_"+(i+1)+"_args"))
					{
						CustomCommandArgs[i]=settings.getSettingValue("custom_command_"+(i+1)+"_args");
					}
					
					if(settings.settingExists("custom_command_"+(i+1)+"_name"))
					{
						CustomCommandButtons[i].Text=settings.getSettingValue("custom_command_"+(i+1)+"_name");
					}
					else
					{
						CustomCommandButtons[i].Text="unnamed ["+(i+1)+"]";
					}
					
					CustomCommandButtons[i].Enabled=true;
					CustomCommandButtons[i].Visible=true;
				}
				else
				{
					CustomCommandPaths[i]="";
					CustomCommandArgs[i]="";
					CustomCommandButtons[i].Text="Unbound";
					CustomCommandButtons[i].Enabled=false;
					CustomCommandButtons[i].Visible=false;
				}
			}
			
			/*if(settings.settingExists("VM_Port"))
			{
				List<string> vmPortList=settings.getSettingValues("VM_Port");
				
				VM_Port_ComboBox.Items.Clear();
				
				if(vmPortList.Count==0)
				{
					VM_Port_ComboBox.Items.Add("7001");
				}
				else
				{	
					foreach(string vmPort in vmPortList)
					{
						if(!vmPort.Trim(' ','\t').Equals(""))
							VM_Port_ComboBox.Items.Add(vmPort.Trim(' ','\t'));
					}
				}
				VM_Port_ComboBox.SelectedIndex=0;
			}*/
		}
		
		Settings GatherSettings(bool baseSettings, bool generateBaseSettingsFile)
		{
			Settings nsettings=new Settings();
			
			if(!generateBaseSettingsFile)
			{
				try
				{
					nsettings.getSettingsFromXML(SettingsFileName);
				}
				catch(Exception)
				{
					switch(MessageBox.Show("Settings xml "+SettingsFileName+" not found. Create one?","Warning!!!",MessageBoxButtons.YesNo))
					{
						case DialogResult.Yes:
							generateBaseSettingsFile=true;
							break;
						case DialogResult.No:
							break;
						default:
							break;
					}
				}
			}
			
			nsettings.AddSetting("ie_path",IEPathTextBox.Text);
			nsettings.AddSetting("firefox_path",FireFoxPathTextBox.Text);
			nsettings.AddSetting("google_chrome_path",ChromePathTextBox.Text);
			//otherbrowsers and their path can't be added from UI. will be inherited from base config
			
			string selectedBrowser="";
			
			if(OpenInIERadioButton.Checked)
			{
				selectedBrowser="IE";
			}
			else if(OpenInFireFoxRadioButton.Checked)
			{
				selectedBrowser="Firefox";
			}
			else if(OpenInChromeRadioButton.Checked)
			{
				selectedBrowser="Chrome";
			}
			else if(OpenInEmbeddedIERadioButton.Checked)
			{
				selectedBrowser="EmbeddedIE";
			}
			else 
			{
				selectedBrowser=otherBrowsersComboBox.Text;
			}
			nsettings.AddSetting("selected_browser",selectedBrowser);
				
			nsettings.AddSetting("putty_path",Putty_Path_textbox.Text);
			nsettings.AddSetting("winscp_path",WinSCP_Path_textbox.Text);
			nsettings.AddSetting("vnc_path",VNC__Path_textbox.Text);
			nsettings.AddSetting("staf_path",StafpathTextBox.Text);
			nsettings.AddSetting("ziptool_path",ZipToolPathTextBox.Text);
			nsettings.AddSetting("defaultVNCScreenNumber",vncScreenNumberTextBox.Text);
			nsettings.AddSetting("cmd_start_directory",CommandLineStartDirectory_TextBox.Text);
			nsettings.AddSetting("defaultHostUserName",HostUserNameTextBox.Text);
			nsettings.AddSetting("defaultHostPassword",HostPasswordTextBox.Text);
			
			List<string> userCredentialList=new List<string>();
			foreach(string userCredential in UserCredentialsComboBox.Items)
				userCredentialList.Add(userCredential);
//			if(userCredentialList.Count==0)
//			{
//				userCredentialList.Add("user/user@123");
//			}
			nsettings.AddSetting("UserCredentials",userCredentialList);
			
			nsettings.AddSetting("TesterBuddy_DefaultURL",Default_URL_TextBox.Text);
			nsettings.AddSetting("TesterBuddy_Logs_Path",LogsPathTextBox.Text);
			nsettings.AddSetting("TesterBuddy_ScreenShots_Path",ScreenShotDirectory.Text);
			nsettings.AddSetting("TesterBuddy_ScreenShots_Prefix",ScreenShotPrefixTextBox.Text);
					
			
				
			for(int i=0;i<CustomCommandPaths.Length;i++)
			{
				if((CustomCommandButtons[i].Enabled=true)&&(!string.IsNullOrEmpty(CustomCommandPaths[i])))
				{
					nsettings.AddSetting("custom_command_"+(i+1)+"_path",CustomCommandPaths[i]);
					
					if(!string.IsNullOrEmpty(CustomCommandArgs[i]))
					{
						nsettings.AddSetting("custom_command_"+(i+1)+"_args",CustomCommandArgs[i]);
					}
					
					if(!string.IsNullOrEmpty(CustomCommandButtons[i].Text))
					{
						nsettings.AddSetting("custom_command_"+(i+1)+"_name",CustomCommandButtons[i].Text);
					}
				}			
			}
			
			//Following settings should go only to base settings
			if(baseSettings || generateBaseSettingsFile)
			{
				nsettings.AddSetting("System_hosts_file_path",hostsFile);
								
				//if(additionalHosts.Count==0)
				//{
				//	additionalHosts.Add("localhost");
				//}
				
				nsettings.AddSetting("TesterBuddy_Additional_Hosts",additionalHosts);
				
				selectedhost=HostNameComboBox.Text;
				if(string.IsNullOrEmpty(selectedhost))
				{
					selectedhost="localhost";
				}
				nsettings.AddSetting("TesterBuddy_Selected_Host",selectedhost);
				
				nsettings.AddSetting("TesterBuddy_TempDir_Path",TesterBuddy_TempDir_Path);
			}
			
			if(generateBaseSettingsFile)
			{
				nsettings.SaveSettingsToXMLFile(SettingsFileName);
			}
			
			if(!baseSettings)
			{
				nsettings.RemoveSetting("System_hosts_file_path");
				nsettings.RemoveSetting("TesterBuddy_Additional_Hosts");
				nsettings.RemoveSetting("TesterBuddy_Selected_Host");
				nsettings.RemoveSetting("TesterBuddy_TempDir_Path");
				
			}
			/*
			List<string> default_VM_PortList=new List<string>();
			foreach(string default_VM_Port in VM_Port_ComboBox.Items)
				default_VM_PortList.Add(default_VM_Port);
			nsettings.AddSetting("VM_Port",default_VM_PortList);
			*/
			
		
			   
			return nsettings;
		}					
	}
}
