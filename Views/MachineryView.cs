using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Views
{
    internal interface MachineryView
    {
        //Propertis -Fileds
        string TrId { get; set; }
        string TrName { get; set; }
        string TrRegistration { get; set; }
        string TrServ { get; set; }
        /*string ForId { get; set; }
        string ForName { get; set; }
        string ForModel { get; set; }
        string ForServ { get; set; }
        */
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
        void SetMachListBindingSource(BindingSource MachineryListe);
        void Show();//optional

    }
}
