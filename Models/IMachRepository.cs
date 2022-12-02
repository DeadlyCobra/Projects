using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Models
{
    public interface IMachRepository
    {
        //truck
        void Add(Machinery machinery);
        void Edit(Machinery machinery);
        void Delete(int id);

        IEnumerable<Machinery> GetAll();
        IEnumerable<Machinery> GetByValue(string value);//Searchs


    }
}
