namespace Ass01Solution_SE1736_DANGMINHTHANG
{
    partial class frmProjectDetails
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
            txtID = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtSponsor = new System.Windows.Forms.TextBox();
            txtSave = new System.Windows.Forms.Button();
            txtCancel = new System.Windows.Forms.Button();
            StartDate = new System.Windows.Forms.TextBox();
            EndDate = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(117, 101);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Project ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(117, 152);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Project Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(117, 205);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 20);
            label3.TabIndex = 2;
            label3.Text = "Project Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(117, 256);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(112, 20);
            label4.TabIndex = 3;
            label4.Text = "Project Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(117, 317);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 20);
            label5.TabIndex = 4;
            label5.Text = "Project City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(117, 368);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(113, 20);
            label6.TabIndex = 5;
            label6.Text = "Project Sponsor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(117, 421);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(146, 20);
            label7.TabIndex = 6;
            label7.Text = "Estimated Start Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(117, 472);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(140, 20);
            label8.TabIndex = 7;
            label8.Text = "Estimated End Date";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(297, 101);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(394, 27);
            txtID.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(297, 149);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(394, 27);
            txtName.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(297, 202);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(394, 27);
            txtDescription.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(297, 253);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(394, 27);
            txtAddress.TabIndex = 11;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(297, 314);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(394, 27);
            txtCity.TabIndex = 12;
            // 
            // txtSponsor
            // 
            txtSponsor.Location = new System.Drawing.Point(297, 365);
            txtSponsor.Name = "txtSponsor";
            txtSponsor.Size = new System.Drawing.Size(394, 27);
            txtSponsor.TabIndex = 13;
            // 
            // txtSave
            // 
            txtSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            txtSave.Location = new System.Drawing.Point(297, 538);
            txtSave.Name = "txtSave";
            txtSave.Size = new System.Drawing.Size(129, 53);
            txtSave.TabIndex = 16;
            txtSave.Text = "Save";
            txtSave.UseVisualStyleBackColor = true;
            txtSave.Click += txtSave_Click;
            // 
            // txtCancel
            // 
            txtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            txtCancel.Location = new System.Drawing.Point(562, 538);
            txtCancel.Name = "txtCancel";
            txtCancel.Size = new System.Drawing.Size(129, 53);
            txtCancel.TabIndex = 17;
            txtCancel.Text = "Cancel";
            txtCancel.UseVisualStyleBackColor = true;
            txtCancel.Click += txtCancel_Click;
            // 
            // StartDate
            // 
            StartDate.Location = new System.Drawing.Point(297, 418);
            StartDate.Name = "StartDate";
            StartDate.Size = new System.Drawing.Size(394, 27);
            StartDate.TabIndex = 14;
            // 
            // EndDate
            // 
            EndDate.Location = new System.Drawing.Point(297, 469);
            EndDate.Name = "EndDate";
            EndDate.Size = new System.Drawing.Size(394, 27);
            EndDate.TabIndex = 15;
            // 
            // frmProjectDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(824, 653);
            Controls.Add(EndDate);
            Controls.Add(StartDate);
            Controls.Add(txtCancel);
            Controls.Add(txtSave);
            Controls.Add(txtSponsor);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProjectDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmProjectDetails";
            Load += frmProjectDetails_Load;
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
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSponsor;
        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.TextBox StartDate;
        private System.Windows.Forms.TextBox EndDate;
    }
}