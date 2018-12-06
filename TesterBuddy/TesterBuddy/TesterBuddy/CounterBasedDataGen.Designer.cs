/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 4/1/2015
 * Time: 11:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TesterBuddy
{
	partial class CounterBasedDataGen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterBasedDataGen));
			this.DataGenMenuStrip = new System.Windows.Forms.MenuStrip();
			this.DataGenMainSplitContiner = new System.Windows.Forms.SplitContainer();
			this.FormatXMLButton = new System.Windows.Forms.Button();
			this.GenerateDataFile_Button = new System.Windows.Forms.Button();
			this.LoadTempalte_Button = new System.Windows.Forms.Button();
			this.SaveTemplate_Button = new System.Windows.Forms.Button();
			this.DataGenerateSubSplitContainer = new System.Windows.Forms.SplitContainer();
			this.Template_TextBox = new System.Windows.Forms.TextBox();
			this.DataGenerateProgressBar = new System.Windows.Forms.ProgressBar();
			this.OpenTemplateFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SaveTemplateFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.SaveDataFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.EscapeSelectedXMLStringButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DataGenMainSplitContiner)).BeginInit();
			this.DataGenMainSplitContiner.Panel1.SuspendLayout();
			this.DataGenMainSplitContiner.Panel2.SuspendLayout();
			this.DataGenMainSplitContiner.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGenerateSubSplitContainer)).BeginInit();
			this.DataGenerateSubSplitContainer.Panel1.SuspendLayout();
			this.DataGenerateSubSplitContainer.Panel2.SuspendLayout();
			this.DataGenerateSubSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// DataGenMenuStrip
			// 
			this.DataGenMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.DataGenMenuStrip.Name = "DataGenMenuStrip";
			this.DataGenMenuStrip.Size = new System.Drawing.Size(704, 24);
			this.DataGenMenuStrip.TabIndex = 1;
			this.DataGenMenuStrip.Text = "Data Generate Menu Strip";
			// 
			// DataGenMainSplitContiner
			// 
			this.DataGenMainSplitContiner.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGenMainSplitContiner.Location = new System.Drawing.Point(0, 24);
			this.DataGenMainSplitContiner.Name = "DataGenMainSplitContiner";
			this.DataGenMainSplitContiner.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// DataGenMainSplitContiner.Panel1
			// 
			this.DataGenMainSplitContiner.Panel1.Controls.Add(this.EscapeSelectedXMLStringButton);
			this.DataGenMainSplitContiner.Panel1.Controls.Add(this.FormatXMLButton);
			this.DataGenMainSplitContiner.Panel1.Controls.Add(this.GenerateDataFile_Button);
			this.DataGenMainSplitContiner.Panel1.Controls.Add(this.LoadTempalte_Button);
			this.DataGenMainSplitContiner.Panel1.Controls.Add(this.SaveTemplate_Button);
			// 
			// DataGenMainSplitContiner.Panel2
			// 
			this.DataGenMainSplitContiner.Panel2.Controls.Add(this.DataGenerateSubSplitContainer);
			this.DataGenMainSplitContiner.Size = new System.Drawing.Size(704, 364);
			this.DataGenMainSplitContiner.SplitterDistance = 29;
			this.DataGenMainSplitContiner.TabIndex = 2;
			// 
			// FormatXMLButton
			// 
			this.FormatXMLButton.Location = new System.Drawing.Point(217, 4);
			this.FormatXMLButton.Name = "FormatXMLButton";
			this.FormatXMLButton.Size = new System.Drawing.Size(95, 23);
			this.FormatXMLButton.TabIndex = 3;
			this.FormatXMLButton.Text = "Format XML";
			this.FormatXMLButton.UseVisualStyleBackColor = true;
			this.FormatXMLButton.Click += new System.EventHandler(this.FormatXMLButtonClick);
			// 
			// GenerateDataFile_Button
			// 
			this.GenerateDataFile_Button.Location = new System.Drawing.Point(580, 3);
			this.GenerateDataFile_Button.Name = "GenerateDataFile_Button";
			this.GenerateDataFile_Button.Size = new System.Drawing.Size(112, 23);
			this.GenerateDataFile_Button.TabIndex = 2;
			this.GenerateDataFile_Button.Text = "Generate Data File";
			this.GenerateDataFile_Button.UseVisualStyleBackColor = true;
			this.GenerateDataFile_Button.Click += new System.EventHandler(this.GenerateDataFile_ButtonClick);
			// 
			// LoadTempalte_Button
			// 
			this.LoadTempalte_Button.Location = new System.Drawing.Point(116, 3);
			this.LoadTempalte_Button.Name = "LoadTempalte_Button";
			this.LoadTempalte_Button.Size = new System.Drawing.Size(95, 23);
			this.LoadTempalte_Button.TabIndex = 1;
			this.LoadTempalte_Button.Text = "Load Template";
			this.LoadTempalte_Button.UseVisualStyleBackColor = true;
			this.LoadTempalte_Button.Click += new System.EventHandler(this.LoadTempalte_ButtonClick);
			// 
			// SaveTemplate_Button
			// 
			this.SaveTemplate_Button.Location = new System.Drawing.Point(15, 3);
			this.SaveTemplate_Button.Name = "SaveTemplate_Button";
			this.SaveTemplate_Button.Size = new System.Drawing.Size(95, 23);
			this.SaveTemplate_Button.TabIndex = 0;
			this.SaveTemplate_Button.Text = "Save Template";
			this.SaveTemplate_Button.UseVisualStyleBackColor = true;
			this.SaveTemplate_Button.Click += new System.EventHandler(this.SaveTemplate_ButtonClick);
			// 
			// DataGenerateSubSplitContainer
			// 
			this.DataGenerateSubSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGenerateSubSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.DataGenerateSubSplitContainer.Name = "DataGenerateSubSplitContainer";
			this.DataGenerateSubSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// DataGenerateSubSplitContainer.Panel1
			// 
			this.DataGenerateSubSplitContainer.Panel1.Controls.Add(this.Template_TextBox);
			// 
			// DataGenerateSubSplitContainer.Panel2
			// 
			this.DataGenerateSubSplitContainer.Panel2.Controls.Add(this.DataGenerateProgressBar);
			this.DataGenerateSubSplitContainer.Size = new System.Drawing.Size(704, 331);
			this.DataGenerateSubSplitContainer.SplitterDistance = 302;
			this.DataGenerateSubSplitContainer.TabIndex = 1;
			// 
			// Template_TextBox
			// 
			this.Template_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Template_TextBox.Location = new System.Drawing.Point(0, 0);
			this.Template_TextBox.Multiline = true;
			this.Template_TextBox.Name = "Template_TextBox";
			this.Template_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Template_TextBox.Size = new System.Drawing.Size(704, 302);
			this.Template_TextBox.TabIndex = 0;
			this.Template_TextBox.Text = resources.GetString("Template_TextBox.Text");
			this.Template_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Template_TextBoxKeyDown);
			// 
			// DataGenerateProgressBar
			// 
			this.DataGenerateProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGenerateProgressBar.Location = new System.Drawing.Point(0, 0);
			this.DataGenerateProgressBar.Name = "DataGenerateProgressBar";
			this.DataGenerateProgressBar.Size = new System.Drawing.Size(704, 25);
			this.DataGenerateProgressBar.TabIndex = 0;
			// 
			// OpenTemplateFileDialog
			// 
			this.OpenTemplateFileDialog.FileName = "*.template.xml";
			this.OpenTemplateFileDialog.Filter = "\"Template xml File (*.template.xml)|*.template.xml|All files (*.*)|*.*\"";
			// 
			// SaveTemplateFileDialog
			// 
			this.SaveTemplateFileDialog.Filter = "\"Template xml File (*.template.xml)|*.template.xml|All files (*.*)|*.*\"";
			// 
			// SaveDataFileDialog
			// 
			this.SaveDataFileDialog.Filter = "\"Data File (*.dat)|*.dat|All files (*.*)|*.*\"";
			// 
			// EscapeSelectedXMLStringButton
			// 
			this.EscapeSelectedXMLStringButton.Location = new System.Drawing.Point(318, 4);
			this.EscapeSelectedXMLStringButton.Name = "EscapeSelectedXMLStringButton";
			this.EscapeSelectedXMLStringButton.Size = new System.Drawing.Size(153, 23);
			this.EscapeSelectedXMLStringButton.TabIndex = 4;
			this.EscapeSelectedXMLStringButton.Text = "Escape selected XML string";
			this.EscapeSelectedXMLStringButton.UseVisualStyleBackColor = true;
			this.EscapeSelectedXMLStringButton.Click += new System.EventHandler(this.EscapeSelectedXMLStringButtonClick);
			// 
			// CounterBasedDataGen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 388);
			this.Controls.Add(this.DataGenMainSplitContiner);
			this.Controls.Add(this.DataGenMenuStrip);
			this.MainMenuStrip = this.DataGenMenuStrip;
			this.Name = "CounterBasedDataGen";
			this.Text = "Data Generation";
			this.Resize += new System.EventHandler(this.CounterBasedDataGenResize);
			this.DataGenMainSplitContiner.Panel1.ResumeLayout(false);
			this.DataGenMainSplitContiner.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGenMainSplitContiner)).EndInit();
			this.DataGenMainSplitContiner.ResumeLayout(false);
			this.DataGenerateSubSplitContainer.Panel1.ResumeLayout(false);
			this.DataGenerateSubSplitContainer.Panel1.PerformLayout();
			this.DataGenerateSubSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGenerateSubSplitContainer)).EndInit();
			this.DataGenerateSubSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button EscapeSelectedXMLStringButton;
		private System.Windows.Forms.Button FormatXMLButton;
		private System.Windows.Forms.ProgressBar DataGenerateProgressBar;
		private System.Windows.Forms.SplitContainer DataGenerateSubSplitContainer;
		private System.Windows.Forms.SaveFileDialog SaveDataFileDialog;
		private System.Windows.Forms.SaveFileDialog SaveTemplateFileDialog;
		private System.Windows.Forms.OpenFileDialog OpenTemplateFileDialog;
		private System.Windows.Forms.TextBox Template_TextBox;
		private System.Windows.Forms.Button GenerateDataFile_Button;
		private System.Windows.Forms.Button LoadTempalte_Button;
		private System.Windows.Forms.Button SaveTemplate_Button;
		private System.Windows.Forms.SplitContainer DataGenMainSplitContiner;
		private System.Windows.Forms.MenuStrip DataGenMenuStrip;
	}
}
