namespace Student
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstuname = new System.Windows.Forms.TextBox();
            this.txtstuid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.STU_ID = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnseachh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtupid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtupname = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdelid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // txtstuname
            // 
            this.txtstuname.Location = new System.Drawing.Point(143, 90);
            this.txtstuname.Name = "txtstuname";
            this.txtstuname.Size = new System.Drawing.Size(140, 20);
            this.txtstuname.TabIndex = 2;
            // 
            // txtstuid
            // 
            this.txtstuid.Location = new System.Drawing.Point(143, 38);
            this.txtstuid.Name = "txtstuid";
            this.txtstuid.Size = new System.Drawing.Size(140, 20);
            this.txtstuid.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(352, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 144);
            this.dataGridView1.TabIndex = 4;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(48, 159);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 5;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(143, 159);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 6;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(224, 159);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // STU_ID
            // 
            this.STU_ID.AutoSize = true;
            this.STU_ID.Location = new System.Drawing.Point(6, 31);
            this.STU_ID.Name = "STU_ID";
            this.STU_ID.Size = new System.Drawing.Size(40, 13);
            this.STU_ID.TabIndex = 8;
            this.STU_ID.Text = "Stu_ID";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(91, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnseachh
            // 
            this.btnseachh.Location = new System.Drawing.Point(116, 59);
            this.btnseachh.Name = "btnseachh";
            this.btnseachh.Size = new System.Drawing.Size(75, 23);
            this.btnseachh.TabIndex = 10;
            this.btnseachh.Text = "Serach";
            this.btnseachh.UseVisualStyleBackColor = true;
            this.btnseachh.Click += new System.EventHandler(this.btnseachh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnseachh);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.STU_ID);
            this.panel1.Location = new System.Drawing.Point(52, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 91);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Stu_ID";
            // 
            // txtupid
            // 
            this.txtupid.Location = new System.Drawing.Point(97, 21);
            this.txtupid.Name = "txtupid";
            this.txtupid.Size = new System.Drawing.Size(100, 20);
            this.txtupid.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stu_name";
            // 
            // txtupname
            // 
            this.txtupname.Location = new System.Drawing.Point(97, 69);
            this.txtupname.Name = "txtupname";
            this.txtupname.Size = new System.Drawing.Size(100, 20);
            this.txtupname.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtupname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtupid);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(52, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 141);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtdelid);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(377, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // txtdelid
            // 
            this.txtdelid.Location = new System.Drawing.Point(76, 33);
            this.txtdelid.Name = "txtdelid";
            this.txtdelid.Size = new System.Drawing.Size(100, 20);
            this.txtdelid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtstuid);
            this.Controls.Add(this.txtstuname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstuname;
        private System.Windows.Forms.TextBox txtstuid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label STU_ID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnseachh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtupid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtupname;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdelid;
        private System.Windows.Forms.Label label5;
    }
}

