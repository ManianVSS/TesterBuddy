/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 04-Nov-16
 * Time: 12:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TesterBuddy
{
	partial class FileSplitter
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.OpenFileDialog OpenFileDialog;
		private System.Windows.Forms.Button SplitFileButton;
		private System.Windows.Forms.TextBox SplitSourceFileNameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SizeTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BrowseFileButton;
		
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
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SplitFileButton = new System.Windows.Forms.Button();
			this.SplitSourceFileNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SizeTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BrowseFileButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// OpenFileDialog
			// 
			this.OpenFileDialog.FileName = "*.*";
			this.OpenFileDialog.Filter = "\"All Files|*.*\"";
			// 
			// SplitFileButton
			// 
			this.SplitFileButton.Location = new System.Drawing.Point(241, 71);
			this.SplitFileButton.Name = "SplitFileButton";
			this.SplitFileButton.Size = new System.Drawing.Size(100, 23);
			this.SplitFileButton.TabIndex = 0;
			this.SplitFileButton.Text = "Split File (bytes)";
			this.SplitFileButton.UseVisualStyleBackColor = true;
			this.SplitFileButton.Click += new System.EventHandler(this.SplitFileButtonClick);
			// 
			// SplitSourceFileNameTextBox
			// 
			this.SplitSourceFileNameTextBox.Location = new System.Drawing.Point(109, 31);
			this.SplitSourceFileNameTextBox.Name = "SplitSourceFileNameTextBox";
			this.SplitSourceFileNameTextBox.Size = new System.Drawing.Size(338, 20);
			this.SplitSourceFileNameTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "File to split:";
			// 
			// SizeTextBox
			// 
			this.SizeTextBox.Location = new System.Drawing.Point(109, 73);
			this.SizeTextBox.Name = "SizeTextBox";
			this.SizeTextBox.Size = new System.Drawing.Size(89, 20);
			this.SizeTextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Split size bytes:";
			// 
			// BrowseFileButton
			// 
			this.BrowseFileButton.Location = new System.Drawing.Point(465, 31);
			this.BrowseFileButton.Name = "BrowseFileButton";
			this.BrowseFileButton.Size = new System.Drawing.Size(33, 23);
			this.BrowseFileButton.TabIndex = 5;
			this.BrowseFileButton.Text = "...";
			this.BrowseFileButton.UseVisualStyleBackColor = true;
			this.BrowseFileButton.Click += new System.EventHandler(this.BrowseFileButtonClick);
			// 
			// FileSplitter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 113);
			this.Controls.Add(this.BrowseFileButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SizeTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SplitSourceFileNameTextBox);
			this.Controls.Add(this.SplitFileButton);
			this.Name = "FileSplitter";
			this.Text = "FileSplitter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
