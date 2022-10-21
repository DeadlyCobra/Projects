using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Models
{
    public interface IEmpRepository
    {
        void Add(Employees employees);
        void Edit(Employees employees);
        void Delete(int id);

        
        IEnumerable<Employees> GetAll();
        IEnumerable<Employees> GetByValue(string value);//Searchs
    }
}
