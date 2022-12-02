using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Models
{
    internal interface ICosRepository
    {
        void Add(Customers Customers);
        void Edit( Customers Customers);
        void Delete(int id);


        IEnumerable<Customers> GetAll();
        IEnumerable<Customers> GetByValue(string value);
    }
}
