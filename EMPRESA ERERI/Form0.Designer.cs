namespace EMPRESA_ERERI
{
    partial class Form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            this.button1 = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(408, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(440, 262);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(216, 20);
            this.txtuser.TabIndex = 1;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(440, 326);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(216, 20);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(877, 540);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.button1);
            this.Name = "Form0";
            this.Text = "Form0";
            this.Load += new System.EventHandler(this.Form0_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpassword;
    }
}