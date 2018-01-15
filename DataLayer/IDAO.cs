using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDAO <T> where T:class
    {
        void Create(T t);
        T Read(string id);
        void Update( T t);
        void Delete(string id);
    }
}
