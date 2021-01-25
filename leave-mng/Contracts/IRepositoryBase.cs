using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_mng.Contracts
{
    public interface IRepositoryBase<T> where T : class 
    {
        ICollection<T> FindAll();
        T FindById(int id);
        bool Create(T item);
        bool Update(T item);
        bool Delete(T item);
        bool Save();
        bool Exists(int id);
    }
}
