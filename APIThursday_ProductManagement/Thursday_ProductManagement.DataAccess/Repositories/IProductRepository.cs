using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thursday_ProductManagement.DataAccess.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        
      
        
    }
}
//    /// <summary>
//    /// Creating a Product
//    /// </summary>
//    /// <param name="product"></param>
//    /// <returns></returns>
//    public bool CreateProduct(Product product);

//    /// <summary>
//    /// Getting All the products
//    /// </summary>
//    /// <returns></returns>
//    public IEnumerable<Product> GetAll();

//    /// <summary>
//    /// Updating The products
//    /// </summary>
//    /// <param name="product"></param>
//    /// <returns></returns>

//    public bool UpdateProduct(Product product);

//    /// <summary>
//    /// DEleting the product
//    /// </summary>
//    /// <param name="id"></param>
//    /// <returns></returns>
//    public bool DeleteProduct(int id);

//    /// <summary>
//    /// Get the Single Product ID
//    /// </summary>
//    /// <param name="id"></param>
//    /// <returns></returns>

//    public Product GetProductById(int id);