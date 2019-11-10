using KDLAnalize.MainWinForms.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDLAnalize.MainWinForms.BAL
{

    public interface IReposetory<T>:IDisposable where T:class
    {
        string Name { get; }
        void UpdateAll();
        List<T> GetAll();
        void Delete(int Id);
        object GetById(int id);
    }
    class TypeAnalizeReposetory : IReposetory<TypeAnalize>
    {
        DB _db;
        public TypeAnalizeReposetory(DB db)
        {
            if (db != null)
            {
                _db = db;
            }
        }
        public string Name => "TypeAnalize";

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }      
        public List<TypeAnalize> GetAll()
        {
            return _db.GetDict(Name);
        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAll()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
