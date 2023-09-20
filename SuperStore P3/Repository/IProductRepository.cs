using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        
        Product GetProductById(int id);
        void updateProduct(Product entity);
        void RemoveProduct(Product entity);
        void addProduct(Product entity);
        IEnumerable<Product> GetAllProducts();
    }
    
}
