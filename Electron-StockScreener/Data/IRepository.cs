using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electron_StockScreener.Data
{
    interface IRepository<T> where T : class
    {
        T Find(Guid? guid);
        T Find(Guid? id, Guid? pid);
        T Find(int? id);
        IEnumerable<T> GetCollections();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void AddList(IEnumerable<T> entityList);
        void UpdateList(IEnumerable<T> entityList);
        void DeleteList(IEnumerable<T> entityList);
    }
}
