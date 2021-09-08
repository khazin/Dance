namespace Dance
{
    partial class ViewUser
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
            this.components = new System.ComponentModel.Container();
            this.lnameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewBtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.fnameTxt = new System.Windows.Forms.TextBox();
            this.usridTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.unameTxt = new System.Windows.Forms.TextBox();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.danceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleTxt = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusTxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danceDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lnameTxt
            // 
            this.lnameTxt.Location = new System.Drawing.Point(179, 158);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(121, 26);
            this.lnameTxt.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "User ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(833, 240);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(860, 336);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(89, 32);
            this.viewBtn.TabIndex = 18;
            this.viewBtn.Text = "view";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Enabled = false;
            this.updatebtn.Location = new System.Drawing.Point(757, 336);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(77, 32);
            this.updatebtn.TabIndex = 17;
            this.updatebtn.Text = "update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(649, 336);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 32);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(536, 336);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(89, 32);
            this.insertBtn.TabIndex = 15;
            this.insertBtn.Text = "insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // fnameTxt
            // 
            this.fnameTxt.Location = new System.Drawing.Point(179, 107);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(121, 26);
            this.fnameTxt.TabIndex = 14;
            // 
            // usridTxt
            // 
            this.usridTxt.Location = new System.Drawing.Point(179, 49);
            this.usridTxt.Name = "usridTxt";
            this.usridTxt.ReadOnly = true;
            this.usridTxt.Size = new System.Drawing.Size(121, 26);
            this.usridTxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Email";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(179, 213);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(121, 26);
            this.emailTxt.TabIndex = 24;
            // 
            // unameTxt
            // 
            this.unameTxt.Location = new System.Drawing.Point(179, 342);
            this.unameTxt.Name = "unameTxt";
            this.unameTxt.Size = new System.Drawing.Size(128, 26);
            this.unameTxt.TabIndex = 26;
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(179, 385);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '*';
            this.pwdTxt.Size = new System.Drawing.Size(128, 26);
            this.pwdTxt.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Password";
            // 
            // roleTxt
            // 
            this.roleTxt.Enabled = false;
            this.roleTxt.FormattingEnabled = true;
            this.roleTxt.Items.AddRange(new object[] {
            "admin",
            "instructor",
            "pupil"});
            this.roleTxt.Location = new System.Drawing.Point(179, 260);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(121, 28);
            this.roleTxt.TabIndex = 30;
            this.roleTxt.Text = "instructor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Status";
            // 
            // statusTxt
            // 
            this.statusTxt.Enabled = false;
            this.statusTxt.FormattingEnabled = true;
            this.statusTxt.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.statusTxt.Location = new System.Drawing.Point(179, 440);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(128, 28);
            this.statusTxt.TabIndex = 33;
            this.statusTxt.Text = "active";
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 571);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.roleTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pwdTxt);
            this.Controls.Add(this.unameTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.fnameTxt);
            this.Controls.Add(this.usridTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewUser";
            this.Text = "ViewUser";
            this.Click += new System.EventHandler(this.ViewUser_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danceDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lnameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.TextBox fnameTxt;
        private System.Windows.Forms.TextBox usridTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox unameTxt;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource danceDataSetBindingSource;
        private System.Windows.Forms.ComboBox roleTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox statusTxt;
    }
}