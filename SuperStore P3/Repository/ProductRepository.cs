using EcoPower_Logistics.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Models;
using Data;
using coPower_Logistics;


namespace EcoPower_Logistics
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SuperStoreContext _context) : base(_context)
        {
        }

        public Product GetProductById(int id)
        {
            var product = GetAll().FirstOrDefault(x => x.ProductId == id);

            if (product == null)
            {
                
                return null;
            }

            return product;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return GetAll().ToList();
        
        }
        public void addProduct(Product entity)
        {
            Add(entity);
        }
        public void RemoveProduct( Product entity)
        {

            Remove(entity);
        }
        public void updateProduct(Product entity) {
            Update(entity);
        
        }
    }
}






































