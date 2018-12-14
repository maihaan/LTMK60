namespace TCPClient
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTinNhan = new System.Windows.Forms.TextBox();
            this.tbNoiDung = new System.Windows.Forms.TextBox();
            this.btGui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTinNhan
            // 
            this.tbTinNhan.Location = new System.Drawing.Point(13, 13);
            this.tbTinNhan.Multiline = true;
            this.tbTinNhan.Name = "tbTinNhan";
            this.tbTinNhan.ReadOnly = true;
            this.tbTinNhan.Size = new System.Drawing.Size(291, 285);
            this.tbTinNhan.TabIndex = 0;
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.Location = new System.Drawing.Point(13, 304);
            this.tbNoiDung.Multiline = true;
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.Size = new System.Drawing.Size(225, 46);
            this.tbNoiDung.TabIndex = 1;
            // 
            // btGui
            // 
            this.btGui.Location = new System.Drawing.Point(244, 304);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(60, 46);
            this.btGui.TabIndex = 2;
            this.btGui.Text = "Send";
            this.btGui.UseVisualStyleBackColor = true;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 362);
            this.Controls.Add(this.btGui);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.tbTinNhan);
            this.Name = "Form1";
            this.Text = "TCP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTinNhan;
        private System.Windows.Forms.TextBox tbNoiDung;
        private System.Windows.Forms.Button btGui;
    }
}

