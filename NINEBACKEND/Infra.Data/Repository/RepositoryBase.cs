using Domain.Interfaces;

namespace Infra.Data.Repository

{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly DataContext context;
        public Repository(DataContext Context){
            this.context = context;
        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(string ID)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}