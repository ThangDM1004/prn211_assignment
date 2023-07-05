using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
	public class ProductDAO
	{
		public static List<FlowerBouquet> GetAllProduct()
		{
			List<FlowerBouquet> products = new List<FlowerBouquet>();
			try
			{
				using (var context = new FStoreDBContext())
				{
					products = context.FlowerBouquets.ToList();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return products;
		}
		public static void UpdateProduct(FlowerBouquet product)
		{
			try
			{
				using (var context = new FStoreDBContext())
				{
					context.Entry<FlowerBouquet>(product).State = EntityState.Modified;
					context.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public static void DeleteProduct(FlowerBouquet product)
		{
			try
			{
				using (var context = new FStoreDBContext())
				{
					var p1 = context.FlowerBouquets.SingleOrDefault(m => m.FlowerBouquetId == product.FlowerBouquetId);
					context.FlowerBouquets.Remove(p1);
					context.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public static void SaveProduct(FlowerBouquet product)
		{
			try
			{
				List<FlowerBouquet> list = GetAllProduct();
				var size = list.Count;
				product.FlowerBouquetId = size + 1;
				using (var context = new FStoreDBContext())
				{
					context.FlowerBouquets.Add(product);
					context.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}


		public static List<FlowerBouquet> SearchProduct(string name, decimal price_min, decimal price_max)
		{
			List<FlowerBouquet> flowerBouquets = new List<FlowerBouquet>();
			try
			{
				using (var context = new FStoreDBContext())
				{
					if (name == null)
					{
						flowerBouquets = context.FlowerBouquets.Where(n => n.UnitPrice >= price_min && n.UnitPrice <= price_max).ToList();
					}
					else
					{
						flowerBouquets = context.FlowerBouquets.Where(n => n.FlowerBouquetName.Contains(name) && (n.UnitPrice >= price_min && n.UnitPrice <= price_max)).ToList();
					}

				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return flowerBouquets;
		}


		public static FlowerBouquet GetProductById(int id)
		{
			FlowerBouquet flower = null;
			try
			{
				using (var context = new FStoreDBContext())
				{
					flower = context.FlowerBouquets.SingleOrDefault(f => f.FlowerBouquetId == id);
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
			return flower;
		}
		public static List<Category> GetCategories()
		{
			List<Category> listCategories = new List<Category>();
			try
			{
				using (var context = new FStoreDBContext())
				{
					listCategories = context.Categories.ToList();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return listCategories;
		}
		public static List<Supplier> GetSupplier()
		{
			List<Supplier> listCategories = new List<Supplier>();
			try
			{
				using (var context = new FStoreDBContext())
				{
					listCategories = context.Suppliers.ToList();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return listCategories;
		}
		public static Category GetCategoriesByID(int id)
		{
			Category listCategories = new Category();
			try
			{
				using (var context = new FStoreDBContext())
				{
					listCategories = context.Categories.SingleOrDefault(l => l.CategoryId == id);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return listCategories;
		}
		public static Supplier GetSupplierByID(int id)
		{
			Supplier listCategories = new Supplier();
			try
			{
				using (var context = new FStoreDBContext())
				{
					listCategories = context.Suppliers.SingleOrDefault(s => s.SupplierId == id);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return listCategories;
		}

	}
}
