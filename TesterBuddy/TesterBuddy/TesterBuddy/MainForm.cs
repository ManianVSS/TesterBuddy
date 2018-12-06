/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 15/03/2015
 * Time: 11:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

/*
 * Features required:
 * Comparing Multiple files.
 * Two pane transfer window.
 * Backup (archive) utility.
 * Screenshots managing utility.
 * Custom Commands Utility. Users should be able to bind some action to specific nodes.
 * Provide proper icon for app and other things.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Text.RegularExpressions;
using System.Linq;
using System.Web;

using SettinsNS;
using XMLUtils;
using HostUtil;
using WebRequestHelperNS;
using DataGenerate;
using STAFAL;
using ArchiveHelperNS;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TesterBuddy
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    /// 
    public partial class MainForm : Form
    {
        //String NowString;
        //long apicount=0;
        //		bool RSConnected=false;
        ASCIIEncoding ae;
        //byte[] body;
        //TcpClient tc;
        //LinkedList<TcpClient> teamclient=new LinkedList<TcpClient>();
        //TcpListener tl;
        //GSocket teamSocket;

        const string TesterBuddyVersionString = "3.1.0";

        Thread extractThread;

        //string cmd,arg;
        //int lengthcmd,lengtharg;
        //StreamReader sr;
        //string line;
        string TodayString;
        //string[] cmdFiles;
        //List<string> currentCommand;
        IPRecord[] ipl;
        //DateTime RestoreTime;
        string hostsFile = @"c:\windows\system32\drivers\etc\hosts";
        public Settings settings = new Settings();
        //AutoCompleteStringCollection hostnameacsc=new AutoCompleteStringCollection();

        List<string> ipPrefix = new List<string>();
        List<string> additionalHosts = new List<string>();
        string SettingsFileName = "TesterBuddy.settings.xml";
        string selectedhost;//="localhost";
                            //string APIDirectory="api";
        List<string> apiList = new List<string>();
        string previousScreenshotText = "";
        string TesterBuddy_TempDir_Path = "tempdir";
        List<KeyValuePair<string, string>> ClientProperties = new List<KeyValuePair<string, string>>();

        string appname = "TesterBuddy";
        string appversion = "1.1";
        //Starting directory for command prompt
        //string cmd_start_directory="";

        //Web-Request timeout value
        int webrequest_timeout = 0;

        //VNC screen

        //Null for direct

        //List<ThreadStart> API_ThreadList=new List<ThreadStart>();
        List<ThreadStart> API_ThreadStartList = new List<ThreadStart>();

        List<KeyValuePair<string, string>> otherBrowsers = new List<KeyValuePair<string, string>>();
        
        //Custom command variables
        string[] CustomCommandPaths = new string[10];
        string[] CustomCommandArgs = new string[10];
        private List<Button> CustomCommandButtons = new List<Button>();

        private GlobalHotkey TakeSnapHotKey;

        public MainForm()
        {
            InitializeComponent();

            SettingsFileName = "TesterBuddy.settings.xml";

            CustomCommandButtons.Add(CustomCommandButton1);
            CustomCommandButtons.Add(CustomCommandButton2);
            CustomCommandButtons.Add(CustomCommandButton3);
            CustomCommandButtons.Add(CustomCommandButton4);
            CustomCommandButtons.Add(CustomCommandButton5);
            CustomCommandButtons.Add(CustomCommandButton6);
            CustomCommandButtons.Add(CustomCommandButton7);
            CustomCommandButtons.Add(CustomCommandButton8);
            CustomCommandButtons.Add(CustomCommandButton9);
            CustomCommandButtons.Add(CustomCommandButton10);

            for (int i = 0; i < CustomCommandArgs.Length; i++)
            {
                CustomCommandArgs[i] = "";
            }

            InitSettings(SettingsFileName, true);
            CheckAndLoadNewSettings();

            InitApplication();

            TakeSnapHotKey = new GlobalHotkey();
            TakeSnapHotKey.RegisterGlobalHotKey((int)Keys.PrintScreen, GlobalHotkey.MOD_CONTROL | GlobalHotkey.MOD_SHIFT, this.Handle);
        }

        bool shortcutScreenCapture = false;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == TakeSnapHotKey.HotkeyID)
            {
                shortcutScreenCapture = true;
                Button3Click(this, null);
                ScreenShotSaveButtonClick(this, null);
                shortcutScreenCapture = false;
            }
            base.WndProc(ref m);
        }

        void CheckAndLoadNewSettings()
        {
            if (string.IsNullOrEmpty(selectedhost))
                return;
            if (File.Exists(selectedhost + ".TB.Settings.xml"))
            {
                InitSettings(selectedhost + ".TB.Settings.xml", false);
            }
        }

        void AddHostToolStripMenuItemClick(object sender, EventArgs e)
        {
            Button1Click(sender, e);
        }

        void AddHostToComboBox(string host)
        {
            if (!HostNameComboBox.Items.Contains(host))
            {
                HostNameComboBox.Items.Add(host);
            }
        }

        //The OK|ADD button in the ADD HOST tab.
        void Button1Click(object sender, EventArgs e)
        {
            ASCIIEncoding ae = new ASCIIEncoding();
            IPRecord hi;

            if ((IPAddressTextBox1.Text.Length > 3) || (IPAddressTextBox2.Text.Length > 3)
               || (IPAddressTextBox3.Text.Length > 3) || (IPAddressTextBox4.Text.Length > 3)
               || (int.Parse(IPAddressTextBox1.Text) > 255) || (int.Parse(IPAddressTextBox2.Text) > 255)
               || (int.Parse(IPAddressTextBox3.Text) > 255) || (int.Parse(IPAddressTextBox4.Text) > 255)
               || (int.Parse(IPAddressTextBox1.Text) < 0) || (int.Parse(IPAddressTextBox2.Text) < 0)
               || (int.Parse(IPAddressTextBox3.Text) < 0) || (int.Parse(IPAddressTextBox4.Text) < 0))
            {
                MessageBox.Show("Please enter a valid IP.", "Wrong User Input!!!");
                return;
            }

            hi = new IPRecord(IPAddressTextBox1.Text + "." + IPAddressTextBox2.Text + "." + IPAddressTextBox3.Text + "." + IPAddressTextBox4.Text, HostNameTextBox.Text, textBox6.Text);

            if (!string.IsNullOrEmpty(CommentsTextBox.Text))
            {
                hi.AddComments(CommentsTextBox.Text);
            }

            try
            {
                IPRecord.AddRecords(hi, hostsFile);
                //MessageBox.Show("The host information was successfully added.","Result-OK");

                ipl = IPRecord.GetRecords(hostsFile);
                //listBox1.Items.Clear();
                comboBox1.Items.Clear();

                foreach (IPRecord ipr in ipl)
                {
                    //listBox1.Items.Add(ipr.hostname);
                    comboBox1.Items.Add(ipr.hostname);
                    AddHostToComboBox(ipr.hostname);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Exception occured:" + exp.Message, "Exception!!!");
            }
            RefreshHostButtonClick(sender, e);

            MessageBox.Show("The host was added to host file", ":)");
        }

        private void StartInIE(String url)
        {

            if (UseHTTPSForAppLinksCheckbox.Checked)
            {
                url = url.Replace("http://", "https://");
            }

            if (Links_OnlyCopyUrlCheckbox.Checked)
            {
                if (Clipboard.ContainsText())
                {
                    ClipRingTreeView.Nodes.Add(Clipboard.GetText());
                }

                Clipboard.SetText(url);
            }
            else
            {
                if (!File.Exists(IEPathTextBox.Text))
                {
                    MessageBox.Show("IE path incorrect!!", "Error!!");
                    return;
                }

                Process a = new Process();
                a.StartInfo.FileName = IEPathTextBox.Text;
                a.StartInfo.Arguments = url;
                a.Start();
            }
        }
        
        void Button24Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "mstsc.exe";

            if (HostSpecificCheckBox.Checked)
            {
                cmd.StartInfo.Arguments = "/v " + HostNameComboBox.Text + " -console";
            }

            cmd.Start();
        }

        //Telnet
        void Button27Click(object sender, EventArgs e)
        {

            Process cmd = new Process();
            cmd.StartInfo.FileName = Putty_Path_textbox.Text;

            if (HostSpecificCheckBox.Checked)
            {
                if (AutoCredential_CheckBox.Checked)
                {
                    cmd.StartInfo.Arguments = "-telnet -l " + HostUserNameTextBox.Text + " " + HostNameComboBox.Text;
                }
                else
                {
                    cmd.StartInfo.Arguments = "-telnet  " + HostNameComboBox.Text;
                }
            }

            cmd.Start();
        }

        void Button28Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "ping";
            cmd.StartInfo.Arguments = HostNameComboBox.Text;
            cmd.Start();
        }

        void LoadSettings(string filename)
        {
            string[] setttingData = File.ReadAllLines("Settings.dat");
        }

        void AutoCorrectSettings()
        {

        }

        void MainFormLoad(object sender, EventArgs e)
        {

        }

        void LoadIP(string ipstring)
        {
            string[] ipa = ipstring.Split('.');
            IPAddressTextBox1.Text = ipa[0];
            IPAddressTextBox2.Text = ipa[1];
            IPAddressTextBox3.Text = ipa[2];
            IPAddressTextBox4.Text = ipa[3];
        }

        void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = ipl[comboBox1.SelectedIndex].alias;
            CommentsTextBox.Text = ipl[comboBox1.SelectedIndex].comments;
            LoadIP(ipl[comboBox1.SelectedIndex].IP);
        }

        //VNC
        void Button29Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = VNC__Path_textbox.Text;

            if (HostSpecificCheckBox.Checked)
            {
                cmd.StartInfo.Arguments = HostNameComboBox.Text + ":" + vncScreenNumberTextBox.Text;
            }

            cmd.Start();
        }

        //Putty
        void Button31Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = Putty_Path_textbox.Text;

            if (HostSpecificCheckBox.Checked)
            {
                if (AutoCredential_CheckBox.Checked)
                {
                    cmd.StartInfo.Arguments = "-ssh -l " + HostUserNameTextBox.Text + " -pw " + HostPasswordTextBox.Text + " " + HostNameComboBox.Text;
                }
                else
                {
                    cmd.StartInfo.Arguments = "-ssh " + HostNameComboBox.Text;
                }
            }

            cmd.Start();
        }

        void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("TesterBuddy Version-" + TesterBuddyVersionString + " .\rFor queries contact manianvss@hotmail.com .", "Information");
        }

        void PictureBox1Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                ClipRingTreeView.Nodes.Add(Clipboard.GetText());
            Clipboard.SetImage(pictureBox1.Image);
        }

        void HideAllApplicationForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            Thread.Sleep(250);
        }

        void ShowAllApplicationForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Show();
            }
            Thread.Sleep(250);
        }


        void Button3Click(object sender, EventArgs e)
        {

            if (!shortcutScreenCapture)
            {
                HideAllApplicationForms();
            }

            if (Screenshot_SnipCapture_RadioButton.Checked)
            {
                if (Clipboard.ContainsText())
                {
                    ClipRingTreeView.Nodes.Add(Clipboard.GetText());
                }
                ScreenShotPictureBox sspb = new ScreenShotPictureBox(this);
                sspb.Show(this);

                pictureBox1.Image = Clipboard.GetImage();
            }
            else
            {
                enmScreenCaptureMode mode = enmScreenCaptureMode.Window;

                if (Screenshot_ScreenCapture_RadioButton.Checked)
                {
                    mode = enmScreenCaptureMode.Screen;
                }

                Bitmap bm = ScreenCapturer.Capture(mode);
                pictureBox1.Image = bm;
                if (Clipboard.ContainsText())
                {
                    ClipRingTreeView.Nodes.Add(Clipboard.GetText());
                }
                Clipboard.SetImage(bm);
            }

            if (!shortcutScreenCapture)
            {
                ShowAllApplicationForms();
            }

            if (pictureBox1.Image != null)
            {
                previousScreenshotText = "TesterBuddy.ImageCapture.jpg";
                pictureBox1.Image.Save(previousScreenshotText);
            }

        }

        //winscp
        void Button5Click(object sender, EventArgs e)
        {
            string urlstring = "";

            if (HostSpecificCheckBox.Checked)
            {
                if (AutoCredential_CheckBox.Checked)
                {
                    urlstring = "sftp://" + HostUserNameTextBox.Text + ":" + HostPasswordTextBox.Text + "@" + HostNameComboBox.Text;
                }
                else
                {
                    urlstring = "sftp://" + HostNameComboBox.Text;
                }
            }
            else
            {
                urlstring = "sftp://";
            }

            if (Links_OnlyCopyUrlCheckbox.Checked)
            {
                if (Clipboard.ContainsText())
                {
                    ClipRingTreeView.Nodes.Add(Clipboard.GetText());
                }
                Clipboard.SetText(urlstring);
            }
            else
            {
                Process.Start(urlstring);
            }
        }

        void Button6Click(object sender, EventArgs e)
        {
            string urlstring = @"\\" + HostNameComboBox.Text + @"\";

            if (Links_OnlyCopyUrlCheckbox.Checked)
            {
                if (Clipboard.ContainsText())
                {
                    ClipRingTreeView.Nodes.Add(Clipboard.GetText());
                }

                Clipboard.SetText(urlstring);
            }
            else
            {
                Process.Start(urlstring);
            }
        }

        void ClipRingTreeViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.V))
            {
                if (Clipboard.ContainsText())
                    ClipRingTreeView.Nodes.Add(Clipboard.GetText());
            }

            if (e.Control && (e.KeyCode == Keys.C))
            {
                if (ClipRingTreeView.SelectedNode != null)
                {
                    if (ClipRingTreeView.SelectedNode.Text != null)
                        Clipboard.SetText(ClipRingTreeView.SelectedNode.Text);
                }
            }

            if (e.Control && (e.KeyCode == Keys.O))
            {
                if (ClipRingTreeView.SelectedNode != null)
                {
                    string[] lines = ClipRingTreeView.SelectedNode.Text.Split('\n');

                    foreach (string s in lines)
                    {
                        ClipRingTreeView.SelectedNode.Nodes.Add(s);
                    }
                }
            }

            if (e.Control && (e.KeyCode == Keys.S))
            {
                if (ClipRingTreeView.SelectedNode != null)
                {
                    ae = new ASCIIEncoding();
                    saveFileDialog1.InitialDirectory = LogsPathTextBox.Text;
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.ShowDialog();
                    string fname = saveFileDialog1.FileName;
                    FileStream fs = new FileStream(fname, FileMode.Create);
                    fs.Write(ae.GetBytes(ClipRingTreeView.SelectedNode.Text), 0, ae.GetByteCount(ClipRingTreeView.SelectedNode.Text));
                    fs.Close();
                }
            }

            if (e.KeyCode == Keys.Delete)
            {
                if (ClipRingTreeView.SelectedNode != null)
                {
                    ClipRingTreeView.Nodes.Remove(ClipRingTreeView.SelectedNode);
                }
            }
        }

        void ClipRingTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        string GetTimeStamp()
        {
            return DateTime.Now.Ticks.ToString();
        }

        void ScreenShotSaveButtonClick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                do
                {
                    previousScreenshotText = ScreenShotDirectory.Text + ScreenShotPrefixTextBox.Text + GetTimeStamp() + ".jpg";
                } while (File.Exists(previousScreenshotText));

                pictureBox1.Image.Save(previousScreenshotText);
            }

            //ScreenShotCounter.Text=(int.Parse(ScreenShotCounter.Text)+1).ToString();
        }

        void RefreshHosts()
        {
            ipl = IPRecord.GetRecords(hostsFile);

            comboBox1.Items.Clear();

            foreach (IPRecord ipr in ipl)
            {
                comboBox1.Items.Add(ipr.hostname);
                AddHostToComboBox(ipr.hostname);
            }
        }
        void RefreshHostButtonClick(object sender, EventArgs e)
        {
            RefreshHosts();
        }

        void ToOneLineButtonClick(object sender, EventArgs e)
        {
            ProcessTextRTB2.Text = ProcessTextRTB1.Text.Replace("\n", " ");
        }

        void OneWordPerLineButtonClick(object sender, EventArgs e)
        {
            //char[] sep={' ','\t'};
            //string[] words=ProcessTextRTB1.Text.Split(sep,2);
            string[] words = ProcessTextRTB1.Text.Split(' ');
            ProcessTextRTB2.Text = "";
            foreach (string s in words)
                ProcessTextRTB2.Text = ProcessTextRTB2.Text + s + "\r\n";
        }


        void LogFoldersSelectedIndexChanged(object sender, EventArgs e)
        {
            if (LogFolders.SelectedIndex != -1)
            {
                LogFiles.Items.Clear();
                string newpath = LogsPathTextBox.Text + (string)(LogFolders.Items[LogFolders.SelectedIndex]);
                string[] filelist = Directory.GetFiles(newpath);

                foreach (string s in filelist)
                    LogFiles.Items.Add(s.Remove(0, s.LastIndexOf("\\") + 1));
            }
        }

        void LogFilesMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((LogFiles.SelectedIndex != -1) && (LogFolders.SelectedIndex != -1))
            {
                string processString = LogsPathTextBox.Text + (string)LogFolders.Items[LogFolders.SelectedIndex] + "\\" + (string)LogFiles.Items[LogFiles.SelectedIndex];
                Process.Start(processString);
            }
        }

        void LogFoldersMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LogFolders.SelectedIndex != -1)
            {
                string processString = LogsPathTextBox.Text + (string)LogFolders.Items[LogFolders.SelectedIndex];
                Process.Start(processString);
            }
        }

        void NewTextLogButtonClick(object sender, EventArgs e)
        {
            if (LogFolders.SelectedIndex != -1)
            {
                string processString = LogsPathTextBox.Text + (string)LogFolders.Items[LogFolders.SelectedIndex] + "\\new.log";
                Process a = new Process();
                a.StartInfo.FileName = "notepad";
                a.StartInfo.Arguments = processString;
                a.Start();
            }
        }

        void CopyLogPathButtonClick(object sender, EventArgs e)
        {
            if ((LogFiles.SelectedIndex != -1) && (LogFolders.SelectedIndex != -1))
            {
                if (Clipboard.ContainsText())
                    ClipRingTreeView.Nodes.Add(Clipboard.GetText());

                Clipboard.SetText(LogsPathTextBox.Text + (string)LogFolders.Items[LogFolders.SelectedIndex] + "\\" + (string)LogFiles.Items[LogFiles.SelectedIndex]);
            }
        }

        void RefreshClick(object sender, EventArgs e)
        {

            ipl = IPRecord.GetRecords(hostsFile);
            String TodayString = DateTime.Today.Date.Day.ToString() + "_" + DateTime.Today.Date.Month.ToString() + "_" + DateTime.Today.Date.Year.ToString();

            LogFolders.Items.Clear();
            LogFiles.Items.Clear();

            string[] dirlist = Directory.GetDirectories(LogsPathTextBox.Text);

            foreach (string s in dirlist)
            {
                LogFolders.Items.Add(s.Remove(0, s.LastIndexOf("\\") + 1));
            }

            if (!Directory.Exists(LogsPathTextBox.Text + TodayString))
            {
                Directory.CreateDirectory(LogsPathTextBox.Text + TodayString);
            }
            else
            {
                string[] filelist = Directory.GetFiles(LogsPathTextBox.Text + TodayString + "\\");

                foreach (string s in filelist)
                    LogFiles.Items.Add(s.Remove(0, s.LastIndexOf("\\") + 1));
            }
            ScreenShotDirectory.Text = LogsPathTextBox.Text + TodayString + "\\";
        }

        void HttpsCheckButtonClick(object sender, EventArgs e)
        {
            UrlHit("https://" + HostNameComboBox.Text + ":" + HttpsCheckPortTextBox.Text + "/");
        }

        void HttpCheckButtonClick(object sender, EventArgs e)
        {
            UrlHit("http://" + HostNameComboBox.Text + ":" + HttpCheckPortTextBox.Text + "/");
        }

        void UrlHit(string urlstring)
        {
            Process a;

            if (UseHTTPSForAppLinksCheckbox.Checked)
            {
                urlstring = urlstring.Replace("http://", "https://");
            }

            if (Links_OnlyCopyUrlCheckbox.Checked)
            {
                if (Clipboard.ContainsText())
                {
                    ClipRingTreeView.Nodes.Add(Clipboard.GetText());
                }

                Clipboard.SetText(urlstring);
            }
            else if (OpenInFireFoxRadioButton.Checked)
            {
                if (!File.Exists(FireFoxPathTextBox.Text))
                {
                    MessageBox.Show("Firefox path incorrect!!", "Error!!");
                    return;
                }
                a = new Process();
                a.StartInfo.FileName = FireFoxPathTextBox.Text;
                a.StartInfo.Arguments = urlstring;
                a.Start();
            }
            else if (OpenInEmbeddedIERadioButton.Checked)
            {
                webBrowser1.Url = new Uri(urlstring);
                tabControl1.SelectTab(tabPage8);
            }
            else if (OpenInChromeRadioButton.Checked)
            {
                if (!File.Exists(ChromePathTextBox.Text))
                {
                    MessageBox.Show("Chrome path incorrect!!", "Error!!");
                    return;
                }
                a = new Process();
                a.StartInfo.FileName = ChromePathTextBox.Text;
                a.StartInfo.Arguments = urlstring;
                a.Start();
            }
            else if (OpenInIERadioButton.Checked)
            {
                StartInIE(urlstring);
            }
            else if (otherBrowsersComboBox.Enabled)
            {

                string browserpath = otherBrowsers[otherBrowsersComboBox.SelectedIndex != -1 ? otherBrowsersComboBox.SelectedIndex : 0].Value;
                if (!File.Exists(browserpath))
                {
                    MessageBox.Show("Other browser path incorrect!!", "Error!!");
                    return;
                }
                a = new Process();
                a.StartInfo.FileName = browserpath;
                a.StartInfo.Arguments = urlstring;
                a.Start();
            }
            else
            {
                MessageBox.Show("There is an error with browser selection!!", "Error!!");
            }
        }

        void LogFilesKeyDown(object sender, KeyEventArgs e)
        {
            Process a;

            if (e.Control && (e.KeyCode == Keys.V))
            {
                if (Clipboard.ContainsFileDropList())
                {
                    foreach (string s in Clipboard.GetFileDropList())
                    {
                        //Process.Start("xcopy "+s+LogsPathTextBox.Text);
                        a = new Process();
                        a.StartInfo.FileName = "xcopy";
                        a.StartInfo.Arguments = s + LogsPathTextBox.Text;
                        a.Start();
                        ClipRingTreeView.Nodes.Add(s);
                    }
                }
            }
        }

        void FTPBrowserButtonClick(object sender, EventArgs e)
        {
            UrlHit("ftp://" + HostNameComboBox.Text);
        }

        void PictureBox1MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Clipboard.ContainsImage())
                pictureBox1.Image = Clipboard.GetImage();
        }

        void OpenHostFileClick(object sender, EventArgs e)
        {
            Process a = new Process();
            a.StartInfo.FileName = @"c:\windows\system32\notepad.exe";
            a.StartInfo.Arguments = hostsFile;
            a.Start();
        }

        //Helper functions to read and write bytes to stream.
        byte[] ReadLengthAndBytes(Stream s)
        {
            byte[] buff = new byte[4];
            s.Read(buff, 0, 4);
            int len = BitConverter.ToInt32(buff, 0);

            buff = new byte[len];
            s.Read(buff, 0, len);
            return buff;
        }

        void WriteLengthAndBytes(Stream s, int len, byte[] buff)
        {
            s.Write(BitConverter.GetBytes(len), 0, 4);
            s.Write(buff, 0, len);
        }

        void SendMsgToStream(Stream s, string msg)
        {
            ASCIIEncoding ae = new ASCIIEncoding();
            WriteLengthAndBytes(s, (byte)ae.GetByteCount(msg), ae.GetBytes(msg));
        }

        String GetMsgFromStream(Stream s)
        {
            ASCIIEncoding ae = new ASCIIEncoding();
            return ae.GetString(ReadLengthAndBytes(s));
        }

        void OpenTodayLogButtonClick(object sender, EventArgs e)
        {
            Process.Start(LogsPathTextBox.Text + "\\" + TodayString);
        }

        void AddPrefixButtonClick(object sender, EventArgs e)
        {
            string prefix = ProcessTextFixTextBox.Text;
            ProcessTextRTB2.Clear();
            string[] lines = ProcessTextRTB1.Text.Split('\n');
            foreach (string line in lines)
                ProcessTextRTB2.AppendText(prefix + line + '\n');
        }



        void MainFormKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyData == Keys.L))
            {
                tabControl1.SelectedTab = tabPage6;
            }
        }

        //Copies Ip from split textbox
        public string getIPFromUI()
        {
            if ((IPAddressTextBox1.Text.Length > 3) || (IPAddressTextBox2.Text.Length > 3)
               || (IPAddressTextBox3.Text.Length > 3) || (IPAddressTextBox4.Text.Length > 3)
               || (int.Parse(IPAddressTextBox1.Text) > 255) || (int.Parse(IPAddressTextBox2.Text) > 255)
               || (int.Parse(IPAddressTextBox3.Text) > 255) || (int.Parse(IPAddressTextBox4.Text) > 255)
               || (int.Parse(IPAddressTextBox1.Text) < 0) || (int.Parse(IPAddressTextBox2.Text) < 0)
               || (int.Parse(IPAddressTextBox3.Text) < 0) || (int.Parse(IPAddressTextBox4.Text) < 0))
            {
                MessageBox.Show("Please enter a valid IP.", "Wrong User Input!!!");
                return "";
            }

            return IPAddressTextBox1.Text + "." + IPAddressTextBox2.Text + "." + IPAddressTextBox3.Text + "." + IPAddressTextBox4.Text;
        }

        //Copy IP Button on Clicked function below.
        void CopyIPButtonClick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                ClipRingTreeView.Nodes.Add(Clipboard.GetText());
            Clipboard.SetText(getIPFromUI());//ipl[comboBox1.SelectedIndex].IP);
        }

        //Copy Details Button on Clicked function below.
        void Button33Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                if (comboBox1.Items.Count > 0)
                    comboBox1.SelectedIndex = 0;
            }

            if (Clipboard.ContainsText())
                ClipRingTreeView.Nodes.Add(Clipboard.GetText());
            Clipboard.SetText(ipl[comboBox1.SelectedIndex].IP + " " + ipl[comboBox1.SelectedIndex].hostname + " " + ipl[comboBox1.SelectedIndex].alias);
        }

        void PasteIPButtonClick(object sender, EventArgs e)
        {
            String ip = Clipboard.GetText();
            String[] ipstr = ip.Split('.');
            IPAddressTextBox1.Text = ipstr[0];
            IPAddressTextBox2.Text = ipstr[1];
            IPAddressTextBox3.Text = ipstr[2];
            IPAddressTextBox4.Text = ipstr[3];
        }

        void OpenScreenshotButtonClick(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(ScreenShotDirectory.Text, "*.jpg");

            if (files.Length > 0)
                Process.Start(files[0]);
        }

        private List<string> GetIpAddresses()
        {
            Process cmd = new Process();
            //StreamWriter sw=cmd.StandardInput;
            string ipconfigfile = @"C:\Windows\System32\ipconfig.exe";
            cmd.StartInfo.FileName = ipconfigfile;
            cmd.StartInfo.Arguments = " /all";
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            StreamReader sr = cmd.StandardOutput;
            string[] output = (sr.ReadToEnd()).Split('\n');
            string tempIp;
            List<string> ips = new List<string>();

            foreach (string s in output)
            {
                if (s.Contains("Address. . . . . . . . . . . : "))
                {
                    tempIp = s.Substring(s.IndexOf("Address. . . . . . . . . . . : ") + "Address. . . . . . . . . . . : ".Length);

                    if (tempIp.Contains("("))
                    {
                        tempIp = tempIp.Substring(0, tempIp.IndexOf("("));
                    }
                    else
                    {
                        tempIp = tempIp.Substring(0, tempIp.IndexOf("\r\n"));
                    }

                    ips.Add(tempIp);
                }
            }

            return ips;
        }

        //IPconfig click
        void Button87Click(object sender, EventArgs e)
        {
            string fetchedIP = "";

            foreach (string s in GetIpAddresses())
            {
                fetchedIP = fetchedIP + s + "\r";
            }
            MessageBox.Show("Ipconfig Info:\r" + fetchedIP, "Ipconfig");
        }

        void GetParamFromURLButtonClick(object sender, EventArgs e)
        {
            string pstr = ProcessTextRTB1.Text.Substring(ProcessTextRTB1.Text.IndexOf('?') + 1);
            ProcessTextRTB2.Clear();
            string[] lines = pstr.Split('&');
            foreach (string line in lines)
            {
                string param = line.Substring(0, line.IndexOf('='));
                string pvalue = line.Substring(line.IndexOf('=') + 1);
                ProcessTextRTB2.AppendText(param + "=" + HttpUtility.UrlDecode(pvalue) + '\n');
            }
        }


        void HostNameTextBoxTextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains(HostNameTextBox.Text))
            {
                int index = comboBox1.Items.IndexOf(HostNameTextBox.Text);

                textBox6.Text = ipl[index].alias;
                CommentsTextBox.Text = ipl[index].comments;
                LoadIP(ipl[index].IP);
            }
        }

        void RunStafProcess(string host, string app, string args, string workingdir, bool waitforcompletion)
        {
            Process cmd = new Process();

            cmd.StartInfo.FileName = StafpathTextBox.Text;
            cmd.StartInfo.Arguments = host + " PROCESS START COMMAND " + app;

            if (args != null)
                cmd.StartInfo.Arguments = args;

            if (waitforcompletion)
                cmd.StartInfo.Arguments = cmd.StartInfo.Arguments + " wait";

            cmd.Start();
        }

        void PasteHostDetailsButtonClick(object sender, EventArgs e)
        {
            string[] words = Clipboard.GetText().Split(' ', '\t');
            string ip;
            string[] ipstr;
            bool hostnamedone = false;
            bool oneAliasDone = false;

            textBox6.Clear();

            foreach (string word in words)
            {
                if (char.IsDigit(word[0]))
                {
                    ip = word;
                    ipstr = ip.Split('.');
                    IPAddressTextBox1.Text = ipstr[0];
                    IPAddressTextBox2.Text = ipstr[1];
                    IPAddressTextBox3.Text = ipstr[2];
                    IPAddressTextBox4.Text = ipstr[3];
                }
                else
                {
                    if (!hostnamedone)
                    {
                        hostnamedone = true;
                        HostNameTextBox.Text = word;
                    }
                    else
                    {
                        if (word.Length == 1)
                        {
                            if (char.IsWhiteSpace(word[0]))
                                continue;
                        }

                        word.TrimStart('\t', ' ');
                        word.TrimEnd('\t', ' ');

                        if (oneAliasDone)
                        {
                            textBox6.Text = textBox6.Text + "\t";
                        }
                        textBox6.Text = textBox6.Text + word;

                        oneAliasDone = true;
                    }
                }
            }
        }

        void HostNameComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (HostNameComboBox.SelectedIndex == -1)
                return;
            selectedhost = HostNameComboBox.Text;
            UpdateFormTitle();
            CheckAndLoadNewSettings();
        }

        void ProcessText_RemoveLeadingWhiteSpacesClick(object sender, EventArgs e)
        {
            string[] lines = ProcessTextRTB1.Text.Split('\n');
            ProcessTextRTB2.Clear();

            foreach (string line in lines)
            {
                ProcessTextRTB2.AppendText(line.TrimStart(' ', '\t') + "\n");
            }
        }

        void ProcessText_ToJavaStringButtonClick(object sender, EventArgs e)
        {
            string temp = ProcessTextRTB1.Text;
            temp = temp.Replace("\\", @"\\");
            temp = temp.Replace("\"", "\\\"");
            temp = temp.Replace("\'", "\\\'");
            temp = temp.Replace("\n", "\\n\"\n+\"");
            temp = temp.Replace("\t", "\\t\"\t+\"");
            temp = temp.Replace("\r", @"\r");
            temp = temp.Replace("\b", @"\b");
            temp = temp.Replace("\f", @"\f");
            ProcessTextRTB2.Text = "\"" + temp + "\"";
        }

        void CopyScreenshotButtonClick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (Clipboard.ContainsText())
                    ClipRingTreeView.Nodes.Add(Clipboard.GetText());
                Clipboard.SetImage(pictureBox1.Image);
            }
        }

        void PasteScreenshotButtonClick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                pictureBox1.Image = Clipboard.GetImage();
            }
        }

        void RefreshConfigButtonClick(object sender, EventArgs e)
        {
            settings = new Settings();

            if (HostSpecificCheckBox.Checked)
            {
                CheckAndLoadNewSettings();
                LoadBaseSetting(false);
            }
            else
            {
                InitSettings(SettingsFileName, true);
            }
        }

        bool ValidateAppPath(string appPath)
        {
            return File.Exists(appPath);
        }

        void ValidateConfigButtonClick(object sender, EventArgs e)
        {
            if (!ValidateAppPath(IEPathTextBox.Text))
            {
                MessageBox.Show("IE path incorrect", "Settings Error!");
            }

            if (!ValidateAppPath(FireFoxPathTextBox.Text))
            {
                MessageBox.Show("FireFox path incorrect", "Settings Error!");
            }

            if (!ValidateAppPath(ChromePathTextBox.Text))
            {
                MessageBox.Show("Google Chrome path incorrect", "Settings Error!");
            }

            if (!ValidateAppPath(Putty_Path_textbox.Text))
            {
                MessageBox.Show("Putty path incorrect", "Settings Error!");
            }

            if (!ValidateAppPath(WinSCP_Path_textbox.Text))
            {
                MessageBox.Show("WinSCP path incorrect", "Settings Error!");
            }

            if (!ValidateAppPath(VNC__Path_textbox.Text))
            {
                MessageBox.Show("VNC path incorrect", "Settings Error!");
            }

            if (!ValidateAppPath(StafpathTextBox.Text))
            {
                MessageBox.Show("STAF path incorrect", "Settings Error!");
            }

            if (!ValidateAppPath(ZipToolPathTextBox.Text))
            {
                MessageBox.Show("7z path incorrect", "Settings Error!");
            }
        }

        void SortHostsButtonClick(object sender, EventArgs e)
        {
            IPRecord.SortRecordsBasedOnHostName(hostsFile);
            RefreshHostButtonClick(sender, e);
        }

        public List<string> GetIP()
        {

            Process cmd = new Process();
            //StreamWriter sw=cmd.StandardInput;
            cmd.StartInfo.FileName = "c:\\windows\\system32\\ipconfig.exe";
            cmd.StartInfo.Arguments = " /all";
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            StreamReader sr = cmd.StandardOutput;
            string[] output = (sr.ReadToEnd()).Split('\n');
            string tempIp;
            List<string> iplist = new List<string>();

            foreach (string s in output)
            {
                if (s.Contains("IP") && s.Contains("Address") && (!s.Contains("IPv6")))
                {
                    foreach (string ipPre in ipPrefix)
                    {
                        if (s.Contains(ipPre))
                        {
                            tempIp = s.Substring(s.IndexOf(ipPre));

                            //Regex.IsMatch(
                            for (int i = 0; i < tempIp.Length; i++)
                            {
                                if (!(char.IsDigit(tempIp[i]) || (tempIp[i] == '.')))
                                {
                                    tempIp = tempIp.Substring(0, i);
                                    break;
                                }
                            }

                            iplist.Add(tempIp);
                        }
                    }
                }
            }

            return iplist;
        }

        void FixHostsButtonClick(object sender, EventArgs e)
        {
            string hostname = Environment.MachineName.ToLower();
            string domainname = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;

            //MessageBox.Show("Hostname: "+hostname+"."+domainname,"Info");
            List<string> iplist = GetIP();

            if (iplist.Count < 1)
            {
                MessageBox.Show("Please provide appropriate \"IP Prefix\" in the settings file or check the network setting for system IP.\n", "Error with IP resolution");
            }

            IPRecord.AddRecords(new IPRecord("127.0.0.1", "localhost.localdomain", "localhost"), hostsFile);
            IPRecord.AddRecords(new IPRecord(iplist[0], hostname + "." + domainname, hostname), hostsFile);
            RefreshHostButtonClick(sender, e);
        }

        void AutoHostAddButtonClick(object sender, EventArgs e)
        {
            string HostToAdd = HostNameTextBox.Text;

            Process cmd = new Process();
            //StreamWriter sw=cmd.StandardInput;
            cmd.StartInfo.FileName = "c:\\windows\\system32\\ping.exe";
            cmd.StartInfo.Arguments = " " + HostToAdd;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            StreamReader sr = cmd.StandardOutput;
            string[] output = (sr.ReadToEnd()).Split('\n');

            IPRecord.DeleteHostByName(HostToAdd, hostsFile);

            int startIndex = output[1].IndexOf('[') + 1, endIndex = output[1].IndexOf(']') - startIndex;

            string ip = output[1].Substring(startIndex, endIndex);

            IPRecord newRecord = new IPRecord(ip, HostToAdd, "");

            IPRecord.AddRecords(newRecord, hostsFile);

            RefreshHostButtonClick(sender, e);
        }

        void DeleteHostButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HostNameTextBox.Text))
            {
                IPRecord.DeleteHostByName(HostNameTextBox.Text, hostsFile);
                RefreshHosts();
            }
        }


        void AdditionalHostAddButtonClick(object sender, EventArgs e)
        {
            selectedhost = HostNameComboBox.Text;

            if (HostNameComboBox.Items.Contains(selectedhost))
            {
                return;
            }

            AddHostToComboBox(selectedhost);

            if (!additionalHosts.Contains(selectedhost))
            {
                additionalHosts.Add(selectedhost);
            }

            SaveBaseSettings();
            //BuildAdditionalHostsSettings();
            CheckAndLoadNewSettings();
        }

        void SaveBaseSettings()
        {
            //Save base only settings to base settings file
            Settings basesettings = new Settings(SettingsFileName);

            basesettings.AddSetting("System_hosts_file_path", hostsFile);

            if (additionalHosts.Count > 0)
            {
                basesettings.AddSetting("TesterBuddy_Additional_Hosts", additionalHosts);
            }
            //selectedhost=HostNameComboBox.Text;
            if (!string.IsNullOrEmpty(selectedhost))
            {
                basesettings.AddSetting("TesterBuddy_Selected_Host", selectedhost);
            }

            basesettings.AddSetting("TesterBuddy_TempDir_Path", TesterBuddy_TempDir_Path);

            basesettings.SaveSettingsToXMLFile(SettingsFileName);
        }

        void SaveConfigurationButtonClick(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new Settings();
            }

            Settings nsettings = new Settings(settings);



            if (HostSpecificSettingsCheckBox.Checked)
            {
                nsettings = GatherSettings(false, false);
                nsettings.SaveSettingsToXMLFile(selectedhost + ".TB.Settings.xml");

                SaveBaseSettings();
            }
            else
            {
                nsettings = GatherSettings(true, false);
                nsettings.SaveSettingsToXMLFile(SettingsFileName);
            }

            settings = nsettings;
        }

        private void FormatXMLButton_Click(object sender, EventArgs e)
        {
            ProcessTextRTB2.Text = XMLFormatter.IndentXML(ProcessTextRTB1.Text);
        }

        private void AddSuffixButton_Click(object sender, EventArgs e)
        {
            string suffix = ProcessTextFixTextBox.Text;
            ProcessTextRTB2.Clear();
            string[] lines = ProcessTextRTB1.Text.Split('\n');
            foreach (string line in lines)
                ProcessTextRTB2.AppendText(line + suffix + '\n');
        }

        void RemoveNullParamXMLButtonClick(object sender, EventArgs e)
        {
            ProcessTextRTB2.Text = XMLFormatter.RemoveNullValueParameters(ProcessTextRTB1.Text);
        }

        void IncrementValuesButtonClick(object sender, EventArgs e)
        {
            string initialText = ProcessTextRTB1.Text;
            string criteria = ProcessTextFixTextBox.Text;
            //string finalText;

            //If no criteria mentioned, increment all numbers
            if (string.IsNullOrEmpty(criteria))
            {

            }

            //Else increment postfixed numbers eg Order1 will become Order2
            else
            {

            }
        }

        void SaveConfigAsButtonClick(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".xml";

            switch (saveFileDialog1.ShowDialog())
            {

                case DialogResult.OK:
                case DialogResult.Yes:
                    settings.SaveSettingsToXMLFile(saveFileDialog1.FileName);
                    break;
                default:
                    break;
            }

        }

        void LoadConfigButtonClick(object sender, EventArgs e)
        {
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.DefaultExt = ".xml";
            switch (openFileDialog1.ShowDialog())
            {

                case DialogResult.OK:
                case DialogResult.Yes:
                    InitSettings(openFileDialog1.FileName);
                    break;

                default:
                    break;
            }
        }

        void HTTPPostParamListBoxKeyDown(object sender, KeyEventArgs e)
        {
            //param=value pairs demilted by either & or whitespace
            if (e.Control && (e.KeyCode == Keys.V))
            {
                if (Clipboard.ContainsText())
                {
                    string paramListToAdd = Clipboard.GetText();
                    //List<KeyValuePair<string,string>> paramToAdd=new List<KeyValuePair<string, string>>();
                    string[] paramPairs;

                    if (!paramListToAdd.Contains("="))
                    {
                        //Should contain atleast one parameter
                        return;
                    }

                    paramPairs = paramListToAdd.Split('&');// split only based on &, ' ','\n','\t');

                    foreach (string parampair in paramPairs)
                    {

                        if (!parampair.StartsWith("=") && parampair.Contains("="))// Don't chekc multiple equals&& (parampair.IndexOf("=")==parampair.LastIndexOf("=")))
                        {
                            AddParamValueToHTTPPostList(parampair.Substring(0, parampair.IndexOf("=")), parampair.Substring(parampair.IndexOf("=") + 1));
                        }
                    }
                }
            }
        }

        public void AddParamValueToHTTPPostList(string param, string value)
        {
            //Update if existing parameter.
            for (int i = 0; i < HTTPPostParamListBox.Items.Count; i++)
            {
                if (((string)HTTPPostParamListBox.Items[i]).StartsWith(param + "="))
                {
                    HTTPPostParamListBox.Items[i] = param + "=" + value;
                    return;
                }
            }

            HTTPPostParamListBox.Items.Add(param + "=" + value);
        }

        void HTTPPostAddParamToListButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HTTPPostParameterTextBox.Text))
            {
                //Add new parameter if not found for updation.
                AddParamValueToHTTPPostList(HTTPPostParameterTextBox.Text, HTTPPostValueTextBox.Text);
            }
        }

        void HTTPPostRunButtonClick(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> postParams = new List<KeyValuePair<string, string>>();

            foreach (string param in HTTPPostParamListBox.Items)
            {
                postParams.Add(new KeyValuePair<string, string>(param.Substring(0, param.IndexOf("=")), param.Substring(param.IndexOf("=") + 1)));
            }
            string webresponse = WebRequestHelper.GetURLResultPOST(HTTPPostURLTextBox.Text, postParams, webrequest_timeout);

            HTTPPostResultBrowser.DocumentText = "<html><body> webresponse </body> </html>";
        }

        void HTTPPost_DeleteParamButtonClick(object sender, EventArgs e)
        {
            if (HTTPPostParamListBox.SelectedIndex != -1)
            {
                HTTPPostParamListBox.Items.Remove(HTTPPostParamListBox.SelectedItem);
            }
        }

        void HTTPPost_ClearParamButtonClick(object sender, EventArgs e)
        {
            HTTPPostParamListBox.Items.Clear();
        }

        void HTTPPostParamListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            string paramvalue;

            if (HTTPPostParamListBox.SelectedIndex != -1)
            {
                paramvalue = (string)HTTPPostParamListBox.SelectedItem;
                HTTPPostParameterTextBox.Text = paramvalue.Substring(0, paramvalue.IndexOf("="));
                HTTPPostValueTextBox.Text = paramvalue.Substring(paramvalue.IndexOf("=") + 1);
            }
        }

        void OpenConfigXMLButtonClick(object sender, EventArgs e)
        {
            if (HostSpecificSettingsCheckBox.Checked && File.Exists(selectedhost + ".TB.Settings.xml"))
            {
                Process.Start(selectedhost + ".TB.Settings.xml");
            }
            else
            {
                Process.Start(SettingsFileName);
            }
        }

        //Increment counters provided in text and criteria based on the criteria
        //Eg if text is "abc def" and criteria is "abc"
        //, output text would be "abd def" and criteria would become "abd"

        private void IncrementCounters(ref string instring, ref string counterString)
        {
            ASCIIEncoding ae = new ASCIIEncoding();

            string[] counters = counterString.Split('\n');

            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = counters[i].Trim('\r', ' ', '\t');

                //Debug Messages
                //ProcessTextRTB2.AppendText("\n Counters["+i+"]="+counters[i]);
            }

            string[] replaceCounters = new string[counters.Length];

            for (int i = 0; i < counters.Length; i++)
            {
                replaceCounters[i] = counters[i];
            }

            //bool carry;
            char tempChar, tempchar2;

            for (int i = 0; i < replaceCounters.Length; i++)
            {
                for (int j = replaceCounters[i].Length - 1; j >= 0; j--)
                {
                    tempChar = replaceCounters[i][j];
                    tempchar2 = replaceCounters[i][j];
                    tempchar2++;

                    string str1 = replaceCounters[i].Substring(0, j);
                    string str2;

                    if (char.IsDigit(replaceCounters[i][j]))
                    {
                        tempchar2 = (char)(((tempChar + 1) - '0') % 10 + '0');
                        str2 = tempchar2.ToString();
                    }
                    else if (char.IsLetter(replaceCounters[i][j]))
                    {
                        char addchar;

                        if (char.IsLower(replaceCounters[i][j]))
                        {
                            addchar = 'a';
                        }
                        else
                        {
                            addchar = 'A';
                        }

                        tempchar2 = (char)(((tempChar + 1) - addchar) % 26 + addchar);
                        str2 = tempchar2.ToString();
                    }
                    else
                    {
                        //Don't have to increment on non alpha numerical character.
                        //str2=((char)(replaceCounters[i][j]+1)).ToString();
                        continue;
                    }
                    string str3 = replaceCounters[i].Substring(j + 1, replaceCounters[i].Length - j - 1);

                    //Debug messages
                    //ProcessTextRTB2.AppendText("\n replaceCounters[i].Substring(0,j)="+str1);
                    //ProcessTextRTB2.AppendText("\n ((char)replaceCounters[i][j]+1)).ToString()="+str2);
                    //ProcessTextRTB2.AppendText("\n replaceCounters[i].Substring(j+1,replaceCounters[i].Length-j-1)="+str3);

                    replaceCounters[i] = str1 + str2 + str3;

                    //Debug messages
                    //ProcessTextRTB2.AppendText("\n replaceCounters["+i+"]="+replaceCounters[i]);

                    if (tempChar < tempchar2)
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < counters.Length; i++)
            {
                if (string.IsNullOrEmpty(replaceCounters[i]))
                {
                    continue;
                }

                instring = instring.Replace(counters[i], replaceCounters[i]);
                counterString = counterString.Replace(counters[i], replaceCounters[i]);
            }
        }

        void ProcessText_IncrementCountersButtonClick(object sender, EventArgs e)
        {

            string text, criteria;

            text = ProcessTextRTB1.Text;
            criteria = ProcessTextRTB2.Text;
            IncrementCounters(ref text, ref criteria);

            ProcessTextRTB1.Text = text;
            ProcessTextRTB2.Text = criteria;

        }

        void WC_openinIERBCheckedChanged(object sender, EventArgs e)
        {
            OpenInIERadioButton.Checked = true;
        }

        void WC_openinFFRBCheckedChanged(object sender, EventArgs e)
        {
            OpenInFireFoxRadioButton.Checked = true;
        }

        void WC_openinTBRBCheckedChanged(object sender, EventArgs e)
        {
            OpenInEmbeddedIERadioButton.Checked = true;
        }

        private static string[] GetFiles(string sourceFolder, string filters)//, System.IO.SearchOption searchOption)
        {
            return filters.Split('|').SelectMany(filter => System.IO.Directory.GetFiles(sourceFolder, filter)).ToArray();
        }

        public void ExtractArchivesInDirectory(string directory, int maxRecurse, bool recursive, bool delarchive)
        {
            string[] archiveFiles = GetFiles(directory, "*.jar|*.tar|*.rar|*.7z|*.zip|*.war|*.sar|*.gz|*.gzip");//Directory.GetFiles(directory,"*.*ar");

            foreach (string archiveFile in archiveFiles)
            {
                //FileAttributes fileattr=File.GetAttributes(directory);

                //if((fileattr&FileAttributes.Archive)==FileAttributes.Archive)
                //{
                ExtractArchiveFile(archiveFile, false, maxRecurse - 1, recursive, delarchive);
                //}
            }

            if ((recursive) && (maxRecurse > 0))
            {
                string[] directories = Directory.GetDirectories(directory);

                foreach (string dir in directories)
                {
                    ExtractArchivesInDirectory(dir, maxRecurse - 1, recursive, delarchive);
                }
            }
        }

        public bool IsArchive(string s)
        {
            s = s.ToLower();
            return (s.EndsWith(".jar") || s.EndsWith(".rar")
                   || s.EndsWith(".tar") || s.EndsWith(".ear")
                   || s.EndsWith(".war") || s.EndsWith(".sar")
                   || s.EndsWith(".zip") || s.EndsWith(".7z")
                   || s.EndsWith(".gzip") || s.EndsWith(".bz")
                   || s.EndsWith(".gz")
                  );
        }

        public bool CompareFileContents(string file1, string file2, ref string report)
        {
            return false;
        }

        public bool MQACompareArchives(string archiveFile1, string archiveFile2, string tempdir, ref string report)
        {
            if (!Directory.Exists(tempdir))
            {
                throw new Exception("Temp directory " + tempdir + " does not exist");
            }

            if (!Directory.Exists(archiveFile1))
            {
                throw new Exception("File " + archiveFile1 + " does not exist");
            }

            if (!Directory.Exists(archiveFile2))
            {
                throw new Exception("File " + archiveFile2 + " does not exist");
            }

            if (!IsArchive(archiveFile1) || !IsArchive(archiveFile2))
            {

            }

            return true;
        }

        public void ExtractArchiveFile(string file, bool firstcall, int maxRecurse, bool recursive, bool delarchive)
        {
            if (!firstcall)
            {
                string pfile = file;

                pfile = file.Substring(ExtractArchivePathTextBox.Text.Substring(0, ExtractArchivePathTextBox.Text.LastIndexOf('.')).Length);

                //If there is atleast one remove term associated then check for file name term remove and exception files.
                if (ExtractArchiveRemoveTermsComboBox.Items.Count > 0)
                {
                    bool fileExcluded = false;

                    //Check if file falls in one of the exception category only if there is atleast one exception
                    if (ExtractArchiveExcludedFilesComboBox.Items.Count > 0)
                    {
                        foreach (string s in ExtractArchiveExcludedFilesComboBox.Items)
                        {
                            if (pfile.ToLower().EndsWith(s.ToLower()))
                            {
                                fileExcluded = true;
                                break;
                            }
                        }
                    }

                    //Check for remove terms and remove them from file/folder names.
                    if (!fileExcluded)
                    {
                        foreach (string s in ExtractArchiveRemoveTermsComboBox.Items)
                        {
                            if (pfile.Contains(s))
                            {
                                pfile = pfile.Replace(s, "");
                            }
                        }
                    }
                }
                pfile = ExtractArchivePathTextBox.Text.Substring(0, ExtractArchivePathTextBox.Text.LastIndexOf('.')) + "\\" + pfile;
                File.Move(file, pfile);

                file = pfile;
            }

            string dirname = file.Substring(0, file.LastIndexOf('.'));

            if (dirname.Length > 250)
            {
                return;
            }

            Process p = new Process();
            p.StartInfo.FileName = ZipToolPathTextBox.Text;
            p.StartInfo.Arguments = "x " + file + " -o" + dirname;

            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;


            //p.StartInfo.UseShellExecute=false;
            //p.StartInfo.RedirectStandardInput=true;
            //p.StartInfo.RedirectStandardOutput=true;
            //p.StartInfo.CreateNoWindow=true;

            p.Start();
            p.WaitForExit();

            //ArchiveTools_ResultsTextBox.AppendText(p.StandardOutput.ReadToEnd());

            if (recursive)
            {
                if (maxRecurse > 0)
                {
                    ExtractArchivesInDirectory(file.Substring(0, file.LastIndexOf('.')), maxRecurse - 1, recursive, recursive);
                }
                else
                {
                    string[] allfiles = Directory.GetFiles(file.Substring(0, file.LastIndexOf('.')));
                    //Directory.GetFiles(file.Substring(0,file.LastIndexOf('.')), "*.*")
                    //.Where(s => s.EndsWith(".jar") || s.EndsWith(".ear") || s.EndsWith(".war") || s.EndsWith(".sar") || s.EndsWith(".zip") || s.EndsWith(".7z") || s.EndsWith(".rar") || s.EndsWith(".tar")  || s.EndsWith(".gzip") || s.EndsWith(".gz")   );
                    //Directory.GetFiles(file.Substring(0,file.LastIndexOf('.')),"*.*ar");
                    List<string> dirFiles = new List<string>();

                    foreach (string s in allfiles)
                    {
                        if (s.ToLower().EndsWith(".jar") || s.ToLower().EndsWith(".rar")
                           || s.ToLower().EndsWith(".tar") || s.ToLower().EndsWith(".ear")
                           || s.ToLower().EndsWith(".war") || s.ToLower().EndsWith(".sar")
                           || s.ToLower().EndsWith(".zip") || s.ToLower().EndsWith(".7z")
                           || s.ToLower().EndsWith(".gzip") || s.ToLower().EndsWith(".bz")
                           || s.ToLower().EndsWith(".gz")
                          )
                        {
                            dirFiles.Add(s);
                        }
                    }

                    foreach (string dirFile in dirFiles)
                    {
                        string pdirFile = dirFile;

                        foreach (string s in ExtractArchiveRemoveTermsComboBox.Items)
                        {
                            if (pdirFile.Contains(s))
                            {
                                pdirFile = pdirFile.Replace(s, "");
                            }
                        }
                        File.Move(dirFile, pdirFile);
                    }
                }
            }

            if (delarchive)
            {
                File.Delete(file);
            }
        }

        void BrowseArchiveFileButtonClick(object sender, EventArgs e)
        {
            //ExtractArchivePathTextBox.
            //openFileDialog1.Filter="";
            openFileDialog1.ShowDialog();

            string archiveFileName = openFileDialog1.FileName;
            ExtractArchivePathTextBox.Text = archiveFileName;

            //if(ExtractArchivePathTextBox.Text.Contains(" "))
            //{
            //	ExtractArchivePathTextBox.Text=ExtractArchivePathTextBox.Text.Replace(" ","/ ");
            //}
            //ExtractArchiveFile(archiveFileName,RecursivelyExtractArchiveCheckBox.Checked);
        }

        void ArchiveExtractButtonClick(object sender, EventArgs e)
        {
            int maxrecurse = 0;

            if (!string.IsNullOrEmpty(ExtractArchiveMaxNestingTextBox.Text))
            {
                maxrecurse = int.Parse(ExtractArchiveMaxNestingTextBox.Text);
            }

            ThreadStart zipTS;
            {
                if (!string.IsNullOrEmpty(ExtractArchive_ExtractPathTextBox.Text) && !ExtractArchivePathTextBox.Text.Equals(ExtractArchive_ExtractPathTextBox.Text))
                {
                    File.Copy(ExtractArchivePathTextBox.Text, ExtractArchive_ExtractPathTextBox.Text);
                }

                zipTS = delegate { ExtractArchiveFile(ExtractArchivePathTextBox.Text, true, maxrecurse, RecursivelyExtractArchiveCheckBox.Checked, false); };
            }

            extractThread = new Thread(zipTS);
            ExtractGroupBox.Enabled = false;
            ExtractFileTimer.Start();
            extractThread.Start();

            /*
			ExtractArchiveFile(ExtractArchivePathTextBox.Text,true,maxrecurse,RecursivelyExtractArchiveCheckBox.Checked,false);
			 */

        }

        void ExtractFileTimerTick(object sender, EventArgs e)
        {
            if (extractThread != null)
            {
                if (!extractThread.IsAlive)
                {
                    ExtractFileTimer.Stop();
                    MessageBox.Show("Extract archive operation complete!", "Done");
                    ExtractGroupBox.Enabled = true;
                    extractThread = null;
                }
            }
        }

        void ExtractArchiveAddRemoveTermButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ExtractArchiveAddRemoveTermTextBox.Text) && !ExtractArchiveRemoveTermsComboBox.Items.Contains(ExtractArchiveAddRemoveTermTextBox.Text))
            {
                ExtractArchiveRemoveTermsComboBox.Items.Add(ExtractArchiveAddRemoveTermTextBox.Text);
            }
        }

        void ExtractArchiveRemoveTermsComboBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (ExtractArchiveRemoveTermsComboBox.SelectedIndex != -1)
                {
                    ExtractArchiveRemoveTermsComboBox.Items.RemoveAt(ExtractArchiveRemoveTermsComboBox.SelectedIndex);
                }
                else if (ExtractArchiveRemoveTermsComboBox.Items.Count > 0)
                {
                    ExtractArchiveRemoveTermsComboBox.Items.RemoveAt(0);
                }
                //else do nothing
            }
        }

        void UserCredentialsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserCredentialsComboBox.SelectedIndex != -1)
            {
                string credential = ((string)UserCredentialsComboBox.Items[UserCredentialsComboBox.SelectedIndex]);

                if (credential.Contains("/"))
                {
                    HostUserNameTextBox.Text = credential.Substring(0, credential.IndexOf("/"));
                    HostPasswordTextBox.Text = credential.Substring(credential.IndexOf("/") + 1);
                }
            }
        }

        void HTTPPost_PasteParamDataButtonClick(object sender, EventArgs e)
        {
            string[] lines = Clipboard.GetText().Split('\r', '\n');

            foreach (string line in lines)
            {
                if (line.Trim('\r', '\n').Length > 0)
                {
                    AddParamValueToHTTPPostList(line.Substring(0, line.IndexOf('=')), line.Substring(line.IndexOf('=') + 1));
                }
            }
        }

       
        void MachineCheckSTAFButtonClick(object sender, EventArgs e)
        {
            Machine m = new Machine();

            m.name = HostNameComboBox.Text;

            if (m.CheckStafConnection())
            {
                MessageBox.Show("Staf is running on " + m.name + ".", "Success");
            }
            else
            {
                MessageBox.Show("Staf error " + m.name + ".", "Fail");
            }

            //m.GetTrustLevel();

            //MessageBox.Show("Trust level "+m.GetTrustLevel(), "Trust level");
        }


        void ExtractArchiveDeleteRemoveTermButtonClick(object sender, EventArgs e)
        {
            if (ExtractArchiveRemoveTermsComboBox.SelectedIndex != -1)
            {
                ExtractArchiveRemoveTermsComboBox.Items.RemoveAt(ExtractArchiveRemoveTermsComboBox.SelectedIndex);
            }
            else if (ExtractArchiveRemoveTermsComboBox.Items.Count > 0)
            {
                ExtractArchiveRemoveTermsComboBox.Items.RemoveAt(0);
            }
            //else do nothing
        }

        void ExtractArchiveAddExcludedFileButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ExtractArchiveAddExcludedFileTextBox.Text) && !ExtractArchiveExcludedFilesComboBox.Items.Contains(ExtractArchiveAddExcludedFileTextBox.Text))
            {
                ExtractArchiveExcludedFilesComboBox.Items.Add(ExtractArchiveAddExcludedFileTextBox.Text);
            }
        }

        void ExtractArchiveDeleteExcludedFileButtonClick(object sender, EventArgs e)
        {
            if (ExtractArchiveExcludedFilesComboBox.SelectedIndex != -1)
            {
                ExtractArchiveExcludedFilesComboBox.Items.RemoveAt(ExtractArchiveExcludedFilesComboBox.SelectedIndex);
            }
            else if (ExtractArchiveExcludedFilesComboBox.Items.Count > 0)
            {
                ExtractArchiveExcludedFilesComboBox.Items.RemoveAt(0);
            }
            //else do nothing
        }

        void ExtractArchiveExcludedFilesComboBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (ExtractArchiveExcludedFilesComboBox.SelectedIndex != -1)
                {
                    ExtractArchiveExcludedFilesComboBox.Items.RemoveAt(ExtractArchiveExcludedFilesComboBox.SelectedIndex);
                }
                else if (ExtractArchiveExcludedFilesComboBox.Items.Count > 0)
                {
                    ExtractArchiveExcludedFilesComboBox.Items.RemoveAt(0);
                }
                //else do nothing
            }
        }

        void ExtractArchiveResetButtonClick(object sender, EventArgs e)
        {
            RecursivelyExtractArchiveCheckBox.Checked = false;
            ExtractArchiveMaxNestingTextBox.Clear();

            ExtractArchiveAddRemoveTermTextBox.Clear();
            ExtractArchiveRemoveTermsComboBox.Items.Clear();

            ExtractArchiveAddExcludedFileTextBox.Clear();
            ExtractArchiveExcludedFilesComboBox.Items.Clear();
        }

        void EditScreenShotButtonClick(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            else if (string.IsNullOrEmpty(previousScreenshotText))
            {
                previousScreenshotText = "TesterBuddy.ImageCapture.jpg";
                pictureBox1.Image.Save(previousScreenshotText);
            }
            else
            {

            }

            Process a = new Process();
            a.StartInfo.FileName = "mspaint";
            a.StartInfo.Arguments = previousScreenshotText;
            a.Start();
        }

        void Utils_CMDButtonClick(object sender, EventArgs e)
        {
            Process a = new Process();
            a.StartInfo.WorkingDirectory = CommandLineStartDirectory_TextBox.Text;
            a.StartInfo.FileName = "cmd";

            a.Start();
        }     

        void CredentialAddButtonClick(object sender, EventArgs e)
        {
            string newCredential = HostUserNameTextBox.Text + "/" + HostPasswordTextBox.Text;

            if (!UserCredentialsComboBox.Items.Contains(newCredential))
            {
                UserCredentialsComboBox.Items.Add(newCredential);
            }
        }

        void CredentialRemoveButtonClick(object sender, EventArgs e)
        {
            if (UserCredentialsComboBox.SelectedIndex != -1)
            {
                UserCredentialsComboBox.Items.RemoveAt(UserCredentialsComboBox.SelectedIndex);
            }
        }

        void UserCredentialsComboBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (UserCredentialsComboBox.SelectedIndex != -1)
                {
                    UserCredentialsComboBox.Items.RemoveAt(UserCredentialsComboBox.SelectedIndex);
                }
            }
        }

        void Links_CopyIPButtonClick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                ClipRingTreeView.Nodes.Add(Clipboard.GetText());
            }

            //Clipboard.SetText(getIPFromUI());//ipl[comboBox1.SelectedIndex].IP);
            IPRecord ipr = IPRecord.GetRecordByHostname(HostNameComboBox.Text, hostsFile);

            if (ipr != null)
            {
                Clipboard.SetText(ipr.IP);
            }
            else
            {
                MessageBox.Show("IP not found.", "Error");
            }
        }

        void BrowseExtractPathButtonClick(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            string extractPath = folderBrowserDialog1.SelectedPath;
            ExtractArchive_ExtractPathTextBox.Text = extractPath;
        }

        void ViewArchiveButtonClick(object sender, EventArgs e)
        {
            ArchiveHelper.path_7zip = ZipToolPathTextBox.Text;
            MyDirInfo mdi = ArchiveHelper.GetArchiveDirectoryInfo(null, ExtractArchivePathTextBox.Text, TesterBuddy_TempDir_Path);
            ArchiveToolsViewArchiveTreeView.Nodes.Clear();

            if (mdi == null)
            {
                MessageBox.Show("Archive info returned null", "Err!!");
                return;
            }

            TreeNode tn = ArchiveToolsViewArchiveTreeView.Nodes.Add("Archive:" + mdi.name + " Modified:" + mdi.modified);
            AddDirInfoToTreeNode(mdi, tn);
        }

        void AddDirInfoToTreeNode(MyDirInfo mdi, TreeNode tn)
        {
            TreeNode tnChild;

            foreach (MyDirInfo mdiChild in mdi.Children)
            {
                //For files add directly
                if (mdiChild.type == 0)
                {
                    tn.Nodes.Add("File: " + mdiChild.name + " Size: " + mdiChild.size + " Modified:" + mdiChild.modified);
                }
                else if (mdiChild.type == 1)
                {
                    tnChild = tn.Nodes.Add("Folder:" + mdiChild.name + " Modified:" + mdiChild.modified);
                    AddDirInfoToTreeNode(mdiChild, tnChild);
                }
                else
                {
                    tnChild = tn.Nodes.Add("Archive:" + mdiChild.name + " Modified:" + mdiChild.modified);
                    AddDirInfoToTreeNode(mdiChild, tnChild);
                }
            }
        }

        void FindMultiTextButtonClick(object sender, EventArgs e)
        {
            string[] toFinds, findIns;
            string founds = "";

            toFinds = ProcessTextRTB2.Text.Split('\n');
            findIns = ProcessTextRTB1.Text.Split('\n');

            foreach (string toFind in toFinds)
            {
                foreach (string findIn in findIns)
                {
                    if (findIn.Contains(toFind))
                    {
                        founds = founds + "\n" + toFind;
                    }
                }
            }

            ProcessTextRTB2.Text = founds;
        }

        void Button_ProcessText_RemoveCommonLinesClick(object sender, EventArgs e)
        {
            string[] lineset1 = ProcessTextRTB1.Text.Split('\n');
            string[] lineset2 = ProcessTextRTB2.Text.Split('\n');

            string ptext1 = "", ptext2 = "";

            foreach (string line in lineset1)
            {
                if (!lineset2.Contains(line))
                {
                    ptext1 = ptext1 + line + "\n";
                }
            }

            foreach (string line in lineset2)
            {
                if (!lineset1.Contains(line))
                {
                    ptext2 = ptext2 + line + "\n";
                }
            }

            ProcessTextRTB1.Text = ptext1;
            ProcessTextRTB2.Text = ptext2;
        }

        void IPAddressTextBox1KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.OemPeriod:
                    e.SuppressKeyPress = true;
                    if (IPAddressTextBox1.SelectionStart == IPAddressTextBox1.Text.Length)
                    {
                        IPAddressTextBox2.Select();
                        IPAddressTextBox2.SelectionStart = 0;
                    }
                    break;

                case Keys.Right:
                    if (IPAddressTextBox1.SelectionStart == IPAddressTextBox1.Text.Length)
                    {
                        e.SuppressKeyPress = true;
                        IPAddressTextBox2.Select();
                        IPAddressTextBox2.SelectionStart = 0;
                    }
                    break;

                case Keys.Delete:
                    if (IPAddressTextBox1.SelectionStart == IPAddressTextBox1.Text.Length)
                    {
                        IPAddressTextBox2.Select();
                        IPAddressTextBox2.SelectionStart = 0;
                    }
                    break;

                case Keys.Back:
                case Keys.Left:
                    if (IPAddressTextBox1.SelectionStart == 0)
                    {
                        e.SuppressKeyPress = true;
                    }
                    break;



                default:
                    if (char.IsControl((char)e.KeyValue))
                    {
                        return;
                    }
                    else if (!char.IsDigit((char)e.KeyValue))
                    {
                        e.SuppressKeyPress = true;
                        return;
                    }
                    else
                    {
                        if (IPAddressTextBox1.Text.Length >= 3)
                        {
                            if (IPAddressTextBox1.SelectionStart == IPAddressTextBox1.Text.Length)
                            {
                                IPAddressTextBox2.Select();
                                IPAddressTextBox2.SelectionStart = 0;
                                SendKeys.Send(((char)e.KeyValue).ToString());
                            }
                            e.SuppressKeyPress = true;

                            return;
                        }
                    }
                    break;

            }
        }

        void IPAddressTextBox2KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.OemPeriod:
                    e.SuppressKeyPress = true;
                    if (IPAddressTextBox2.SelectionStart == IPAddressTextBox2.Text.Length)
                    {
                        IPAddressTextBox3.Select();
                        IPAddressTextBox3.SelectionStart = 0;
                    }
                    break;

                case Keys.Right:
                    if (IPAddressTextBox2.SelectionStart == IPAddressTextBox2.Text.Length)
                    {
                        e.SuppressKeyPress = true;
                        IPAddressTextBox3.Select();
                        IPAddressTextBox3.SelectionStart = 0;
                    }
                    break;

                case Keys.Delete:
                    if (IPAddressTextBox2.SelectionStart == IPAddressTextBox2.Text.Length)
                    {
                        IPAddressTextBox3.Select();
                        IPAddressTextBox3.SelectionStart = 0;
                    }
                    break;

                case Keys.Back:
                case Keys.Left:
                    if (IPAddressTextBox2.SelectionStart == 0)
                    {
                        e.SuppressKeyPress = true;
                        IPAddressTextBox1.Select();
                        IPAddressTextBox1.SelectionStart = IPAddressTextBox1.Text.Length;
                    }
                    break;

                default:
                    if (char.IsControl((char)e.KeyValue))
                    {
                        return;
                    }
                    else if (!char.IsDigit((char)e.KeyValue))
                    {
                        e.SuppressKeyPress = true;
                        return;
                    }
                    else
                    {
                        if (IPAddressTextBox2.Text.Length >= 3)
                        {
                            if (IPAddressTextBox2.SelectionStart == IPAddressTextBox2.Text.Length)
                            {
                                IPAddressTextBox3.Select();
                                IPAddressTextBox3.SelectionStart = 0;
                                SendKeys.Send(((char)e.KeyValue).ToString());
                            }
                            e.SuppressKeyPress = true;

                            return;
                        }
                    }
                    break;

            }
        }

        void IPAddressTextBox3KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.OemPeriod:
                    e.SuppressKeyPress = true;
                    if (IPAddressTextBox3.SelectionStart == IPAddressTextBox3.Text.Length)
                    {
                        IPAddressTextBox4.Select();
                        IPAddressTextBox4.SelectionStart = 0;
                    }
                    break;

                case Keys.Right:
                    if (IPAddressTextBox3.SelectionStart == IPAddressTextBox3.Text.Length)
                    {
                        e.SuppressKeyPress = true;
                        IPAddressTextBox4.Select();
                        IPAddressTextBox4.SelectionStart = 0;
                    }
                    break;

                case Keys.Delete:
                    if (IPAddressTextBox3.SelectionStart == IPAddressTextBox3.Text.Length)
                    {
                        IPAddressTextBox4.Select();
                        IPAddressTextBox4.SelectionStart = 0;
                    }
                    break;

                case Keys.Back:
                case Keys.Left:
                    if (IPAddressTextBox3.SelectionStart == 0)
                    {
                        e.SuppressKeyPress = true;
                        IPAddressTextBox2.Select();
                        IPAddressTextBox2.SelectionStart = IPAddressTextBox2.Text.Length;
                    }
                    break;

                default:
                    if (char.IsControl((char)e.KeyValue))
                    {
                        return;
                    }
                    else if (!char.IsDigit((char)e.KeyValue))
                    {
                        e.SuppressKeyPress = true;
                        return;
                    }
                    else
                    {
                        if (IPAddressTextBox3.Text.Length >= 3)
                        {
                            if (IPAddressTextBox3.SelectionStart == IPAddressTextBox3.Text.Length)
                            {
                                IPAddressTextBox4.Select();
                                IPAddressTextBox4.SelectionStart = 0;
                                SendKeys.Send(((char)e.KeyValue).ToString());
                            }
                            e.SuppressKeyPress = true;

                            return;
                        }
                    }
                    break;

            }
        }

        void IPAddressTextBox4KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.OemPeriod:
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Right:
                    break;

                case Keys.Delete:
                    break;

                case Keys.Back:
                case Keys.Left:
                    if (IPAddressTextBox4.SelectionStart == 0)
                    {
                        e.SuppressKeyPress = true;
                        IPAddressTextBox3.Select();
                        IPAddressTextBox3.SelectionStart = IPAddressTextBox3.Text.Length;
                    }
                    break;

                default:
                    if (char.IsControl((char)e.KeyValue))
                    {
                        return;
                    }
                    else if (!char.IsDigit((char)e.KeyValue))
                    {
                        e.SuppressKeyPress = true;
                        return;
                    }
                    else
                    {
                        if (IPAddressTextBox4.Text.Length >= 3)
                        {
                            e.SuppressKeyPress = true;
                            return;
                        }
                    }
                    break;

            }
        }

        void UrlGoButtonClick(object sender, EventArgs e)
        {
            //webBrowser1.Url=;
            //tabControl1.SelectTab(tabPage8);
            webBrowser1.Navigate(new Uri(Default_URL_TextBox.Text), false);
        }


        void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Default_URL_TextBox.Text = webBrowser1.Url.ToString();
        }

        void WebBrowser1Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            Default_URL_TextBox.Text = webBrowser1.Url.ToString();
        }

        void WebBrowser1Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Default_URL_TextBox.Text = webBrowser1.Url.ToString();
        }

        void WebBrowser1FileDownload(object sender, EventArgs e)
        {

        }

        void WebBrowser1ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {

        }

        void WebBrowser1NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        void RecursivelyExtractArchiveCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            ExtractTokenGroupBox.Enabled = RecursivelyExtractArchiveCheckBox.Checked;
        }

        void UpdateFormTitle()
        {
            this.Text = "[" + appname + ":" + appversion + "]" + ":" + selectedhost;
        }

        void HostNameComboBoxTextUpdate(object sender, EventArgs e)
        {
            selectedhost = HostNameComboBox.Text;
            UpdateFormTitle();
        }

        void RuleBasedTextGenerationToolStripMenuItemClick(object sender, EventArgs e)
        {
            CounterBasedDataGen textGenForm = new CounterBasedDataGen();
            textGenForm.Show();
        }

        void EscapeXMLButtonClick(object sender, EventArgs e)
        {
            //ProcessTextRTB2.Text=HttpUtility.HtmlEncode(ProcessTextRTB1.Text);
            ProcessTextRTB2.Text = XMLFormatter.XmlEscape(ProcessTextRTB1.Text);
        }

        void UnescapeXMLStringButtonClick(object sender, EventArgs e)
        {
            //ProcessTextRTB2.Text=HttpUtility.HtmlDecode(ProcessTextRTB1.Text);
            ProcessTextRTB2.Text = XMLFormatter.XmlUnescape(ProcessTextRTB1.Text);
        }

        void EncodeURLParamButtonClick(object sender, EventArgs e)
        {
            ProcessTextRTB2.Text = HttpUtility.UrlEncode(ProcessTextRTB1.Text);
        }

        void DecodeURLParamButtonClick(object sender, EventArgs e)
        {
            ProcessTextRTB2.Text = HttpUtility.UrlDecode(ProcessTextRTB1.Text);
        }

        /*
		public virtual void SerializeToFile(string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read);
            formatter.Serialize(stream, this);
            stream.Close();
        }
		
		public static MainForm DeserializeFromFile(string filename)
		{
			IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            MainForm mf = (MainForm)formatter.Deserialize(stream);
            stream.Close();
            return mf;
		}*/

        void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            //SerializeToFile("TesterBuddy.Serialized.bin");
            TakeSnapHotKey.Dispose();
        }

        void MainFormFormClosed(object sender, FormClosedEventArgs e)
        {
            //SerializeToFile("TesterBuddy.Serialized.bin");
        }
        
        void DeleteAdditionalHostButtonClick(object sender, EventArgs e)
        {
            selectedhost = HostNameComboBox.Text;

            if (additionalHosts.Contains(selectedhost))
            {
                additionalHosts.Remove(selectedhost);
            }
            if (HostNameComboBox.Items.Contains(selectedhost))
            {
                HostNameComboBox.Items.Remove(selectedhost);
            }
            if (HostNameComboBox.Items.Count > 1)
            {
                HostNameComboBox.SelectedIndex = 0;
            }
            SaveBaseSettings();
            CheckAndLoadNewSettings();
        }

        void AppPort_ComboBoxTextUpdate(object sender, EventArgs e)
        {
            UpdateFormTitle();
        }

        void AppPort_ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFormTitle();
        }

        private void CustomButtonClicked(int i, object sender, EventArgs e)
        {
            Process a = new Process();

            if (string.IsNullOrEmpty(CustomCommandPaths[i]) || !File.Exists(CustomCommandPaths[i]))
            {
                return;
            }

            a.StartInfo.FileName = CustomCommandPaths[i];

            if (!string.IsNullOrEmpty(CustomCommandArgs[i]))
            {
                a.StartInfo.Arguments = CustomCommandArgs[i];
            }

            a.Start();
        }

        void CustomCommandButton1Click(object sender, EventArgs e)
        {
            CustomButtonClicked(0, sender, e);
        }

        void CustomCommandButton6Click(object sender, EventArgs e)
        {
            CustomButtonClicked(5, sender, e);
        }

        void CustomCommandButton2Click(object sender, EventArgs e)
        {
            CustomButtonClicked(1, sender, e);
        }

        void CustomCommandButton3Click(object sender, EventArgs e)
        {
            CustomButtonClicked(2, sender, e);
        }

        void CustomCommandButton5Click(object sender, EventArgs e)
        {
            CustomButtonClicked(4, sender, e);
        }

        void CustomCommandButton4Click(object sender, EventArgs e)
        {
            CustomButtonClicked(3, sender, e);
        }

        void CustomCommandButton7Click(object sender, EventArgs e)
        {
            CustomButtonClicked(6, sender, e);
        }

        void CustomCommandButton10Click(object sender, EventArgs e)
        {
            CustomButtonClicked(9, sender, e);
        }

        void CustomCommandButton9Click(object sender, EventArgs e)
        {
            CustomButtonClicked(8, sender, e);
        }

        void CustomCommandButton8Click(object sender, EventArgs e)
        {
            CustomButtonClicked(7, sender, e);
        }      

        void UseHTTPSForAppLinksCheckboxCheckedChanged(object sender, EventArgs e)
        {
            UpdateFormTitle();
        }

        void FileSplitterToolStripMenuItemClick(object sender, EventArgs e)
        {
            new FileSplitter().Show();
        }

        bool MainWindowHidden = false;
        void MainNotifyIconClick(object sender, EventArgs e)
        {
            if (MainWindowHidden)
            {
                this.Show();
                MainWindowHidden = false;
            }
            else
            {
                this.Hide();
                MainWindowHidden = true;
            }
        }

        void EncodeBase64ButtonClick(object sender, EventArgs e)
        {
            ProcessTextRTB2.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(ProcessTextRTB1.Text));
        }

        void DecodeBase64ButtonClick(object sender, EventArgs e)
        {
            ProcessTextRTB2.Text = Encoding.UTF8.GetString(Convert.FromBase64String(ProcessTextRTB1.Text));
        }


        static byte[] Decompress(byte[] gzip)
        {
            // Create a GZIP stream with decompression mode.
            // ... Then create a buffer and write into while reading from the GZIP stream.
            using (GZipStream stream = new GZipStream(new MemoryStream(gzip),
                                                      CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return memory.ToArray();
                }
            }
        }

        public static byte[] Compress(byte[] raw)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory,
                                                        CompressionMode.Compress, true))
                {
                    gzip.Write(raw, 0, raw.Length);
                }
                return memory.ToArray();
            }
        }

        void EncodeGZipBase64ButtonClick(object sender, EventArgs e)
        {
            ProcessTextRTB2.Text = Convert.ToBase64String(Compress(Encoding.UTF8.GetBytes(ProcessTextRTB1.Text)));
        }

        void DecodeGZipBase64Buttonn2Click(object sender, EventArgs e)
        {
            ProcessTextRTB2.Text = Encoding.UTF8.GetString(Decompress(Convert.FromBase64String(ProcessTextRTB1.Text)));
        }


    }
    
}
