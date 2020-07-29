using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using KikDriveController;

namespace KikDriveServices
{
    public interface IRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll();
        public T Get(int id);
        public int Insert(T obj);
        public void Update(T obj);
        public void Delete(T obj);

    }
}
