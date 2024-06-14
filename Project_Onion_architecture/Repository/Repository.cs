using Microsoft.EntityFrameworkCore;
using Project_Onion_architecture.Data;

namespace Project_Onion_architecture.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext db;
        public Repository(ApplicationDbContext db)
        {
            this.db = db;
            
        }
        public DbSet<T> table
        {
            get { return this.db.Set<T>();}
        }
        public virtual void Add(T entity)
        {
            table.Add(entity);
            db.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            table.Remove(entity);
            db.SaveChanges();
        }

        public virtual List<T> GetAll()
        {
            return table.ToList();
        }

        public virtual T GetById(int id)
        {
            return table.Find(id);
        }

        public virtual void Update(T entity)
        {
            table.Update(entity);
            db.SaveChanges();
        }
    }
}
