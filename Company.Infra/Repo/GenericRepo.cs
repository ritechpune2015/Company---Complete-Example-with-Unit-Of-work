using Company.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infra.Repo
{
    public class GenericRepo<T> : IGeneric<T> where T:class
    {
        DbContext db;
        public GenericRepo(CompanyContext temp)
        {
            db = temp;
        }
        public void Add(T rec)
        {
            db.Set<T>().Add(rec);
        }

        public void Delete(long id)
        {
            T rec = db.Set<T>().Find(id);
            db.Set<T>().Remove(rec);
        }

        public void Edit(T rec)
        {
            db.Entry(rec).State = EntityState.Modified;
        }

        public T FindById(long id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
    }
}
