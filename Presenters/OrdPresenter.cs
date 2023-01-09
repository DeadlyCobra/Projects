using Projects.Models;
using Projects.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Presenters
{
    
    internal class OrdPresenter
    {
        //Feilds
        private IOrdersView view;
        private IOrdRepository repository;
        private BindingSource ordBindingSource;
        private IEnumerable<Orders> OrdersListe;
        //Constructor
        public OrdPresenter(IOrdersView view,IOrdRepository repository)
        {
            this.ordBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchOrd;
            this.view.AddNewEvent += AddNewOrd;
            this.view.EditEvent += LoadSelectedOrdToEdit;
            this.view.DeleteEvent += DeleteSelectedOrd;
            this.view.SaveEvent += SaveOrd;
            this.view.CancelEvent += CancaelAction;
            //Set Customers bindnig source
            this.view.SetOrdListBindingSource(ordBindingSource);

            //Load Customers List view
            LoadAllOrders();
            //Show view
            this.view.Show();
        }
        //Metods
        private void LoadAllOrders()
        {
            OrdersListe = repository.GetAll();
            ordBindingSource.DataSource = OrdersListe;
        }
        private void SearchOrd(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SerchValue);
            if (emptyValue == false)
            {
                OrdersListe = repository.GetByValue(this.view.SerchValue);
            }
            else OrdersListe = repository.GetAll();
            ordBindingSource.DataSource = OrdersListe;
        }
        private void AddNewOrd(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedOrdToEdit(object? sender, EventArgs e)
        {
            var Ord = (Orders)ordBindingSource.Current;
            view.OrdId = Ord.Id.ToString();
            view.OrdCompName = Ord.OrdCompanName;
            view.OrdStreetAdres =Ord.OrdComAddress ;
            view.OrdCity = Ord.OrdComCity;
            view.OrdCountry = Ord.OrdComCountry;
            view.OrdPostal = Ord.OrdComPostal;
            view.OrdCargoType = Ord.OrdKindOfCargo;
            view.OrdTrailer = Ord.OrdTrailer;
            view.OrdWeight = Ord.OrdWeight;
            view.OrdDateofdeparture = Ord.OrdDateOfDeparture;
            view.OrdDeliverydate = Ord.OrdDeliveryDate;
            view.OrdCarriageprice = Ord.OrdCarriagePrice;
            view.Ordtrucker = Ord.OrdtTrucker;
            view.Ordtruck = Ord.OrdtTruck;
            view.OrdExpenses = Ord.OrdtExpenses;

            view.IsEdit = true;
        }
        private void SaveOrd(object? sender, EventArgs e)
        {
            var model = new Orders();
            model.Id= Convert.ToInt32(view.OrdId);
            model.OrdCompanName = view.OrdCompName;
            model.OrdComAddress = view.OrdStreetAdres;
            model.OrdComCity = view.OrdCity;
            model.OrdComCountry = view.OrdCountry;
            model.OrdComPostal= view.OrdPostal;
            model.OrdKindOfCargo= view.OrdCargoType;
            model.OrdTrailer= view.OrdTrailer;
            model.OrdWeight= view.OrdWeight;
            model.OrdDateOfDeparture= view.OrdDateofdeparture;
            model.OrdDeliveryDate= view.OrdDeliverydate;
            model.OrdCarriagePrice= view.OrdCarriageprice;
            model.OrdtTrucker= view.Ordtrucker;
            model.OrdtTruck= view.Ordtruck;
            model.OrdtExpenses = view.OrdExpenses;



            try
            {
                new Common.ModelDataVaildation().Vaildate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Customers edit successfuly";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Customers added successfuly";
                }
                view.IsSuccessful = true;
                LoadAllOrders();
                CleanViewFields();
            }
            catch (Exception ex)
            {
               view.IsSuccessful = false;
               view.Message = ex.Message;
            }
        }
        private void CleanViewFields()
        {
            view.OrdId = "0";
            view.OrdCompName = "";
            view.OrdStreetAdres ="";
            view.OrdCity = "";
            view.OrdCountry = "";
            view.OrdPostal = "";
            view.OrdCargoType = "";
            view.OrdTrailer = "";
            view.OrdWeight = "";
            view.OrdDateofdeparture = "";
            view.OrdDeliverydate = "";
            view.OrdCarriageprice = "";
            view.Ordtrucker = "";
            view.Ordtruck = "";
            view.OrdExpenses = "";

        }
        private void CancaelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void DeleteSelectedOrd(object? sender, EventArgs e)
        {
            try
            {
                var Ords = (Orders)ordBindingSource.Current;
                repository.Delete(Ords.Id);
                view.IsSuccessful = true;
                view.Message = "Orders deleted successfully";
                LoadAllOrders();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error ocurred, could not delete orders";
            }
        }




    }
}
