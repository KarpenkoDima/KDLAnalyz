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

        public virtual void Dispose(bool disposing)
        {            
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }

    class LogAnalizeReposetory : IReposetory<Log>
    {
        public string Name => "Log";
        public string Where = "where [TypeAnalizeID] = {0}";
        DB _db;
        public LogAnalizeReposetory(DB db, int TypeAnalizeID)
        {
            if (db != null)
            {
                _db = db;
            }
            Where = string.Format(Where, TypeAnalizeID);
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Log> GetAll()
        {
            return _db.GetDictlog(this.Name, Where);
        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAll()
        {
            throw new NotImplementedException();
        }
    }
}
