using Domain_Layer.Models;
using Repository_layer.IRepository;
using Service_Layer.ICustomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.Services
{
    public class ContactServices : IContactServices
    {
        private readonly IRepository<Contact> _repository;

        public ContactServices(IRepository<Contact> repository)
        {
            this._repository = repository;
        }
        public bool Delete(int id)
        {
           _repository.Delete(_repository.Get(id));
            try
            {
                _repository.SaveChanges();
                return true;
            }
            catch( Exception ex)
            {
                return false;
            }
           
        }

        public Contact Get(int Id)
        {
            return _repository.Get(Id);
        }

        public IEnumerable<Contact> GetAll()
        {
            return _repository.GetAll();
        }

        public void Insert(Contact entity)
        {
            if (entity != null)
            {
                _repository.Insert(entity);
                _repository.SaveChanges();
            }
        }

        public void Remove(Contact entity)
        {
           if(entity!=null)
            {
                _repository.Remove(entity);
                _repository.SaveChanges();
            }
        }

        public void Update(Contact entity)
        {
            if (entity != null)
            {
                _repository.Update(entity);
                _repository.SaveChanges();
            }
        }
    }
}
