namespace Dance
{
    partial class ViewClass
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewBtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dclassTxt = new System.Windows.Forms.TextBox();
            this.cidTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sessionsTxt = new System.Windows.Forms.TextBox();
            this.feesTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Class ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 240);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(12, 313);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(89, 32);
            this.viewBtn.TabIndex = 38;
            this.viewBtn.Text = "view";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Enabled = false;
            this.updatebtn.Location = new System.Drawing.Point(135, 311);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(77, 32);
            this.updatebtn.TabIndex = 37;
            this.updatebtn.Text = "update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(12, 368);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 32);
            this.deleteBtn.TabIndex = 36;
            this.deleteBtn.Text = "delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dclassTxt
            // 
            this.dclassTxt.Enabled = false;
            this.dclassTxt.Location = new System.Drawing.Point(775, 311);
            this.dclassTxt.Name = "dclassTxt";
            this.dclassTxt.Size = new System.Drawing.Size(121, 26);
            this.dclassTxt.TabIndex = 34;
            // 
            // cidTxt
            // 
            this.cidTxt.Enabled = false;
            this.cidTxt.Location = new System.Drawing.Point(484, 311);
            this.cidTxt.Name = "cidTxt";
            this.cidTxt.Size = new System.Drawing.Size(121, 26);
            this.cidTxt.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Dance Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "No of sessions";
            // 
            // sessionsTxt
            // 
            this.sessionsTxt.Location = new System.Drawing.Point(775, 380);
            this.sessionsTxt.Name = "sessionsTxt";
            this.sessionsTxt.Size = new System.Drawing.Size(121, 26);
            this.sessionsTxt.TabIndex = 43;
            // 
            // feesTxt
            // 
            this.feesTxt.Location = new System.Drawing.Point(484, 380);
            this.feesTxt.Name = "feesTxt";
            this.feesTxt.Size = new System.Drawing.Size(121, 26);
            this.feesTxt.TabIndex = 44;
            // 
            // ViewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.feesTxt);
            this.Controls.Add(this.sessionsTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dclassTxt);
            this.Controls.Add(this.cidTxt);
            this.Controls.Add(this.label1);
            this.Name = "ViewClass";
            this.Text = "ViewClass";
            this.Load += new System.EventHandler(this.ViewClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox dclassTxt;
        private System.Windows.Forms.TextBox cidTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sessionsTxt;
        private System.Windows.Forms.TextBox feesTxt;
    }
}