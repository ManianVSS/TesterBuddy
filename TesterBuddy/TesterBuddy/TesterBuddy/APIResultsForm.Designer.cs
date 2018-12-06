/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 8/9/2014
 * Time: 11:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TesterBuddy
{
	partial class APIResultsForm
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
			this.APIResults_FirstSplitContainer = new System.Windows.Forms.SplitContainer();
			this.APIResults_SubSplitContainer = new System.Windows.Forms.SplitContainer();
			this.APIResults_APIInputTextBox = new System.Windows.Forms.TextBox();
			this.APIResults_APITemplateTextBox = new System.Windows.Forms.TextBox();
			this.APIResults_APIOutputTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.APIResults_FirstSplitContainer)).BeginInit();
			this.APIResults_FirstSplitContainer.Panel1.SuspendLayout();
			this.APIResults_FirstSplitContainer.Panel2.SuspendLayout();
			this.APIResults_FirstSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.APIResults_SubSplitContainer)).BeginInit();
			this.APIResults_SubSplitContainer.Panel1.SuspendLayout();
			this.APIResults_SubSplitContainer.Panel2.SuspendLayout();
			this.APIResults_SubSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// APIResults_FirstSplitContainer
			// 
			this.APIResults_FirstSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.APIResults_FirstSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.APIResults_FirstSplitContainer.Name = "APIResults_FirstSplitContainer";
			// 
			// APIResults_FirstSplitContainer.Panel1
			// 
			this.APIResults_FirstSplitContainer.Panel1.Controls.Add(this.APIResults_SubSplitContainer);
			// 
			// APIResults_FirstSplitContainer.Panel2
			// 
			this.APIResults_FirstSplitContainer.Panel2.Controls.Add(this.APIResults_APIOutputTextBox);
			this.APIResults_FirstSplitContainer.Size = new System.Drawing.Size(725, 404);
			this.APIResults_FirstSplitContainer.SplitterDistance = 241;
			this.APIResults_FirstSplitContainer.TabIndex = 0;
			// 
			// APIResults_SubSplitContainer
			// 
			this.APIResults_SubSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.APIResults_SubSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.APIResults_SubSplitContainer.Name = "APIResults_SubSplitContainer";
			this.APIResults_SubSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// APIResults_SubSplitContainer.Panel1
			// 
			this.APIResults_SubSplitContainer.Panel1.Controls.Add(this.APIResults_APIInputTextBox);
			// 
			// APIResults_SubSplitContainer.Panel2
			// 
			this.APIResults_SubSplitContainer.Panel2.Controls.Add(this.APIResults_APITemplateTextBox);
			this.APIResults_SubSplitContainer.Size = new System.Drawing.Size(241, 404);
			this.APIResults_SubSplitContainer.SplitterDistance = 274;
			this.APIResults_SubSplitContainer.TabIndex = 0;
			// 
			// APIResults_APIInputTextBox
			// 
			this.APIResults_APIInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.APIResults_APIInputTextBox.Location = new System.Drawing.Point(0, 0);
			this.APIResults_APIInputTextBox.Multiline = true;
			this.APIResults_APIInputTextBox.Name = "APIResults_APIInputTextBox";
			this.APIResults_APIInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.APIResults_APIInputTextBox.Size = new System.Drawing.Size(241, 274);
			this.APIResults_APIInputTextBox.TabIndex = 0;
			this.APIResults_APIInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.APIResults_APIInputTextBoxKeyDown);
			// 
			// APIResults_APITemplateTextBox
			// 
			this.APIResults_APITemplateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.APIResults_APITemplateTextBox.Location = new System.Drawing.Point(0, 0);
			this.APIResults_APITemplateTextBox.Multiline = true;
			this.APIResults_APITemplateTextBox.Name = "APIResults_APITemplateTextBox";
			this.APIResults_APITemplateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.APIResults_APITemplateTextBox.Size = new System.Drawing.Size(241, 126);
			this.APIResults_APITemplateTextBox.TabIndex = 1;
			this.APIResults_APITemplateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.APIResults_APITemplateTextBoxKeyDown);
			// 
			// APIResults_APIOutputTextBox
			// 
			this.APIResults_APIOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.APIResults_APIOutputTextBox.Location = new System.Drawing.Point(0, 0);
			this.APIResults_APIOutputTextBox.Multiline = true;
			this.APIResults_APIOutputTextBox.Name = "APIResults_APIOutputTextBox";
			this.APIResults_APIOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.APIResults_APIOutputTextBox.Size = new System.Drawing.Size(480, 404);
			this.APIResults_APIOutputTextBox.TabIndex = 1;
			this.APIResults_APIOutputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.APIResults_APIOutputTextBoxKeyDown);
			// 
			// APIResultsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 404);
			this.Controls.Add(this.APIResults_FirstSplitContainer);
			this.Name = "APIResultsForm";
			this.Text = "APIResultsForm";
			this.APIResults_FirstSplitContainer.Panel1.ResumeLayout(false);
			this.APIResults_FirstSplitContainer.Panel2.ResumeLayout(false);
			this.APIResults_FirstSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.APIResults_FirstSplitContainer)).EndInit();
			this.APIResults_FirstSplitContainer.ResumeLayout(false);
			this.APIResults_SubSplitContainer.Panel1.ResumeLayout(false);
			this.APIResults_SubSplitContainer.Panel1.PerformLayout();
			this.APIResults_SubSplitContainer.Panel2.ResumeLayout(false);
			this.APIResults_SubSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.APIResults_SubSplitContainer)).EndInit();
			this.APIResults_SubSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox APIResults_APIOutputTextBox;
		private System.Windows.Forms.TextBox APIResults_APITemplateTextBox;
		private System.Windows.Forms.TextBox APIResults_APIInputTextBox;
		private System.Windows.Forms.SplitContainer APIResults_SubSplitContainer;
		private System.Windows.Forms.SplitContainer APIResults_FirstSplitContainer;
	}
}
