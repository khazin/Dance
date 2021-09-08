namespace Dance
{
    partial class Login
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
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.usrnameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Location = new System.Drawing.Point(35, 294);
            this.registerLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(137, 20);
            this.registerLink.TabIndex = 14;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Register new user";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(190, 182);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(150, 35);
            this.loginBtn.TabIndex = 13;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(190, 111);
            this.pwdTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '*';
            this.pwdTxt.Size = new System.Drawing.Size(148, 26);
            this.pwdTxt.TabIndex = 12;
            // 
            // usrnameTxt
            // 
            this.usrnameTxt.Location = new System.Drawing.Point(190, 51);
            this.usrnameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usrnameTxt.Name = "usrnameTxt";
            this.usrnameTxt.Size = new System.Drawing.Size(148, 26);
            this.usrnameTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pwdTxt);
            this.Controls.Add(this.usrnameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.TextBox usrnameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

