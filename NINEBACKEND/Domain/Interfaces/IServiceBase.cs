namespace Domain.Interfaces
{
    public interface IServiceBase<T> where T: class
    {
      Task<T> GetById(string ID);
      void Add(T entity);
      void Update(T entity);
      void Delete(T entity);
      Task<IEnumerable<T>> GetAll();   
    }
}