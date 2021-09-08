namespace Dance
{
    partial class Enrollment
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
            this.unameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.enrollBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dclassCombo = new System.Windows.Forms.ComboBox();
            this.instructCombo = new System.Windows.Forms.ComboBox();
            this.venueCombo = new System.Windows.Forms.ComboBox();
            this.feesCombo = new System.Windows.Forms.ComboBox();
            this.enddateCombo = new System.Windows.Forms.ComboBox();
            this.startdateCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.danceDataSet1 = new Dance.danceDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.danceDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // unameTxt
            // 
            this.unameTxt.Enabled = false;
            this.unameTxt.Location = new System.Drawing.Point(252, 88);
            this.unameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unameTxt.Name = "unameTxt";
            this.unameTxt.Size = new System.Drawing.Size(148, 26);
            this.unameTxt.TabIndex = 37;
            this.unameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lnameTxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "End date";
            // 
            // enrollBtn
            // 
            this.enrollBtn.Location = new System.Drawing.Point(531, 363);
            this.enrollBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enrollBtn.Name = "enrollBtn";
            this.enrollBtn.Size = new System.Drawing.Size(150, 35);
            this.enrollBtn.TabIndex = 32;
            this.enrollBtn.Text = "Enroll";
            this.enrollBtn.UseVisualStyleBackColor = true;
            this.enrollBtn.Click += new System.EventHandler(this.enrollBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Venue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Instructor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Dance Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 378);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Fees";
            // 
            // dclassCombo
            // 
            this.dclassCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dclassCombo.FormattingEnabled = true;
            this.dclassCombo.Items.AddRange(new object[] {
            "jazz dance",
            "ballet",
            "tap dance",
            "hip-hop dance",
            "ballroom dance"});
            this.dclassCombo.Location = new System.Drawing.Point(249, 137);
            this.dclassCombo.Name = "dclassCombo";
            this.dclassCombo.Size = new System.Drawing.Size(148, 28);
            this.dclassCombo.TabIndex = 39;
            this.dclassCombo.DropDownClosed += new System.EventHandler(this.dclassCombo_DropDownClosed);
            // 
            // instructCombo
            // 
            this.instructCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructCombo.Enabled = false;
            this.instructCombo.FormattingEnabled = true;
            this.instructCombo.Items.AddRange(new object[] {
            "patrick",
            "bob",
            "sandy"});
            this.instructCombo.Location = new System.Drawing.Point(252, 184);
            this.instructCombo.Name = "instructCombo";
            this.instructCombo.Size = new System.Drawing.Size(148, 28);
            this.instructCombo.TabIndex = 40;
            // 
            // venueCombo
            // 
            this.venueCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.venueCombo.Enabled = false;
            this.venueCombo.FormattingEnabled = true;
            this.venueCombo.Items.AddRange(new object[] {
            "room 1",
            "room 2",
            "room 3"});
            this.venueCombo.Location = new System.Drawing.Point(253, 236);
            this.venueCombo.Name = "venueCombo";
            this.venueCombo.Size = new System.Drawing.Size(148, 28);
            this.venueCombo.TabIndex = 41;
            // 
            // feesCombo
            // 
            this.feesCombo.Enabled = false;
            this.feesCombo.FormattingEnabled = true;
            this.feesCombo.Location = new System.Drawing.Point(249, 370);
            this.feesCombo.Name = "feesCombo";
            this.feesCombo.Size = new System.Drawing.Size(148, 28);
            this.feesCombo.TabIndex = 42;
            // 
            // enddateCombo
            // 
            this.enddateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enddateCombo.FormattingEnabled = true;
            this.enddateCombo.Items.AddRange(new object[] {
            "november 2019",
            "december 2019",
            "january 2020",
            "february 2020"});
            this.enddateCombo.Location = new System.Drawing.Point(249, 326);
            this.enddateCombo.Name = "enddateCombo";
            this.enddateCombo.Size = new System.Drawing.Size(148, 28);
            this.enddateCombo.TabIndex = 43;
            // 
            // startdateCombo
            // 
            this.startdateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startdateCombo.FormattingEnabled = true;
            this.startdateCombo.Items.AddRange(new object[] {
            "october 2019",
            "november 2019",
            "december 2019"});
            this.startdateCombo.Location = new System.Drawing.Point(250, 282);
            this.startdateCombo.Name = "startdateCombo";
            this.startdateCombo.Size = new System.Drawing.Size(148, 28);
            this.startdateCombo.TabIndex = 45;
            this.startdateCombo.DropDownClosed += new System.EventHandler(this.startdateCombo_DropDownClosed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 290);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Start date";
            // 
            // danceDataSet1
            // 
            this.danceDataSet1.DataSetName = "danceDataSet";
            this.danceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startdateCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.enddateCombo);
            this.Controls.Add(this.feesCombo);
            this.Controls.Add(this.venueCombo);
            this.Controls.Add(this.instructCombo);
            this.Controls.Add(this.dclassCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unameTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enrollBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Enrollment";
            this.Text = "Enrollment";
            this.Load += new System.EventHandler(this.Enrollment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danceDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button enrollBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dclassCombo;
        private System.Windows.Forms.ComboBox instructCombo;
        private System.Windows.Forms.ComboBox venueCombo;
        private System.Windows.Forms.ComboBox feesCombo;
        private System.Windows.Forms.ComboBox enddateCombo;
        private System.Windows.Forms.ComboBox startdateCombo;
        private System.Windows.Forms.Label label8;
        private danceDataSet danceDataSet1;
    }
}