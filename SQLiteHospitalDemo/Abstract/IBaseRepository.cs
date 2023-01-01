using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteHospitalDemo.Abstract
{
    public interface IBaseRepository<T> : IDisposable where T : TableData, new()
    {
        List<T> GetAll();
        void Add(T item);
        void Delete(T item);
    }
}
