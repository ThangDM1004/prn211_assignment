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
                using(var context = new FStoreDBContext())
                {
                    products = context.FlowerBouquets.ToList();
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }
        public static void UpdateProduct(FlowerBouquet product)
        {
            try
            {
                using(var context = new FStoreDBContext())
                {
                    context.Entry<FlowerBouquet>(product).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteProduct(FlowerBouquet product)
        {
            try
            {
                using(var context = new FStoreDBContext())
                {
                   var p1 = context.FlowerBouquets.SingleOrDefault(m => m.FlowerBouquetId == product.FlowerBouquetId);
                    context.FlowerBouquets.Remove(p1);
                    context.SaveChanges();
                }
            }catch( Exception ex) 
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
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<FlowerBouquet> SearchByID(int id)
        {
            List<FlowerBouquet> flowerBouquets = new List<FlowerBouquet>();
            try
            {
                using(var context = new FStoreDBContext())
                {
                    flowerBouquets = context.FlowerBouquets.Where(f => f.FlowerBouquetId == id ).ToList();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flowerBouquets;
        }

        public static List<FlowerBouquet> SearchByName(string name)
        {
            List<FlowerBouquet> flowerBouquets = new List<FlowerBouquet>();
            try
            {
                using (var context = new FStoreDBContext())
                {
                    flowerBouquets = context.FlowerBouquets.Where(n => n.FlowerBouquetName.Contains(name)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flowerBouquets;
        }

        public static List<FlowerBouquet> SearchByPrice(decimal price)
        {
            List<FlowerBouquet> flowerBouquets = new List<FlowerBouquet>();
            try
            {
                using (var context = new FStoreDBContext())
                {
                    flowerBouquets = context.FlowerBouquets.Where(p => p.UnitPrice == price).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flowerBouquets;
        }
        public static List<FlowerBouquet> SearchByStock(int stock)
        {
            List<FlowerBouquet> flowerBouquets = new List<FlowerBouquet>();
            try
            {
                using (var context = new FStoreDBContext())
                {
                    flowerBouquets = context.FlowerBouquets.Where(s => s.UnitsInStock == stock).ToList();
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

    }
}
