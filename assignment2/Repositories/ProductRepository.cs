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
        public  List<FlowerBouquet> GetAllProduct() => ProductDAO.GetAllProduct();
       
        public void UpdateProduct(FlowerBouquet product) => ProductDAO.UpdateProduct(product);
        public void DeleteProduct(FlowerBouquet product) => ProductDAO.DeleteProduct(product);
        public void SaveProduct(FlowerBouquet product) => ProductDAO.SaveProduct(product);
              public  List<FlowerBouquet> SearchByID(int id) =>ProductDAO.SearchByID(id) ;
      public  List<FlowerBouquet> SearchByName(string name)=> ProductDAO.SearchByName(name) ;
        public List<FlowerBouquet> SearchByPrice(decimal price)=> ProductDAO.SearchByPrice(price) ;
        public List<FlowerBouquet> SearchByStock(int stock)=> ProductDAO.SearchByStock(stock);
        public  FlowerBouquet GetProductById(int id) => ProductDAO.GetProductById(id) ;

    }
}
