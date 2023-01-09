using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Views
{
    public interface IOrdersView
    {
        //Propertis -Fileds
        string OrdId { get; set; }
        string OrdCompName { get; set; }
        string OrdCountry { get; set; }
        string OrdStreetAdres { get; set; }
        string OrdCity { get; set; }
        string OrdPostal { get; set; }
        string OrdCargoType { get; set; }
        string OrdWeight { get; set; }
        string OrdTrailer { get; set; }
        string Ordtruck { get; set; }
        string Ordtrucker { get; set; }
        string OrdDateofdeparture { get; set; }
        string OrdDeliverydate { get; set; }
        string OrdCarriageprice { get; set; }
        string OrdExpenses { get; set; }

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
        void SetOrdListBindingSource(BindingSource OrdersLista);
        void Show();
    }
}
