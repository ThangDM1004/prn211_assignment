using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        Customer getMemberByEmail(string email);
        List<Customer> GetAllCustomer();
        List<Customer> GetAllCustomerByID(int ID);
        void UpdateCustomer(Customer cus);
        void DeleteCustomer(Customer cus);
        void SaveCustomer(Customer cus);
        Customer getMemberByID(int id);


	}
}
