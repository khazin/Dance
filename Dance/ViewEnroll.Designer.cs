namespace Dance
{
    partial class ViewEnroll
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
            this.instructTxt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.danceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewBtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.usridTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.feesTxt = new System.Windows.Forms.TextBox();
            this.venueTxt = new System.Windows.Forms.ComboBox();
            this.dclassTxt = new System.Windows.Forms.ComboBox();
            this.startdateTxt = new System.Windows.Forms.ComboBox();
            this.enddateTxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.danceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // instructTxt
            // 
            this.instructTxt.FormattingEnabled = true;
            this.instructTxt.Items.AddRange(new object[] {
            "patrick",
            "bob",
            "sandy"});
            this.instructTxt.Location = new System.Drawing.Point(426, 349);
            this.instructTxt.Name = "instructTxt";
            this.instructTxt.Size = new System.Drawing.Size(127, 28);
            this.instructTxt.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "start date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Venue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Instructor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(906, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Dance Class";
            // 
            // unameTxt
            // 
            this.unameTxt.Location = new System.Drawing.Point(722, 286);
            this.unameTxt.Name = "unameTxt";
            this.unameTxt.Size = new System.Drawing.Size(127, 26);
            this.unameTxt.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 240);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(29, 286);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(89, 32);
            this.viewBtn.TabIndex = 38;
            this.viewBtn.Text = "view";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(168, 286);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(77, 32);
            this.updatebtn.TabIndex = 37;
            this.updatebtn.Text = "update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(18, 363);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 32);
            this.deleteBtn.TabIndex = 36;
            this.deleteBtn.Text = "delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // usridTxt
            // 
            this.usridTxt.Location = new System.Drawing.Point(426, 284);
            this.usridTxt.Name = "usridTxt";
            this.usridTxt.Size = new System.Drawing.Size(127, 26);
            this.usridTxt.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(905, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "fees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "end date";
            // 
            // feesTxt
            // 
            this.feesTxt.Location = new System.Drawing.Point(1042, 357);
            this.feesTxt.Name = "feesTxt";
            this.feesTxt.Size = new System.Drawing.Size(128, 26);
            this.feesTxt.TabIndex = 51;
            // 
            // venueTxt
            // 
            this.venueTxt.FormattingEnabled = true;
            this.venueTxt.Items.AddRange(new object[] {
            "room 1",
            "room 2",
            "room 3"});
            this.venueTxt.Location = new System.Drawing.Point(722, 349);
            this.venueTxt.Name = "venueTxt";
            this.venueTxt.Size = new System.Drawing.Size(127, 28);
            this.venueTxt.TabIndex = 54;
            // 
            // dclassTxt
            // 
            this.dclassTxt.FormattingEnabled = true;
            this.dclassTxt.Items.AddRange(new object[] {
            "jazz class",
            "ballet",
            "tap dance",
            "hip-hop dance",
            "ballroom dance"});
            this.dclassTxt.Location = new System.Drawing.Point(1042, 282);
            this.dclassTxt.Name = "dclassTxt";
            this.dclassTxt.Size = new System.Drawing.Size(127, 28);
            this.dclassTxt.TabIndex = 55;
            // 
            // startdateTxt
            // 
            this.startdateTxt.FormattingEnabled = true;
            this.startdateTxt.Items.AddRange(new object[] {
            "october 2019",
            "nevember 2019",
            "december 2019"});
            this.startdateTxt.Location = new System.Drawing.Point(417, 409);
            this.startdateTxt.Name = "startdateTxt";
            this.startdateTxt.Size = new System.Drawing.Size(127, 28);
            this.startdateTxt.TabIndex = 56;
            // 
            // enddateTxt
            // 
            this.enddateTxt.FormattingEnabled = true;
            this.enddateTxt.Items.AddRange(new object[] {
            "november 2019",
            "december 2019",
            "january 2020",
            "february 2020"});
            this.enddateTxt.Location = new System.Drawing.Point(721, 412);
            this.enddateTxt.Name = "enddateTxt";
            this.enddateTxt.Size = new System.Drawing.Size(128, 28);
            this.enddateTxt.TabIndex = 57;
            // 
            // ViewEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 468);
            this.Controls.Add(this.enddateTxt);
            this.Controls.Add(this.startdateTxt);
            this.Controls.Add(this.dclassTxt);
            this.Controls.Add(this.venueTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.feesTxt);
            this.Controls.Add(this.instructTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.unameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.usridTxt);
            this.Controls.Add(this.label2);
            this.Name = "ViewEnroll";
            this.Text = "ViewEnroll";
            ((System.ComponentModel.ISupportInitialize)(this.danceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox instructTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource danceDataSetBindingSource;
        private System.Windows.Forms.TextBox unameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox usridTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox feesTxt;
        private System.Windows.Forms.ComboBox venueTxt;
        private System.Windows.Forms.ComboBox dclassTxt;
        private System.Windows.Forms.ComboBox startdateTxt;
        private System.Windows.Forms.ComboBox enddateTxt;
    }
}