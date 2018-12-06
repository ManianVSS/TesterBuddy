/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 15/3/2015
 * Time: 10:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TesterBuddy
{
	partial class EditClientPropertiesForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox ClientPropertyValueTextBox;
		private System.Windows.Forms.TextBox ClientPropertyNameTextBox;
		private System.Windows.Forms.Label label_PValue;
		private System.Windows.Forms.Label label_PName;
		private System.Windows.Forms.ListBox ClientPropertiesListBox;
		private System.Windows.Forms.Button PropertyAddButton;
		private System.Windows.Forms.Button PropertyRemoveButton;
		private System.Windows.Forms.Button PropertySetButton;
		
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
			this.ClientPropertyValueTextBox = new System.Windows.Forms.TextBox();
			this.ClientPropertyNameTextBox = new System.Windows.Forms.TextBox();
			this.label_PValue = new System.Windows.Forms.Label();
			this.label_PName = new System.Windows.Forms.Label();
			this.ClientPropertiesListBox = new System.Windows.Forms.ListBox();
			this.PropertyAddButton = new System.Windows.Forms.Button();
			this.PropertyRemoveButton = new System.Windows.Forms.Button();
			this.PropertySetButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ClientPropertyValueTextBox
			// 
			this.ClientPropertyValueTextBox.Location = new System.Drawing.Point(110, 35);
			this.ClientPropertyValueTextBox.Name = "ClientPropertyValueTextBox";
			this.ClientPropertyValueTextBox.Size = new System.Drawing.Size(380, 20);
			this.ClientPropertyValueTextBox.TabIndex = 7;
			// 
			// ClientPropertyNameTextBox
			// 
			this.ClientPropertyNameTextBox.Location = new System.Drawing.Point(110, 12);
			this.ClientPropertyNameTextBox.Name = "ClientPropertyNameTextBox";
			this.ClientPropertyNameTextBox.Size = new System.Drawing.Size(380, 20);
			this.ClientPropertyNameTextBox.TabIndex = 6;
			// 
			// label_PValue
			// 
			this.label_PValue.Location = new System.Drawing.Point(18, 35);
			this.label_PValue.Name = "label_PValue";
			this.label_PValue.Size = new System.Drawing.Size(85, 23);
			this.label_PValue.TabIndex = 5;
			this.label_PValue.Text = "Property Value:";
			// 
			// label_PName
			// 
			this.label_PName.Location = new System.Drawing.Point(18, 12);
			this.label_PName.Name = "label_PName";
			this.label_PName.Size = new System.Drawing.Size(85, 23);
			this.label_PName.TabIndex = 4;
			this.label_PName.Text = "Property Name:";
			// 
			// ClientPropertiesListBox
			// 
			this.ClientPropertiesListBox.FormattingEnabled = true;
			this.ClientPropertiesListBox.Location = new System.Drawing.Point(18, 61);
			this.ClientPropertiesListBox.Name = "ClientPropertiesListBox";
			this.ClientPropertiesListBox.Size = new System.Drawing.Size(472, 238);
			this.ClientPropertiesListBox.TabIndex = 8;
			// 
			// PropertyAddButton
			// 
			this.PropertyAddButton.Location = new System.Drawing.Point(515, 12);
			this.PropertyAddButton.Name = "PropertyAddButton";
			this.PropertyAddButton.Size = new System.Drawing.Size(75, 23);
			this.PropertyAddButton.TabIndex = 9;
			this.PropertyAddButton.Text = "Add";
			this.PropertyAddButton.UseVisualStyleBackColor = true;
			this.PropertyAddButton.Click += new System.EventHandler(this.PropertyAddButtonClick);
			// 
			// PropertyRemoveButton
			// 
			this.PropertyRemoveButton.Location = new System.Drawing.Point(515, 41);
			this.PropertyRemoveButton.Name = "PropertyRemoveButton";
			this.PropertyRemoveButton.Size = new System.Drawing.Size(75, 23);
			this.PropertyRemoveButton.TabIndex = 10;
			this.PropertyRemoveButton.Text = "Remove";
			this.PropertyRemoveButton.UseVisualStyleBackColor = true;
			this.PropertyRemoveButton.Click += new System.EventHandler(this.PropertyRemoveButtonClick);
			// 
			// PropertySetButton
			// 
			this.PropertySetButton.Location = new System.Drawing.Point(515, 70);
			this.PropertySetButton.Name = "PropertySetButton";
			this.PropertySetButton.Size = new System.Drawing.Size(75, 23);
			this.PropertySetButton.TabIndex = 11;
			this.PropertySetButton.Text = "Set";
			this.PropertySetButton.UseVisualStyleBackColor = true;
			this.PropertySetButton.Click += new System.EventHandler(this.PropertySetButtonClick);
			// 
			// EditClientPropertiesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 311);
			this.Controls.Add(this.PropertySetButton);
			this.Controls.Add(this.PropertyRemoveButton);
			this.Controls.Add(this.PropertyAddButton);
			this.Controls.Add(this.ClientPropertiesListBox);
			this.Controls.Add(this.ClientPropertyValueTextBox);
			this.Controls.Add(this.ClientPropertyNameTextBox);
			this.Controls.Add(this.label_PValue);
			this.Controls.Add(this.label_PName);
			this.Name = "EditClientPropertiesForm";
			this.Text = "EditClientPropertiesForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
