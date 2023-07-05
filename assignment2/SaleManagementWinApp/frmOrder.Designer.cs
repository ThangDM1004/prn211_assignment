namespace SaleManagementWinApp
{
    partial class frmOrder
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
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            btnDeleteOrder = new System.Windows.Forms.Button();
            txtTotal = new System.Windows.Forms.TextBox();
            txtCustomerID = new System.Windows.Forms.TextBox();
            txtorderID = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            Order = new System.Windows.Forms.Label();
            btnView = new System.Windows.Forms.Button();
            dgvOrder = new System.Windows.Forms.DataGridView();
            txtOrderStatus = new System.Windows.Forms.TextBox();
            txtShippedDate = new System.Windows.Forms.TextBox();
            txtOrderDate = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            dgvOrderDetails = new System.Windows.Forms.DataGridView();
            txtDiscount = new System.Windows.Forms.TextBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtFlowerBouquetID = new System.Windows.Forms.TextBox();
            txtOrderDetailsID = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            splitContainer1.Location = new System.Drawing.Point(2, -1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnUpdate);
            splitContainer1.Panel1.Controls.Add(btnDeleteOrder);
            splitContainer1.Panel1.Controls.Add(txtTotal);
            splitContainer1.Panel1.Controls.Add(txtCustomerID);
            splitContainer1.Panel1.Controls.Add(txtorderID);
            splitContainer1.Panel1.Controls.Add(label10);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(Order);
            splitContainer1.Panel1.Controls.Add(btnView);
            splitContainer1.Panel1.Controls.Add(dgvOrder);
            splitContainer1.Panel1.Controls.Add(txtOrderStatus);
            splitContainer1.Panel1.Controls.Add(txtShippedDate);
            splitContainer1.Panel1.Controls.Add(txtOrderDate);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnDelete);
            splitContainer1.Panel2.Controls.Add(dgvOrderDetails);
            splitContainer1.Panel2.Controls.Add(txtDiscount);
            splitContainer1.Panel2.Controls.Add(txtQuantity);
            splitContainer1.Panel2.Controls.Add(txtUnitPrice);
            splitContainer1.Panel2.Controls.Add(txtFlowerBouquetID);
            splitContainer1.Panel2.Controls.Add(txtOrderDetailsID);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new System.Drawing.Size(1517, 587);
            splitContainer1.SplitterDistance = 824;
            splitContainer1.TabIndex = 27;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new System.Drawing.Point(629, 264);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new System.Drawing.Size(94, 29);
            btnDeleteOrder.TabIndex = 43;
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new System.Drawing.Point(204, 187);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(129, 27);
            txtTotal.TabIndex = 41;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Location = new System.Drawing.Point(204, 108);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new System.Drawing.Size(129, 27);
            txtCustomerID.TabIndex = 40;
            // 
            // txtorderID
            // 
            txtorderID.Enabled = false;
            txtorderID.Location = new System.Drawing.Point(204, 45);
            txtorderID.Name = "txtorderID";
            txtorderID.Size = new System.Drawing.Size(129, 27);
            txtorderID.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(412, 194);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(91, 20);
            label10.TabIndex = 38;
            label10.Text = "Order Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(412, 118);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(100, 20);
            label9.TabIndex = 37;
            label9.Text = "Shipped Date";
            // 
            // Order
            // 
            Order.AutoSize = true;
            Order.Location = new System.Drawing.Point(412, 49);
            Order.Name = "Order";
            Order.Size = new System.Drawing.Size(83, 20);
            Order.TabIndex = 36;
            Order.Text = "Order Date";
            // 
            // btnView
            // 
            btnView.Location = new System.Drawing.Point(147, 264);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(94, 29);
            btnView.TabIndex = 35;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new System.Drawing.Point(53, 324);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new System.Drawing.Size(772, 227);
            dgvOrder.TabIndex = 33;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Enabled = false;
            txtOrderStatus.Location = new System.Drawing.Point(532, 191);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.Size = new System.Drawing.Size(141, 27);
            txtOrderStatus.TabIndex = 32;
            // 
            // txtShippedDate
            // 
            txtShippedDate.Enabled = false;
            txtShippedDate.Location = new System.Drawing.Point(532, 115);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new System.Drawing.Size(191, 27);
            txtShippedDate.TabIndex = 31;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Enabled = false;
            txtOrderDate.Location = new System.Drawing.Point(532, 49);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new System.Drawing.Size(191, 27);
            txtOrderDate.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(79, 190);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 20);
            label4.TabIndex = 29;
            label4.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(79, 111);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 20);
            label2.TabIndex = 28;
            label2.Text = "Customer ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(79, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 20);
            label1.TabIndex = 27;
            label1.Text = "Order ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(280, 264);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new System.Drawing.Point(3, 324);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 29;
            dgvOrderDetails.Size = new System.Drawing.Size(677, 227);
            dgvOrderDetails.TabIndex = 10;
            // 
            // txtDiscount
            // 
            txtDiscount.Enabled = false;
            txtDiscount.Location = new System.Drawing.Point(499, 108);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new System.Drawing.Size(153, 27);
            txtDiscount.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Enabled = false;
            txtQuantity.Location = new System.Drawing.Point(499, 49);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(153, 27);
            txtQuantity.TabIndex = 8;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Location = new System.Drawing.Point(197, 187);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(153, 27);
            txtUnitPrice.TabIndex = 7;
            // 
            // txtFlowerBouquetID
            // 
            txtFlowerBouquetID.Enabled = false;
            txtFlowerBouquetID.Location = new System.Drawing.Point(197, 111);
            txtFlowerBouquetID.Name = "txtFlowerBouquetID";
            txtFlowerBouquetID.Size = new System.Drawing.Size(153, 27);
            txtFlowerBouquetID.TabIndex = 6;
            // 
            // txtOrderDetailsID
            // 
            txtOrderDetailsID.Enabled = false;
            txtOrderDetailsID.Location = new System.Drawing.Point(197, 45);
            txtOrderDetailsID.Name = "txtOrderDetailsID";
            txtOrderDetailsID.Size = new System.Drawing.Size(153, 27);
            txtOrderDetailsID.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(52, 190);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(72, 20);
            label8.TabIndex = 4;
            label8.Text = "Unit Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(410, 51);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 20);
            label7.TabIndex = 3;
            label7.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(410, 114);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(67, 20);
            label6.TabIndex = 2;
            label6.Text = "Discount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(52, 118);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(132, 20);
            label5.TabIndex = 1;
            label5.Text = "Flower Bouquet ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(52, 49);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 20);
            label3.TabIndex = 0;
            label3.Text = "Order ID";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(384, 264);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_2;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1519, 589);
            Controls.Add(splitContainer1);
            Name = "frmOrder";
            Text = "Order";
            Load += frmOrder_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrderDetailsID;
        private System.Windows.Forms.TextBox txtFlowerBouquetID;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtorderID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Order;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnUpdate;
    }
}