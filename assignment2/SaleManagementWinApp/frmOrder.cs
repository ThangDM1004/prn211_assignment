using BusinessObjects;
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
    public partial class frmOrder : Form
    {
        public string orderRole { get; set; }
        public int CustomerID_order { get; set; }
        IOrderRepository ord = new OrderRepository();
        IOrderDetailRepository ord_d = new OrderDetailRepository();
        BindingSource source;

        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            if (orderRole != "Admin")
            {

                btnDeleteOrder.Visible = false;
                LoadOrderList(ord.GetOrderByCustomer(CustomerID_order));
            }
            else
            {
                btnDelete.Visible = false;
                LoadOrderList(ord.GetAllOrder());
            }

        }
        private void ClearText()
        {
            txtCustomerID.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtorderID.Text = string.Empty;
            txtOrderStatus.Text = string.Empty;
            txtShippedDate.Text = string.Empty;
            txtTotal.Text = string.Empty;

        }
        private void ClearText_()
        {
            txtOrderDetailsID.Text = string.Empty;
            txtFlowerBouquetID.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtQuantity.Text = string.Empty;


        }
        public void LoadOrderList(List<Order> list)
        {

            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtCustomerID.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtorderID.DataBindings.Clear();
                txtOrderStatus.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtTotal.DataBindings.Clear();


                txtCustomerID.DataBindings.Add("Text", source, "CustomerID"); ;
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate"); ;
                txtorderID.DataBindings.Add("Text", source, "OrderID"); ;
                txtOrderStatus.DataBindings.Add("Text", source, "OrderStatus"); ;
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate"); ;
                txtTotal.DataBindings.Add("Text", source, "Total"); ;


                dgvOrder.DataSource = null;
                dgvOrder.DataSource = source;
                if (list.Count() == 0)
                {
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load project list");
            }
        }
        private Order GetOrderObject()
        {
            Order order = null;
            try
            {
                order = new Order
                {
                    CustomerId = int.Parse(txtCustomerID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    OrderId = int.Parse(txtorderID.Text),
                    OrderStatus = txtOrderStatus.Text,
                    ShippedDate = DateTime.Parse(txtOrderDate.Text),
                    Total = decimal.Parse(txtTotal.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Project");
            }
            return order;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCreateOrder Create = new frmCreateOrder
            {
                Text = "Update Order",
                InsertOrUpdateOrder = true,
                OrderInfo = GetOrderObject(),
                ordRep = ord
            };
            if (Create.ShowDialog() == DialogResult.Cancel)
            {
                LoadOrderList(ord.GetAllOrder());
            }
        }



        private void btnView_Click(object sender, EventArgs e)
        {
            var p = new Order
            {
                OrderId = int.Parse(txtorderID.Text),
            };
            LoadOrderDetailsList(ord_d.GetOrderDetails(p.OrderId));
        }
        public void LoadOrderDetailsList(List<OrderDetail> list)
        {

            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtOrderDetailsID.DataBindings.Clear();
                txtFlowerBouquetID.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();


                txtOrderDetailsID.DataBindings.Add("Text", source, "OrderID"); ;
                txtFlowerBouquetID.DataBindings.Add("Text", source, "FlowerBouquetID"); ;
                txtQuantity.DataBindings.Add("Text", source, "Quantity"); ;
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice"); ;
                txtDiscount.DataBindings.Add("Text", source, "Discount"); ;


                dgvOrderDetails.DataSource = null;
                dgvOrderDetails.DataSource = source;
                if (list.Count() == 0)
                {
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load project list");
            }
        }



       

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Order Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                var p = new Order
                {
                    OrderId = int.Parse(txtorderID.Text),
                };
                ord.DeleteOrder(p);
                dgvOrderDetails.DataSource = null;
                LoadOrderList(ord.GetAllOrder());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Order Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {

                var p = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderDetailsID.Text),
                    FlowerBouquetId = int.Parse(txtFlowerBouquetID.Text),
                };
                ord_d.DeleteOrder(p.FlowerBouquetId,p.OrderId);
                LoadOrderDetailsList(ord_d.GetOrderDetails(int.Parse(txtorderID.Text)));
            }
        }

        private void btnUpdate_Click_2(object sender, EventArgs e)
        {
            frmCreateOrder Create = new frmCreateOrder
            {
                Text = "Update Order",
                InsertOrUpdateOrder = true,
                OrderInfo = GetOrderObject(),
                ordRep = ord
            };
            if (Create.ShowDialog() == DialogResult.Cancel)
            {
                LoadOrderList(ord.GetAllOrder());
            }
        }
    }
}
