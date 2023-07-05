using BusinessObjects;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmCreateOrder : Form
    {
        public IOrderRepository ordRep { get; set; }
        public bool InsertOrUpdateOrder { get; set; }
        public Order OrderInfo { get; set; }
        public frmCreateOrder()
        {
            InitializeComponent();
        }

        private void frmCreateOrder_Load(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = false;
            txtorderID.Enabled = false;
            if (InsertOrUpdateOrder)
            {

                txtCustomerID.Text = OrderInfo.CustomerId.ToString();
                txtOrderDate.Text = OrderInfo.OrderDate.ToString();
                txtorderID.Text = OrderInfo.OrderId.ToString();
                txtOrderStatus.Text = OrderInfo.OrderStatus.ToString();
                txtShippedDate.Text = OrderInfo.ShippedDate.ToString();
                txtTotal.Text = OrderInfo.Total.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderDate.Text == "" || txtOrderStatus.Text == "" ||
                txtShippedDate.Text == "" || txtTotal.Text == "" )
                {
                    MessageBox.Show("All fields are required!", "Product Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var p = new Order
                    {

                        OrderId = int.Parse(txtorderID.Text),
                        OrderDate = DateTime.Parse(txtOrderDate.Text),
                        CustomerId = int.Parse(txtCustomerID.Text),
                        OrderStatus = txtOrderStatus.Text,
                        ShippedDate = DateTime.Parse(txtShippedDate.Text),
                        Total = decimal.Parse(txtTotal.Text),
                        
                    };
                    if (InsertOrUpdateOrder == true)
                    {
                        ordRep.UpdateOrder(p);
                        DialogResult d;
                        d = MessageBox.Show("Create Product Successfully, Are You Continue ?", "Notice", MessageBoxButtons.OKCancel);
                        if (d == DialogResult.OK)
                        {

                        }
                        else
                        {
                            Close();
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdateOrder == true ? "Add new project" : "Update a project");
            }
        }
    }
}
