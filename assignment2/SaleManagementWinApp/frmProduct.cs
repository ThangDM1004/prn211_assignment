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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SaleManagementWinApp
{
    public partial class frmProduct : Form
    {
        IProductRepository pro = new ProductRepository();
        ICustomerRepository customerRep = new CustomerRepository();
        IOrderRepository orderRep = new OrderRepository();
        IOrderDetailRepository orderDetailRep = new OrderDetailRepository();
        BindingSource source;
        public string proRole { get; set; }
        public string proEmail { get; set; }
        public int CustomerID_pro { get; set; }
        public frmProduct()
        {
            InitializeComponent();

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

            var product = pro.GetAllProduct();
            try
            {
                if (proRole != "Admin")
                {
                    btnAdd.Visible = false;
                    btnDelete.Visible = false;
                    btnUpdate.Visible = false;

                }
                else
                {
                    btnAdd.Visible = true;
                    btnDelete.Visible = true;
                    btnUpdate.Visible = true;
                    btnOrder.Visible = false;
                }
                LoadProductList(product);
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
    }
        private void ClearText()
        {
            txtCategoryID.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtFLowerBouquetID.Text = string.Empty;
            txtFLowerBouquetName.Text = string.Empty;
            txtFLowerBouquetStatus.Text = string.Empty;
            txtSupplierID.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Text = "Add Product",
                InsertOrUpdate = false,
                ProjectDetailsRepository = pro
            };
            if (frmProductDetail.ShowDialog() == DialogResult.Cancel)
            {
                LoadProductList(pro.GetAllProduct());
                source.Position = source.Position - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Text = "Update Product",
                InsertOrUpdate = true,
                ProductInfo = GetProductObject(),
                ProjectDetailsRepository = pro
            };
            if (frmProductDetail.ShowDialog() == DialogResult.Cancel)
            {
                LoadProductList(pro.GetAllProduct());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Product Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                var p = new FlowerBouquet
                {
                    FlowerBouquetId = int.Parse(txtFLowerBouquetID.Text),
                };
                pro.DeleteProduct(p);
                LoadProductList(pro.GetAllProduct());
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var order = GetOrderByEmail(proEmail);
            if (order == null || order.OrderStatus.Trim() == "Done")
            {
                order = new Order
                {
                    OrderId = CreateOrderID(),
                    CustomerId = customerRep.getMemberByEmail(proEmail).CustomerId,
                    OrderDate = DateTime.Now,
                    OrderStatus = "Not Done",
                    Total = 0
                };
                OrderDetail orderDetail = GetNewOrderDetails(order, pro.GetProductById(int.Parse(txtFLowerBouquetID.Text)));
                order.Total += orderDetail.UnitPrice * (100 - (decimal)orderDetail.Discount) / 100;
                orderRep.CreateOder(order);
                AddOrUpdateOrderDetail(order, pro.GetProductById(int.Parse(txtFLowerBouquetID.Text)), orderDetail);
            }
            else
            {
                OrderDetail orderDetail = GetNewOrderDetails(order, pro.GetProductById(int.Parse(txtFLowerBouquetID.Text)));
                order.Total += orderDetail.UnitPrice * (100 - (decimal)orderDetail.Discount) / 100;
                orderRep.UpdateOrder(order);
                AddOrUpdateOrderDetail(order, pro.GetProductById(int.Parse(txtFLowerBouquetID.Text)), orderDetail);
            }

            MessageBox.Show("Order successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void AddOrUpdateOrderDetail(Order order, FlowerBouquet flowerBouquet, OrderDetail orderDetail)
        {
            OrderDetail orderDetail1 = orderDetailRep.GetOrderDetailByOrderIdAndProductId(order, flowerBouquet);
            if (orderDetail1 == null) { orderDetailRep.AddOrderDetail(orderDetail); }
            else orderDetailRep.UpdateOrderDetail(orderDetail);
        }
        public Order GetOrderByEmail(string email)
        {
            var customer = customerRep.getMemberByEmail(email);
            Order order = orderRep.GetOrderByCustomerID(customer.CustomerId);
            return order;
        }

        public int CreateOrderID()
        {
            int id = 0;
            var order = orderRep.GetAllOrder().OrderByDescending(o => o.OrderId).FirstOrDefault();
            id = order.OrderId + 1;
            return id;
        }

        public OrderDetail GetNewOrderDetails(Order order, FlowerBouquet flowerBouquet)
        {
            OrderDetail orderDetail = orderDetailRep.GetOrderDetailByOrderIdAndProductId(order, flowerBouquet);
            if (orderDetail == null)
            {
                orderDetail = new OrderDetail
                {
                    OrderId = order.OrderId,
                    FlowerBouquetId = flowerBouquet.FlowerBouquetId,
                    UnitPrice = flowerBouquet.UnitPrice,
                    Quantity = 1,
                    Discount = 0
                };
            }
            else { orderDetail.Quantity += 1; }
            return orderDetail;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LoadProductList(List<FlowerBouquet> list)
        {
           
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtCategoryID.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtFLowerBouquetID.DataBindings.Clear();
                txtFLowerBouquetName.DataBindings.Clear();
                txtFLowerBouquetStatus.DataBindings.Clear();
                txtSupplierID.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtCategoryID.DataBindings.Add("Text", source, "CategoryID"); ;
                txtDescription.DataBindings.Add("Text", source, "Description"); ;
                txtFLowerBouquetID.DataBindings.Add("Text", source, "FLowerBouquetID"); ;
                txtFLowerBouquetName.DataBindings.Add("Text", source, "FLowerBouquetName"); ;
                txtFLowerBouquetStatus.DataBindings.Add("Text", source, "FLowerBouquetStatus"); ;
                txtSupplierID.DataBindings.Add("Text", source, "SupplierID"); ;
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice"); ;
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock"); ;
                dgvProduct.DataSource = null;
                dgvProduct.DataSource = source;
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
        private FlowerBouquet GetProductObject()
        {
            FlowerBouquet products = null;
            try
            {
                products = new FlowerBouquet
                {
                    FlowerBouquetId = int.Parse(txtFLowerBouquetID.Text),
                    FlowerBouquetName = txtFLowerBouquetName.Text,
                    FlowerBouquetStatus = byte.Parse(txtFLowerBouquetStatus.Text),
                    CategoryId = int.Parse(txtCategoryID.Text),
                    Description = txtDescription.Text,
                    SupplierId = int.Parse(txtSupplierID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Project");
            }
            return products;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(txtSearch.Text, out _);
            List<FlowerBouquet> search = new List<FlowerBouquet>();
            if (isNumeric )
            {
                search = pro.SearchByID(int.Parse(txtSearch.Text));
                if(search.Count() > 0)
                {
                                           LoadProductList(search);
                 
                }
                else
                {
                    search = pro.SearchByStock(int.Parse(txtSearch.Text));
                   
                        if (search.Count > 0)
                        {
                            LoadProductList(search);
                        }
                        else
                        {
                            MessageBox.Show("Product not exist!!!");
                        }
                    
                }
               
            }
            else
            {
                
                    search = pro.SearchByPrice(decimal.Parse(txtSearch.Text));
                    if(search.Count()>0)
                    {
                        LoadProductList(search);
                }
                else
                {
                    search = pro.SearchByName(txtSearch.Text);
                    if (search.Count > 0)
                    {
                        LoadProductList(search);
                    }
                    else
                    {
                        MessageBox.Show("Product not exist");
                    }
                }
               
                    
                            
            }
        }
    }
}
