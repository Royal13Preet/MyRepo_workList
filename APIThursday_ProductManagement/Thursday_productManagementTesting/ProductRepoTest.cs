using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.DataAccess.Repositories;

namespace Thursday_productManagementTesting
{
    public class ProductRepoTest
    {
        private static ProductDbContext GetdbContext()
        {
            var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;
            return new ProductDbContext(options);
        }

        private static Repository<Product> GetRepository(ProductDbContext context)
        {
            var mockLogger = new Mock<ILogger<Repository<Product>>>();
            return new Repository<Product>(context, mockLogger.Object);
        }
        
 
         [Fact]
        public void Create_Entity_Should_Add_To_Database()
        {
            //Arrange
            var context = GetdbContext();
            var repository = GetRepository(context);
            var entity = new Product { Id = 1, Name = "Test Product", Price = 45 };

            //Act
            var result = repository.Create(entity);

            //Assert
            Assert.True(result);
            Assert.Single(context.Set<Product>());
        }
         
        [Fact]
        public void GetAll_should_return_all_Entities()
        {
            var context = GetdbContext();
            var repository = GetRepository(context);
            context.Set<Product>().AddRange(
                new Product { Id = 1, Name = "Product 1", Price = 67 },
                new Product { Id = 2, Name = "Product 2", Price = 45 });
            context.SaveChanges();

            //Act
            var result = repository.GetAll().ToList();

            //Assert
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetById_should_Return_Correct_Entity()
        {
            //Arrange
            var context = GetdbContext();
            var repository = GetRepository(context);
            var entity = new Product { Id = 1, Name = "Product 1", Price = 43 };
            context.Set<Product>().Add(entity);
            context.SaveChanges();

            //Act
            var result = repository.GetById(1);

            //Assert
            Assert.NotNull(result);
            Assert.Equal("Product 1", result.Name);
        }

        [Fact]
        public void Update_Entity_should_Modify_Existing_Records()
        {
            var context = GetdbContext();
            var repository = GetRepository(context);
            var entity = new Product { Id = 1, Name = "old Name", Price = 33 };
            context.Set<Product>().Add(entity);
            context.SaveChanges();

            //Act
            entity.Name = "New Name";
            var result = repository.Update(entity);

            //Assert
            Assert.True(result);
            Assert.Equal("New Name", context.Set<Product>().Find(1)!.Name);
        }

       
        [Fact]
        public void Delete_Entity_should_remove_from_database()
        {
            var context = GetdbContext();
            var repository = GetRepository(context);
            var entity = new Product { Id = 1, Name = "Product 1", Price = 34 };
            context.Set<Product>().Add(entity);
            context.SaveChanges();

            //Act
            var result = repository.Delete(1);

            //Assert
            Assert.True(result);
            Assert.Null(context.Set<Product>().Find(1));
        }
    }
}
