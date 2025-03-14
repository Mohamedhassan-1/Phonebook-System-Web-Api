using Repository_layer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Layer.Data_Folder;
using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
namespace Repository_layer.Repository
{
    public class Repository<T>:IRepository<T> where T:BaseEntity
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> entities;
        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
        }

        public T Get(int Id)
        {
            return entities.SingleOrDefault(c => c.id == Id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            try
            {
                _applicationDbContext.SaveChanges();
            }
            catch(Exception ex)
            {

            }
        }

        public void Update(T entity)
        {
            entities.Update(entity);
            SaveChanges();
        }
    }
}
