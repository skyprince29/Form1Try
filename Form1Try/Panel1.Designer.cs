namespace Form1Try
{
    partial class Panel1
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
            this.paneltb = new System.Windows.Forms.TextBox();
            this.panelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paneltb
            // 
            this.paneltb.Location = new System.Drawing.Point(59, 32);
            this.paneltb.Name = "paneltb";
            this.paneltb.Size = new System.Drawing.Size(150, 20);
            this.paneltb.TabIndex = 7;
            this.paneltb.TextChanged += new System.EventHandler(this.paneltb_TextChanged);
            // 
            // panelbtn
            // 
            this.panelbtn.Location = new System.Drawing.Point(84, 58);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(102, 23);
            this.panelbtn.TabIndex = 6;
            this.panelbtn.Text = "Show Form 2";
            this.panelbtn.UseVisualStyleBackColor = true;
            this.panelbtn.Click += new System.EventHandler(this.panelbtn_Click);
            // 
            // Panel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.paneltb);
            this.Controls.Add(this.panelbtn);
            this.Name = "Panel1";
            this.Size = new System.Drawing.Size(268, 117);
            this.Load += new System.EventHandler(this.Panel1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paneltb;
        private System.Windows.Forms.Button panelbtn;
    }
}
