
namespace StorageAndTrade
{
	partial class DirectoryControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.textBoxControl = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxControl
            // 
            this.textBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxControl.BackColor = System.Drawing.Color.White;
            this.textBoxControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxControl.Location = new System.Drawing.Point(0, 2);
            this.textBoxControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxControl.Name = "textBoxControl";
            this.textBoxControl.ReadOnly = true;
            this.textBoxControl.Size = new System.Drawing.Size(334, 23);
            this.textBoxControl.TabIndex = 0;
            this.textBoxControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxControl_KeyDown);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Location = new System.Drawing.Point(338, 2);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(28, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "..";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFind.Enabled = false;
            this.buttonFind.Location = new System.Drawing.Point(369, 2);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(28, 23);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "f";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // DirectoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxControl);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DirectoryControl";
            this.Size = new System.Drawing.Size(398, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxControl;
		private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonFind;
    }
}
