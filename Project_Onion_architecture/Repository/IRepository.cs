﻿namespace Project_Onion_architecture.Repository
{
    public interface IRepository<T> where T : class
    {
        public void Add(T entity);
        public List<T> GetAll();
        public T GetById(int id);
        public void Update(T entity);
        public void Delete(T entity);


    }
}
