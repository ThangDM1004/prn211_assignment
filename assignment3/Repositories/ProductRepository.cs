using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class ProductRepository : IProductRepository
	{
		public List<FlowerBouquet> GetAllProduct() => ProductDAO.GetAllProduct();

		public void UpdateProduct(FlowerBouquet product) => ProductDAO.UpdateProduct(product);
		public void DeleteProduct(FlowerBouquet product) => ProductDAO.DeleteProduct(product);
		public void SaveProduct(FlowerBouquet product) => ProductDAO.SaveProduct(product);
		public List<FlowerBouquet> SearchProduct(string name, decimal price_min, decimal price_max) => ProductDAO.SearchProduct(name, price_min, price_max);
		public FlowerBouquet GetProductById(int id) => ProductDAO.GetProductById(id);
		public List<Supplier> GetSupplier() => ProductDAO.GetSupplier();
		public List<Category> GetCategories() => ProductDAO.GetCategories();

		public  Supplier GetSupplierByID(int id) => ProductDAO.GetSupplierByID(id);
		public  Category GetCategoriesByID(int id) =>ProductDAO.GetCategoriesByID(id);
	}
}
