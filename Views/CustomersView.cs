using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Views
{
    internal interface CustomersView
    {
        //Propertis -Fileds
        string CostId { get; set; }
        string CostCompName { get; set; }
        string CostNip { get; set; }
        string CostContry { get; set; }
        string CostStreetAdres { get; set; }
        string CostCity { get; set; }
        string CostProvince { get; set; }
        string CostPostal { get; set; }
        string CostEmail { get; set; }
        string CostPhonneNum { get; set; }

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

        //Metods
        void SetCostListBindingSource(BindingSource Customerslist);
        void Show();

    }
}
