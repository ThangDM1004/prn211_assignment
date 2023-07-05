namespace SaleManagementWinApp
{
    partial class frmCreateOrder
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
            txtTotal = new System.Windows.Forms.TextBox();
            txtCustomerID = new System.Windows.Forms.TextBox();
            txtorderID = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            Order = new System.Windows.Forms.Label();
            txtOrderStatus = new System.Windows.Forms.TextBox();
            txtShippedDate = new System.Windows.Forms.TextBox();
            txtOrderDate = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(242, 193);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(328, 27);
            txtTotal.TabIndex = 37;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Location = new System.Drawing.Point(242, 114);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new System.Drawing.Size(328, 27);
            txtCustomerID.TabIndex = 36;
            // 
            // txtorderID
            // 
            txtorderID.Enabled = false;
            txtorderID.Location = new System.Drawing.Point(242, 51);
            txtorderID.Name = "txtorderID";
            txtorderID.Size = new System.Drawing.Size(328, 27);
            txtorderID.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(697, 196);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(91, 20);
            label10.TabIndex = 34;
            label10.Text = "Order Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(697, 120);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(100, 20);
            label9.TabIndex = 33;
            label9.Text = "Shipped Date";
            // 
            // Order
            // 
            Order.AutoSize = true;
            Order.Location = new System.Drawing.Point(697, 51);
            Order.Name = "Order";
            Order.Size = new System.Drawing.Size(83, 20);
            Order.TabIndex = 32;
            Order.Text = "Order Date";
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Location = new System.Drawing.Point(817, 193);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.Size = new System.Drawing.Size(401, 27);
            txtOrderStatus.TabIndex = 31;
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new System.Drawing.Point(817, 117);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new System.Drawing.Size(401, 27);
            txtShippedDate.TabIndex = 30;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new System.Drawing.Point(817, 51);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new System.Drawing.Size(401, 27);
            txtOrderDate.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(117, 196);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 20);
            label4.TabIndex = 28;
            label4.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(117, 117);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 20);
            label2.TabIndex = 27;
            label2.Text = "Customer ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(117, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 20);
            label1.TabIndex = 26;
            label1.Text = "Order ID";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(242, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 38;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(938, 306);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 29);
            button2.TabIndex = 39;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmCreateOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1344, 402);
            Controls.Add(button2);
            Controls.Add(btnSave);
            Controls.Add(txtTotal);
            Controls.Add(txtCustomerID);
            Controls.Add(txtorderID);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(Order);
            Controls.Add(txtOrderStatus);
            Controls.Add(txtShippedDate);
            Controls.Add(txtOrderDate);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCreateOrder";
            Text = "frmCreateOrder";
            Load += frmCreateOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtorderID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Order;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
    }
}