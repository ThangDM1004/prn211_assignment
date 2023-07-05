using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public  Customer getMemberByEmail(string email) => CustomerDAO.getMemberByEmail(email);
        public List<Customer> GetAllCustomer() => CustomerDAO.GetAllCustomer();

        public  List<Customer> GetAllCustomerByID(int ID) => CustomerDAO.GetAllCustomerByID(ID);

        public void UpdateCustomer(Customer cus) => CustomerDAO.UpdateCustomer(cus) ;
         public void DeleteCustomer(Customer cus)=> CustomerDAO.DeleteCustomer(cus);
        public void SaveCustomer(Customer cus)=> CustomerDAO.SaveCustomer(cus);
    }
}
