using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Views
{
    public interface EmployeesView
    {
        //Propertis -Fileds
        string EmpId { get; set; }
        string EmpFirstName { get; set; }
        string EmpLastName { get; set; }
        string EmpStreatAdres { get; set; }
        string EmpCity { get; set; }
        string EmpProvince { get; set; }
        string EmpPostal { get; set; }
        string EmpEmail { get; set; }
        string EmpPhonneNum { get; set; }
        string EmpPosition { get; set; }
        
        string SerchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetEmpListBindingSource(BindingSource Employesslist);
        void Show();//optional
        

        
    }
}
