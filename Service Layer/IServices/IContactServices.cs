using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.ICustomServices
{
    public interface IContactServices
    {
        IEnumerable<Contact> GetAll();
        Contact Get(int Id);
        void Insert(Contact entity);
        void Update(Contact entity);
        bool Delete(int id);
        void Remove(Contact entity);
    }
}
