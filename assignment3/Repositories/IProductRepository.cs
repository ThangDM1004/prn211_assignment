using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public interface IProductRepository
	{
		List<FlowerBouquet> GetAllProduct();
		void UpdateProduct(FlowerBouquet product);
		void SaveProduct(FlowerBouquet product);
		void DeleteProduct(FlowerBouquet product);
		List<FlowerBouquet> SearchProduct(string name, decimal price_min, decimal price_max);
		FlowerBouquet GetProductById(int id);
		List<Supplier> GetSupplier();
		List<Category> GetCategories();

		Category GetCategoriesByID(int id);
		Supplier GetSupplierByID(int id);
	}

}
