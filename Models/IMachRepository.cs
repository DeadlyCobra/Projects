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
    public interface IMachRepositoryFor
    {
        //forktlifts
        void AddFor(Machinery machinery);
        void EditFor(Machinery machinery);
        void DeleteFor(int id);

        IEnumerable<Machinery> GetAllFor(int id);
        IEnumerable<Machinery> GetByValueFor(string value);//Searchs
    }
}
