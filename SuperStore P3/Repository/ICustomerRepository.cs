using Models;
using System;
using System.Collections.Generic;

namespace EcoPower_Logistics.Repository
{
    public interface ICustomerRepository :IGenericRepository<Customer>
    {
        Customer GetCustomerById(int id); 
        IEnumerable<Customer> GetAllCustomers();
        void AddCustomer(Customer entity);
        void RemoveCustomer(Customer entity);
        void UpdateCustomer(Customer entity);
    }
}

