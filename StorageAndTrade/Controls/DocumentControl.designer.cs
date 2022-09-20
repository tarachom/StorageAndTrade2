
namespace StorageAndTrade
{
	partial class DocumentControl
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxControl
            // 
            this.textBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxControl.BackColor = System.Drawing.Color.White;
            this.textBoxControl.Location = new System.Drawing.Point(0, 2);
            this.textBoxControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxControl.Name = "textBoxControl";
            this.textBoxControl.ReadOnly = true;
            this.textBoxControl.Size = new System.Drawing.Size(318, 23);
            this.textBoxControl.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Location = new System.Drawing.Point(321, 2);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(37, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(360, 2);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(37, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "X";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // DocumentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxControl);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DocumentControl";
            this.Size = new System.Drawing.Size(398, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxControl;
		private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonClear;
    }
}
