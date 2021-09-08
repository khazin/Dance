namespace Dance
{
    partial class Menu
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
            this.Enroll = new System.Windows.Forms.Button();
            this.viewUser = new System.Windows.Forms.Button();
            this.viewClass = new System.Windows.Forms.Button();
            this.viewEnroll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enroll
            // 
            this.Enroll.Location = new System.Drawing.Point(309, 69);
            this.Enroll.Name = "Enroll";
            this.Enroll.Size = new System.Drawing.Size(186, 30);
            this.Enroll.TabIndex = 0;
            this.Enroll.Text = "Enroll dance class";
            this.Enroll.UseVisualStyleBackColor = true;
            this.Enroll.Click += new System.EventHandler(this.Enroll_Click);
            // 
            // viewUser
            // 
            this.viewUser.Location = new System.Drawing.Point(309, 132);
            this.viewUser.Name = "viewUser";
            this.viewUser.Size = new System.Drawing.Size(186, 30);
            this.viewUser.TabIndex = 1;
            this.viewUser.Text = "View User";
            this.viewUser.UseVisualStyleBackColor = true;
            this.viewUser.Click += new System.EventHandler(this.viewUser_Click);
            // 
            // viewClass
            // 
            this.viewClass.Location = new System.Drawing.Point(309, 197);
            this.viewClass.Name = "viewClass";
            this.viewClass.Size = new System.Drawing.Size(186, 30);
            this.viewClass.TabIndex = 2;
            this.viewClass.Text = "View Class";
            this.viewClass.UseVisualStyleBackColor = true;
            this.viewClass.Click += new System.EventHandler(this.viewClass_Click);
            // 
            // viewEnroll
            // 
            this.viewEnroll.Location = new System.Drawing.Point(309, 272);
            this.viewEnroll.Name = "viewEnroll";
            this.viewEnroll.Size = new System.Drawing.Size(186, 30);
            this.viewEnroll.TabIndex = 3;
            this.viewEnroll.Text = "View Enrollment";
            this.viewEnroll.UseVisualStyleBackColor = true;
            this.viewEnroll.Click += new System.EventHandler(this.viewEnroll_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewEnroll);
            this.Controls.Add(this.viewClass);
            this.Controls.Add(this.viewUser);
            this.Controls.Add(this.Enroll);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Enroll;
        private System.Windows.Forms.Button viewUser;
        private System.Windows.Forms.Button viewClass;
        private System.Windows.Forms.Button viewEnroll;
    }
}