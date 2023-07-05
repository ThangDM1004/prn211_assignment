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
       void SaveProduct(FlowerBouquet product);
        void UpdateProduct(FlowerBouquet product);
        void DeleteProduct(FlowerBouquet product);
        List<FlowerBouquet> SearchByID(int id);
        List<FlowerBouquet> SearchByName(string name);
        List<FlowerBouquet> SearchByPrice(decimal price);
        List<FlowerBouquet> SearchByStock(int stock);
        FlowerBouquet GetProductById(int id);
    }
}
