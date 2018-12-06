/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 11/08/2009
 * Time: 11:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TesterBuddy
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleBasedTextGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSplitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.AddHostDetailsTab = new System.Windows.Forms.TabPage();
            this.DeleteHostButton = new System.Windows.Forms.Button();
            this.FixLocalHostButton = new System.Windows.Forms.Button();
            this.AutoHostAddButton = new System.Windows.Forms.Button();
            this.etchostEditGroup = new System.Windows.Forms.GroupBox();
            this.FixHostsButton = new System.Windows.Forms.Button();
            this.SortHostsButton = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.OpenHostFile = new System.Windows.Forms.Button();
            this.RefreshHostButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CommentsTextBox = new System.Windows.Forms.TextBox();
            this.PasteHostDetailsButton = new System.Windows.Forms.Button();
            this.PasteIPButton = new System.Windows.Forms.Button();
            this.CopyDetailsButton = new System.Windows.Forms.Button();
            this.CopyIPButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.IPAddressTextBox4 = new System.Windows.Forms.TextBox();
            this.IPAddressTextBox3 = new System.Windows.Forms.TextBox();
            this.IPAddressTextBox2 = new System.Windows.Forms.TextBox();
            this.IPAddressTextBox1 = new System.Windows.Forms.TextBox();
            this.HostNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label_apiDirecotry = new System.Windows.Forms.Label();
            this.APIDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.CommandLineStartDirectory_TextBox = new System.Windows.Forms.TextBox();
            this.label_CMDDIR = new System.Windows.Forms.Label();
            this.ChromePathTextBox = new System.Windows.Forms.TextBox();
            this.label_chromepath = new System.Windows.Forms.Label();
            this.ZipToolPathTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.OpenConfigXMLButton = new System.Windows.Forms.Button();
            this.LoadConfigButton = new System.Windows.Forms.Button();
            this.SaveConfigAsButton = new System.Windows.Forms.Button();
            this.HostSpecificSettingsCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveConfigurationButton = new System.Windows.Forms.Button();
            this.ValidateConfigButton = new System.Windows.Forms.Button();
            this.RefreshConfigButton = new System.Windows.Forms.Button();
            this.StafpathTextBox = new System.Windows.Forms.TextBox();
            this.StafPathLabel = new System.Windows.Forms.Label();
            this.IEPathTextBox = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.CommandPathTextBox = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.LogsPathTextBox = new System.Windows.Forms.TextBox();
            this.LogsPathLabel = new System.Windows.Forms.Label();
            this.WinSCP_Path_textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Putty_Path_textbox = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.VNC__Path_textbox = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.FireFoxPathTextBox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.CustomCommandsGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomCommandButton10 = new System.Windows.Forms.Button();
            this.CustomCommandButton9 = new System.Windows.Forms.Button();
            this.CustomCommandButton8 = new System.Windows.Forms.Button();
            this.CustomCommandButton7 = new System.Windows.Forms.Button();
            this.CustomCommandButton6 = new System.Windows.Forms.Button();
            this.CustomCommandButton5 = new System.Windows.Forms.Button();
            this.CustomCommandButton4 = new System.Windows.Forms.Button();
            this.CustomCommandButton3 = new System.Windows.Forms.Button();
            this.CustomCommandButton2 = new System.Windows.Forms.Button();
            this.CustomCommandButton1 = new System.Windows.Forms.Button();
            this.DeleteAdditionalHostButton = new System.Windows.Forms.Button();
            this.Links_CopyIPButton = new System.Windows.Forms.Button();
            this.Links_OnlyCopyUrlCheckbox = new System.Windows.Forms.CheckBox();
            this.AdditionalHostAddButton = new System.Windows.Forms.Button();
            this.HostNameComboBox = new System.Windows.Forms.ComboBox();
            this.HostName2Label = new System.Windows.Forms.Label();
            this.LocalCommandGroupBox = new System.Windows.Forms.GroupBox();
            this.Utils_CMDButton = new System.Windows.Forms.Button();
            this.IPConfigButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.vncScreenNumberTextBox = new System.Windows.Forms.TextBox();
            this.FTPClientButton = new System.Windows.Forms.Button();
            this.AutoCredential_CheckBox = new System.Windows.Forms.CheckBox();
            this.FTPBrowserButton = new System.Windows.Forms.Button();
            this.CredentialRemoveButton = new System.Windows.Forms.Button();
            this.SMB_Button = new System.Windows.Forms.Button();
            this.CredentialAddButton = new System.Windows.Forms.Button();
            this.WinSCP_Button = new System.Windows.Forms.Button();
            this.UserCredentialsComboBox = new System.Windows.Forms.ComboBox();
            this.HostSpecificCheckBox = new System.Windows.Forms.CheckBox();
            this.HostPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RemoteDesktop_button = new System.Windows.Forms.Button();
            this.HostPasswordLabel = new System.Windows.Forms.Label();
            this.Telnet_button = new System.Windows.Forms.Button();
            this.HostUserNameTextBox = new System.Windows.Forms.TextBox();
            this.HostUserNameLabel = new System.Windows.Forms.Label();
            this.Putty_button = new System.Windows.Forms.Button();
            this.VNC_button = new System.Windows.Forms.Button();
            this.MachineCheckGroupBox = new System.Windows.Forms.GroupBox();
            this.MachineCheckSTAFButton = new System.Windows.Forms.Button();
            this.HttpCheckPortTextBox = new System.Windows.Forms.TextBox();
            this.HttpsCheckPortTextBox = new System.Windows.Forms.TextBox();
            this.HttpsCheckButton = new System.Windows.Forms.Button();
            this.HttpCheckButton = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UseHTTPSForAppLinksCheckbox = new System.Windows.Forms.CheckBox();
            this.OpenInChromeRadioButton = new System.Windows.Forms.RadioButton();
            this.otherBrowsersComboBox = new System.Windows.Forms.ComboBox();
            this.otherBrowserRadioButton = new System.Windows.Forms.RadioButton();
            this.OpenInIERadioButton = new System.Windows.Forms.RadioButton();
            this.OpenInFireFoxRadioButton = new System.Windows.Forms.RadioButton();
            this.OpenInEmbeddedIERadioButton = new System.Windows.Forms.RadioButton();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.WebBrowserSplitContainer = new System.Windows.Forms.SplitContainer();
            this.label30 = new System.Windows.Forms.Label();
            this.UrlGoButton = new System.Windows.Forms.Button();
            this.Default_URL_TextBox = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ScreenCaptureModeGroupBox = new System.Windows.Forms.GroupBox();
            this.Screenshot_SnipCapture_RadioButton = new System.Windows.Forms.RadioButton();
            this.Screenshot_ScreenCapture_RadioButton = new System.Windows.Forms.RadioButton();
            this.Screenshot_ActiveWindowCapture_RadioButton = new System.Windows.Forms.RadioButton();
            this.PasteScreenshotButton = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.ScreenShotDirectory = new System.Windows.Forms.TextBox();
            this.CopyScreenshotButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.ScreenShotSaveButton = new System.Windows.Forms.Button();
            this.EditScreenShotButton = new System.Windows.Forms.Button();
            this.ScreenShotPrefixTextBox = new System.Windows.Forms.TextBox();
            this.OpenScreenshotButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ClipRingTreeView = new System.Windows.Forms.TreeView();
            this.LogsTAB = new System.Windows.Forms.TabPage();
            this.OpenTodayLogButton = new System.Windows.Forms.Button();
            this.LogFolders = new System.Windows.Forms.ListBox();
            this.LogFiles = new System.Windows.Forms.ListBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.RefreshLogsButton = new System.Windows.Forms.Button();
            this.CopyLogPathButton = new System.Windows.Forms.Button();
            this.NewTextLogButton = new System.Windows.Forms.Button();
            this.ProcessTextTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ProcessTextRTB1 = new System.Windows.Forms.RichTextBox();
            this.ProcessTextRTB2 = new System.Windows.Forms.RichTextBox();
            this.DecodeGZipBase64Buttonn2 = new System.Windows.Forms.Button();
            this.EncodeGZipBase64Button = new System.Windows.Forms.Button();
            this.DecodeBase64Button = new System.Windows.Forms.Button();
            this.EncodeBase64Button = new System.Windows.Forms.Button();
            this.DecodeURLParamButton = new System.Windows.Forms.Button();
            this.EncodeURLParamButton = new System.Windows.Forms.Button();
            this.UnescapeXMLStringButton = new System.Windows.Forms.Button();
            this.EscapeXMLButton = new System.Windows.Forms.Button();
            this.Button_ProcessText_RemoveCommonLines = new System.Windows.Forms.Button();
            this.FindMultiTextButton = new System.Windows.Forms.Button();
            this.ProcessText_IncrementCountersButton = new System.Windows.Forms.Button();
            this.IncrementValuesButton = new System.Windows.Forms.Button();
            this.RemoveNullParamXMLButton = new System.Windows.Forms.Button();
            this.ProcessTextFixLabel = new System.Windows.Forms.Label();
            this.ProcessTextFixTextBox = new System.Windows.Forms.TextBox();
            this.ToOneLineButton = new System.Windows.Forms.Button();
            this.FormatXMLButton = new System.Windows.Forms.Button();
            this.OneWordPerLineButton = new System.Windows.Forms.Button();
            this.ProcessText_ToJavaStringButton = new System.Windows.Forms.Button();
            this.ProcessText_RemoveLeadingWhiteSpaces = new System.Windows.Forms.Button();
            this.AddSuffixButton = new System.Windows.Forms.Button();
            this.AddPrefixButton = new System.Windows.Forms.Button();
            this.GetParamFromURLButton = new System.Windows.Forms.Button();
            this.WebPosterTab = new System.Windows.Forms.TabPage();
            this.SContainerHttpPost = new System.Windows.Forms.SplitContainer();
            this.HTTPPost_PasteParamDataButton = new System.Windows.Forms.Button();
            this.HTTPPost_ClearParamButton = new System.Windows.Forms.Button();
            this.HTTPPost_DeleteParamButton = new System.Windows.Forms.Button();
            this.label56 = new System.Windows.Forms.Label();
            this.HTTPPostURLTextBox = new System.Windows.Forms.TextBox();
            this.HTTPPostRunButton = new System.Windows.Forms.Button();
            this.HTTPPostAddParamToListButton = new System.Windows.Forms.Button();
            this.HTTPPostValueTextBox = new System.Windows.Forms.TextBox();
            this.HTTPPostParameterTextBox = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.HTTPPostParamListBox = new System.Windows.Forms.ListBox();
            this.HTTPPostResultBrowser = new System.Windows.Forms.WebBrowser();
            this.ArchivingToolsTab = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.ExtractGroupBox = new System.Windows.Forms.GroupBox();
            this.ViewArchiveButton = new System.Windows.Forms.Button();
            this.BrowseExtractPathButton = new System.Windows.Forms.Button();
            this.Extract_ExtractPathLabel = new System.Windows.Forms.Label();
            this.ExtractArchive_ExtractPathTextBox = new System.Windows.Forms.TextBox();
            this.ExtractTokenGroupBox = new System.Windows.Forms.GroupBox();
            this.ExtractArchiveAddExcludedFileTextBox = new System.Windows.Forms.TextBox();
            this.ExtractArchiveDeleteRemoveTermButton = new System.Windows.Forms.Button();
            this.ExtractArchiveDeleteExcludedFileButton = new System.Windows.Forms.Button();
            this.ExtractArchiveAddRemoveTermButton = new System.Windows.Forms.Button();
            this.ExtractArchiveExcludedFilesComboBox = new System.Windows.Forms.ComboBox();
            this.label57 = new System.Windows.Forms.Label();
            this.ExtractArchiveRemoveTermsComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ExtractArchiveAddRemoveTermTextBox = new System.Windows.Forms.TextBox();
            this.ExtractArchiveAddExcludedFileButton = new System.Windows.Forms.Button();
            this.ExtractArchiveResetButton = new System.Windows.Forms.Button();
            this.MaxNestingLabel = new System.Windows.Forms.Label();
            this.ExtractArchiveMaxNestingTextBox = new System.Windows.Forms.TextBox();
            this.RecursivelyExtractArchiveCheckBox = new System.Windows.Forms.CheckBox();
            this.BrowseArchiveFileButton = new System.Windows.Forms.Button();
            this.ArchiveExtractButton = new System.Windows.Forms.Button();
            this.ExtractArchivePathLabel = new System.Windows.Forms.Label();
            this.ExtractArchivePathTextBox = new System.Windows.Forms.TextBox();
            this.ArchiveToolsViewArchiveTreeView = new System.Windows.Forms.TreeView();
            this.ArchiveTools_ResultsTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button35 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button52 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button54 = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.button58 = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label44 = new System.Windows.Forms.Label();
            this.button59 = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.button60 = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.button61 = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.button62 = new System.Windows.Forms.Button();
            this.button63 = new System.Windows.Forms.Button();
            this.button64 = new System.Windows.Forms.Button();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.button65 = new System.Windows.Forms.Button();
            this.button66 = new System.Windows.Forms.Button();
            this.button67 = new System.Windows.Forms.Button();
            this.button68 = new System.Windows.Forms.Button();
            this.button69 = new System.Windows.Forms.Button();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.button70 = new System.Windows.Forms.Button();
            this.button71 = new System.Windows.Forms.Button();
            this.button72 = new System.Windows.Forms.Button();
            this.button73 = new System.Windows.Forms.Button();
            this.button74 = new System.Windows.Forms.Button();
            this.button75 = new System.Windows.Forms.Button();
            this.button76 = new System.Windows.Forms.Button();
            this.button77 = new System.Windows.Forms.Button();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.button78 = new System.Windows.Forms.Button();
            this.button79 = new System.Windows.Forms.Button();
            this.button80 = new System.Windows.Forms.Button();
            this.button81 = new System.Windows.Forms.Button();
            this.button82 = new System.Windows.Forms.Button();
            this.button83 = new System.Windows.Forms.Button();
            this.button84 = new System.Windows.Forms.Button();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.label50 = new System.Windows.Forms.Label();
            this.button85 = new System.Windows.Forms.Button();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.button86 = new System.Windows.Forms.Button();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.AutoTimeIncrementTimer = new System.Windows.Forms.Timer(this.components);
            this.TeamSessionTimer = new System.Windows.Forms.Timer(this.components);
            this.ExtractFileTimer = new System.Windows.Forms.Timer(this.components);
            this.MainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.AddHostDetailsTab.SuspendLayout();
            this.etchostEditGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.CustomCommandsGroupBox.SuspendLayout();
            this.LocalCommandGroupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.MachineCheckGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WebBrowserSplitContainer)).BeginInit();
            this.WebBrowserSplitContainer.Panel1.SuspendLayout();
            this.WebBrowserSplitContainer.Panel2.SuspendLayout();
            this.WebBrowserSplitContainer.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.ScreenCaptureModeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.LogsTAB.SuspendLayout();
            this.ProcessTextTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.WebPosterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SContainerHttpPost)).BeginInit();
            this.SContainerHttpPost.Panel1.SuspendLayout();
            this.SContainerHttpPost.Panel2.SuspendLayout();
            this.SContainerHttpPost.SuspendLayout();
            this.ArchivingToolsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.ExtractGroupBox.SuspendLayout();
            this.ExtractTokenGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.ToolsMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1265, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // ToolsMenuItem
            // 
            this.ToolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruleBasedTextGenerationToolStripMenuItem,
            this.fileSplitterToolStripMenuItem});
            this.ToolsMenuItem.Name = "ToolsMenuItem";
            this.ToolsMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ToolsMenuItem.Text = "Tools";
            // 
            // ruleBasedTextGenerationToolStripMenuItem
            // 
            this.ruleBasedTextGenerationToolStripMenuItem.Name = "ruleBasedTextGenerationToolStripMenuItem";
            this.ruleBasedTextGenerationToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.ruleBasedTextGenerationToolStripMenuItem.Text = "RuleBasedTextGeneration";
            this.ruleBasedTextGenerationToolStripMenuItem.Click += new System.EventHandler(this.RuleBasedTextGenerationToolStripMenuItemClick);
            // 
            // fileSplitterToolStripMenuItem
            // 
            this.fileSplitterToolStripMenuItem.Name = "fileSplitterToolStripMenuItem";
            this.fileSplitterToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.fileSplitterToolStripMenuItem.Text = "File splitter";
            this.fileSplitterToolStripMenuItem.Click += new System.EventHandler(this.FileSplitterToolStripMenuItemClick);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 743);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1265, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddHostDetailsTab
            // 
            this.AddHostDetailsTab.Controls.Add(this.DeleteHostButton);
            this.AddHostDetailsTab.Controls.Add(this.FixLocalHostButton);
            this.AddHostDetailsTab.Controls.Add(this.AutoHostAddButton);
            this.AddHostDetailsTab.Controls.Add(this.etchostEditGroup);
            this.AddHostDetailsTab.Controls.Add(this.groupBox2);
            this.AddHostDetailsTab.Location = new System.Drawing.Point(4, 22);
            this.AddHostDetailsTab.Margin = new System.Windows.Forms.Padding(2);
            this.AddHostDetailsTab.Name = "AddHostDetailsTab";
            this.AddHostDetailsTab.Padding = new System.Windows.Forms.Padding(2);
            this.AddHostDetailsTab.Size = new System.Drawing.Size(1257, 693);
            this.AddHostDetailsTab.TabIndex = 0;
            this.AddHostDetailsTab.Text = "Add Host Details";
            this.AddHostDetailsTab.UseVisualStyleBackColor = true;
            // 
            // DeleteHostButton
            // 
            this.DeleteHostButton.Location = new System.Drawing.Point(754, 172);
            this.DeleteHostButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteHostButton.Name = "DeleteHostButton";
            this.DeleteHostButton.Size = new System.Drawing.Size(116, 22);
            this.DeleteHostButton.TabIndex = 38;
            this.DeleteHostButton.Text = "Delete Host";
            this.DeleteHostButton.UseVisualStyleBackColor = true;
            this.DeleteHostButton.Click += new System.EventHandler(this.DeleteHostButtonClick);
            // 
            // FixLocalHostButton
            // 
            this.FixLocalHostButton.Location = new System.Drawing.Point(754, 141);
            this.FixLocalHostButton.Margin = new System.Windows.Forms.Padding(2);
            this.FixLocalHostButton.Name = "FixLocalHostButton";
            this.FixLocalHostButton.Size = new System.Drawing.Size(116, 22);
            this.FixLocalHostButton.TabIndex = 37;
            this.FixLocalHostButton.Text = "Fix LocalHost";
            this.FixLocalHostButton.UseVisualStyleBackColor = true;
            // 
            // AutoHostAddButton
            // 
            this.AutoHostAddButton.Location = new System.Drawing.Point(754, 110);
            this.AutoHostAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AutoHostAddButton.Name = "AutoHostAddButton";
            this.AutoHostAddButton.Size = new System.Drawing.Size(116, 22);
            this.AutoHostAddButton.TabIndex = 30;
            this.AutoHostAddButton.Text = "Find and Add Host";
            this.AutoHostAddButton.UseVisualStyleBackColor = true;
            this.AutoHostAddButton.Click += new System.EventHandler(this.AutoHostAddButtonClick);
            // 
            // etchostEditGroup
            // 
            this.etchostEditGroup.Controls.Add(this.FixHostsButton);
            this.etchostEditGroup.Controls.Add(this.SortHostsButton);
            this.etchostEditGroup.Controls.Add(this.label34);
            this.etchostEditGroup.Controls.Add(this.OpenHostFile);
            this.etchostEditGroup.Controls.Add(this.RefreshHostButton);
            this.etchostEditGroup.Controls.Add(this.comboBox1);
            this.etchostEditGroup.Location = new System.Drawing.Point(13, 84);
            this.etchostEditGroup.Name = "etchostEditGroup";
            this.etchostEditGroup.Size = new System.Drawing.Size(264, 144);
            this.etchostEditGroup.TabIndex = 32;
            this.etchostEditGroup.TabStop = false;
            this.etchostEditGroup.Text = "Hosts Utility";
            // 
            // FixHostsButton
            // 
            this.FixHostsButton.Location = new System.Drawing.Point(119, 95);
            this.FixHostsButton.Name = "FixHostsButton";
            this.FixHostsButton.Size = new System.Drawing.Size(102, 28);
            this.FixHostsButton.TabIndex = 33;
            this.FixHostsButton.Text = "Fix Hosts";
            this.FixHostsButton.UseVisualStyleBackColor = true;
            this.FixHostsButton.Click += new System.EventHandler(this.FixHostsButtonClick);
            // 
            // SortHostsButton
            // 
            this.SortHostsButton.Location = new System.Drawing.Point(11, 95);
            this.SortHostsButton.Name = "SortHostsButton";
            this.SortHostsButton.Size = new System.Drawing.Size(102, 28);
            this.SortHostsButton.TabIndex = 32;
            this.SortHostsButton.Text = "Sort Hosts";
            this.SortHostsButton.UseVisualStyleBackColor = true;
            this.SortHostsButton.Click += new System.EventHandler(this.SortHostsButtonClick);
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(5, 22);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(62, 15);
            this.label34.TabIndex = 29;
            this.label34.Text = "Select Host";
            // 
            // OpenHostFile
            // 
            this.OpenHostFile.Location = new System.Drawing.Point(119, 61);
            this.OpenHostFile.Name = "OpenHostFile";
            this.OpenHostFile.Size = new System.Drawing.Size(102, 28);
            this.OpenHostFile.TabIndex = 31;
            this.OpenHostFile.Text = "Manual Edit";
            this.OpenHostFile.UseVisualStyleBackColor = true;
            this.OpenHostFile.Click += new System.EventHandler(this.OpenHostFileClick);
            // 
            // RefreshHostButton
            // 
            this.RefreshHostButton.Location = new System.Drawing.Point(11, 61);
            this.RefreshHostButton.Name = "RefreshHostButton";
            this.RefreshHostButton.Size = new System.Drawing.Size(102, 28);
            this.RefreshHostButton.TabIndex = 30;
            this.RefreshHostButton.Text = "Refresh Hosts";
            this.RefreshHostButton.UseVisualStyleBackColor = true;
            this.RefreshHostButton.Click += new System.EventHandler(this.RefreshHostButtonClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CommentsTextBox);
            this.groupBox2.Controls.Add(this.PasteHostDetailsButton);
            this.groupBox2.Controls.Add(this.PasteIPButton);
            this.groupBox2.Controls.Add(this.CopyDetailsButton);
            this.groupBox2.Controls.Add(this.CopyIPButton);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.IPAddressTextBox4);
            this.groupBox2.Controls.Add(this.IPAddressTextBox3);
            this.groupBox2.Controls.Add(this.IPAddressTextBox2);
            this.groupBox2.Controls.Add(this.IPAddressTextBox1);
            this.groupBox2.Controls.Add(this.HostNameTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(339, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(388, 351);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Host";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(40, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Comments:";
            // 
            // CommentsTextBox
            // 
            this.CommentsTextBox.Location = new System.Drawing.Point(109, 169);
            this.CommentsTextBox.Multiline = true;
            this.CommentsTextBox.Name = "CommentsTextBox";
            this.CommentsTextBox.Size = new System.Drawing.Size(236, 78);
            this.CommentsTextBox.TabIndex = 30;
            // 
            // PasteHostDetailsButton
            // 
            this.PasteHostDetailsButton.Location = new System.Drawing.Point(142, 267);
            this.PasteHostDetailsButton.Margin = new System.Windows.Forms.Padding(2);
            this.PasteHostDetailsButton.Name = "PasteHostDetailsButton";
            this.PasteHostDetailsButton.Size = new System.Drawing.Size(93, 20);
            this.PasteHostDetailsButton.TabIndex = 29;
            this.PasteHostDetailsButton.Text = "Paste Details";
            this.PasteHostDetailsButton.UseVisualStyleBackColor = true;
            this.PasteHostDetailsButton.Click += new System.EventHandler(this.PasteHostDetailsButtonClick);
            // 
            // PasteIPButton
            // 
            this.PasteIPButton.Location = new System.Drawing.Point(38, 267);
            this.PasteIPButton.Margin = new System.Windows.Forms.Padding(2);
            this.PasteIPButton.Name = "PasteIPButton";
            this.PasteIPButton.Size = new System.Drawing.Size(65, 20);
            this.PasteIPButton.TabIndex = 28;
            this.PasteIPButton.Text = "Paste IP";
            this.PasteIPButton.UseVisualStyleBackColor = true;
            this.PasteIPButton.Click += new System.EventHandler(this.PasteIPButtonClick);
            // 
            // CopyDetailsButton
            // 
            this.CopyDetailsButton.Location = new System.Drawing.Point(142, 291);
            this.CopyDetailsButton.Margin = new System.Windows.Forms.Padding(2);
            this.CopyDetailsButton.Name = "CopyDetailsButton";
            this.CopyDetailsButton.Size = new System.Drawing.Size(93, 20);
            this.CopyDetailsButton.TabIndex = 27;
            this.CopyDetailsButton.Text = "Copy Details";
            this.CopyDetailsButton.UseVisualStyleBackColor = true;
            this.CopyDetailsButton.Click += new System.EventHandler(this.Button33Click);
            // 
            // CopyIPButton
            // 
            this.CopyIPButton.Location = new System.Drawing.Point(38, 291);
            this.CopyIPButton.Margin = new System.Windows.Forms.Padding(2);
            this.CopyIPButton.Name = "CopyIPButton";
            this.CopyIPButton.Size = new System.Drawing.Size(65, 20);
            this.CopyIPButton.TabIndex = 26;
            this.CopyIPButton.Text = "Copy IP";
            this.CopyIPButton.UseVisualStyleBackColor = true;
            this.CopyIPButton.Click += new System.EventHandler(this.CopyIPButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 291);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 20);
            this.button1.TabIndex = 25;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(38, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Alias (opt):";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(109, 75);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(236, 20);
            this.textBox6.TabIndex = 14;
            // 
            // IPAddressTextBox4
            // 
            this.IPAddressTextBox4.Location = new System.Drawing.Point(302, 128);
            this.IPAddressTextBox4.Margin = new System.Windows.Forms.Padding(2);
            this.IPAddressTextBox4.Name = "IPAddressTextBox4";
            this.IPAddressTextBox4.Size = new System.Drawing.Size(43, 20);
            this.IPAddressTextBox4.TabIndex = 18;
            this.IPAddressTextBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPAddressTextBox4KeyDown);
            // 
            // IPAddressTextBox3
            // 
            this.IPAddressTextBox3.Location = new System.Drawing.Point(239, 128);
            this.IPAddressTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.IPAddressTextBox3.Name = "IPAddressTextBox3";
            this.IPAddressTextBox3.Size = new System.Drawing.Size(42, 20);
            this.IPAddressTextBox3.TabIndex = 17;
            this.IPAddressTextBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPAddressTextBox3KeyDown);
            // 
            // IPAddressTextBox2
            // 
            this.IPAddressTextBox2.Location = new System.Drawing.Point(172, 128);
            this.IPAddressTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.IPAddressTextBox2.Name = "IPAddressTextBox2";
            this.IPAddressTextBox2.Size = new System.Drawing.Size(44, 20);
            this.IPAddressTextBox2.TabIndex = 16;
            this.IPAddressTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPAddressTextBox2KeyDown);
            // 
            // IPAddressTextBox1
            // 
            this.IPAddressTextBox1.Location = new System.Drawing.Point(109, 128);
            this.IPAddressTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.IPAddressTextBox1.Name = "IPAddressTextBox1";
            this.IPAddressTextBox1.Size = new System.Drawing.Size(38, 20);
            this.IPAddressTextBox1.TabIndex = 15;
            this.IPAddressTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPAddressTextBox1KeyDown);
            // 
            // HostNameTextBox
            // 
            this.HostNameTextBox.Location = new System.Drawing.Point(109, 28);
            this.HostNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HostNameTextBox.Name = "HostNameTextBox";
            this.HostNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.HostNameTextBox.TabIndex = 13;
            this.HostNameTextBox.Text = "localhost";
            this.HostNameTextBox.TextChanged += new System.EventHandler(this.HostNameTextBoxTextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(284, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = ".";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(218, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = ".";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(151, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = ".";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Host IP:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Host Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddHostDetailsTab);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.LogsTAB);
            this.tabControl1.Controls.Add(this.ProcessTextTab);
            this.tabControl1.Controls.Add(this.WebPosterTab);
            this.tabControl1.Controls.Add(this.ArchivingToolsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1265, 719);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label_apiDirecotry);
            this.tabPage5.Controls.Add(this.APIDirectoryTextBox);
            this.tabPage5.Controls.Add(this.CommandLineStartDirectory_TextBox);
            this.tabPage5.Controls.Add(this.label_CMDDIR);
            this.tabPage5.Controls.Add(this.ChromePathTextBox);
            this.tabPage5.Controls.Add(this.label_chromepath);
            this.tabPage5.Controls.Add(this.ZipToolPathTextBox);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.OpenConfigXMLButton);
            this.tabPage5.Controls.Add(this.LoadConfigButton);
            this.tabPage5.Controls.Add(this.SaveConfigAsButton);
            this.tabPage5.Controls.Add(this.HostSpecificSettingsCheckBox);
            this.tabPage5.Controls.Add(this.SaveConfigurationButton);
            this.tabPage5.Controls.Add(this.ValidateConfigButton);
            this.tabPage5.Controls.Add(this.RefreshConfigButton);
            this.tabPage5.Controls.Add(this.StafpathTextBox);
            this.tabPage5.Controls.Add(this.StafPathLabel);
            this.tabPage5.Controls.Add(this.IEPathTextBox);
            this.tabPage5.Controls.Add(this.label54);
            this.tabPage5.Controls.Add(this.CommandPathTextBox);
            this.tabPage5.Controls.Add(this.label38);
            this.tabPage5.Controls.Add(this.LogsPathTextBox);
            this.tabPage5.Controls.Add(this.LogsPathLabel);
            this.tabPage5.Controls.Add(this.WinSCP_Path_textbox);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.Putty_Path_textbox);
            this.tabPage5.Controls.Add(this.label33);
            this.tabPage5.Controls.Add(this.VNC__Path_textbox);
            this.tabPage5.Controls.Add(this.label32);
            this.tabPage5.Controls.Add(this.FireFoxPathTextBox);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(1257, 693);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Config";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label_apiDirecotry
            // 
            this.label_apiDirecotry.Location = new System.Drawing.Point(83, 285);
            this.label_apiDirecotry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_apiDirecotry.Name = "label_apiDirecotry";
            this.label_apiDirecotry.Size = new System.Drawing.Size(72, 18);
            this.label_apiDirecotry.TabIndex = 42;
            this.label_apiDirecotry.Text = "API Directory:";
            // 
            // APIDirectoryTextBox
            // 
            this.APIDirectoryTextBox.Location = new System.Drawing.Point(165, 285);
            this.APIDirectoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.APIDirectoryTextBox.Name = "APIDirectoryTextBox";
            this.APIDirectoryTextBox.Size = new System.Drawing.Size(595, 20);
            this.APIDirectoryTextBox.TabIndex = 41;
            this.APIDirectoryTextBox.Text = "api";
            // 
            // CommandLineStartDirectory_TextBox
            // 
            this.CommandLineStartDirectory_TextBox.Location = new System.Drawing.Point(165, 259);
            this.CommandLineStartDirectory_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CommandLineStartDirectory_TextBox.Name = "CommandLineStartDirectory_TextBox";
            this.CommandLineStartDirectory_TextBox.Size = new System.Drawing.Size(595, 20);
            this.CommandLineStartDirectory_TextBox.TabIndex = 38;
            this.CommandLineStartDirectory_TextBox.Text = "c:\\";
            // 
            // label_CMDDIR
            // 
            this.label_CMDDIR.Location = new System.Drawing.Point(7, 259);
            this.label_CMDDIR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CMDDIR.Name = "label_CMDDIR";
            this.label_CMDDIR.Size = new System.Drawing.Size(154, 18);
            this.label_CMDDIR.TabIndex = 37;
            this.label_CMDDIR.Text = "Command line start directory:";
            // 
            // ChromePathTextBox
            // 
            this.ChromePathTextBox.Location = new System.Drawing.Point(165, 66);
            this.ChromePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChromePathTextBox.Name = "ChromePathTextBox";
            this.ChromePathTextBox.Size = new System.Drawing.Size(595, 20);
            this.ChromePathTextBox.TabIndex = 36;
            this.ChromePathTextBox.Text = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            // 
            // label_chromepath
            // 
            this.label_chromepath.Location = new System.Drawing.Point(91, 66);
            this.label_chromepath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_chromepath.Name = "label_chromepath";
            this.label_chromepath.Size = new System.Drawing.Size(70, 18);
            this.label_chromepath.TabIndex = 35;
            this.label_chromepath.Text = "Chrome Path:";
            // 
            // ZipToolPathTextBox
            // 
            this.ZipToolPathTextBox.Location = new System.Drawing.Point(165, 233);
            this.ZipToolPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ZipToolPathTextBox.Name = "ZipToolPathTextBox";
            this.ZipToolPathTextBox.Size = new System.Drawing.Size(595, 20);
            this.ZipToolPathTextBox.TabIndex = 34;
            this.ZipToolPathTextBox.Text = "C:\\Program Files (x86)\\7-Zip\\7z.exe";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(99, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 33;
            this.label11.Text = "7Zip Path:";
            // 
            // OpenConfigXMLButton
            // 
            this.OpenConfigXMLButton.Location = new System.Drawing.Point(959, 134);
            this.OpenConfigXMLButton.Name = "OpenConfigXMLButton";
            this.OpenConfigXMLButton.Size = new System.Drawing.Size(125, 23);
            this.OpenConfigXMLButton.TabIndex = 32;
            this.OpenConfigXMLButton.Text = "Open Config XML";
            this.OpenConfigXMLButton.UseVisualStyleBackColor = true;
            this.OpenConfigXMLButton.Click += new System.EventHandler(this.OpenConfigXMLButtonClick);
            // 
            // LoadConfigButton
            // 
            this.LoadConfigButton.Location = new System.Drawing.Point(959, 106);
            this.LoadConfigButton.Name = "LoadConfigButton";
            this.LoadConfigButton.Size = new System.Drawing.Size(125, 23);
            this.LoadConfigButton.TabIndex = 31;
            this.LoadConfigButton.Text = "Load Config";
            this.LoadConfigButton.UseVisualStyleBackColor = true;
            this.LoadConfigButton.Click += new System.EventHandler(this.LoadConfigButtonClick);
            // 
            // SaveConfigAsButton
            // 
            this.SaveConfigAsButton.Location = new System.Drawing.Point(959, 77);
            this.SaveConfigAsButton.Name = "SaveConfigAsButton";
            this.SaveConfigAsButton.Size = new System.Drawing.Size(125, 23);
            this.SaveConfigAsButton.TabIndex = 30;
            this.SaveConfigAsButton.Text = "Save Config as";
            this.SaveConfigAsButton.UseVisualStyleBackColor = true;
            this.SaveConfigAsButton.Click += new System.EventHandler(this.SaveConfigAsButtonClick);
            // 
            // HostSpecificSettingsCheckBox
            // 
            this.HostSpecificSettingsCheckBox.Checked = true;
            this.HostSpecificSettingsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HostSpecificSettingsCheckBox.Location = new System.Drawing.Point(828, 106);
            this.HostSpecificSettingsCheckBox.Name = "HostSpecificSettingsCheckBox";
            this.HostSpecificSettingsCheckBox.Size = new System.Drawing.Size(125, 24);
            this.HostSpecificSettingsCheckBox.TabIndex = 29;
            this.HostSpecificSettingsCheckBox.Text = "HostSpecificSettings";
            this.HostSpecificSettingsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveConfigurationButton
            // 
            this.SaveConfigurationButton.Location = new System.Drawing.Point(828, 77);
            this.SaveConfigurationButton.Name = "SaveConfigurationButton";
            this.SaveConfigurationButton.Size = new System.Drawing.Size(125, 23);
            this.SaveConfigurationButton.TabIndex = 28;
            this.SaveConfigurationButton.Text = "Save Config";
            this.SaveConfigurationButton.UseVisualStyleBackColor = true;
            this.SaveConfigurationButton.Click += new System.EventHandler(this.SaveConfigurationButtonClick);
            // 
            // ValidateConfigButton
            // 
            this.ValidateConfigButton.Location = new System.Drawing.Point(828, 48);
            this.ValidateConfigButton.Name = "ValidateConfigButton";
            this.ValidateConfigButton.Size = new System.Drawing.Size(125, 23);
            this.ValidateConfigButton.TabIndex = 27;
            this.ValidateConfigButton.Text = "Validate Config";
            this.ValidateConfigButton.UseVisualStyleBackColor = true;
            this.ValidateConfigButton.Click += new System.EventHandler(this.ValidateConfigButtonClick);
            // 
            // RefreshConfigButton
            // 
            this.RefreshConfigButton.Location = new System.Drawing.Point(828, 19);
            this.RefreshConfigButton.Name = "RefreshConfigButton";
            this.RefreshConfigButton.Size = new System.Drawing.Size(125, 23);
            this.RefreshConfigButton.TabIndex = 26;
            this.RefreshConfigButton.Text = "Refresh Config";
            this.RefreshConfigButton.UseVisualStyleBackColor = true;
            this.RefreshConfigButton.Click += new System.EventHandler(this.RefreshConfigButtonClick);
            // 
            // StafpathTextBox
            // 
            this.StafpathTextBox.Location = new System.Drawing.Point(165, 209);
            this.StafpathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StafpathTextBox.Name = "StafpathTextBox";
            this.StafpathTextBox.Size = new System.Drawing.Size(595, 20);
            this.StafpathTextBox.TabIndex = 25;
            this.StafpathTextBox.Text = "C:\\STAF\\bin\\Staf.exe";
            // 
            // StafPathLabel
            // 
            this.StafPathLabel.Location = new System.Drawing.Point(99, 209);
            this.StafPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StafPathLabel.Name = "StafPathLabel";
            this.StafPathLabel.Size = new System.Drawing.Size(62, 18);
            this.StafPathLabel.TabIndex = 24;
            this.StafPathLabel.Text = "Staf Path:";
            // 
            // IEPathTextBox
            // 
            this.IEPathTextBox.Location = new System.Drawing.Point(165, 21);
            this.IEPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IEPathTextBox.Name = "IEPathTextBox";
            this.IEPathTextBox.Size = new System.Drawing.Size(595, 20);
            this.IEPathTextBox.TabIndex = 21;
            this.IEPathTextBox.Text = "c:\\Program Files\\Internet Explorer\\iexplore.exe";
            // 
            // label54
            // 
            this.label54.Location = new System.Drawing.Point(99, 21);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(56, 18);
            this.label54.TabIndex = 20;
            this.label54.Text = "IE8 Path:";
            // 
            // CommandPathTextBox
            // 
            this.CommandPathTextBox.Location = new System.Drawing.Point(165, 185);
            this.CommandPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CommandPathTextBox.Name = "CommandPathTextBox";
            this.CommandPathTextBox.Size = new System.Drawing.Size(595, 20);
            this.CommandPathTextBox.TabIndex = 19;
            this.CommandPathTextBox.Text = "C:\\TesterLogs\\Commands";
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(25, 185);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(135, 18);
            this.label38.TabIndex = 18;
            this.label38.Text = "Command Templates Path:";
            // 
            // LogsPathTextBox
            // 
            this.LogsPathTextBox.Location = new System.Drawing.Point(165, 161);
            this.LogsPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogsPathTextBox.Name = "LogsPathTextBox";
            this.LogsPathTextBox.Size = new System.Drawing.Size(595, 20);
            this.LogsPathTextBox.TabIndex = 17;
            this.LogsPathTextBox.Text = "C:\\TesterLogs\\";
            // 
            // LogsPathLabel
            // 
            this.LogsPathLabel.Location = new System.Drawing.Point(99, 161);
            this.LogsPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogsPathLabel.Name = "LogsPathLabel";
            this.LogsPathLabel.Size = new System.Drawing.Size(62, 18);
            this.LogsPathLabel.TabIndex = 16;
            this.LogsPathLabel.Text = "LogsPath:";
            // 
            // WinSCP_Path_textbox
            // 
            this.WinSCP_Path_textbox.Location = new System.Drawing.Point(165, 137);
            this.WinSCP_Path_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.WinSCP_Path_textbox.Name = "WinSCP_Path_textbox";
            this.WinSCP_Path_textbox.Size = new System.Drawing.Size(595, 20);
            this.WinSCP_Path_textbox.TabIndex = 15;
            this.WinSCP_Path_textbox.Text = "C:\\Program Files\\WinSCP\\WinSCP.exe";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(99, 137);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "WinSCP Path:";
            // 
            // Putty_Path_textbox
            // 
            this.Putty_Path_textbox.Location = new System.Drawing.Point(165, 113);
            this.Putty_Path_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Putty_Path_textbox.Name = "Putty_Path_textbox";
            this.Putty_Path_textbox.Size = new System.Drawing.Size(595, 20);
            this.Putty_Path_textbox.TabIndex = 13;
            this.Putty_Path_textbox.Text = "C:\\Program Files\\PuTTY\\putty.exe";
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(99, 113);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(62, 18);
            this.label33.TabIndex = 12;
            this.label33.Text = "Putty Path:";
            // 
            // VNC__Path_textbox
            // 
            this.VNC__Path_textbox.Location = new System.Drawing.Point(165, 90);
            this.VNC__Path_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.VNC__Path_textbox.Name = "VNC__Path_textbox";
            this.VNC__Path_textbox.Size = new System.Drawing.Size(595, 20);
            this.VNC__Path_textbox.TabIndex = 11;
            this.VNC__Path_textbox.Text = "C:\\Program Files\\RealVNC\\VNC4\\vncviewer.exe";
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(105, 90);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 18);
            this.label32.TabIndex = 10;
            this.label32.Text = "VNC Path:";
            // 
            // FireFoxPathTextBox
            // 
            this.FireFoxPathTextBox.Location = new System.Drawing.Point(165, 45);
            this.FireFoxPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FireFoxPathTextBox.Name = "FireFoxPathTextBox";
            this.FireFoxPathTextBox.Size = new System.Drawing.Size(595, 20);
            this.FireFoxPathTextBox.TabIndex = 9;
            this.FireFoxPathTextBox.Text = "c:\\Program Files\\Mozilla Firefox\\firefox.exe";
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(91, 45);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(70, 18);
            this.label31.TabIndex = 8;
            this.label31.Text = "FireFox Path:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.CustomCommandsGroupBox);
            this.tabPage6.Controls.Add(this.DeleteAdditionalHostButton);
            this.tabPage6.Controls.Add(this.Links_CopyIPButton);
            this.tabPage6.Controls.Add(this.Links_OnlyCopyUrlCheckbox);
            this.tabPage6.Controls.Add(this.AdditionalHostAddButton);
            this.tabPage6.Controls.Add(this.HostNameComboBox);
            this.tabPage6.Controls.Add(this.HostName2Label);
            this.tabPage6.Controls.Add(this.LocalCommandGroupBox);
            this.tabPage6.Controls.Add(this.groupBox5);
            this.tabPage6.Controls.Add(this.groupBox1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(1257, 693);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Links";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // CustomCommandsGroupBox
            // 
            this.CustomCommandsGroupBox.Controls.Add(this.CustomCommandButton10);
            this.CustomCommandsGroupBox.Controls.Add(this.CustomCommandButton9);
            this.CustomCommandsGroupBox.Controls.Add(this.CustomCommandButton8);
            this.CustomCommandsGroupBox.Controls.Add(this.CustomCommandButton7);
            this.CustomCommandsGroupBox.Controls.Add(this.CustomCommandButton6);
            this.CustomCommandsGroupBox.Controls.Add(this.CustomCommandButton5);
            this.CustomCommandsGroupBox.Controls.Add(this.CustomCommandButton4);
            this.CustomCommandsGroupBox.Controls.Add(this.CustomCommandButton3);
            this.CustomCommandsGroupBox.Controls.Add(this.CustomCommandButton2);
            this.CustomCommandsGroupBox.Controls.Add(this.CustomCommandButton1);
            this.CustomCommandsGroupBox.Location = new System.Drawing.Point(3, 190);
            this.CustomCommandsGroupBox.Name = "CustomCommandsGroupBox";
            this.CustomCommandsGroupBox.Size = new System.Drawing.Size(441, 173);
            this.CustomCommandsGroupBox.TabIndex = 78;
            this.CustomCommandsGroupBox.TabStop = false;
            this.CustomCommandsGroupBox.Text = "Custom Commands";
            // 
            // CustomCommandButton10
            // 
            this.CustomCommandButton10.Enabled = false;
            this.CustomCommandButton10.Location = new System.Drawing.Point(220, 134);
            this.CustomCommandButton10.Name = "CustomCommandButton10";
            this.CustomCommandButton10.Size = new System.Drawing.Size(180, 23);
            this.CustomCommandButton10.TabIndex = 9;
            this.CustomCommandButton10.Text = "Unbound";
            this.CustomCommandButton10.UseVisualStyleBackColor = true;
            this.CustomCommandButton10.Visible = false;
            this.CustomCommandButton10.Click += new System.EventHandler(this.CustomCommandButton10Click);
            // 
            // CustomCommandButton9
            // 
            this.CustomCommandButton9.Enabled = false;
            this.CustomCommandButton9.Location = new System.Drawing.Point(220, 105);
            this.CustomCommandButton9.Name = "CustomCommandButton9";
            this.CustomCommandButton9.Size = new System.Drawing.Size(180, 23);
            this.CustomCommandButton9.TabIndex = 8;
            this.CustomCommandButton9.Text = "Unbound";
            this.CustomCommandButton9.UseVisualStyleBackColor = true;
            this.CustomCommandButton9.Visible = false;
            this.CustomCommandButton9.Click += new System.EventHandler(this.CustomCommandButton9Click);
            // 
            // CustomCommandButton8
            // 
            this.CustomCommandButton8.Enabled = false;
            this.CustomCommandButton8.Location = new System.Drawing.Point(220, 76);
            this.CustomCommandButton8.Name = "CustomCommandButton8";
            this.CustomCommandButton8.Size = new System.Drawing.Size(180, 23);
            this.CustomCommandButton8.TabIndex = 7;
            this.CustomCommandButton8.Text = "Unbound";
            this.CustomCommandButton8.UseVisualStyleBackColor = true;
            this.CustomCommandButton8.Visible = false;
            this.CustomCommandButton8.Click += new System.EventHandler(this.CustomCommandButton8Click);
            // 
            // CustomCommandButton7
            // 
            this.CustomCommandButton7.Enabled = false;
            this.CustomCommandButton7.Location = new System.Drawing.Point(220, 47);
            this.CustomCommandButton7.Name = "CustomCommandButton7";
            this.CustomCommandButton7.Size = new System.Drawing.Size(180, 23);
            this.CustomCommandButton7.TabIndex = 6;
            this.CustomCommandButton7.Text = "Unbound";
            this.CustomCommandButton7.UseVisualStyleBackColor = true;
            this.CustomCommandButton7.Visible = false;
            this.CustomCommandButton7.Click += new System.EventHandler(this.CustomCommandButton7Click);
            // 
            // CustomCommandButton6
            // 
            this.CustomCommandButton6.Enabled = false;
            this.CustomCommandButton6.Location = new System.Drawing.Point(220, 19);
            this.CustomCommandButton6.Name = "CustomCommandButton6";
            this.CustomCommandButton6.Size = new System.Drawing.Size(180, 23);
            this.CustomCommandButton6.TabIndex = 5;
            this.CustomCommandButton6.Text = "Unbound";
            this.CustomCommandButton6.UseVisualStyleBackColor = true;
            this.CustomCommandButton6.Visible = false;
            this.CustomCommandButton6.Click += new System.EventHandler(this.CustomCommandButton6Click);
            // 
            // CustomCommandButton5
            // 
            this.CustomCommandButton5.Enabled = false;
            this.CustomCommandButton5.Location = new System.Drawing.Point(2, 134);
            this.CustomCommandButton5.Name = "CustomCommandButton5";
            this.CustomCommandButton5.Size = new System.Drawing.Size(180, 23);
            this.CustomCommandButton5.TabIndex = 4;
            this.CustomCommandButton5.Text = "Unbound";
            this.CustomCommandButton5.UseVisualStyleBackColor = true;
            this.CustomCommandButton5.Visible = false;
            this.CustomCommandButton5.Click += new System.EventHandler(this.CustomCommandButton5Click);
            // 
            // CustomCommandButton4
            // 
            this.CustomCommandButton4.Enabled = false;
            this.CustomCommandButton4.Location = new System.Drawing.Point(2, 105);
            this.CustomCommandButton4.Name = "CustomCommandButton4";
            this.CustomCommandButton4.Size = new System.Drawing.Size(180, 23);
            this.CustomCommandButton4.TabIndex = 3;
            this.CustomCommandButton4.Text = "Unbound";
            this.CustomCommandButton4.UseVisualStyleBackColor = true;
            this.CustomCommandButton4.Visible = false;
            this.CustomCommandButton4.Click += new System.EventHandler(this.CustomCommandButton4Click);
            // 
            // CustomCommandButton3
            // 
            this.CustomCommandButton3.Enabled = false;
            this.CustomCommandButton3.Location = new System.Drawing.Point(2, 76);
            this.CustomCommandButton3.Name = "CustomCommandButton3";
            this.CustomCommandButton3.Size = new System.Drawing.Size(180, 23);
            this.CustomCommandButton3.TabIndex = 2;
            this.CustomCommandButton3.Text = "Unbound";
            this.CustomCommandButton3.UseVisualStyleBackColor = true;
            this.CustomCommandButton3.Visible = false;
            this.CustomCommandButton3.Click += new System.EventHandler(this.CustomCommandButton3Click);
            // 
            // CustomCommandButton2
            // 
            this.CustomCommandButton2.Enabled = false;
            this.CustomCommandButton2.Location = new System.Drawing.Point(2, 47);
            this.CustomCommandButton2.Name = "CustomCommandButton2";
            this.CustomCommandButton2.Size = new System.Drawing.Size(180, 23);
            this.CustomCommandButton2.TabIndex = 1;
            this.CustomCommandButton2.Text = "Unbound";
            this.CustomCommandButton2.UseVisualStyleBackColor = true;
            this.CustomCommandButton2.Visible = false;
            this.CustomCommandButton2.Click += new System.EventHandler(this.CustomCommandButton2Click);
            // 
            // CustomCommandButton1
            // 
            this.CustomCommandButton1.Enabled = false;
            this.CustomCommandButton1.Location = new System.Drawing.Point(2, 19);
            this.CustomCommandButton1.Name = "CustomCommandButton1";
            this.CustomCommandButton1.Size = new System.Drawing.Size(180, 23);
            this.CustomCommandButton1.TabIndex = 0;
            this.CustomCommandButton1.Text = "Unbound";
            this.CustomCommandButton1.UseVisualStyleBackColor = true;
            this.CustomCommandButton1.Visible = false;
            this.CustomCommandButton1.Click += new System.EventHandler(this.CustomCommandButton1Click);
            // 
            // DeleteAdditionalHostButton
            // 
            this.DeleteAdditionalHostButton.Location = new System.Drawing.Point(944, 56);
            this.DeleteAdditionalHostButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteAdditionalHostButton.Name = "DeleteAdditionalHostButton";
            this.DeleteAdditionalHostButton.Size = new System.Drawing.Size(83, 23);
            this.DeleteAdditionalHostButton.TabIndex = 77;
            this.DeleteAdditionalHostButton.Text = "Delete";
            this.DeleteAdditionalHostButton.UseVisualStyleBackColor = true;
            this.DeleteAdditionalHostButton.Click += new System.EventHandler(this.DeleteAdditionalHostButtonClick);
            // 
            // Links_CopyIPButton
            // 
            this.Links_CopyIPButton.Location = new System.Drawing.Point(1031, 31);
            this.Links_CopyIPButton.Margin = new System.Windows.Forms.Padding(2);
            this.Links_CopyIPButton.Name = "Links_CopyIPButton";
            this.Links_CopyIPButton.Size = new System.Drawing.Size(65, 23);
            this.Links_CopyIPButton.TabIndex = 75;
            this.Links_CopyIPButton.Text = "Copy IP";
            this.Links_CopyIPButton.UseVisualStyleBackColor = true;
            this.Links_CopyIPButton.Click += new System.EventHandler(this.Links_CopyIPButtonClick);
            // 
            // Links_OnlyCopyUrlCheckbox
            // 
            this.Links_OnlyCopyUrlCheckbox.Location = new System.Drawing.Point(1112, 30);
            this.Links_OnlyCopyUrlCheckbox.Name = "Links_OnlyCopyUrlCheckbox";
            this.Links_OnlyCopyUrlCheckbox.Size = new System.Drawing.Size(137, 24);
            this.Links_OnlyCopyUrlCheckbox.TabIndex = 63;
            this.Links_OnlyCopyUrlCheckbox.Text = "Only Copy Url/Links";
            this.Links_OnlyCopyUrlCheckbox.UseVisualStyleBackColor = true;
            // 
            // AdditionalHostAddButton
            // 
            this.AdditionalHostAddButton.Location = new System.Drawing.Point(944, 31);
            this.AdditionalHostAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AdditionalHostAddButton.Name = "AdditionalHostAddButton";
            this.AdditionalHostAddButton.Size = new System.Drawing.Size(83, 23);
            this.AdditionalHostAddButton.TabIndex = 64;
            this.AdditionalHostAddButton.Text = "ADD Host/IP";
            this.AdditionalHostAddButton.UseVisualStyleBackColor = true;
            this.AdditionalHostAddButton.Click += new System.EventHandler(this.AdditionalHostAddButtonClick);
            // 
            // HostNameComboBox
            // 
            this.HostNameComboBox.FormattingEnabled = true;
            this.HostNameComboBox.Location = new System.Drawing.Point(761, 33);
            this.HostNameComboBox.Name = "HostNameComboBox";
            this.HostNameComboBox.Size = new System.Drawing.Size(177, 21);
            this.HostNameComboBox.TabIndex = 53;
            this.HostNameComboBox.SelectedIndexChanged += new System.EventHandler(this.HostNameComboBoxSelectedIndexChanged);
            this.HostNameComboBox.TextUpdate += new System.EventHandler(this.HostNameComboBoxTextUpdate);
            // 
            // HostName2Label
            // 
            this.HostName2Label.Location = new System.Drawing.Point(691, 37);
            this.HostName2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HostName2Label.Name = "HostName2Label";
            this.HostName2Label.Size = new System.Drawing.Size(66, 20);
            this.HostName2Label.TabIndex = 51;
            this.HostName2Label.Text = "Host Name:";
            // 
            // LocalCommandGroupBox
            // 
            this.LocalCommandGroupBox.Controls.Add(this.Utils_CMDButton);
            this.LocalCommandGroupBox.Controls.Add(this.IPConfigButton);
            this.LocalCommandGroupBox.Location = new System.Drawing.Point(306, 21);
            this.LocalCommandGroupBox.Name = "LocalCommandGroupBox";
            this.LocalCommandGroupBox.Size = new System.Drawing.Size(164, 80);
            this.LocalCommandGroupBox.TabIndex = 49;
            this.LocalCommandGroupBox.TabStop = false;
            this.LocalCommandGroupBox.Text = "Local Commands";
            // 
            // Utils_CMDButton
            // 
            this.Utils_CMDButton.Location = new System.Drawing.Point(21, 47);
            this.Utils_CMDButton.Margin = new System.Windows.Forms.Padding(2);
            this.Utils_CMDButton.Name = "Utils_CMDButton";
            this.Utils_CMDButton.Size = new System.Drawing.Size(118, 23);
            this.Utils_CMDButton.TabIndex = 40;
            this.Utils_CMDButton.Text = "CMD";
            this.Utils_CMDButton.UseVisualStyleBackColor = true;
            this.Utils_CMDButton.Click += new System.EventHandler(this.Utils_CMDButtonClick);
            // 
            // IPConfigButton
            // 
            this.IPConfigButton.Location = new System.Drawing.Point(21, 19);
            this.IPConfigButton.Name = "IPConfigButton";
            this.IPConfigButton.Size = new System.Drawing.Size(118, 23);
            this.IPConfigButton.TabIndex = 49;
            this.IPConfigButton.Text = "IPConfig";
            this.IPConfigButton.UseVisualStyleBackColor = true;
            this.IPConfigButton.Click += new System.EventHandler(this.Button87Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.vncScreenNumberTextBox);
            this.groupBox5.Controls.Add(this.FTPClientButton);
            this.groupBox5.Controls.Add(this.AutoCredential_CheckBox);
            this.groupBox5.Controls.Add(this.FTPBrowserButton);
            this.groupBox5.Controls.Add(this.CredentialRemoveButton);
            this.groupBox5.Controls.Add(this.SMB_Button);
            this.groupBox5.Controls.Add(this.CredentialAddButton);
            this.groupBox5.Controls.Add(this.WinSCP_Button);
            this.groupBox5.Controls.Add(this.UserCredentialsComboBox);
            this.groupBox5.Controls.Add(this.HostSpecificCheckBox);
            this.groupBox5.Controls.Add(this.HostPasswordTextBox);
            this.groupBox5.Controls.Add(this.RemoteDesktop_button);
            this.groupBox5.Controls.Add(this.HostPasswordLabel);
            this.groupBox5.Controls.Add(this.Telnet_button);
            this.groupBox5.Controls.Add(this.HostUserNameTextBox);
            this.groupBox5.Controls.Add(this.HostUserNameLabel);
            this.groupBox5.Controls.Add(this.Putty_button);
            this.groupBox5.Controls.Add(this.VNC_button);
            this.groupBox5.Controls.Add(this.MachineCheckGroupBox);
            this.groupBox5.Location = new System.Drawing.Point(481, 114);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(546, 286);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Remote Utilities";
            // 
            // vncScreenNumberTextBox
            // 
            this.vncScreenNumberTextBox.Location = new System.Drawing.Point(126, 58);
            this.vncScreenNumberTextBox.Name = "vncScreenNumberTextBox";
            this.vncScreenNumberTextBox.Size = new System.Drawing.Size(32, 20);
            this.vncScreenNumberTextBox.TabIndex = 63;
            // 
            // FTPClientButton
            // 
            this.FTPClientButton.Location = new System.Drawing.Point(3, 231);
            this.FTPClientButton.Name = "FTPClientButton";
            this.FTPClientButton.Size = new System.Drawing.Size(118, 23);
            this.FTPClientButton.TabIndex = 46;
            this.FTPClientButton.Text = "FTP client";
            this.FTPClientButton.UseVisualStyleBackColor = true;
            // 
            // AutoCredential_CheckBox
            // 
            this.AutoCredential_CheckBox.Checked = true;
            this.AutoCredential_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoCredential_CheckBox.Location = new System.Drawing.Point(108, 17);
            this.AutoCredential_CheckBox.Name = "AutoCredential_CheckBox";
            this.AutoCredential_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.AutoCredential_CheckBox.TabIndex = 62;
            this.AutoCredential_CheckBox.Text = "Auto Credential";
            this.AutoCredential_CheckBox.UseVisualStyleBackColor = true;
            // 
            // FTPBrowserButton
            // 
            this.FTPBrowserButton.Location = new System.Drawing.Point(5, 260);
            this.FTPBrowserButton.Name = "FTPBrowserButton";
            this.FTPBrowserButton.Size = new System.Drawing.Size(118, 23);
            this.FTPBrowserButton.TabIndex = 45;
            this.FTPBrowserButton.Text = "FTP(Default)";
            this.FTPBrowserButton.UseVisualStyleBackColor = true;
            this.FTPBrowserButton.Click += new System.EventHandler(this.FTPBrowserButtonClick);
            // 
            // CredentialRemoveButton
            // 
            this.CredentialRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CredentialRemoveButton.Location = new System.Drawing.Point(496, 39);
            this.CredentialRemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.CredentialRemoveButton.Name = "CredentialRemoveButton";
            this.CredentialRemoveButton.Size = new System.Drawing.Size(25, 21);
            this.CredentialRemoveButton.TabIndex = 74;
            this.CredentialRemoveButton.Text = "-";
            this.CredentialRemoveButton.UseVisualStyleBackColor = true;
            this.CredentialRemoveButton.Click += new System.EventHandler(this.CredentialRemoveButtonClick);
            // 
            // SMB_Button
            // 
            this.SMB_Button.Location = new System.Drawing.Point(3, 202);
            this.SMB_Button.Name = "SMB_Button";
            this.SMB_Button.Size = new System.Drawing.Size(118, 23);
            this.SMB_Button.TabIndex = 43;
            this.SMB_Button.Text = "Win Shares(SMB)";
            this.SMB_Button.UseVisualStyleBackColor = true;
            this.SMB_Button.Click += new System.EventHandler(this.Button6Click);
            // 
            // CredentialAddButton
            // 
            this.CredentialAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CredentialAddButton.Location = new System.Drawing.Point(386, 39);
            this.CredentialAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.CredentialAddButton.Name = "CredentialAddButton";
            this.CredentialAddButton.Size = new System.Drawing.Size(25, 21);
            this.CredentialAddButton.TabIndex = 73;
            this.CredentialAddButton.Text = "+";
            this.CredentialAddButton.UseVisualStyleBackColor = true;
            this.CredentialAddButton.Click += new System.EventHandler(this.CredentialAddButtonClick);
            // 
            // WinSCP_Button
            // 
            this.WinSCP_Button.Location = new System.Drawing.Point(3, 173);
            this.WinSCP_Button.Name = "WinSCP_Button";
            this.WinSCP_Button.Size = new System.Drawing.Size(118, 23);
            this.WinSCP_Button.TabIndex = 42;
            this.WinSCP_Button.Text = "Win SCP";
            this.WinSCP_Button.UseVisualStyleBackColor = true;
            this.WinSCP_Button.Click += new System.EventHandler(this.Button5Click);
            // 
            // UserCredentialsComboBox
            // 
            this.UserCredentialsComboBox.FormattingEnabled = true;
            this.UserCredentialsComboBox.Location = new System.Drawing.Point(386, 13);
            this.UserCredentialsComboBox.Name = "UserCredentialsComboBox";
            this.UserCredentialsComboBox.Size = new System.Drawing.Size(135, 21);
            this.UserCredentialsComboBox.TabIndex = 72;
            this.UserCredentialsComboBox.SelectedIndexChanged += new System.EventHandler(this.UserCredentialsComboBoxSelectedIndexChanged);
            this.UserCredentialsComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserCredentialsComboBoxKeyDown);
            // 
            // HostSpecificCheckBox
            // 
            this.HostSpecificCheckBox.Checked = true;
            this.HostSpecificCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HostSpecificCheckBox.Location = new System.Drawing.Point(10, 17);
            this.HostSpecificCheckBox.Name = "HostSpecificCheckBox";
            this.HostSpecificCheckBox.Size = new System.Drawing.Size(104, 24);
            this.HostSpecificCheckBox.TabIndex = 58;
            this.HostSpecificCheckBox.Text = "Use Hostname";
            this.HostSpecificCheckBox.UseVisualStyleBackColor = true;
            // 
            // HostPasswordTextBox
            // 
            this.HostPasswordTextBox.Location = new System.Drawing.Point(284, 42);
            this.HostPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HostPasswordTextBox.Name = "HostPasswordTextBox";
            this.HostPasswordTextBox.Size = new System.Drawing.Size(93, 20);
            this.HostPasswordTextBox.TabIndex = 70;
            this.HostPasswordTextBox.Text = "user@123";
            // 
            // RemoteDesktop_button
            // 
            this.RemoteDesktop_button.Location = new System.Drawing.Point(3, 144);
            this.RemoteDesktop_button.Margin = new System.Windows.Forms.Padding(2);
            this.RemoteDesktop_button.Name = "RemoteDesktop_button";
            this.RemoteDesktop_button.Size = new System.Drawing.Size(118, 24);
            this.RemoteDesktop_button.TabIndex = 30;
            this.RemoteDesktop_button.Text = "Remote Desktop";
            this.RemoteDesktop_button.UseVisualStyleBackColor = true;
            this.RemoteDesktop_button.Click += new System.EventHandler(this.Button24Click);
            // 
            // HostPasswordLabel
            // 
            this.HostPasswordLabel.Location = new System.Drawing.Point(214, 45);
            this.HostPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HostPasswordLabel.Name = "HostPasswordLabel";
            this.HostPasswordLabel.Size = new System.Drawing.Size(66, 20);
            this.HostPasswordLabel.TabIndex = 71;
            this.HostPasswordLabel.Text = "Password:";
            // 
            // Telnet_button
            // 
            this.Telnet_button.Location = new System.Drawing.Point(3, 115);
            this.Telnet_button.Margin = new System.Windows.Forms.Padding(2);
            this.Telnet_button.Name = "Telnet_button";
            this.Telnet_button.Size = new System.Drawing.Size(118, 24);
            this.Telnet_button.TabIndex = 34;
            this.Telnet_button.Text = "Telnet";
            this.Telnet_button.UseVisualStyleBackColor = true;
            this.Telnet_button.Click += new System.EventHandler(this.Button27Click);
            // 
            // HostUserNameTextBox
            // 
            this.HostUserNameTextBox.Location = new System.Drawing.Point(284, 14);
            this.HostUserNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HostUserNameTextBox.Name = "HostUserNameTextBox";
            this.HostUserNameTextBox.Size = new System.Drawing.Size(93, 20);
            this.HostUserNameTextBox.TabIndex = 68;
            this.HostUserNameTextBox.Text = "user";
            // 
            // HostUserNameLabel
            // 
            this.HostUserNameLabel.Location = new System.Drawing.Point(214, 17);
            this.HostUserNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HostUserNameLabel.Name = "HostUserNameLabel";
            this.HostUserNameLabel.Size = new System.Drawing.Size(66, 20);
            this.HostUserNameLabel.TabIndex = 69;
            this.HostUserNameLabel.Text = "User Name:";
            // 
            // Putty_button
            // 
            this.Putty_button.Location = new System.Drawing.Point(3, 86);
            this.Putty_button.Margin = new System.Windows.Forms.Padding(2);
            this.Putty_button.Name = "Putty_button";
            this.Putty_button.Size = new System.Drawing.Size(118, 24);
            this.Putty_button.TabIndex = 41;
            this.Putty_button.Text = "Putty";
            this.Putty_button.UseVisualStyleBackColor = true;
            this.Putty_button.Click += new System.EventHandler(this.Button31Click);
            // 
            // VNC_button
            // 
            this.VNC_button.Location = new System.Drawing.Point(3, 57);
            this.VNC_button.Margin = new System.Windows.Forms.Padding(2);
            this.VNC_button.Name = "VNC_button";
            this.VNC_button.Size = new System.Drawing.Size(118, 24);
            this.VNC_button.TabIndex = 31;
            this.VNC_button.Text = "VNC viewer";
            this.VNC_button.UseVisualStyleBackColor = true;
            this.VNC_button.Click += new System.EventHandler(this.Button29Click);
            // 
            // MachineCheckGroupBox
            // 
            this.MachineCheckGroupBox.Controls.Add(this.MachineCheckSTAFButton);
            this.MachineCheckGroupBox.Controls.Add(this.HttpCheckPortTextBox);
            this.MachineCheckGroupBox.Controls.Add(this.HttpsCheckPortTextBox);
            this.MachineCheckGroupBox.Controls.Add(this.HttpsCheckButton);
            this.MachineCheckGroupBox.Controls.Add(this.HttpCheckButton);
            this.MachineCheckGroupBox.Controls.Add(this.button28);
            this.MachineCheckGroupBox.Location = new System.Drawing.Point(214, 148);
            this.MachineCheckGroupBox.Name = "MachineCheckGroupBox";
            this.MachineCheckGroupBox.Size = new System.Drawing.Size(230, 132);
            this.MachineCheckGroupBox.TabIndex = 45;
            this.MachineCheckGroupBox.TabStop = false;
            this.MachineCheckGroupBox.Text = "Machine Checks";
            // 
            // MachineCheckSTAFButton
            // 
            this.MachineCheckSTAFButton.Location = new System.Drawing.Point(5, 102);
            this.MachineCheckSTAFButton.Margin = new System.Windows.Forms.Padding(2);
            this.MachineCheckSTAFButton.Name = "MachineCheckSTAFButton";
            this.MachineCheckSTAFButton.Size = new System.Drawing.Size(118, 24);
            this.MachineCheckSTAFButton.TabIndex = 40;
            this.MachineCheckSTAFButton.Text = "STAFCheck";
            this.MachineCheckSTAFButton.UseVisualStyleBackColor = true;
            this.MachineCheckSTAFButton.Click += new System.EventHandler(this.MachineCheckSTAFButtonClick);
            // 
            // HttpCheckPortTextBox
            // 
            this.HttpCheckPortTextBox.Location = new System.Drawing.Point(145, 46);
            this.HttpCheckPortTextBox.Name = "HttpCheckPortTextBox";
            this.HttpCheckPortTextBox.Size = new System.Drawing.Size(72, 20);
            this.HttpCheckPortTextBox.TabIndex = 39;
            this.HttpCheckPortTextBox.Text = "80";
            // 
            // HttpsCheckPortTextBox
            // 
            this.HttpsCheckPortTextBox.Location = new System.Drawing.Point(145, 77);
            this.HttpsCheckPortTextBox.Name = "HttpsCheckPortTextBox";
            this.HttpsCheckPortTextBox.Size = new System.Drawing.Size(72, 20);
            this.HttpsCheckPortTextBox.TabIndex = 38;
            this.HttpsCheckPortTextBox.Text = "443";
            // 
            // HttpsCheckButton
            // 
            this.HttpsCheckButton.Location = new System.Drawing.Point(5, 74);
            this.HttpsCheckButton.Margin = new System.Windows.Forms.Padding(2);
            this.HttpsCheckButton.Name = "HttpsCheckButton";
            this.HttpsCheckButton.Size = new System.Drawing.Size(118, 24);
            this.HttpsCheckButton.TabIndex = 37;
            this.HttpsCheckButton.Text = "HttpsCheck";
            this.HttpsCheckButton.UseVisualStyleBackColor = true;
            this.HttpsCheckButton.Click += new System.EventHandler(this.HttpsCheckButtonClick);
            // 
            // HttpCheckButton
            // 
            this.HttpCheckButton.Location = new System.Drawing.Point(5, 46);
            this.HttpCheckButton.Margin = new System.Windows.Forms.Padding(2);
            this.HttpCheckButton.Name = "HttpCheckButton";
            this.HttpCheckButton.Size = new System.Drawing.Size(118, 24);
            this.HttpCheckButton.TabIndex = 36;
            this.HttpCheckButton.Text = "HttpCheck";
            this.HttpCheckButton.UseVisualStyleBackColor = true;
            this.HttpCheckButton.Click += new System.EventHandler(this.HttpCheckButtonClick);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(5, 18);
            this.button28.Margin = new System.Windows.Forms.Padding(2);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(118, 24);
            this.button28.TabIndex = 35;
            this.button28.Text = "Ping";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.Button28Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UseHTTPSForAppLinksCheckbox);
            this.groupBox1.Controls.Add(this.OpenInChromeRadioButton);
            this.groupBox1.Controls.Add(this.otherBrowsersComboBox);
            this.groupBox1.Controls.Add(this.otherBrowserRadioButton);
            this.groupBox1.Controls.Add(this.OpenInIERadioButton);
            this.groupBox1.Controls.Add(this.OpenInFireFoxRadioButton);
            this.groupBox1.Controls.Add(this.OpenInEmbeddedIERadioButton);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(144, 181);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Browser";
            // 
            // UseHTTPSForAppLinksCheckbox
            // 
            this.UseHTTPSForAppLinksCheckbox.Location = new System.Drawing.Point(36, 152);
            this.UseHTTPSForAppLinksCheckbox.Name = "UseHTTPSForAppLinksCheckbox";
            this.UseHTTPSForAppLinksCheckbox.Size = new System.Drawing.Size(104, 24);
            this.UseHTTPSForAppLinksCheckbox.TabIndex = 81;
            this.UseHTTPSForAppLinksCheckbox.Text = "Use HTTPS";
            this.UseHTTPSForAppLinksCheckbox.UseVisualStyleBackColor = true;
            this.UseHTTPSForAppLinksCheckbox.CheckedChanged += new System.EventHandler(this.UseHTTPSForAppLinksCheckboxCheckedChanged);
            // 
            // OpenInChromeRadioButton
            // 
            this.OpenInChromeRadioButton.Location = new System.Drawing.Point(4, 68);
            this.OpenInChromeRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenInChromeRadioButton.Name = "OpenInChromeRadioButton";
            this.OpenInChromeRadioButton.Size = new System.Drawing.Size(115, 20);
            this.OpenInChromeRadioButton.TabIndex = 55;
            this.OpenInChromeRadioButton.Text = "Open in Chrome";
            this.OpenInChromeRadioButton.UseVisualStyleBackColor = true;
            // 
            // otherBrowsersComboBox
            // 
            this.otherBrowsersComboBox.Enabled = false;
            this.otherBrowsersComboBox.FormattingEnabled = true;
            this.otherBrowsersComboBox.Location = new System.Drawing.Point(57, 124);
            this.otherBrowsersComboBox.Name = "otherBrowsersComboBox";
            this.otherBrowsersComboBox.Size = new System.Drawing.Size(83, 21);
            this.otherBrowsersComboBox.TabIndex = 54;
            // 
            // otherBrowserRadioButton
            // 
            this.otherBrowserRadioButton.Enabled = false;
            this.otherBrowserRadioButton.Location = new System.Drawing.Point(4, 125);
            this.otherBrowserRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.otherBrowserRadioButton.Name = "otherBrowserRadioButton";
            this.otherBrowserRadioButton.Size = new System.Drawing.Size(63, 20);
            this.otherBrowserRadioButton.TabIndex = 41;
            this.otherBrowserRadioButton.Text = "Other";
            this.otherBrowserRadioButton.UseVisualStyleBackColor = true;
            // 
            // OpenInIERadioButton
            // 
            this.OpenInIERadioButton.Location = new System.Drawing.Point(4, 20);
            this.OpenInIERadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenInIERadioButton.Name = "OpenInIERadioButton";
            this.OpenInIERadioButton.Size = new System.Drawing.Size(115, 20);
            this.OpenInIERadioButton.TabIndex = 40;
            this.OpenInIERadioButton.Text = "Open in IE";
            this.OpenInIERadioButton.UseVisualStyleBackColor = true;
            // 
            // OpenInFireFoxRadioButton
            // 
            this.OpenInFireFoxRadioButton.Checked = true;
            this.OpenInFireFoxRadioButton.Location = new System.Drawing.Point(4, 45);
            this.OpenInFireFoxRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenInFireFoxRadioButton.Name = "OpenInFireFoxRadioButton";
            this.OpenInFireFoxRadioButton.Size = new System.Drawing.Size(115, 20);
            this.OpenInFireFoxRadioButton.TabIndex = 39;
            this.OpenInFireFoxRadioButton.TabStop = true;
            this.OpenInFireFoxRadioButton.Text = "Open in Firefox";
            this.OpenInFireFoxRadioButton.UseVisualStyleBackColor = true;
            // 
            // OpenInEmbeddedIERadioButton
            // 
            this.OpenInEmbeddedIERadioButton.Location = new System.Drawing.Point(4, 92);
            this.OpenInEmbeddedIERadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenInEmbeddedIERadioButton.Name = "OpenInEmbeddedIERadioButton";
            this.OpenInEmbeddedIERadioButton.Size = new System.Drawing.Size(136, 20);
            this.OpenInEmbeddedIERadioButton.TabIndex = 33;
            this.OpenInEmbeddedIERadioButton.Text = "Open in embedded IE";
            this.OpenInEmbeddedIERadioButton.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.WebBrowserSplitContainer);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage8.Size = new System.Drawing.Size(1257, 693);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Browser";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // WebBrowserSplitContainer
            // 
            this.WebBrowserSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowserSplitContainer.Location = new System.Drawing.Point(2, 2);
            this.WebBrowserSplitContainer.Name = "WebBrowserSplitContainer";
            this.WebBrowserSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // WebBrowserSplitContainer.Panel1
            // 
            this.WebBrowserSplitContainer.Panel1.Controls.Add(this.label30);
            this.WebBrowserSplitContainer.Panel1.Controls.Add(this.UrlGoButton);
            this.WebBrowserSplitContainer.Panel1.Controls.Add(this.Default_URL_TextBox);
            // 
            // WebBrowserSplitContainer.Panel2
            // 
            this.WebBrowserSplitContainer.Panel2.Controls.Add(this.webBrowser1);
            this.WebBrowserSplitContainer.Size = new System.Drawing.Size(1253, 689);
            this.WebBrowserSplitContainer.SplitterDistance = 71;
            this.WebBrowserSplitContainer.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(5, 16);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(33, 22);
            this.label30.TabIndex = 41;
            this.label30.Text = "URL";
            // 
            // UrlGoButton
            // 
            this.UrlGoButton.Location = new System.Drawing.Point(893, 11);
            this.UrlGoButton.Margin = new System.Windows.Forms.Padding(2);
            this.UrlGoButton.Name = "UrlGoButton";
            this.UrlGoButton.Size = new System.Drawing.Size(35, 23);
            this.UrlGoButton.TabIndex = 40;
            this.UrlGoButton.Text = "GO";
            this.UrlGoButton.UseVisualStyleBackColor = true;
            this.UrlGoButton.Click += new System.EventHandler(this.UrlGoButtonClick);
            // 
            // Default_URL_TextBox
            // 
            this.Default_URL_TextBox.Location = new System.Drawing.Point(49, 13);
            this.Default_URL_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Default_URL_TextBox.Name = "Default_URL_TextBox";
            this.Default_URL_TextBox.Size = new System.Drawing.Size(827, 20);
            this.Default_URL_TextBox.TabIndex = 39;
            this.Default_URL_TextBox.Text = "http://localhost";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1253, 614);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1DocumentCompleted);
            this.webBrowser1.FileDownload += new System.EventHandler(this.WebBrowser1FileDownload);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBrowser1Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.WebBrowser1Navigating);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.WebBrowser1NewWindow);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.WebBrowser1ProgressChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1257, 693);
            this.tabPage3.TabIndex = 8;
            this.tabPage3.Text = "ScreenShots";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ScreenCaptureModeGroupBox);
            this.splitContainer3.Panel1.Controls.Add(this.PasteScreenshotButton);
            this.splitContainer3.Panel1.Controls.Add(this.label36);
            this.splitContainer3.Panel1.Controls.Add(this.ScreenShotDirectory);
            this.splitContainer3.Panel1.Controls.Add(this.CopyScreenshotButton);
            this.splitContainer3.Panel1.Controls.Add(this.label17);
            this.splitContainer3.Panel1.Controls.Add(this.ScreenShotSaveButton);
            this.splitContainer3.Panel1.Controls.Add(this.EditScreenShotButton);
            this.splitContainer3.Panel1.Controls.Add(this.ScreenShotPrefixTextBox);
            this.splitContainer3.Panel1.Controls.Add(this.OpenScreenshotButton);
            this.splitContainer3.Panel1.Controls.Add(this.button3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer3.Size = new System.Drawing.Size(1251, 687);
            this.splitContainer3.SplitterDistance = 150;
            this.splitContainer3.TabIndex = 21;
            // 
            // ScreenCaptureModeGroupBox
            // 
            this.ScreenCaptureModeGroupBox.Controls.Add(this.Screenshot_SnipCapture_RadioButton);
            this.ScreenCaptureModeGroupBox.Controls.Add(this.Screenshot_ScreenCapture_RadioButton);
            this.ScreenCaptureModeGroupBox.Controls.Add(this.Screenshot_ActiveWindowCapture_RadioButton);
            this.ScreenCaptureModeGroupBox.Location = new System.Drawing.Point(260, 7);
            this.ScreenCaptureModeGroupBox.Name = "ScreenCaptureModeGroupBox";
            this.ScreenCaptureModeGroupBox.Size = new System.Drawing.Size(307, 51);
            this.ScreenCaptureModeGroupBox.TabIndex = 23;
            this.ScreenCaptureModeGroupBox.TabStop = false;
            this.ScreenCaptureModeGroupBox.Text = "Capture Mode";
            // 
            // Screenshot_SnipCapture_RadioButton
            // 
            this.Screenshot_SnipCapture_RadioButton.Location = new System.Drawing.Point(210, 19);
            this.Screenshot_SnipCapture_RadioButton.Name = "Screenshot_SnipCapture_RadioButton";
            this.Screenshot_SnipCapture_RadioButton.Size = new System.Drawing.Size(91, 24);
            this.Screenshot_SnipCapture_RadioButton.TabIndex = 2;
            this.Screenshot_SnipCapture_RadioButton.Text = "Screen Snip ";
            this.Screenshot_SnipCapture_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Screenshot_ScreenCapture_RadioButton
            // 
            this.Screenshot_ScreenCapture_RadioButton.Location = new System.Drawing.Point(119, 19);
            this.Screenshot_ScreenCapture_RadioButton.Name = "Screenshot_ScreenCapture_RadioButton";
            this.Screenshot_ScreenCapture_RadioButton.Size = new System.Drawing.Size(85, 24);
            this.Screenshot_ScreenCapture_RadioButton.TabIndex = 1;
            this.Screenshot_ScreenCapture_RadioButton.Text = "Full Screen";
            this.Screenshot_ScreenCapture_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Screenshot_ActiveWindowCapture_RadioButton
            // 
            this.Screenshot_ActiveWindowCapture_RadioButton.Checked = true;
            this.Screenshot_ActiveWindowCapture_RadioButton.Location = new System.Drawing.Point(9, 19);
            this.Screenshot_ActiveWindowCapture_RadioButton.Name = "Screenshot_ActiveWindowCapture_RadioButton";
            this.Screenshot_ActiveWindowCapture_RadioButton.Size = new System.Drawing.Size(104, 24);
            this.Screenshot_ActiveWindowCapture_RadioButton.TabIndex = 0;
            this.Screenshot_ActiveWindowCapture_RadioButton.TabStop = true;
            this.Screenshot_ActiveWindowCapture_RadioButton.Text = "Active Window";
            this.Screenshot_ActiveWindowCapture_RadioButton.UseVisualStyleBackColor = true;
            // 
            // PasteScreenshotButton
            // 
            this.PasteScreenshotButton.Location = new System.Drawing.Point(975, 69);
            this.PasteScreenshotButton.Name = "PasteScreenshotButton";
            this.PasteScreenshotButton.Size = new System.Drawing.Size(103, 32);
            this.PasteScreenshotButton.TabIndex = 20;
            this.PasteScreenshotButton.Text = "Paste Screenshot";
            this.PasteScreenshotButton.UseVisualStyleBackColor = true;
            this.PasteScreenshotButton.Click += new System.EventHandler(this.PasteScreenshotButtonClick);
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(304, 86);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(87, 20);
            this.label36.TabIndex = 16;
            this.label36.Text = "FileNamePrefix:";
            // 
            // ScreenShotDirectory
            // 
            this.ScreenShotDirectory.Location = new System.Drawing.Point(393, 60);
            this.ScreenShotDirectory.Name = "ScreenShotDirectory";
            this.ScreenShotDirectory.Size = new System.Drawing.Size(345, 20);
            this.ScreenShotDirectory.TabIndex = 11;
            this.ScreenShotDirectory.Text = "c:\\";
            // 
            // CopyScreenshotButton
            // 
            this.CopyScreenshotButton.Location = new System.Drawing.Point(871, 69);
            this.CopyScreenshotButton.Name = "CopyScreenshotButton";
            this.CopyScreenshotButton.Size = new System.Drawing.Size(98, 32);
            this.CopyScreenshotButton.TabIndex = 19;
            this.CopyScreenshotButton.Text = "Copy Screenshot";
            this.CopyScreenshotButton.UseVisualStyleBackColor = true;
            this.CopyScreenshotButton.Click += new System.EventHandler(this.CopyScreenshotButtonClick);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(313, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 38);
            this.label17.TabIndex = 13;
            this.label17.Text = "Directory";
            // 
            // ScreenShotSaveButton
            // 
            this.ScreenShotSaveButton.Location = new System.Drawing.Point(43, 63);
            this.ScreenShotSaveButton.Name = "ScreenShotSaveButton";
            this.ScreenShotSaveButton.Size = new System.Drawing.Size(98, 32);
            this.ScreenShotSaveButton.TabIndex = 10;
            this.ScreenShotSaveButton.Text = "Save";
            this.ScreenShotSaveButton.UseVisualStyleBackColor = true;
            this.ScreenShotSaveButton.Click += new System.EventHandler(this.ScreenShotSaveButtonClick);
            // 
            // EditScreenShotButton
            // 
            this.EditScreenShotButton.Location = new System.Drawing.Point(147, 63);
            this.EditScreenShotButton.Name = "EditScreenShotButton";
            this.EditScreenShotButton.Size = new System.Drawing.Size(98, 32);
            this.EditScreenShotButton.TabIndex = 18;
            this.EditScreenShotButton.Text = "Edit Screenshot";
            this.EditScreenShotButton.UseVisualStyleBackColor = true;
            this.EditScreenShotButton.Click += new System.EventHandler(this.EditScreenShotButtonClick);
            // 
            // ScreenShotPrefixTextBox
            // 
            this.ScreenShotPrefixTextBox.Location = new System.Drawing.Point(393, 86);
            this.ScreenShotPrefixTextBox.Name = "ScreenShotPrefixTextBox";
            this.ScreenShotPrefixTextBox.Size = new System.Drawing.Size(345, 20);
            this.ScreenShotPrefixTextBox.TabIndex = 15;
            this.ScreenShotPrefixTextBox.Text = "ScreenShot_";
            // 
            // OpenScreenshotButton
            // 
            this.OpenScreenshotButton.Location = new System.Drawing.Point(147, 25);
            this.OpenScreenshotButton.Name = "OpenScreenshotButton";
            this.OpenScreenshotButton.Size = new System.Drawing.Size(98, 32);
            this.OpenScreenshotButton.TabIndex = 17;
            this.OpenScreenshotButton.Text = "Open Screenshot";
            this.OpenScreenshotButton.UseVisualStyleBackColor = true;
            this.OpenScreenshotButton.Click += new System.EventHandler(this.OpenScreenshotButtonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 32);
            this.button3.TabIndex = 1;
            this.button3.Text = "Capture";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1251, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ClipRingTreeView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1257, 693);
            this.tabPage4.TabIndex = 9;
            this.tabPage4.Text = "Clip Ring";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ClipRingTreeView
            // 
            this.ClipRingTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClipRingTreeView.Location = new System.Drawing.Point(3, 3);
            this.ClipRingTreeView.Name = "ClipRingTreeView";
            this.ClipRingTreeView.Size = new System.Drawing.Size(1251, 687);
            this.ClipRingTreeView.TabIndex = 0;
            this.ClipRingTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ClipRingTreeViewAfterSelect);
            this.ClipRingTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClipRingTreeViewKeyDown);
            // 
            // LogsTAB
            // 
            this.LogsTAB.Controls.Add(this.OpenTodayLogButton);
            this.LogsTAB.Controls.Add(this.LogFolders);
            this.LogsTAB.Controls.Add(this.LogFiles);
            this.LogsTAB.Controls.Add(this.label35);
            this.LogsTAB.Controls.Add(this.label20);
            this.LogsTAB.Controls.Add(this.RefreshLogsButton);
            this.LogsTAB.Controls.Add(this.CopyLogPathButton);
            this.LogsTAB.Controls.Add(this.NewTextLogButton);
            this.LogsTAB.Location = new System.Drawing.Point(4, 22);
            this.LogsTAB.Name = "LogsTAB";
            this.LogsTAB.Padding = new System.Windows.Forms.Padding(3);
            this.LogsTAB.Size = new System.Drawing.Size(1257, 693);
            this.LogsTAB.TabIndex = 10;
            this.LogsTAB.Text = "Logs";
            this.LogsTAB.UseVisualStyleBackColor = true;
            // 
            // OpenTodayLogButton
            // 
            this.OpenTodayLogButton.Location = new System.Drawing.Point(589, 147);
            this.OpenTodayLogButton.Name = "OpenTodayLogButton";
            this.OpenTodayLogButton.Size = new System.Drawing.Size(160, 37);
            this.OpenTodayLogButton.TabIndex = 10;
            this.OpenTodayLogButton.Text = "Open Today\'s Log Folder";
            this.OpenTodayLogButton.UseVisualStyleBackColor = true;
            this.OpenTodayLogButton.Click += new System.EventHandler(this.OpenTodayLogButtonClick);
            // 
            // LogFolders
            // 
            this.LogFolders.FormattingEnabled = true;
            this.LogFolders.Location = new System.Drawing.Point(8, 332);
            this.LogFolders.Name = "LogFolders";
            this.LogFolders.Size = new System.Drawing.Size(559, 238);
            this.LogFolders.TabIndex = 9;
            this.LogFolders.SelectedIndexChanged += new System.EventHandler(this.LogFoldersSelectedIndexChanged);
            this.LogFolders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LogFoldersMouseDoubleClick);
            // 
            // LogFiles
            // 
            this.LogFiles.FormattingEnabled = true;
            this.LogFiles.Location = new System.Drawing.Point(8, 46);
            this.LogFiles.Name = "LogFiles";
            this.LogFiles.Size = new System.Drawing.Size(559, 238);
            this.LogFiles.TabIndex = 8;
            this.LogFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogFilesKeyDown);
            this.LogFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LogFilesMouseDoubleClick);
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(8, 24);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(63, 19);
            this.label35.TabIndex = 7;
            this.label35.Text = "Files:";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(8, 310);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 19);
            this.label20.TabIndex = 6;
            this.label20.Text = "Folders:";
            // 
            // RefreshLogsButton
            // 
            this.RefreshLogsButton.Location = new System.Drawing.Point(589, 104);
            this.RefreshLogsButton.Name = "RefreshLogsButton";
            this.RefreshLogsButton.Size = new System.Drawing.Size(160, 37);
            this.RefreshLogsButton.TabIndex = 3;
            this.RefreshLogsButton.Text = "Refresh Logs";
            this.RefreshLogsButton.UseVisualStyleBackColor = true;
            this.RefreshLogsButton.Click += new System.EventHandler(this.RefreshClick);
            // 
            // CopyLogPathButton
            // 
            this.CopyLogPathButton.Location = new System.Drawing.Point(589, 61);
            this.CopyLogPathButton.Name = "CopyLogPathButton";
            this.CopyLogPathButton.Size = new System.Drawing.Size(160, 37);
            this.CopyLogPathButton.TabIndex = 2;
            this.CopyLogPathButton.Text = "Copy File Path";
            this.CopyLogPathButton.UseVisualStyleBackColor = true;
            this.CopyLogPathButton.Click += new System.EventHandler(this.CopyLogPathButtonClick);
            // 
            // NewTextLogButton
            // 
            this.NewTextLogButton.Location = new System.Drawing.Point(589, 18);
            this.NewTextLogButton.Name = "NewTextLogButton";
            this.NewTextLogButton.Size = new System.Drawing.Size(160, 37);
            this.NewTextLogButton.TabIndex = 1;
            this.NewTextLogButton.Text = "New Text Log";
            this.NewTextLogButton.UseVisualStyleBackColor = true;
            this.NewTextLogButton.Click += new System.EventHandler(this.NewTextLogButtonClick);
            // 
            // ProcessTextTab
            // 
            this.ProcessTextTab.Controls.Add(this.splitContainer1);
            this.ProcessTextTab.Location = new System.Drawing.Point(4, 22);
            this.ProcessTextTab.Name = "ProcessTextTab";
            this.ProcessTextTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProcessTextTab.Size = new System.Drawing.Size(1257, 693);
            this.ProcessTextTab.TabIndex = 11;
            this.ProcessTextTab.Text = "Process Text";
            this.ProcessTextTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DecodeGZipBase64Buttonn2);
            this.splitContainer1.Panel2.Controls.Add(this.EncodeGZipBase64Button);
            this.splitContainer1.Panel2.Controls.Add(this.DecodeBase64Button);
            this.splitContainer1.Panel2.Controls.Add(this.EncodeBase64Button);
            this.splitContainer1.Panel2.Controls.Add(this.DecodeURLParamButton);
            this.splitContainer1.Panel2.Controls.Add(this.EncodeURLParamButton);
            this.splitContainer1.Panel2.Controls.Add(this.UnescapeXMLStringButton);
            this.splitContainer1.Panel2.Controls.Add(this.EscapeXMLButton);
            this.splitContainer1.Panel2.Controls.Add(this.Button_ProcessText_RemoveCommonLines);
            this.splitContainer1.Panel2.Controls.Add(this.FindMultiTextButton);
            this.splitContainer1.Panel2.Controls.Add(this.ProcessText_IncrementCountersButton);
            this.splitContainer1.Panel2.Controls.Add(this.IncrementValuesButton);
            this.splitContainer1.Panel2.Controls.Add(this.RemoveNullParamXMLButton);
            this.splitContainer1.Panel2.Controls.Add(this.ProcessTextFixLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ProcessTextFixTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ToOneLineButton);
            this.splitContainer1.Panel2.Controls.Add(this.FormatXMLButton);
            this.splitContainer1.Panel2.Controls.Add(this.OneWordPerLineButton);
            this.splitContainer1.Panel2.Controls.Add(this.ProcessText_ToJavaStringButton);
            this.splitContainer1.Panel2.Controls.Add(this.ProcessText_RemoveLeadingWhiteSpaces);
            this.splitContainer1.Panel2.Controls.Add(this.AddSuffixButton);
            this.splitContainer1.Panel2.Controls.Add(this.AddPrefixButton);
            this.splitContainer1.Panel2.Controls.Add(this.GetParamFromURLButton);
            this.splitContainer1.Size = new System.Drawing.Size(1251, 687);
            this.splitContainer1.SplitterDistance = 804;
            this.splitContainer1.TabIndex = 10;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ProcessTextRTB1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ProcessTextRTB2);
            this.splitContainer2.Size = new System.Drawing.Size(804, 687);
            this.splitContainer2.SplitterDistance = 412;
            this.splitContainer2.TabIndex = 2;
            // 
            // ProcessTextRTB1
            // 
            this.ProcessTextRTB1.AcceptsTab = true;
            this.ProcessTextRTB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessTextRTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessTextRTB1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ProcessTextRTB1.Location = new System.Drawing.Point(0, 0);
            this.ProcessTextRTB1.Name = "ProcessTextRTB1";
            this.ProcessTextRTB1.Size = new System.Drawing.Size(412, 687);
            this.ProcessTextRTB1.TabIndex = 0;
            this.ProcessTextRTB1.Text = "";
            this.ProcessTextRTB1.WordWrap = false;
            // 
            // ProcessTextRTB2
            // 
            this.ProcessTextRTB2.AcceptsTab = true;
            this.ProcessTextRTB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessTextRTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessTextRTB2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ProcessTextRTB2.Location = new System.Drawing.Point(0, 0);
            this.ProcessTextRTB2.Name = "ProcessTextRTB2";
            this.ProcessTextRTB2.Size = new System.Drawing.Size(388, 687);
            this.ProcessTextRTB2.TabIndex = 1;
            this.ProcessTextRTB2.Text = "";
            this.ProcessTextRTB2.WordWrap = false;
            // 
            // DecodeGZipBase64Buttonn2
            // 
            this.DecodeGZipBase64Buttonn2.Location = new System.Drawing.Point(217, 364);
            this.DecodeGZipBase64Buttonn2.Name = "DecodeGZipBase64Buttonn2";
            this.DecodeGZipBase64Buttonn2.Size = new System.Drawing.Size(197, 29);
            this.DecodeGZipBase64Buttonn2.TabIndex = 24;
            this.DecodeGZipBase64Buttonn2.Text = "Decode Base64->unGZip";
            this.DecodeGZipBase64Buttonn2.UseVisualStyleBackColor = true;
            this.DecodeGZipBase64Buttonn2.Click += new System.EventHandler(this.DecodeGZipBase64Buttonn2Click);
            // 
            // EncodeGZipBase64Button
            // 
            this.EncodeGZipBase64Button.Location = new System.Drawing.Point(217, 331);
            this.EncodeGZipBase64Button.Name = "EncodeGZipBase64Button";
            this.EncodeGZipBase64Button.Size = new System.Drawing.Size(197, 29);
            this.EncodeGZipBase64Button.TabIndex = 23;
            this.EncodeGZipBase64Button.Text = "Encode to GZIP->Base 64";
            this.EncodeGZipBase64Button.UseVisualStyleBackColor = true;
            this.EncodeGZipBase64Button.Click += new System.EventHandler(this.EncodeGZipBase64ButtonClick);
            // 
            // DecodeBase64Button
            // 
            this.DecodeBase64Button.Location = new System.Drawing.Point(217, 296);
            this.DecodeBase64Button.Name = "DecodeBase64Button";
            this.DecodeBase64Button.Size = new System.Drawing.Size(197, 29);
            this.DecodeBase64Button.TabIndex = 22;
            this.DecodeBase64Button.Text = "Decode from Base 64";
            this.DecodeBase64Button.UseVisualStyleBackColor = true;
            this.DecodeBase64Button.Click += new System.EventHandler(this.DecodeBase64ButtonClick);
            // 
            // EncodeBase64Button
            // 
            this.EncodeBase64Button.Location = new System.Drawing.Point(217, 263);
            this.EncodeBase64Button.Name = "EncodeBase64Button";
            this.EncodeBase64Button.Size = new System.Drawing.Size(197, 29);
            this.EncodeBase64Button.TabIndex = 21;
            this.EncodeBase64Button.Text = "Encode to Base 64";
            this.EncodeBase64Button.UseVisualStyleBackColor = true;
            this.EncodeBase64Button.Click += new System.EventHandler(this.EncodeBase64ButtonClick);
            // 
            // DecodeURLParamButton
            // 
            this.DecodeURLParamButton.Location = new System.Drawing.Point(14, 640);
            this.DecodeURLParamButton.Name = "DecodeURLParamButton";
            this.DecodeURLParamButton.Size = new System.Drawing.Size(197, 29);
            this.DecodeURLParamButton.TabIndex = 20;
            this.DecodeURLParamButton.Text = "Decode URL Param";
            this.DecodeURLParamButton.UseVisualStyleBackColor = true;
            this.DecodeURLParamButton.Click += new System.EventHandler(this.DecodeURLParamButtonClick);
            // 
            // EncodeURLParamButton
            // 
            this.EncodeURLParamButton.Location = new System.Drawing.Point(14, 608);
            this.EncodeURLParamButton.Name = "EncodeURLParamButton";
            this.EncodeURLParamButton.Size = new System.Drawing.Size(197, 29);
            this.EncodeURLParamButton.TabIndex = 19;
            this.EncodeURLParamButton.Text = "Encode URL Param";
            this.EncodeURLParamButton.UseVisualStyleBackColor = true;
            this.EncodeURLParamButton.Click += new System.EventHandler(this.EncodeURLParamButtonClick);
            // 
            // UnescapeXMLStringButton
            // 
            this.UnescapeXMLStringButton.Location = new System.Drawing.Point(14, 574);
            this.UnescapeXMLStringButton.Name = "UnescapeXMLStringButton";
            this.UnescapeXMLStringButton.Size = new System.Drawing.Size(197, 29);
            this.UnescapeXMLStringButton.TabIndex = 18;
            this.UnescapeXMLStringButton.Text = "Unescape XML String";
            this.UnescapeXMLStringButton.UseVisualStyleBackColor = true;
            this.UnescapeXMLStringButton.Click += new System.EventHandler(this.UnescapeXMLStringButtonClick);
            // 
            // EscapeXMLButton
            // 
            this.EscapeXMLButton.Location = new System.Drawing.Point(14, 539);
            this.EscapeXMLButton.Name = "EscapeXMLButton";
            this.EscapeXMLButton.Size = new System.Drawing.Size(197, 29);
            this.EscapeXMLButton.TabIndex = 17;
            this.EscapeXMLButton.Text = "Escape XML String";
            this.EscapeXMLButton.UseVisualStyleBackColor = true;
            this.EscapeXMLButton.Click += new System.EventHandler(this.EscapeXMLButtonClick);
            // 
            // Button_ProcessText_RemoveCommonLines
            // 
            this.Button_ProcessText_RemoveCommonLines.Location = new System.Drawing.Point(14, 504);
            this.Button_ProcessText_RemoveCommonLines.Name = "Button_ProcessText_RemoveCommonLines";
            this.Button_ProcessText_RemoveCommonLines.Size = new System.Drawing.Size(197, 29);
            this.Button_ProcessText_RemoveCommonLines.TabIndex = 16;
            this.Button_ProcessText_RemoveCommonLines.Text = "Remove Common Lines";
            this.Button_ProcessText_RemoveCommonLines.UseVisualStyleBackColor = true;
            this.Button_ProcessText_RemoveCommonLines.Click += new System.EventHandler(this.Button_ProcessText_RemoveCommonLinesClick);
            // 
            // FindMultiTextButton
            // 
            this.FindMultiTextButton.Location = new System.Drawing.Point(14, 434);
            this.FindMultiTextButton.Name = "FindMultiTextButton";
            this.FindMultiTextButton.Size = new System.Drawing.Size(197, 29);
            this.FindMultiTextButton.TabIndex = 15;
            this.FindMultiTextButton.Text = "Find Multi Text";
            this.FindMultiTextButton.UseVisualStyleBackColor = true;
            this.FindMultiTextButton.Click += new System.EventHandler(this.FindMultiTextButtonClick);
            // 
            // ProcessText_IncrementCountersButton
            // 
            this.ProcessText_IncrementCountersButton.Location = new System.Drawing.Point(14, 469);
            this.ProcessText_IncrementCountersButton.Name = "ProcessText_IncrementCountersButton";
            this.ProcessText_IncrementCountersButton.Size = new System.Drawing.Size(197, 29);
            this.ProcessText_IncrementCountersButton.TabIndex = 14;
            this.ProcessText_IncrementCountersButton.Text = "Increment Counters";
            this.ProcessText_IncrementCountersButton.UseVisualStyleBackColor = true;
            this.ProcessText_IncrementCountersButton.Click += new System.EventHandler(this.ProcessText_IncrementCountersButtonClick);
            // 
            // IncrementValuesButton
            // 
            this.IncrementValuesButton.Location = new System.Drawing.Point(14, 263);
            this.IncrementValuesButton.Name = "IncrementValuesButton";
            this.IncrementValuesButton.Size = new System.Drawing.Size(197, 29);
            this.IncrementValuesButton.TabIndex = 13;
            this.IncrementValuesButton.Text = "Incrment Values";
            this.IncrementValuesButton.UseVisualStyleBackColor = true;
            this.IncrementValuesButton.Click += new System.EventHandler(this.IncrementValuesButtonClick);
            // 
            // RemoveNullParamXMLButton
            // 
            this.RemoveNullParamXMLButton.Location = new System.Drawing.Point(14, 400);
            this.RemoveNullParamXMLButton.Name = "RemoveNullParamXMLButton";
            this.RemoveNullParamXMLButton.Size = new System.Drawing.Size(197, 29);
            this.RemoveNullParamXMLButton.TabIndex = 12;
            this.RemoveNullParamXMLButton.Text = "Remove Null Value Params From XML";
            this.RemoveNullParamXMLButton.UseVisualStyleBackColor = true;
            this.RemoveNullParamXMLButton.Click += new System.EventHandler(this.RemoveNullParamXMLButtonClick);
            // 
            // ProcessTextFixLabel
            // 
            this.ProcessTextFixLabel.AutoSize = true;
            this.ProcessTextFixLabel.Location = new System.Drawing.Point(11, 180);
            this.ProcessTextFixLabel.Name = "ProcessTextFixLabel";
            this.ProcessTextFixLabel.Size = new System.Drawing.Size(113, 13);
            this.ProcessTextFixLabel.TabIndex = 11;
            this.ProcessTextFixLabel.Text = "Prefix / Suffix / Criteria";
            // 
            // ProcessTextFixTextBox
            // 
            this.ProcessTextFixTextBox.Location = new System.Drawing.Point(14, 201);
            this.ProcessTextFixTextBox.Multiline = true;
            this.ProcessTextFixTextBox.Name = "ProcessTextFixTextBox";
            this.ProcessTextFixTextBox.Size = new System.Drawing.Size(197, 51);
            this.ProcessTextFixTextBox.TabIndex = 10;
            // 
            // ToOneLineButton
            // 
            this.ToOneLineButton.Location = new System.Drawing.Point(14, 5);
            this.ToOneLineButton.Name = "ToOneLineButton";
            this.ToOneLineButton.Size = new System.Drawing.Size(197, 29);
            this.ToOneLineButton.TabIndex = 2;
            this.ToOneLineButton.Text = "To One Line";
            this.ToOneLineButton.UseVisualStyleBackColor = true;
            this.ToOneLineButton.Click += new System.EventHandler(this.ToOneLineButtonClick);
            // 
            // FormatXMLButton
            // 
            this.FormatXMLButton.Location = new System.Drawing.Point(14, 366);
            this.FormatXMLButton.Name = "FormatXMLButton";
            this.FormatXMLButton.Size = new System.Drawing.Size(197, 29);
            this.FormatXMLButton.TabIndex = 9;
            this.FormatXMLButton.Text = "Format XML";
            this.FormatXMLButton.UseVisualStyleBackColor = true;
            this.FormatXMLButton.Click += new System.EventHandler(this.FormatXMLButton_Click);
            // 
            // OneWordPerLineButton
            // 
            this.OneWordPerLineButton.Location = new System.Drawing.Point(14, 40);
            this.OneWordPerLineButton.Name = "OneWordPerLineButton";
            this.OneWordPerLineButton.Size = new System.Drawing.Size(197, 29);
            this.OneWordPerLineButton.TabIndex = 3;
            this.OneWordPerLineButton.Text = "One Word Per Line";
            this.OneWordPerLineButton.UseVisualStyleBackColor = true;
            this.OneWordPerLineButton.Click += new System.EventHandler(this.OneWordPerLineButtonClick);
            // 
            // ProcessText_ToJavaStringButton
            // 
            this.ProcessText_ToJavaStringButton.Location = new System.Drawing.Point(14, 331);
            this.ProcessText_ToJavaStringButton.Name = "ProcessText_ToJavaStringButton";
            this.ProcessText_ToJavaStringButton.Size = new System.Drawing.Size(197, 29);
            this.ProcessText_ToJavaStringButton.TabIndex = 8;
            this.ProcessText_ToJavaStringButton.Text = "To Java String";
            this.ProcessText_ToJavaStringButton.UseVisualStyleBackColor = true;
            this.ProcessText_ToJavaStringButton.Click += new System.EventHandler(this.ProcessText_ToJavaStringButtonClick);
            // 
            // ProcessText_RemoveLeadingWhiteSpaces
            // 
            this.ProcessText_RemoveLeadingWhiteSpaces.Location = new System.Drawing.Point(14, 75);
            this.ProcessText_RemoveLeadingWhiteSpaces.Name = "ProcessText_RemoveLeadingWhiteSpaces";
            this.ProcessText_RemoveLeadingWhiteSpaces.Size = new System.Drawing.Size(197, 29);
            this.ProcessText_RemoveLeadingWhiteSpaces.TabIndex = 4;
            this.ProcessText_RemoveLeadingWhiteSpaces.Text = "Remove Leading White Spaces";
            this.ProcessText_RemoveLeadingWhiteSpaces.UseVisualStyleBackColor = true;
            this.ProcessText_RemoveLeadingWhiteSpaces.Click += new System.EventHandler(this.ProcessText_RemoveLeadingWhiteSpacesClick);
            // 
            // AddSuffixButton
            // 
            this.AddSuffixButton.Location = new System.Drawing.Point(14, 145);
            this.AddSuffixButton.Name = "AddSuffixButton";
            this.AddSuffixButton.Size = new System.Drawing.Size(197, 29);
            this.AddSuffixButton.TabIndex = 7;
            this.AddSuffixButton.Text = "Add Suffix";
            this.AddSuffixButton.UseVisualStyleBackColor = true;
            this.AddSuffixButton.Click += new System.EventHandler(this.AddSuffixButton_Click);
            // 
            // AddPrefixButton
            // 
            this.AddPrefixButton.Location = new System.Drawing.Point(14, 110);
            this.AddPrefixButton.Name = "AddPrefixButton";
            this.AddPrefixButton.Size = new System.Drawing.Size(197, 29);
            this.AddPrefixButton.TabIndex = 5;
            this.AddPrefixButton.Text = "Add Prefix";
            this.AddPrefixButton.UseVisualStyleBackColor = true;
            this.AddPrefixButton.Click += new System.EventHandler(this.AddPrefixButtonClick);
            // 
            // GetParamFromURLButton
            // 
            this.GetParamFromURLButton.Location = new System.Drawing.Point(14, 296);
            this.GetParamFromURLButton.Name = "GetParamFromURLButton";
            this.GetParamFromURLButton.Size = new System.Drawing.Size(197, 29);
            this.GetParamFromURLButton.TabIndex = 6;
            this.GetParamFromURLButton.Text = "GetParamFromURL";
            this.GetParamFromURLButton.UseVisualStyleBackColor = true;
            this.GetParamFromURLButton.Click += new System.EventHandler(this.GetParamFromURLButtonClick);
            // 
            // WebPosterTab
            // 
            this.WebPosterTab.Controls.Add(this.SContainerHttpPost);
            this.WebPosterTab.Location = new System.Drawing.Point(4, 22);
            this.WebPosterTab.Name = "WebPosterTab";
            this.WebPosterTab.Padding = new System.Windows.Forms.Padding(3);
            this.WebPosterTab.Size = new System.Drawing.Size(1257, 693);
            this.WebPosterTab.TabIndex = 17;
            this.WebPosterTab.Text = "HTTP Post";
            this.WebPosterTab.UseVisualStyleBackColor = true;
            // 
            // SContainerHttpPost
            // 
            this.SContainerHttpPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SContainerHttpPost.Location = new System.Drawing.Point(3, 3);
            this.SContainerHttpPost.Name = "SContainerHttpPost";
            // 
            // SContainerHttpPost.Panel1
            // 
            this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPost_PasteParamDataButton);
            this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPost_ClearParamButton);
            this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPost_DeleteParamButton);
            this.SContainerHttpPost.Panel1.Controls.Add(this.label56);
            this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPostURLTextBox);
            this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPostRunButton);
            this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPostAddParamToListButton);
            this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPostValueTextBox);
            this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPostParameterTextBox);
            this.SContainerHttpPost.Panel1.Controls.Add(this.label55);
            this.SContainerHttpPost.Panel1.Controls.Add(this.label26);
            this.SContainerHttpPost.Panel1.Controls.Add(this.label25);
            this.SContainerHttpPost.Panel1.Controls.Add(this.HTTPPostParamListBox);
            // 
            // SContainerHttpPost.Panel2
            // 
            this.SContainerHttpPost.Panel2.Controls.Add(this.HTTPPostResultBrowser);
            this.SContainerHttpPost.Size = new System.Drawing.Size(1251, 687);
            this.SContainerHttpPost.SplitterDistance = 416;
            this.SContainerHttpPost.TabIndex = 0;
            // 
            // HTTPPost_PasteParamDataButton
            // 
            this.HTTPPost_PasteParamDataButton.Location = new System.Drawing.Point(5, 623);
            this.HTTPPost_PasteParamDataButton.Name = "HTTPPost_PasteParamDataButton";
            this.HTTPPost_PasteParamDataButton.Size = new System.Drawing.Size(109, 23);
            this.HTTPPost_PasteParamDataButton.TabIndex = 12;
            this.HTTPPost_PasteParamDataButton.Text = "Paste Param Data";
            this.HTTPPost_PasteParamDataButton.UseVisualStyleBackColor = true;
            this.HTTPPost_PasteParamDataButton.Click += new System.EventHandler(this.HTTPPost_PasteParamDataButtonClick);
            // 
            // HTTPPost_ClearParamButton
            // 
            this.HTTPPost_ClearParamButton.Location = new System.Drawing.Point(254, 594);
            this.HTTPPost_ClearParamButton.Name = "HTTPPost_ClearParamButton";
            this.HTTPPost_ClearParamButton.Size = new System.Drawing.Size(95, 23);
            this.HTTPPost_ClearParamButton.TabIndex = 11;
            this.HTTPPost_ClearParamButton.Text = "Clear Params";
            this.HTTPPost_ClearParamButton.UseVisualStyleBackColor = true;
            this.HTTPPost_ClearParamButton.Click += new System.EventHandler(this.HTTPPost_ClearParamButtonClick);
            // 
            // HTTPPost_DeleteParamButton
            // 
            this.HTTPPost_DeleteParamButton.Location = new System.Drawing.Point(120, 594);
            this.HTTPPost_DeleteParamButton.Name = "HTTPPost_DeleteParamButton";
            this.HTTPPost_DeleteParamButton.Size = new System.Drawing.Size(128, 23);
            this.HTTPPost_DeleteParamButton.TabIndex = 10;
            this.HTTPPost_DeleteParamButton.Text = "Delete Param From List";
            this.HTTPPost_DeleteParamButton.UseVisualStyleBackColor = true;
            this.HTTPPost_DeleteParamButton.Click += new System.EventHandler(this.HTTPPost_DeleteParamButtonClick);
            // 
            // label56
            // 
            this.label56.Location = new System.Drawing.Point(5, 22);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(157, 23);
            this.label56.TabIndex = 9;
            this.label56.Text = "HTTP Url";
            // 
            // HTTPPostURLTextBox
            // 
            this.HTTPPostURLTextBox.Location = new System.Drawing.Point(5, 48);
            this.HTTPPostURLTextBox.Multiline = true;
            this.HTTPPostURLTextBox.Name = "HTTPPostURLTextBox";
            this.HTTPPostURLTextBox.Size = new System.Drawing.Size(344, 78);
            this.HTTPPostURLTextBox.TabIndex = 8;
            this.HTTPPostURLTextBox.Text = "http://localhost";
            // 
            // HTTPPostRunButton
            // 
            this.HTTPPostRunButton.Location = new System.Drawing.Point(267, 131);
            this.HTTPPostRunButton.Name = "HTTPPostRunButton";
            this.HTTPPostRunButton.Size = new System.Drawing.Size(82, 23);
            this.HTTPPostRunButton.TabIndex = 7;
            this.HTTPPostRunButton.Text = "Run";
            this.HTTPPostRunButton.UseVisualStyleBackColor = true;
            this.HTTPPostRunButton.Click += new System.EventHandler(this.HTTPPostRunButtonClick);
            // 
            // HTTPPostAddParamToListButton
            // 
            this.HTTPPostAddParamToListButton.Location = new System.Drawing.Point(5, 594);
            this.HTTPPostAddParamToListButton.Name = "HTTPPostAddParamToListButton";
            this.HTTPPostAddParamToListButton.Size = new System.Drawing.Size(109, 23);
            this.HTTPPostAddParamToListButton.TabIndex = 6;
            this.HTTPPostAddParamToListButton.Text = "Add Param To List";
            this.HTTPPostAddParamToListButton.UseVisualStyleBackColor = true;
            this.HTTPPostAddParamToListButton.Click += new System.EventHandler(this.HTTPPostAddParamToListButtonClick);
            // 
            // HTTPPostValueTextBox
            // 
            this.HTTPPostValueTextBox.Location = new System.Drawing.Point(51, 453);
            this.HTTPPostValueTextBox.Multiline = true;
            this.HTTPPostValueTextBox.Name = "HTTPPostValueTextBox";
            this.HTTPPostValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HTTPPostValueTextBox.Size = new System.Drawing.Size(298, 135);
            this.HTTPPostValueTextBox.TabIndex = 5;
            // 
            // HTTPPostParameterTextBox
            // 
            this.HTTPPostParameterTextBox.Location = new System.Drawing.Point(51, 430);
            this.HTTPPostParameterTextBox.Name = "HTTPPostParameterTextBox";
            this.HTTPPostParameterTextBox.Size = new System.Drawing.Size(298, 20);
            this.HTTPPostParameterTextBox.TabIndex = 4;
            // 
            // label55
            // 
            this.label55.Location = new System.Drawing.Point(5, 457);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(100, 23);
            this.label55.TabIndex = 3;
            this.label55.Text = "Value";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(5, 433);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 23);
            this.label26.TabIndex = 2;
            this.label26.Text = "Param";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(5, 156);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(157, 23);
            this.label25.TabIndex = 1;
            this.label25.Text = "HTTP Post Parameters List";
            // 
            // HTTPPostParamListBox
            // 
            this.HTTPPostParamListBox.FormattingEnabled = true;
            this.HTTPPostParamListBox.HorizontalScrollbar = true;
            this.HTTPPostParamListBox.Location = new System.Drawing.Point(5, 179);
            this.HTTPPostParamListBox.Name = "HTTPPostParamListBox";
            this.HTTPPostParamListBox.ScrollAlwaysVisible = true;
            this.HTTPPostParamListBox.Size = new System.Drawing.Size(344, 251);
            this.HTTPPostParamListBox.TabIndex = 0;
            this.HTTPPostParamListBox.SelectedIndexChanged += new System.EventHandler(this.HTTPPostParamListBoxSelectedIndexChanged);
            this.HTTPPostParamListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HTTPPostParamListBoxKeyDown);
            // 
            // HTTPPostResultBrowser
            // 
            this.HTTPPostResultBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPPostResultBrowser.Location = new System.Drawing.Point(0, 0);
            this.HTTPPostResultBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.HTTPPostResultBrowser.Name = "HTTPPostResultBrowser";
            this.HTTPPostResultBrowser.Size = new System.Drawing.Size(831, 687);
            this.HTTPPostResultBrowser.TabIndex = 0;
            // 
            // ArchivingToolsTab
            // 
            this.ArchivingToolsTab.Controls.Add(this.splitContainer4);
            this.ArchivingToolsTab.Location = new System.Drawing.Point(4, 22);
            this.ArchivingToolsTab.Name = "ArchivingToolsTab";
            this.ArchivingToolsTab.Size = new System.Drawing.Size(1257, 693);
            this.ArchivingToolsTab.TabIndex = 0;
            this.ArchivingToolsTab.Text = "Archiving Tools";
            this.ArchivingToolsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.ExtractGroupBox);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.ArchiveToolsViewArchiveTreeView);
            this.splitContainer4.Panel2.Controls.Add(this.ArchiveTools_ResultsTextBox);
            this.splitContainer4.Size = new System.Drawing.Size(1257, 693);
            this.splitContainer4.SplitterDistance = 493;
            this.splitContainer4.TabIndex = 2;
            // 
            // ExtractGroupBox
            // 
            this.ExtractGroupBox.Controls.Add(this.ViewArchiveButton);
            this.ExtractGroupBox.Controls.Add(this.BrowseExtractPathButton);
            this.ExtractGroupBox.Controls.Add(this.Extract_ExtractPathLabel);
            this.ExtractGroupBox.Controls.Add(this.ExtractArchive_ExtractPathTextBox);
            this.ExtractGroupBox.Controls.Add(this.ExtractTokenGroupBox);
            this.ExtractGroupBox.Controls.Add(this.ExtractArchiveResetButton);
            this.ExtractGroupBox.Controls.Add(this.MaxNestingLabel);
            this.ExtractGroupBox.Controls.Add(this.ExtractArchiveMaxNestingTextBox);
            this.ExtractGroupBox.Controls.Add(this.RecursivelyExtractArchiveCheckBox);
            this.ExtractGroupBox.Controls.Add(this.BrowseArchiveFileButton);
            this.ExtractGroupBox.Controls.Add(this.ArchiveExtractButton);
            this.ExtractGroupBox.Controls.Add(this.ExtractArchivePathLabel);
            this.ExtractGroupBox.Controls.Add(this.ExtractArchivePathTextBox);
            this.ExtractGroupBox.Location = new System.Drawing.Point(16, 11);
            this.ExtractGroupBox.Name = "ExtractGroupBox";
            this.ExtractGroupBox.Size = new System.Drawing.Size(458, 361);
            this.ExtractGroupBox.TabIndex = 0;
            this.ExtractGroupBox.TabStop = false;
            this.ExtractGroupBox.Text = "Extract Tools";
            // 
            // ViewArchiveButton
            // 
            this.ViewArchiveButton.Location = new System.Drawing.Point(335, 118);
            this.ViewArchiveButton.Name = "ViewArchiveButton";
            this.ViewArchiveButton.Size = new System.Drawing.Size(75, 23);
            this.ViewArchiveButton.TabIndex = 25;
            this.ViewArchiveButton.Text = "View";
            this.ViewArchiveButton.UseVisualStyleBackColor = true;
            this.ViewArchiveButton.Click += new System.EventHandler(this.ViewArchiveButtonClick);
            // 
            // BrowseExtractPathButton
            // 
            this.BrowseExtractPathButton.Location = new System.Drawing.Point(370, 46);
            this.BrowseExtractPathButton.Name = "BrowseExtractPathButton";
            this.BrowseExtractPathButton.Size = new System.Drawing.Size(25, 23);
            this.BrowseExtractPathButton.TabIndex = 24;
            this.BrowseExtractPathButton.Text = "..";
            this.BrowseExtractPathButton.UseVisualStyleBackColor = true;
            this.BrowseExtractPathButton.Click += new System.EventHandler(this.BrowseExtractPathButtonClick);
            // 
            // Extract_ExtractPathLabel
            // 
            this.Extract_ExtractPathLabel.Location = new System.Drawing.Point(15, 46);
            this.Extract_ExtractPathLabel.Name = "Extract_ExtractPathLabel";
            this.Extract_ExtractPathLabel.Size = new System.Drawing.Size(80, 23);
            this.Extract_ExtractPathLabel.TabIndex = 23;
            this.Extract_ExtractPathLabel.Text = "Extract Path:";
            // 
            // ExtractArchive_ExtractPathTextBox
            // 
            this.ExtractArchive_ExtractPathTextBox.Location = new System.Drawing.Point(101, 46);
            this.ExtractArchive_ExtractPathTextBox.Name = "ExtractArchive_ExtractPathTextBox";
            this.ExtractArchive_ExtractPathTextBox.Size = new System.Drawing.Size(262, 20);
            this.ExtractArchive_ExtractPathTextBox.TabIndex = 22;
            // 
            // ExtractTokenGroupBox
            // 
            this.ExtractTokenGroupBox.Controls.Add(this.ExtractArchiveAddExcludedFileTextBox);
            this.ExtractTokenGroupBox.Controls.Add(this.ExtractArchiveDeleteRemoveTermButton);
            this.ExtractTokenGroupBox.Controls.Add(this.ExtractArchiveDeleteExcludedFileButton);
            this.ExtractTokenGroupBox.Controls.Add(this.ExtractArchiveAddRemoveTermButton);
            this.ExtractTokenGroupBox.Controls.Add(this.ExtractArchiveExcludedFilesComboBox);
            this.ExtractTokenGroupBox.Controls.Add(this.label57);
            this.ExtractTokenGroupBox.Controls.Add(this.ExtractArchiveRemoveTermsComboBox);
            this.ExtractTokenGroupBox.Controls.Add(this.label8);
            this.ExtractTokenGroupBox.Controls.Add(this.ExtractArchiveAddRemoveTermTextBox);
            this.ExtractTokenGroupBox.Controls.Add(this.ExtractArchiveAddExcludedFileButton);
            this.ExtractTokenGroupBox.Enabled = false;
            this.ExtractTokenGroupBox.Location = new System.Drawing.Point(6, 178);
            this.ExtractTokenGroupBox.Name = "ExtractTokenGroupBox";
            this.ExtractTokenGroupBox.Size = new System.Drawing.Size(389, 174);
            this.ExtractTokenGroupBox.TabIndex = 21;
            this.ExtractTokenGroupBox.TabStop = false;
            this.ExtractTokenGroupBox.Text = "Token";
            // 
            // ExtractArchiveAddExcludedFileTextBox
            // 
            this.ExtractArchiveAddExcludedFileTextBox.Location = new System.Drawing.Point(139, 92);
            this.ExtractArchiveAddExcludedFileTextBox.Name = "ExtractArchiveAddExcludedFileTextBox";
            this.ExtractArchiveAddExcludedFileTextBox.Size = new System.Drawing.Size(148, 20);
            this.ExtractArchiveAddExcludedFileTextBox.TabIndex = 12;
            // 
            // ExtractArchiveDeleteRemoveTermButton
            // 
            this.ExtractArchiveDeleteRemoveTermButton.Location = new System.Drawing.Point(301, 48);
            this.ExtractArchiveDeleteRemoveTermButton.Name = "ExtractArchiveDeleteRemoveTermButton";
            this.ExtractArchiveDeleteRemoveTermButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractArchiveDeleteRemoveTermButton.TabIndex = 17;
            this.ExtractArchiveDeleteRemoveTermButton.Text = "Delete";
            this.ExtractArchiveDeleteRemoveTermButton.UseVisualStyleBackColor = true;
            this.ExtractArchiveDeleteRemoveTermButton.Click += new System.EventHandler(this.ExtractArchiveDeleteRemoveTermButtonClick);
            // 
            // ExtractArchiveDeleteExcludedFileButton
            // 
            this.ExtractArchiveDeleteExcludedFileButton.Location = new System.Drawing.Point(301, 121);
            this.ExtractArchiveDeleteExcludedFileButton.Name = "ExtractArchiveDeleteExcludedFileButton";
            this.ExtractArchiveDeleteExcludedFileButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractArchiveDeleteExcludedFileButton.TabIndex = 18;
            this.ExtractArchiveDeleteExcludedFileButton.Text = "Delete";
            this.ExtractArchiveDeleteExcludedFileButton.UseVisualStyleBackColor = true;
            this.ExtractArchiveDeleteExcludedFileButton.Click += new System.EventHandler(this.ExtractArchiveDeleteExcludedFileButtonClick);
            // 
            // ExtractArchiveAddRemoveTermButton
            // 
            this.ExtractArchiveAddRemoveTermButton.Location = new System.Drawing.Point(301, 22);
            this.ExtractArchiveAddRemoveTermButton.Name = "ExtractArchiveAddRemoveTermButton";
            this.ExtractArchiveAddRemoveTermButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractArchiveAddRemoveTermButton.TabIndex = 11;
            this.ExtractArchiveAddRemoveTermButton.Text = "Add";
            this.ExtractArchiveAddRemoveTermButton.UseVisualStyleBackColor = true;
            this.ExtractArchiveAddRemoveTermButton.Click += new System.EventHandler(this.ExtractArchiveAddRemoveTermButtonClick);
            // 
            // ExtractArchiveExcludedFilesComboBox
            // 
            this.ExtractArchiveExcludedFilesComboBox.FormattingEnabled = true;
            this.ExtractArchiveExcludedFilesComboBox.Location = new System.Drawing.Point(139, 121);
            this.ExtractArchiveExcludedFilesComboBox.Name = "ExtractArchiveExcludedFilesComboBox";
            this.ExtractArchiveExcludedFilesComboBox.Size = new System.Drawing.Size(148, 21);
            this.ExtractArchiveExcludedFilesComboBox.TabIndex = 14;
            this.ExtractArchiveExcludedFilesComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExtractArchiveExcludedFilesComboBoxKeyDown);
            // 
            // label57
            // 
            this.label57.Location = new System.Drawing.Point(12, 27);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(109, 53);
            this.label57.TabIndex = 10;
            this.label57.Text = "Tokens to be removed from file names:";
            // 
            // ExtractArchiveRemoveTermsComboBox
            // 
            this.ExtractArchiveRemoveTermsComboBox.FormattingEnabled = true;
            this.ExtractArchiveRemoveTermsComboBox.Location = new System.Drawing.Point(139, 51);
            this.ExtractArchiveRemoveTermsComboBox.Name = "ExtractArchiveRemoveTermsComboBox";
            this.ExtractArchiveRemoveTermsComboBox.Size = new System.Drawing.Size(148, 21);
            this.ExtractArchiveRemoveTermsComboBox.TabIndex = 9;
            this.ExtractArchiveRemoveTermsComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExtractArchiveRemoveTermsComboBoxKeyDown);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 47);
            this.label8.TabIndex = 15;
            this.label8.Text = "File types excluded from token removal";
            // 
            // ExtractArchiveAddRemoveTermTextBox
            // 
            this.ExtractArchiveAddRemoveTermTextBox.Location = new System.Drawing.Point(139, 22);
            this.ExtractArchiveAddRemoveTermTextBox.Name = "ExtractArchiveAddRemoveTermTextBox";
            this.ExtractArchiveAddRemoveTermTextBox.Size = new System.Drawing.Size(148, 20);
            this.ExtractArchiveAddRemoveTermTextBox.TabIndex = 7;
            // 
            // ExtractArchiveAddExcludedFileButton
            // 
            this.ExtractArchiveAddExcludedFileButton.Location = new System.Drawing.Point(301, 92);
            this.ExtractArchiveAddExcludedFileButton.Name = "ExtractArchiveAddExcludedFileButton";
            this.ExtractArchiveAddExcludedFileButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractArchiveAddExcludedFileButton.TabIndex = 16;
            this.ExtractArchiveAddExcludedFileButton.Text = "Add";
            this.ExtractArchiveAddExcludedFileButton.UseVisualStyleBackColor = true;
            this.ExtractArchiveAddExcludedFileButton.Click += new System.EventHandler(this.ExtractArchiveAddExcludedFileButtonClick);
            // 
            // ExtractArchiveResetButton
            // 
            this.ExtractArchiveResetButton.Location = new System.Drawing.Point(171, 118);
            this.ExtractArchiveResetButton.Name = "ExtractArchiveResetButton";
            this.ExtractArchiveResetButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractArchiveResetButton.TabIndex = 19;
            this.ExtractArchiveResetButton.Text = "Reset";
            this.ExtractArchiveResetButton.UseVisualStyleBackColor = true;
            this.ExtractArchiveResetButton.Click += new System.EventHandler(this.ExtractArchiveResetButtonClick);
            // 
            // MaxNestingLabel
            // 
            this.MaxNestingLabel.Location = new System.Drawing.Point(6, 75);
            this.MaxNestingLabel.Name = "MaxNestingLabel";
            this.MaxNestingLabel.Size = new System.Drawing.Size(75, 23);
            this.MaxNestingLabel.TabIndex = 6;
            this.MaxNestingLabel.Text = "Max Nesting";
            // 
            // ExtractArchiveMaxNestingTextBox
            // 
            this.ExtractArchiveMaxNestingTextBox.Location = new System.Drawing.Point(87, 75);
            this.ExtractArchiveMaxNestingTextBox.Name = "ExtractArchiveMaxNestingTextBox";
            this.ExtractArchiveMaxNestingTextBox.Size = new System.Drawing.Size(276, 20);
            this.ExtractArchiveMaxNestingTextBox.TabIndex = 5;
            // 
            // RecursivelyExtractArchiveCheckBox
            // 
            this.RecursivelyExtractArchiveCheckBox.Location = new System.Drawing.Point(15, 118);
            this.RecursivelyExtractArchiveCheckBox.Name = "RecursivelyExtractArchiveCheckBox";
            this.RecursivelyExtractArchiveCheckBox.Size = new System.Drawing.Size(163, 24);
            this.RecursivelyExtractArchiveCheckBox.TabIndex = 4;
            this.RecursivelyExtractArchiveCheckBox.Text = "Recursively Extract Archive";
            this.RecursivelyExtractArchiveCheckBox.UseVisualStyleBackColor = true;
            this.RecursivelyExtractArchiveCheckBox.CheckedChanged += new System.EventHandler(this.RecursivelyExtractArchiveCheckBoxCheckedChanged);
            // 
            // BrowseArchiveFileButton
            // 
            this.BrowseArchiveFileButton.Location = new System.Drawing.Point(370, 20);
            this.BrowseArchiveFileButton.Name = "BrowseArchiveFileButton";
            this.BrowseArchiveFileButton.Size = new System.Drawing.Size(25, 23);
            this.BrowseArchiveFileButton.TabIndex = 3;
            this.BrowseArchiveFileButton.Text = "..";
            this.BrowseArchiveFileButton.UseVisualStyleBackColor = true;
            this.BrowseArchiveFileButton.Click += new System.EventHandler(this.BrowseArchiveFileButtonClick);
            // 
            // ArchiveExtractButton
            // 
            this.ArchiveExtractButton.Location = new System.Drawing.Point(253, 118);
            this.ArchiveExtractButton.Name = "ArchiveExtractButton";
            this.ArchiveExtractButton.Size = new System.Drawing.Size(75, 23);
            this.ArchiveExtractButton.TabIndex = 2;
            this.ArchiveExtractButton.Text = "Extract";
            this.ArchiveExtractButton.UseVisualStyleBackColor = true;
            this.ArchiveExtractButton.Click += new System.EventHandler(this.ArchiveExtractButtonClick);
            // 
            // ExtractArchivePathLabel
            // 
            this.ExtractArchivePathLabel.Location = new System.Drawing.Point(15, 20);
            this.ExtractArchivePathLabel.Name = "ExtractArchivePathLabel";
            this.ExtractArchivePathLabel.Size = new System.Drawing.Size(48, 23);
            this.ExtractArchivePathLabel.TabIndex = 1;
            this.ExtractArchivePathLabel.Text = "Path:";
            // 
            // ExtractArchivePathTextBox
            // 
            this.ExtractArchivePathTextBox.Location = new System.Drawing.Point(69, 20);
            this.ExtractArchivePathTextBox.Name = "ExtractArchivePathTextBox";
            this.ExtractArchivePathTextBox.Size = new System.Drawing.Size(294, 20);
            this.ExtractArchivePathTextBox.TabIndex = 0;
            // 
            // ArchiveToolsViewArchiveTreeView
            // 
            this.ArchiveToolsViewArchiveTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchiveToolsViewArchiveTreeView.Location = new System.Drawing.Point(0, 0);
            this.ArchiveToolsViewArchiveTreeView.Name = "ArchiveToolsViewArchiveTreeView";
            this.ArchiveToolsViewArchiveTreeView.Size = new System.Drawing.Size(760, 693);
            this.ArchiveToolsViewArchiveTreeView.TabIndex = 2;
            // 
            // ArchiveTools_ResultsTextBox
            // 
            this.ArchiveTools_ResultsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchiveTools_ResultsTextBox.Location = new System.Drawing.Point(0, 0);
            this.ArchiveTools_ResultsTextBox.MaxLength = 999999;
            this.ArchiveTools_ResultsTextBox.Multiline = true;
            this.ArchiveTools_ResultsTextBox.Name = "ArchiveTools_ResultsTextBox";
            this.ArchiveTools_ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ArchiveTools_ResultsTextBox.Size = new System.Drawing.Size(760, 693);
            this.ArchiveTools_ResultsTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 719);
            this.panel2.TabIndex = 2;
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(5, 22);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(62, 15);
            this.label41.TabIndex = 29;
            this.label41.Text = "Select Host";
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(119, 61);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(102, 28);
            this.button33.TabIndex = 31;
            this.button33.Text = "Manual Edit";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(11, 61);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(102, 28);
            this.button34.TabIndex = 30;
            this.button34.Text = "Refresh Hosts";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(71, 18);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 27;
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(30, 356);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(194, 94);
            this.groupBox8.TabIndex = 49;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Machine Type";
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(482, 9);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(56, 21);
            this.label42.TabIndex = 48;
            this.label42.Text = "Name:";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(542, 9);
            this.textBox13.Margin = new System.Windows.Forms.Padding(2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(84, 20);
            this.textBox13.TabIndex = 47;
            this.textBox13.Text = "Madisons";
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(630, 6);
            this.button35.Margin = new System.Windows.Forms.Padding(2);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(118, 24);
            this.button35.TabIndex = 46;
            this.button35.Text = "Launch Store";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox14);
            this.groupBox9.Controls.Add(this.textBox15);
            this.groupBox9.Controls.Add(this.button36);
            this.groupBox9.Controls.Add(this.button37);
            this.groupBox9.Controls.Add(this.button38);
            this.groupBox9.Location = new System.Drawing.Point(466, 216);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(264, 178);
            this.groupBox9.TabIndex = 45;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Machine Checks";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(164, 46);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(72, 20);
            this.textBox14.TabIndex = 39;
            this.textBox14.Text = "80";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(164, 77);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(72, 20);
            this.textBox15.TabIndex = 38;
            this.textBox15.Text = "443";
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(24, 74);
            this.button36.Margin = new System.Windows.Forms.Padding(2);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(118, 24);
            this.button36.TabIndex = 37;
            this.button36.Text = "HttpsCheck";
            this.button36.UseVisualStyleBackColor = true;
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(24, 46);
            this.button37.Margin = new System.Windows.Forms.Padding(2);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(118, 24);
            this.button37.TabIndex = 36;
            this.button37.Text = "HttpCheck";
            this.button37.UseVisualStyleBackColor = true;
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(24, 18);
            this.button38.Margin = new System.Windows.Forms.Padding(2);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(118, 24);
            this.button38.TabIndex = 35;
            this.button38.Text = "Ping";
            this.button38.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button39);
            this.groupBox10.Controls.Add(this.button40);
            this.groupBox10.Controls.Add(this.button42);
            this.groupBox10.Controls.Add(this.button43);
            this.groupBox10.Controls.Add(this.textBox16);
            this.groupBox10.Controls.Add(this.label43);
            this.groupBox10.Location = new System.Drawing.Point(6, 50);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox10.Size = new System.Drawing.Size(219, 202);
            this.groupBox10.TabIndex = 44;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "IE Only Pages";
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(4, 138);
            this.button39.Margin = new System.Windows.Forms.Padding(2);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(152, 24);
            this.button39.TabIndex = 10;
            this.button39.Text = "Workspace Adm. Console";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(4, 110);
            this.button40.Margin = new System.Windows.Forms.Padding(2);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(152, 24);
            this.button40.TabIndex = 7;
            this.button40.Text = "Org Adm. Console";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(4, 52);
            this.button42.Margin = new System.Windows.Forms.Padding(2);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(152, 24);
            this.button42.TabIndex = 5;
            this.button42.Text = "Admin Console";
            this.button42.UseVisualStyleBackColor = true;
            // 
            // button43
            // 
            this.button43.Location = new System.Drawing.Point(4, 24);
            this.button43.Margin = new System.Windows.Forms.Padding(2);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(152, 24);
            this.button43.TabIndex = 3;
            this.button43.Text = "Accelerator";
            this.button43.UseVisualStyleBackColor = true;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(160, 80);
            this.textBox16.Margin = new System.Windows.Forms.Padding(2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(41, 20);
            this.textBox16.TabIndex = 8;
            this.textBox16.Text = "9102";
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(160, 58);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(30, 21);
            this.label43.TabIndex = 9;
            this.label43.Text = "Port:";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button44);
            this.groupBox11.Controls.Add(this.button45);
            this.groupBox11.Controls.Add(this.button46);
            this.groupBox11.Controls.Add(this.button47);
            this.groupBox11.Controls.Add(this.button48);
            this.groupBox11.Controls.Add(this.button49);
            this.groupBox11.Controls.Add(this.button50);
            this.groupBox11.Controls.Add(this.button51);
            this.groupBox11.Location = new System.Drawing.Point(287, 274);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox11.Size = new System.Drawing.Size(158, 288);
            this.groupBox11.TabIndex = 43;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Utilities";
            // 
            // button44
            // 
            this.button44.Location = new System.Drawing.Point(21, 234);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(118, 23);
            this.button44.TabIndex = 46;
            this.button44.Text = "FTP client";
            this.button44.UseVisualStyleBackColor = true;
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(21, 205);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(118, 23);
            this.button45.TabIndex = 44;
            this.button45.Text = "Listner";
            this.button45.UseVisualStyleBackColor = true;
            // 
            // button46
            // 
            this.button46.Location = new System.Drawing.Point(21, 176);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(118, 23);
            this.button46.TabIndex = 43;
            this.button46.Text = "Browse SMB Shares";
            this.button46.UseVisualStyleBackColor = true;
            // 
            // button47
            // 
            this.button47.Location = new System.Drawing.Point(21, 147);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(118, 23);
            this.button47.TabIndex = 42;
            this.button47.Text = "Win SCP";
            this.button47.UseVisualStyleBackColor = true;
            // 
            // button48
            // 
            this.button48.Location = new System.Drawing.Point(21, 118);
            this.button48.Margin = new System.Windows.Forms.Padding(2);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(118, 24);
            this.button48.TabIndex = 30;
            this.button48.Text = "Remote Desktop";
            this.button48.UseVisualStyleBackColor = true;
            // 
            // button49
            // 
            this.button49.Location = new System.Drawing.Point(21, 89);
            this.button49.Margin = new System.Windows.Forms.Padding(2);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(118, 24);
            this.button49.TabIndex = 34;
            this.button49.Text = "Telnet";
            this.button49.UseVisualStyleBackColor = true;
            // 
            // button50
            // 
            this.button50.Location = new System.Drawing.Point(21, 60);
            this.button50.Margin = new System.Windows.Forms.Padding(2);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(118, 24);
            this.button50.TabIndex = 41;
            this.button50.Text = "Putty";
            this.button50.UseVisualStyleBackColor = true;
            // 
            // button51
            // 
            this.button51.Location = new System.Drawing.Point(21, 31);
            this.button51.Margin = new System.Windows.Forms.Padding(2);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(118, 24);
            this.button51.TabIndex = 31;
            this.button51.Text = "VNC viewer";
            this.button51.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button52);
            this.groupBox12.Controls.Add(this.button53);
            this.groupBox12.Controls.Add(this.button54);
            this.groupBox12.Controls.Add(this.button55);
            this.groupBox12.Controls.Add(this.button56);
            this.groupBox12.Controls.Add(this.button57);
            this.groupBox12.Controls.Add(this.button58);
            this.groupBox12.Location = new System.Drawing.Point(287, 40);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox12.Size = new System.Drawing.Size(158, 230);
            this.groupBox12.TabIndex = 42;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Pages";
            // 
            // button52
            // 
            this.button52.Location = new System.Drawing.Point(17, 193);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(118, 23);
            this.button52.TabIndex = 45;
            this.button52.Text = "FTP(Default)";
            this.button52.UseVisualStyleBackColor = true;
            // 
            // button53
            // 
            this.button53.Location = new System.Drawing.Point(17, 164);
            this.button53.Margin = new System.Windows.Forms.Padding(2);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(118, 24);
            this.button53.TabIndex = 14;
            this.button53.Text = "Info Center";
            this.button53.UseVisualStyleBackColor = true;
            // 
            // button54
            // 
            this.button54.Location = new System.Drawing.Point(17, 136);
            this.button54.Margin = new System.Windows.Forms.Padding(2);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(118, 24);
            this.button54.TabIndex = 13;
            this.button54.Text = "Coremetrics";
            this.button54.UseVisualStyleBackColor = true;
            // 
            // button55
            // 
            this.button55.Location = new System.Drawing.Point(17, 108);
            this.button55.Margin = new System.Windows.Forms.Padding(2);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(118, 24);
            this.button55.TabIndex = 12;
            this.button55.Text = "DB Info";
            this.button55.UseVisualStyleBackColor = true;
            // 
            // button56
            // 
            this.button56.Location = new System.Drawing.Point(17, 79);
            this.button56.Margin = new System.Windows.Forms.Padding(2);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(118, 24);
            this.button56.TabIndex = 11;
            this.button56.Text = "DB Query";
            this.button56.UseVisualStyleBackColor = true;
            // 
            // button57
            // 
            this.button57.Location = new System.Drawing.Point(17, 23);
            this.button57.Margin = new System.Windows.Forms.Padding(2);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(118, 24);
            this.button57.TabIndex = 4;
            this.button57.Text = "Lob Tools";
            this.button57.UseVisualStyleBackColor = true;
            // 
            // button58
            // 
            this.button58.Location = new System.Drawing.Point(17, 51);
            this.button58.Margin = new System.Windows.Forms.Padding(2);
            this.button58.Name = "button58";
            this.button58.Size = new System.Drawing.Size(118, 24);
            this.button58.TabIndex = 10;
            this.button58.Text = "Artec";
            this.button58.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.radioButton4);
            this.groupBox13.Controls.Add(this.radioButton5);
            this.groupBox13.Controls.Add(this.radioButton6);
            this.groupBox13.Location = new System.Drawing.Point(452, 42);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox13.Size = new System.Drawing.Size(166, 141);
            this.groupBox13.TabIndex = 40;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Select Browser";
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(4, 32);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(143, 20);
            this.radioButton4.TabIndex = 40;
            this.radioButton4.Text = "Open in Default (use IE)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(4, 57);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(95, 20);
            this.radioButton5.TabIndex = 39;
            this.radioButton5.Text = "Open in Firefox";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.Location = new System.Drawing.Point(4, 81);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(152, 20);
            this.radioButton6.TabIndex = 33;
            this.radioButton6.Text = "Open in TesterBuddy";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.Location = new System.Drawing.Point(10, 275);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(33, 22);
            this.label44.TabIndex = 38;
            this.label44.Text = "URL";
            // 
            // button59
            // 
            this.button59.Location = new System.Drawing.Point(206, 274);
            this.button59.Margin = new System.Windows.Forms.Padding(2);
            this.button59.Name = "button59";
            this.button59.Size = new System.Drawing.Size(35, 23);
            this.button59.TabIndex = 37;
            this.button59.Text = "GO";
            this.button59.UseVisualStyleBackColor = true;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(48, 275);
            this.textBox17.Margin = new System.Windows.Forms.Padding(2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(152, 20);
            this.textBox17.TabIndex = 36;
            this.textBox17.Text = "to be deleted";
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(178, 14);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(63, 21);
            this.label45.TabIndex = 29;
            this.label45.Text = "Catalog ID:";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(246, 12);
            this.textBox18.Margin = new System.Windows.Forms.Padding(2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(84, 20);
            this.textBox18.TabIndex = 28;
            this.textBox18.Text = "<na>";
            // 
            // label46
            // 
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(4, 487);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(351, 25);
            this.label46.TabIndex = 27;
            this.label46.Text = "Note: Host name is taken from Add Host tab.";
            // 
            // button60
            // 
            this.button60.Location = new System.Drawing.Point(338, 8);
            this.button60.Margin = new System.Windows.Forms.Padding(2);
            this.button60.Name = "button60";
            this.button60.Size = new System.Drawing.Size(118, 24);
            this.button60.TabIndex = 2;
            this.button60.Text = "Launch Store";
            this.button60.UseVisualStyleBackColor = true;
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(30, 17);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(56, 21);
            this.label47.TabIndex = 1;
            this.label47.Text = "Store ID:";
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(90, 15);
            this.textBox30.Margin = new System.Windows.Forms.Padding(2);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(84, 20);
            this.textBox30.TabIndex = 0;
            this.textBox30.Text = "555";
            // 
            // groupBox14
            // 
            this.groupBox14.Location = new System.Drawing.Point(30, 356);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(194, 94);
            this.groupBox14.TabIndex = 49;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Machine Type";
            // 
            // label48
            // 
            this.label48.Location = new System.Drawing.Point(482, 9);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(56, 21);
            this.label48.TabIndex = 48;
            this.label48.Text = "Name:";
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(542, 9);
            this.textBox31.Margin = new System.Windows.Forms.Padding(2);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(84, 20);
            this.textBox31.TabIndex = 47;
            this.textBox31.Text = "Madisons";
            // 
            // button61
            // 
            this.button61.Location = new System.Drawing.Point(630, 6);
            this.button61.Margin = new System.Windows.Forms.Padding(2);
            this.button61.Name = "button61";
            this.button61.Size = new System.Drawing.Size(118, 24);
            this.button61.TabIndex = 46;
            this.button61.Text = "Launch Store";
            this.button61.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textBox32);
            this.groupBox15.Controls.Add(this.textBox33);
            this.groupBox15.Controls.Add(this.button62);
            this.groupBox15.Controls.Add(this.button63);
            this.groupBox15.Controls.Add(this.button64);
            this.groupBox15.Location = new System.Drawing.Point(466, 216);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(264, 178);
            this.groupBox15.TabIndex = 45;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Machine Checks";
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(164, 46);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(72, 20);
            this.textBox32.TabIndex = 39;
            this.textBox32.Text = "80";
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(164, 77);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(72, 20);
            this.textBox33.TabIndex = 38;
            this.textBox33.Text = "443";
            // 
            // button62
            // 
            this.button62.Location = new System.Drawing.Point(24, 74);
            this.button62.Margin = new System.Windows.Forms.Padding(2);
            this.button62.Name = "button62";
            this.button62.Size = new System.Drawing.Size(118, 24);
            this.button62.TabIndex = 37;
            this.button62.Text = "HttpsCheck";
            this.button62.UseVisualStyleBackColor = true;
            // 
            // button63
            // 
            this.button63.Location = new System.Drawing.Point(24, 46);
            this.button63.Margin = new System.Windows.Forms.Padding(2);
            this.button63.Name = "button63";
            this.button63.Size = new System.Drawing.Size(118, 24);
            this.button63.TabIndex = 36;
            this.button63.Text = "HttpCheck";
            this.button63.UseVisualStyleBackColor = true;
            // 
            // button64
            // 
            this.button64.Location = new System.Drawing.Point(24, 18);
            this.button64.Margin = new System.Windows.Forms.Padding(2);
            this.button64.Name = "button64";
            this.button64.Size = new System.Drawing.Size(118, 24);
            this.button64.TabIndex = 35;
            this.button64.Text = "Ping";
            this.button64.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.button65);
            this.groupBox16.Controls.Add(this.button66);
            this.groupBox16.Controls.Add(this.button67);
            this.groupBox16.Controls.Add(this.button68);
            this.groupBox16.Controls.Add(this.button69);
            this.groupBox16.Controls.Add(this.textBox34);
            this.groupBox16.Controls.Add(this.label49);
            this.groupBox16.Location = new System.Drawing.Point(6, 50);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox16.Size = new System.Drawing.Size(219, 202);
            this.groupBox16.TabIndex = 44;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "IE Only Pages";
            // 
            // button65
            // 
            this.button65.Location = new System.Drawing.Point(4, 138);
            this.button65.Margin = new System.Windows.Forms.Padding(2);
            this.button65.Name = "button65";
            this.button65.Size = new System.Drawing.Size(152, 24);
            this.button65.TabIndex = 10;
            this.button65.Text = "Workspace Adm. Console";
            this.button65.UseVisualStyleBackColor = true;
            // 
            // button66
            // 
            this.button66.Location = new System.Drawing.Point(4, 110);
            this.button66.Margin = new System.Windows.Forms.Padding(2);
            this.button66.Name = "button66";
            this.button66.Size = new System.Drawing.Size(152, 24);
            this.button66.TabIndex = 7;
            this.button66.Text = "Org Adm. Console";
            this.button66.UseVisualStyleBackColor = true;
            // 
            // button67
            // 
            this.button67.Location = new System.Drawing.Point(4, 80);
            this.button67.Margin = new System.Windows.Forms.Padding(2);
            this.button67.Name = "button67";
            this.button67.Size = new System.Drawing.Size(152, 24);
            this.button67.TabIndex = 6;
            this.button67.Text = "";
            this.button67.UseVisualStyleBackColor = true;
            // 
            // button68
            // 
            this.button68.Location = new System.Drawing.Point(4, 52);
            this.button68.Margin = new System.Windows.Forms.Padding(2);
            this.button68.Name = "button68";
            this.button68.Size = new System.Drawing.Size(152, 24);
            this.button68.TabIndex = 5;
            this.button68.Text = "Admin Console";
            this.button68.UseVisualStyleBackColor = true;
            // 
            // button69
            // 
            this.button69.Location = new System.Drawing.Point(4, 24);
            this.button69.Margin = new System.Windows.Forms.Padding(2);
            this.button69.Name = "button69";
            this.button69.Size = new System.Drawing.Size(152, 24);
            this.button69.TabIndex = 3;
            this.button69.Text = "Accelerator";
            this.button69.UseVisualStyleBackColor = true;
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(160, 80);
            this.textBox34.Margin = new System.Windows.Forms.Padding(2);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(41, 20);
            this.textBox34.TabIndex = 8;
            this.textBox34.Text = "9102";
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(160, 58);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(30, 21);
            this.label49.TabIndex = 9;
            this.label49.Text = "Port:";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.button70);
            this.groupBox17.Controls.Add(this.button71);
            this.groupBox17.Controls.Add(this.button72);
            this.groupBox17.Controls.Add(this.button73);
            this.groupBox17.Controls.Add(this.button74);
            this.groupBox17.Controls.Add(this.button75);
            this.groupBox17.Controls.Add(this.button76);
            this.groupBox17.Controls.Add(this.button77);
            this.groupBox17.Location = new System.Drawing.Point(287, 274);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox17.Size = new System.Drawing.Size(158, 288);
            this.groupBox17.TabIndex = 43;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Utilities";
            // 
            // button70
            // 
            this.button70.Location = new System.Drawing.Point(21, 234);
            this.button70.Name = "button70";
            this.button70.Size = new System.Drawing.Size(118, 23);
            this.button70.TabIndex = 46;
            this.button70.Text = "FTP client";
            this.button70.UseVisualStyleBackColor = true;
            // 
            // button71
            // 
            this.button71.Location = new System.Drawing.Point(21, 205);
            this.button71.Name = "button71";
            this.button71.Size = new System.Drawing.Size(118, 23);
            this.button71.TabIndex = 44;
            this.button71.Text = "Listner";
            this.button71.UseVisualStyleBackColor = true;
            // 
            // button72
            // 
            this.button72.Location = new System.Drawing.Point(21, 176);
            this.button72.Name = "button72";
            this.button72.Size = new System.Drawing.Size(118, 23);
            this.button72.TabIndex = 43;
            this.button72.Text = "Browse SMB Shares";
            this.button72.UseVisualStyleBackColor = true;
            // 
            // button73
            // 
            this.button73.Location = new System.Drawing.Point(21, 147);
            this.button73.Name = "button73";
            this.button73.Size = new System.Drawing.Size(118, 23);
            this.button73.TabIndex = 42;
            this.button73.Text = "Win SCP";
            this.button73.UseVisualStyleBackColor = true;
            // 
            // button74
            // 
            this.button74.Location = new System.Drawing.Point(21, 118);
            this.button74.Margin = new System.Windows.Forms.Padding(2);
            this.button74.Name = "button74";
            this.button74.Size = new System.Drawing.Size(118, 24);
            this.button74.TabIndex = 30;
            this.button74.Text = "Remote Desktop";
            this.button74.UseVisualStyleBackColor = true;
            // 
            // button75
            // 
            this.button75.Location = new System.Drawing.Point(21, 89);
            this.button75.Margin = new System.Windows.Forms.Padding(2);
            this.button75.Name = "button75";
            this.button75.Size = new System.Drawing.Size(118, 24);
            this.button75.TabIndex = 34;
            this.button75.Text = "Telnet";
            this.button75.UseVisualStyleBackColor = true;
            // 
            // button76
            // 
            this.button76.Location = new System.Drawing.Point(21, 60);
            this.button76.Margin = new System.Windows.Forms.Padding(2);
            this.button76.Name = "button76";
            this.button76.Size = new System.Drawing.Size(118, 24);
            this.button76.TabIndex = 41;
            this.button76.Text = "Putty";
            this.button76.UseVisualStyleBackColor = true;
            // 
            // button77
            // 
            this.button77.Location = new System.Drawing.Point(21, 31);
            this.button77.Margin = new System.Windows.Forms.Padding(2);
            this.button77.Name = "button77";
            this.button77.Size = new System.Drawing.Size(118, 24);
            this.button77.TabIndex = 31;
            this.button77.Text = "VNC viewer";
            this.button77.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.button78);
            this.groupBox18.Controls.Add(this.button79);
            this.groupBox18.Controls.Add(this.button80);
            this.groupBox18.Controls.Add(this.button81);
            this.groupBox18.Controls.Add(this.button82);
            this.groupBox18.Controls.Add(this.button83);
            this.groupBox18.Controls.Add(this.button84);
            this.groupBox18.Location = new System.Drawing.Point(287, 40);
            this.groupBox18.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox18.Size = new System.Drawing.Size(158, 230);
            this.groupBox18.TabIndex = 42;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Pages";
            // 
            // button78
            // 
            this.button78.Location = new System.Drawing.Point(17, 193);
            this.button78.Name = "button78";
            this.button78.Size = new System.Drawing.Size(118, 23);
            this.button78.TabIndex = 45;
            this.button78.Text = "FTP(Default)";
            this.button78.UseVisualStyleBackColor = true;
            // 
            // button79
            // 
            this.button79.Location = new System.Drawing.Point(17, 164);
            this.button79.Margin = new System.Windows.Forms.Padding(2);
            this.button79.Name = "button79";
            this.button79.Size = new System.Drawing.Size(118, 24);
            this.button79.TabIndex = 14;
            this.button79.Text = "Info Center";
            this.button79.UseVisualStyleBackColor = true;
            // 
            // button80
            // 
            this.button80.Location = new System.Drawing.Point(17, 136);
            this.button80.Margin = new System.Windows.Forms.Padding(2);
            this.button80.Name = "button80";
            this.button80.Size = new System.Drawing.Size(118, 24);
            this.button80.TabIndex = 13;
            this.button80.Text = "Coremetrics";
            this.button80.UseVisualStyleBackColor = true;
            // 
            // button81
            // 
            this.button81.Location = new System.Drawing.Point(17, 108);
            this.button81.Margin = new System.Windows.Forms.Padding(2);
            this.button81.Name = "button81";
            this.button81.Size = new System.Drawing.Size(118, 24);
            this.button81.TabIndex = 12;
            this.button81.Text = "DB Info";
            this.button81.UseVisualStyleBackColor = true;
            // 
            // button82
            // 
            this.button82.Location = new System.Drawing.Point(17, 79);
            this.button82.Margin = new System.Windows.Forms.Padding(2);
            this.button82.Name = "button82";
            this.button82.Size = new System.Drawing.Size(118, 24);
            this.button82.TabIndex = 11;
            this.button82.Text = "DB Query";
            this.button82.UseVisualStyleBackColor = true;
            // 
            // button83
            // 
            this.button83.Location = new System.Drawing.Point(17, 23);
            this.button83.Margin = new System.Windows.Forms.Padding(2);
            this.button83.Name = "button83";
            this.button83.Size = new System.Drawing.Size(118, 24);
            this.button83.TabIndex = 4;
            this.button83.Text = "Lob Tools";
            this.button83.UseVisualStyleBackColor = true;
            // 
            // button84
            // 
            this.button84.Location = new System.Drawing.Point(17, 51);
            this.button84.Margin = new System.Windows.Forms.Padding(2);
            this.button84.Name = "button84";
            this.button84.Size = new System.Drawing.Size(118, 24);
            this.button84.TabIndex = 10;
            this.button84.Text = "Artec";
            this.button84.UseVisualStyleBackColor = true;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.radioButton7);
            this.groupBox19.Controls.Add(this.radioButton8);
            this.groupBox19.Controls.Add(this.radioButton9);
            this.groupBox19.Location = new System.Drawing.Point(452, 42);
            this.groupBox19.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox19.Size = new System.Drawing.Size(166, 141);
            this.groupBox19.TabIndex = 40;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Select Browser";
            // 
            // radioButton7
            // 
            this.radioButton7.Location = new System.Drawing.Point(4, 32);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(143, 20);
            this.radioButton7.TabIndex = 40;
            this.radioButton7.Text = "Open in Default (use IE)";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.Location = new System.Drawing.Point(4, 57);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(95, 20);
            this.radioButton8.TabIndex = 39;
            this.radioButton8.Text = "Open in Firefox";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.Location = new System.Drawing.Point(4, 81);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(152, 20);
            this.radioButton9.TabIndex = 33;
            this.radioButton9.Text = "Open in TesterBuddy";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(10, 275);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(33, 22);
            this.label50.TabIndex = 38;
            this.label50.Text = "URL";
            // 
            // button85
            // 
            this.button85.Location = new System.Drawing.Point(206, 274);
            this.button85.Margin = new System.Windows.Forms.Padding(2);
            this.button85.Name = "button85";
            this.button85.Size = new System.Drawing.Size(35, 23);
            this.button85.TabIndex = 37;
            this.button85.Text = "GO";
            this.button85.UseVisualStyleBackColor = true;
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(48, 275);
            this.textBox35.Margin = new System.Windows.Forms.Padding(2);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(152, 20);
            this.textBox35.TabIndex = 36;
            this.textBox35.Text = "";
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(178, 14);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(63, 21);
            this.label51.TabIndex = 29;
            this.label51.Text = "Catalog ID:";
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(246, 12);
            this.textBox36.Margin = new System.Windows.Forms.Padding(2);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(84, 20);
            this.textBox36.TabIndex = 28;
            this.textBox36.Text = "<na>";
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(4, 487);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(351, 25);
            this.label52.TabIndex = 27;
            this.label52.Text = "Note: Host name is taken from Add Host tab.";
            // 
            // button86
            // 
            this.button86.Location = new System.Drawing.Point(338, 8);
            this.button86.Margin = new System.Windows.Forms.Padding(2);
            this.button86.Name = "button86";
            this.button86.Size = new System.Drawing.Size(118, 24);
            this.button86.TabIndex = 2;
            this.button86.Text = "Launch Store";
            this.button86.UseVisualStyleBackColor = true;
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(30, 17);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(56, 21);
            this.label53.TabIndex = 1;
            this.label53.Text = "Store ID:";
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(90, 15);
            this.textBox37.Margin = new System.Windows.Forms.Padding(2);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(84, 20);
            this.textBox37.TabIndex = 0;
            this.textBox37.Text = "555";
            // 
            // ExtractFileTimer
            // 
            this.ExtractFileTimer.Enabled = true;
            this.ExtractFileTimer.Interval = 1000;
            this.ExtractFileTimer.Tick += new System.EventHandler(this.ExtractFileTimerTick);
            // 
            // MainNotifyIcon
            // 
            this.MainNotifyIcon.BalloonTipText = "Tester Buddy";
            this.MainNotifyIcon.BalloonTipTitle = "Tester Buddy";
            this.MainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MainNotifyIcon.Icon")));
            this.MainNotifyIcon.Text = "TesterBuddy";
            this.MainNotifyIcon.Visible = true;
            this.MainNotifyIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainNotifyIconClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 765);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Tester Buddy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AddHostDetailsTab.ResumeLayout(false);
            this.etchostEditGroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.CustomCommandsGroupBox.ResumeLayout(false);
            this.LocalCommandGroupBox.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.MachineCheckGroupBox.ResumeLayout(false);
            this.MachineCheckGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.WebBrowserSplitContainer.Panel1.ResumeLayout(false);
            this.WebBrowserSplitContainer.Panel1.PerformLayout();
            this.WebBrowserSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WebBrowserSplitContainer)).EndInit();
            this.WebBrowserSplitContainer.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ScreenCaptureModeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.LogsTAB.ResumeLayout(false);
            this.ProcessTextTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.WebPosterTab.ResumeLayout(false);
            this.SContainerHttpPost.Panel1.ResumeLayout(false);
            this.SContainerHttpPost.Panel1.PerformLayout();
            this.SContainerHttpPost.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SContainerHttpPost)).EndInit();
            this.SContainerHttpPost.ResumeLayout(false);
            this.ArchivingToolsTab.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ExtractGroupBox.ResumeLayout(false);
            this.ExtractGroupBox.PerformLayout();
            this.ExtractTokenGroupBox.ResumeLayout(false);
            this.ExtractTokenGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button CustomCommandButton3;
		private System.Windows.Forms.Button CustomCommandButton4;
		private System.Windows.Forms.Button CustomCommandButton5;
		private System.Windows.Forms.Button CustomCommandButton6;
		private System.Windows.Forms.Button CustomCommandButton7;
		private System.Windows.Forms.Button CustomCommandButton8;
		private System.Windows.Forms.Button CustomCommandButton9;
		private System.Windows.Forms.Button CustomCommandButton10;
		private System.Windows.Forms.Button CustomCommandButton2;
		private System.Windows.Forms.Button CustomCommandButton1;
		private System.Windows.Forms.GroupBox CustomCommandsGroupBox;
		private System.Windows.Forms.Button DeleteAdditionalHostButton;
		private System.Windows.Forms.Label label_apiDirecotry;
		private System.Windows.Forms.TextBox APIDirectoryTextBox;
		private System.Windows.Forms.Button DecodeURLParamButton;
		private System.Windows.Forms.Button EncodeURLParamButton;
		private System.Windows.Forms.Button UnescapeXMLStringButton;
		private System.Windows.Forms.Button EscapeXMLButton;
		private System.Windows.Forms.ToolStripMenuItem ruleBasedTextGenerationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolsMenuItem;
		private System.Windows.Forms.Label label_CMDDIR;
		private System.Windows.Forms.TextBox CommandLineStartDirectory_TextBox;
		private System.Windows.Forms.SplitContainer WebBrowserSplitContainer;
		private System.Windows.Forms.Label label_chromepath;
		private System.Windows.Forms.TextBox ChromePathTextBox;
		private System.Windows.Forms.RadioButton OpenInChromeRadioButton;
		private System.Windows.Forms.Timer ExtractFileTimer;
		private System.Windows.Forms.Button Button_ProcessText_RemoveCommonLines;
		private System.Windows.Forms.Button FindMultiTextButton;
		private System.Windows.Forms.Button ViewArchiveButton;
		private System.Windows.Forms.TreeView ArchiveToolsViewArchiveTreeView;
		private System.Windows.Forms.TextBox ExtractArchive_ExtractPathTextBox;
		private System.Windows.Forms.Label Extract_ExtractPathLabel;
		private System.Windows.Forms.Button BrowseExtractPathButton;
		private System.Windows.Forms.Button Links_CopyIPButton;
		private System.Windows.Forms.Button CredentialRemoveButton;
		private System.Windows.Forms.Button CredentialAddButton;
		private System.Windows.Forms.TextBox vncScreenNumberTextBox;
		private System.Windows.Forms.TextBox ArchiveTools_ResultsTextBox;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.GroupBox ExtractTokenGroupBox;
		private System.Windows.Forms.CheckBox Links_OnlyCopyUrlCheckbox;
		private System.Windows.Forms.Button Utils_CMDButton;
		private System.Windows.Forms.Button ExtractArchiveResetButton;
		private System.Windows.Forms.Button ExtractArchiveDeleteRemoveTermButton;
		private System.Windows.Forms.Button ExtractArchiveDeleteExcludedFileButton;
		private System.Windows.Forms.TextBox ExtractArchiveAddExcludedFileTextBox;
		private System.Windows.Forms.ComboBox ExtractArchiveExcludedFilesComboBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button ExtractArchiveAddExcludedFileButton;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button MachineCheckSTAFButton;
		private System.Windows.Forms.Button HTTPPost_PasteParamDataButton;
		private System.Windows.Forms.ComboBox otherBrowsersComboBox;
		private System.Windows.Forms.RadioButton otherBrowserRadioButton;
		private System.Windows.Forms.TextBox ExtractArchiveAddRemoveTermTextBox;
		private System.Windows.Forms.ComboBox ExtractArchiveRemoveTermsComboBox;
		private System.Windows.Forms.Button ExtractArchiveAddRemoveTermButton;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.TextBox ExtractArchiveMaxNestingTextBox;
		private System.Windows.Forms.Label MaxNestingLabel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox ZipToolPathTextBox;
		private System.Windows.Forms.CheckBox RecursivelyExtractArchiveCheckBox;
		private System.Windows.Forms.Button BrowseArchiveFileButton;
		private System.Windows.Forms.Button ArchiveExtractButton;
		private System.Windows.Forms.TextBox ExtractArchivePathTextBox;
		private System.Windows.Forms.Label ExtractArchivePathLabel;
		private System.Windows.Forms.GroupBox ExtractGroupBox;
		private System.Windows.Forms.TabPage ArchivingToolsTab;
		private System.Windows.Forms.TextBox CommentsTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox UserCredentialsComboBox;
		private System.Windows.Forms.Button ProcessText_IncrementCountersButton;
		private System.Windows.Forms.Button OpenConfigXMLButton;
		private System.Windows.Forms.Button HTTPPost_DeleteParamButton;
		private System.Windows.Forms.Button HTTPPost_ClearParamButton;
		private System.Windows.Forms.Button HTTPPostRunButton;
		private System.Windows.Forms.TextBox HTTPPostURLTextBox;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.WebBrowser HTTPPostResultBrowser;
		private System.Windows.Forms.Button HTTPPostAddParamToListButton;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label55;
		private System.Windows.Forms.TextBox HTTPPostParameterTextBox;
		private System.Windows.Forms.TextBox HTTPPostValueTextBox;
		private System.Windows.Forms.ListBox HTTPPostParamListBox;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.SplitContainer SContainerHttpPost;
		private System.Windows.Forms.TabPage WebPosterTab;
		private System.Windows.Forms.Button LoadConfigButton;
		private System.Windows.Forms.Button SaveConfigAsButton;
		private System.Windows.Forms.Button IncrementValuesButton;
		private System.Windows.Forms.CheckBox HostSpecificSettingsCheckBox;
		private System.Windows.Forms.Button RemoveNullParamXMLButton;
		private System.Windows.Forms.Button SaveConfigurationButton;
		private System.Windows.Forms.Button AdditionalHostAddButton;
		private System.Windows.Forms.Button DeleteHostButton;
		private System.Windows.Forms.Button FixLocalHostButton;
		private System.Windows.Forms.Button AutoHostAddButton;
		private System.Windows.Forms.Button FixHostsButton;
		private System.Windows.Forms.Button SortHostsButton;
		private System.Windows.Forms.CheckBox AutoCredential_CheckBox;
		private System.Windows.Forms.Button ValidateConfigButton;
		private System.Windows.Forms.Button RefreshConfigButton;
		private System.Windows.Forms.CheckBox HostSpecificCheckBox;
		private System.Windows.Forms.TextBox HostNameTextBox;
		private System.Windows.Forms.Button CopyScreenshotButton;
		private System.Windows.Forms.Button PasteScreenshotButton;
		private System.Windows.Forms.Button UrlGoButton;
		private System.Windows.Forms.TextBox Default_URL_TextBox;
		private System.Windows.Forms.TextBox Putty_Path_textbox;
		private System.Windows.Forms.TextBox VNC__Path_textbox;
		private System.Windows.Forms.TextBox WinSCP_Path_textbox;
		private System.Windows.Forms.TextBox FireFoxPathTextBox;
		private System.Windows.Forms.Button ProcessText_ToJavaStringButton;
		private System.Windows.Forms.Label HostPasswordLabel;
		private System.Windows.Forms.TextBox HostPasswordTextBox;
		private System.Windows.Forms.Label HostUserNameLabel;
		private System.Windows.Forms.TextBox HostUserNameTextBox;
		private System.Windows.Forms.Button SMB_Button;
		private System.Windows.Forms.Button WinSCP_Button;
		private System.Windows.Forms.Button RemoteDesktop_button;
		private System.Windows.Forms.Button Telnet_button;
		private System.Windows.Forms.Button Putty_button;
		private System.Windows.Forms.Button VNC_button;
		private System.Windows.Forms.Button ProcessText_RemoveLeadingWhiteSpaces;
		private System.Windows.Forms.GroupBox LocalCommandGroupBox;
		private System.Windows.Forms.Button AddSuffixButton;
		private System.Windows.Forms.ComboBox HostNameComboBox;
		private System.Windows.Forms.Button PasteHostDetailsButton;
		private System.Windows.Forms.TextBox StafpathTextBox;
		private System.Windows.Forms.Label StafPathLabel;
		private System.Windows.Forms.Label HostName2Label;
		private System.Windows.Forms.Button IPConfigButton;
		private System.Windows.Forms.Button GetParamFromURLButton;
		private System.Windows.Forms.TextBox IEPathTextBox;
		private System.Windows.Forms.Label label54;
		private System.Windows.Forms.Button EditScreenShotButton;
		private System.Windows.Forms.Timer TeamSessionTimer;
		private System.Windows.Forms.Button OpenScreenshotButton;
		private System.Windows.Forms.Timer AutoTimeIncrementTimer;
		private System.Windows.Forms.TextBox textBox37;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.Button button86;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.TextBox textBox36;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.TextBox textBox35;
		private System.Windows.Forms.Button button85;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.RadioButton radioButton9;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.GroupBox groupBox19;
		private System.Windows.Forms.Button button84;
		private System.Windows.Forms.Button button83;
		private System.Windows.Forms.Button button82;
		private System.Windows.Forms.Button button81;
		private System.Windows.Forms.Button button80;
		private System.Windows.Forms.Button button79;
		private System.Windows.Forms.Button button78;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.Button button77;
		private System.Windows.Forms.Button button76;
		private System.Windows.Forms.Button button75;
		private System.Windows.Forms.Button button74;
		private System.Windows.Forms.Button button73;
		private System.Windows.Forms.Button button72;
		private System.Windows.Forms.Button button71;
		private System.Windows.Forms.Button button70;
		private System.Windows.Forms.GroupBox groupBox17;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.TextBox textBox34;
		private System.Windows.Forms.Button button69;
		private System.Windows.Forms.Button button68;
		private System.Windows.Forms.Button button67;
		private System.Windows.Forms.Button button66;
		private System.Windows.Forms.Button button65;
		private System.Windows.Forms.GroupBox groupBox16;
		private System.Windows.Forms.Button button64;
		private System.Windows.Forms.Button button63;
		private System.Windows.Forms.Button button62;
		private System.Windows.Forms.TextBox textBox33;
		private System.Windows.Forms.TextBox textBox32;
		private System.Windows.Forms.GroupBox groupBox15;
		private System.Windows.Forms.Button button61;
		private System.Windows.Forms.TextBox textBox31;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.TextBox textBox30;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Button button60;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.Button button59;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.Button button58;
		private System.Windows.Forms.Button button57;
		private System.Windows.Forms.Button button56;
		private System.Windows.Forms.Button button55;
		private System.Windows.Forms.Button button54;
		private System.Windows.Forms.Button button53;
		private System.Windows.Forms.Button button52;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.Button button51;
		private System.Windows.Forms.Button button50;
		private System.Windows.Forms.Button button49;
		private System.Windows.Forms.Button button48;
		private System.Windows.Forms.Button button47;
		private System.Windows.Forms.Button button46;
		private System.Windows.Forms.Button button45;
		private System.Windows.Forms.Button button44;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.Button button43;
		private System.Windows.Forms.Button button42;		
		private System.Windows.Forms.Button button40;
		private System.Windows.Forms.Button button39;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.Button button38;
		private System.Windows.Forms.Button button37;
		private System.Windows.Forms.Button button36;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Button button35;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button34;
		private System.Windows.Forms.Button button33;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.GroupBox etchostEditGroup;
		private System.Windows.Forms.Button PasteIPButton;
		private System.Windows.Forms.Button CopyDetailsButton;
		private System.Windows.Forms.Button CopyIPButton;
		private System.Windows.Forms.TextBox CommandPathTextBox;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button AddPrefixButton;
		private System.Windows.Forms.Button OpenTodayLogButton;
		private System.Windows.Forms.Button OpenHostFile;
		private System.Windows.Forms.Button FTPBrowserButton;
		private System.Windows.Forms.Button FTPClientButton;
		private System.Windows.Forms.Button HttpCheckButton;
		private System.Windows.Forms.Button HttpsCheckButton;
		private System.Windows.Forms.TextBox HttpsCheckPortTextBox;
		private System.Windows.Forms.TextBox HttpCheckPortTextBox;
		private System.Windows.Forms.GroupBox MachineCheckGroupBox;
		private System.Windows.Forms.TextBox ScreenShotPrefixTextBox;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.ListBox LogFiles;
		private System.Windows.Forms.ListBox LogFolders;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button OneWordPerLineButton;
		private System.Windows.Forms.RichTextBox ProcessTextRTB2;
		private System.Windows.Forms.RichTextBox ProcessTextRTB1;
		private System.Windows.Forms.Button ToOneLineButton;
		private System.Windows.Forms.TabPage ProcessTextTab;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label LogsPathLabel;
		private System.Windows.Forms.TextBox LogsPathTextBox;
		private System.Windows.Forms.TabPage LogsTAB;
		private System.Windows.Forms.Button NewTextLogButton;
		private System.Windows.Forms.Button CopyLogPathButton;
		private System.Windows.Forms.Button RefreshLogsButton;
		private System.Windows.Forms.Button RefreshHostButton;
		private System.Windows.Forms.Button ScreenShotSaveButton;
		private System.Windows.Forms.TextBox ScreenShotDirectory;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TreeView ClipRingTreeView;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.RadioButton OpenInIERadioButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton OpenInFireFoxRadioButton;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.RadioButton OpenInEmbeddedIERadioButton;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox IPAddressTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox IPAddressTextBox2;
		private System.Windows.Forms.TextBox IPAddressTextBox3;
		private System.Windows.Forms.TextBox IPAddressTextBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage AddHostDetailsTab;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button FormatXMLButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label ProcessTextFixLabel;
        private System.Windows.Forms.TextBox ProcessTextFixTextBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem fileSplitterToolStripMenuItem;
        private System.Windows.Forms.GroupBox ScreenCaptureModeGroupBox;
        private System.Windows.Forms.RadioButton Screenshot_ActiveWindowCapture_RadioButton;
        private System.Windows.Forms.RadioButton Screenshot_SnipCapture_RadioButton;
        private System.Windows.Forms.RadioButton Screenshot_ScreenCapture_RadioButton;
        private System.Windows.Forms.NotifyIcon MainNotifyIcon;
        private System.Windows.Forms.Button DecodeGZipBase64Buttonn2;
        private System.Windows.Forms.Button EncodeGZipBase64Button;
        private System.Windows.Forms.Button DecodeBase64Button;
        private System.Windows.Forms.Button EncodeBase64Button;
        private System.Windows.Forms.CheckBox UseHTTPSForAppLinksCheckbox;
    }
}
