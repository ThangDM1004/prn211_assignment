using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CustomerDAO
    {
        public static Customer getMemberByEmail(string email)
        {
            Customer member = new Customer();
            try
            {
                using (var context = new FStoreDBContext())
                {
                    member = context.Customers.SingleOrDefault(f => f.Email == email);
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        } 
        public static List<Customer> GetAllCustomer()
        {
            List<Customer> customer = new List<Customer>();
            try
            {
                using(var context = new FStoreDBContext())
                {
                    customer = context.Customers.ToList();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customer;
        }
        public static List<Customer> GetAllCustomerByID(int ID)
        {
            List<Customer> customer = new List<Customer>();
            try
            {
                using (var context = new FStoreDBContext())
                {
                    customer = context.Customers.Where(x => x.CustomerId == ID).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customer;
        }
        public static void UpdateCustomer(Customer cus)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Entry<Customer>(cus).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteCustomer(Customer cus)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    var p1 = context.Customers.SingleOrDefault(m => m.CustomerId == cus.CustomerId);
                    context.Customers.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void SaveCustomer(Customer cus)
        {
            try
            {
                List<Customer> list = GetAllCustomer();
                var size = list.Count;
                cus.CustomerId = size + 1;
                using (var context = new FStoreDBContext())
                {
                    context.Customers.Add(cus);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
