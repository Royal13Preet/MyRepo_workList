using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PracticeProductManagements.DataAccess;
using PracticeProductManagements.DataAccess.DBModel;
using PracticeProductManagements.DataAccess.Repositories;
using PracticeProductManagements.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticeProductManagements.Manager
{
    public class ProductManger : IProductManager
    { 
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductManger> _logger;

        public ProductManger(IProductRepository repository, IMapper mapper, ILogger<ProductManger> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }
        public Product AddNewProduct(ProductDetailsDto product)
        {
            try
            {
                _logger.LogInformation("Attempting to add a new product.");
                var productEntity = _mapper.Map<Product>(product);



                //productEntity.TotalPrice = productEntity.Price * productEntity.StockQuantity;

                var isCreated = _repository.AddProduct(productEntity);

                if (isCreated)
                {
                    _logger.LogInformation("Product added successfully.");
                    return productEntity;  
                }
                else
                {
                    _logger.LogWarning("Product creation failed.");
                    return null!;  
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding a new product.");
                return null;
            }
        }
        public IEnumerable<Product> GetAlltheProducts()
        {
            try
            {
                var products = _repository.GetAllProducts();
                _logger.LogInformation("Fetched all products successfully.");
                return _mapper.Map<List<Product>>(products);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching all products.");
                return null!;
            }

        }
        public Product GetProductById(Guid id)
        {
            try
            {
                var productById = _repository.GetProductByID(id);
                return _mapper.Map<Product>(productById);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching product by ID: {ProductId}.", id);
                return null!;
            }
        }

        public bool RemoveNewProduct(Guid id)
        {
            try
            {
                var isDeleted = _repository.DeleteProduct(id);
                if (isDeleted)
                {
                    _logger.LogInformation("Product with ID: {ProductId} deleted successfully.", id);
                }
                else
                {
                    _logger.LogWarning("Failed to delete product with ID: {ProductId}.", id);
                }
                return isDeleted;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting product with ID: {ProductId}.", id);
            }
            return false;
        }
        public bool UpdateNewProduct(Guid id, ProductDetailsDto productdetailsdto)
        {
           
            try
            {
                var existingProduct = _repository.GetProductByID(id);
                if (existingProduct == null)
                {
                    _logger.LogWarning($"Product with ID {id} not found.");
                    return false;
                }

                var updatedProduct = _mapper.Map(productdetailsdto, existingProduct);

                updatedProduct.TotalPrice = updatedProduct.Price * updatedProduct.StockQuantity;

                var isUpdated = _repository.UpdateProduct(updatedProduct);

                if (isUpdated)
                {
                    _logger.LogInformation("Product updated successfully.");
                }
                else
                {
                    _logger.LogWarning("Failed to update the product.");
                }
                
                return isUpdated;
            }
            
           
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the product.");
                return false;
            }

        }
    }
}

//    var update = _mapper.Map<Product>(productdetailsdto);







