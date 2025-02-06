namespace Product_Managementmvc.DataAccess.Repository
{
    public interface IRepository<T> where T : class
    {
        public bool Create(T entity);

        IEnumerable<T> GetAll();

        T GetById(int id);

        bool Update(T entity);

        bool Delete(int id);
    }
}
