
using Project_Onion_architecture.Repository;

namespace Project_Onion_architecture.Service
{
    public abstract class Service<T> : IService<T> where T : class
    {
        public IRepository<T> obj;
        public Service(IRepository<T>obj)
        {
            this.obj = obj;
        }
        public virtual void Add(T entity)
        {
            obj.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            obj.Delete(entity);
        }

        public virtual List<T> GetAll()
        {
            return obj.GetAll();
        }

        public virtual T GetById(int id)
        {
           return obj.GetById(id);
        }

        public virtual void Update(T entity)
        {
            obj.Update(entity);
        }
    }
}
