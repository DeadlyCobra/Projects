using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Models
{
    internal interface IOrdRepository
    {
        void Add(Orders orders);
        void Edit(Orders orders);
        void Delete(int id);


        IEnumerable<Orders> GetAll();
        IEnumerable<Orders> GetByValue(string value);
    }
}
