namespace SaleManagementWinApp
{
    partial class frmDetailInfo
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
            txtBirthday = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtCustomerName = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtCustomerID = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new System.Drawing.Point(823, 220);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new System.Drawing.Size(354, 27);
            txtBirthday.TabIndex = 28;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(823, 148);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(354, 27);
            txtPassword.TabIndex = 27;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(823, 81);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(354, 27);
            txtCountry.TabIndex = 26;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(260, 293);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(354, 27);
            txtCity.TabIndex = 25;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(260, 220);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(354, 27);
            txtCustomerName.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(260, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(354, 27);
            txtEmail.TabIndex = 23;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new System.Drawing.Point(260, 81);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new System.Drawing.Size(354, 27);
            txtCustomerID.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(721, 223);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(64, 20);
            label6.TabIndex = 21;
            label6.Text = "Birthday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(721, 151);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 20);
            label7.TabIndex = 20;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(721, 84);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(60, 20);
            label8.TabIndex = 19;
            label8.Text = "Country";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(124, 293);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 20);
            label4.TabIndex = 18;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(124, 220);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 20);
            label3.TabIndex = 17;
            label3.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(124, 148);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 20);
            label2.TabIndex = 16;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(124, 81);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 20);
            label1.TabIndex = 15;
            label1.Text = "Customer ID";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(356, 420);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(823, 420);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 30;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmDetailInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1307, 509);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtBirthday);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCustomerName);
            Controls.Add(txtEmail);
            Controls.Add(txtCustomerID);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDetailInfo";
            Text = "frmDetailInfo";
            Load += frmDetailInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}