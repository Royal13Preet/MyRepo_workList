using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thursday_ProductManagement.DataAccess.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        public ProductRepository(ProductDbContext context, ILogger<ProductRepository> logger) : base(context, logger) { }

    }
}


//private readonly ProductDbContext _dbcontext;
//private readonly ILogger<ProductRepository> _logger;

//public ProductRepository(ProductDbContext dbcontext, ILogger<ProductRepository> looger)
//{
//    _dbcontext = dbcontext;
//    _logger = looger;
//}

//public bool CreateProduct(Product product)
//{
//    try
//    {
//        _dbcontext.Products.Add(product);
//        _dbcontext.SaveChanges();
//        return true;
//    }
//    catch (Exception ex)
//    {
//        _logger.LogError(ex, "Error While Adding the Product");
//        throw;
//    }
//}

//public bool DeleteProduct(int id)
//{
//    try
//    {
//        var res = _dbcontext.Products.AsNoTracking().FirstOrDefault(x => x.Id == id);
//        if (res != null)
//        {
//            _dbcontext.Products.Remove(res);
//            _dbcontext.SaveChanges();
//            return true;
//        }
//    }
//    catch (Exception ex)
//    {
//        _logger.LogError(ex, "Error While delting the product");
//    }
//    return false;
//}

//public IEnumerable<Product> GetAll()
//{
//    try
//    {
//        return _dbcontext.Products.ToList();
//    }
//    catch (Exception ex)
//    {
//        _logger.LogError(ex, "Error While Fetching the product");
//        throw;
//    }
//}

//public Product GetProductById(int id)
//{
//    try
//    {
//        var product = _dbcontext.Products.FirstOrDefault(x => x.Id == id);
//        return product!;
//    }
//    catch (Exception ex)
//    {
//        _logger.LogError(ex, "Error while fething the product");
//        throw;
//    }
//}

//public bool UpdateProduct(Product product)
//{
//    try
//    {
//        _dbcontext.Products.Update(product);

//        _dbcontext.SaveChanges();
//        return true;
//        //return false;
//    }
//    catch (Exception ex)
//    {
//        _logger.LogError(ex, "Error while updating the product");
//        throw;
//    }

//}