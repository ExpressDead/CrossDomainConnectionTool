namespace CrossDomainConnectionTool
{
    partial class CDToolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDToolForm));
            this.domainTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domainTxt
            // 
            this.domainTxt.Location = new System.Drawing.Point(12, 12);
            this.domainTxt.Name = "domainTxt";
            this.domainTxt.Size = new System.Drawing.Size(213, 20);
            this.domainTxt.TabIndex = 0;
            this.domainTxt.Text = "Enter Domain Name";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(12, 38);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(213, 20);
            this.userTxt.TabIndex = 1;
            this.userTxt.Text = "Enter User Name";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(150, 64);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // CDToolForm
            // 
            this.AcceptButton = this.connectBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 99);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.domainTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CDToolForm";
            this.Text = "Cross Connect Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox domainTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Button connectBtn;
    }
}

