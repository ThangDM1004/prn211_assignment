namespace Ass01Solution_SE1736_DANGMINHTHANG
{
    partial class frmProjectManagements
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtProID = new System.Windows.Forms.TextBox();
            txtProName = new System.Windows.Forms.TextBox();
            txtProDes = new System.Windows.Forms.TextBox();
            txtProAdd = new System.Windows.Forms.TextBox();
            txtProCity = new System.Windows.Forms.TextBox();
            txtProSpo = new System.Windows.Forms.TextBox();
            dgvProjectList = new System.Windows.Forms.DataGridView();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            txtClose = new System.Windows.Forms.Button();
            txtStartDate = new System.Windows.Forms.TextBox();
            txtEndDate = new System.Windows.Forms.TextBox();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            cbProductCity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProjectList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(117, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Project ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(117, 100);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Project Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(117, 208);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Project Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(117, 158);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(135, 20);
            label4.TabIndex = 3;
            label4.Text = "Project Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(673, 50);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 20);
            label5.TabIndex = 4;
            label5.Text = "Project City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(673, 100);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(113, 20);
            label6.TabIndex = 5;
            label6.Text = "Project Sponsor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(673, 158);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(146, 20);
            label7.TabIndex = 6;
            label7.Text = "Estimated Start Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(673, 208);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(140, 20);
            label8.TabIndex = 7;
            label8.Text = "Estimated End Date";
            // 
            // txtProID
            // 
            txtProID.Enabled = false;
            txtProID.Location = new System.Drawing.Point(277, 47);
            txtProID.Name = "txtProID";
            txtProID.Size = new System.Drawing.Size(336, 27);
            txtProID.TabIndex = 8;
            // 
            // txtProName
            // 
            txtProName.Enabled = false;
            txtProName.Location = new System.Drawing.Point(277, 97);
            txtProName.Name = "txtProName";
            txtProName.Size = new System.Drawing.Size(336, 27);
            txtProName.TabIndex = 9;
            // 
            // txtProDes
            // 
            txtProDes.Enabled = false;
            txtProDes.Location = new System.Drawing.Point(277, 155);
            txtProDes.Name = "txtProDes";
            txtProDes.Size = new System.Drawing.Size(336, 27);
            txtProDes.TabIndex = 10;
            // 
            // txtProAdd
            // 
            txtProAdd.Enabled = false;
            txtProAdd.Location = new System.Drawing.Point(277, 205);
            txtProAdd.Name = "txtProAdd";
            txtProAdd.Size = new System.Drawing.Size(336, 27);
            txtProAdd.TabIndex = 11;
            // 
            // txtProCity
            // 
            txtProCity.Enabled = false;
            txtProCity.Location = new System.Drawing.Point(844, 47);
            txtProCity.Name = "txtProCity";
            txtProCity.Size = new System.Drawing.Size(336, 27);
            txtProCity.TabIndex = 12;
            // 
            // txtProSpo
            // 
            txtProSpo.Enabled = false;
            txtProSpo.Location = new System.Drawing.Point(844, 97);
            txtProSpo.Name = "txtProSpo";
            txtProSpo.Size = new System.Drawing.Size(336, 27);
            txtProSpo.TabIndex = 13;
            // 
            // dgvProjectList
            // 
            dgvProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjectList.Location = new System.Drawing.Point(118, 351);
            dgvProjectList.Name = "dgvProjectList";
            dgvProjectList.RowHeadersWidth = 51;
            dgvProjectList.RowTemplate.Height = 29;
            dgvProjectList.Size = new System.Drawing.Size(1063, 303);
            dgvProjectList.TabIndex = 16;
            dgvProjectList.CellDoubleClick += dgvProjectList_CellDoubleClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(277, 263);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 17;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(614, 263);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(94, 29);
            btnNew.TabIndex = 18;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(947, 263);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtClose
            // 
            txtClose.Location = new System.Drawing.Point(615, 678);
            txtClose.Name = "txtClose";
            txtClose.Size = new System.Drawing.Size(94, 29);
            txtClose.TabIndex = 20;
            txtClose.Text = "Close";
            txtClose.UseVisualStyleBackColor = true;
            txtClose.Click += txtClose_Click;
            // 
            // txtStartDate
            // 
            txtStartDate.Enabled = false;
            txtStartDate.Location = new System.Drawing.Point(844, 151);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new System.Drawing.Size(336, 27);
            txtStartDate.TabIndex = 21;
            // 
            // txtEndDate
            // 
            txtEndDate.Enabled = false;
            txtEndDate.Location = new System.Drawing.Point(844, 205);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new System.Drawing.Size(336, 27);
            txtEndDate.TabIndex = 22;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(118, 318);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(304, 27);
            txtSearch.TabIndex = 23;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(428, 318);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(175, 295);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(196, 20);
            label9.TabIndex = 25;
            label9.Text = "Product ID or Product Name";
            // 
            // cbProductCity
            // 
            cbProductCity.FormattingEnabled = true;
            cbProductCity.Items.AddRange(new object[] { "HCM", "Đà Nẵng", "Cần Thơ", "Hà Nội" });
            cbProductCity.Location = new System.Drawing.Point(546, 318);
            cbProductCity.Name = "cbProductCity";
            cbProductCity.Size = new System.Drawing.Size(184, 28);
            cbProductCity.TabIndex = 26;
            cbProductCity.Text = "-- Select Product City --";
            cbProductCity.SelectedIndexChanged += cbProductCity_SelectedIndexChanged;
            // 
            // frmProjectManagements
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1276, 719);
            Controls.Add(cbProductCity);
            Controls.Add(label9);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvProjectList);
            Controls.Add(txtProSpo);
            Controls.Add(txtProCity);
            Controls.Add(txtProAdd);
            Controls.Add(txtProDes);
            Controls.Add(txtProName);
            Controls.Add(txtProID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProjectManagements";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmProjectManagements";
            Load += frmProjectManagements_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProjectList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtProDes;
        private System.Windows.Forms.TextBox txtProAdd;
        private System.Windows.Forms.TextBox txtProCity;
        private System.Windows.Forms.TextBox txtProSpo;
        private System.Windows.Forms.DataGridView dgvProjectList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button txtClose;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbProductCity;
    }
}