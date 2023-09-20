
using Data;
using EcoPower_Logistics.Repository;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using coPower_Logistics;


namespace EcoPower_Logistics
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
       
            public CustomerRepository(DbContextOptions<SuperStoreContext> options, IConfiguration configuration)
                : base(new SuperStoreContext(options, configuration))
            {
            }
        


        public Customer GetCustomerById(int id)
        {
            var customer = GetAll().FirstOrDefault(c => c.CustomerId == id);
            return customer;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return GetAll().ToList();
        }

        public void AddCustomer(Customer entity)
        {
            Add(entity);
        }

        public void RemoveCustomer(Customer entity)
        {
            Remove(entity);
        }

        public void UpdateCustomer(Customer entity)
        {
            Update(entity);
        }
    }
}

