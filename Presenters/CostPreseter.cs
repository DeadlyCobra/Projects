using Projects.Models;
using Projects.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Presenters
{
    internal class CostPreseter
    {
        //Feilds
        private CustomersView view;
        private ICosRepository repository;
        private BindingSource costBindingSource;
        private IEnumerable<Customers> CustomersList;

        //Constructor
        public CostPreseter(CustomersView view, ICosRepository repository)
        {
            this.costBindingSource= new BindingSource();
            this.view = view;
            this.repository= repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchCost;
            this.view.AddNewEvent += AddNewCost;
            this.view.EditEvent += LoadSelectedCostToEdit;
            this.view.DeleteEvent += DeleteSelectedCost;
            this.view.SaveEvent += SaveCost;
            this.view.CancelEvent += CancaelAction;
            //Set Customers bindnig source
            this.view.SetCostListBindingSource(costBindingSource);
    
            //Load Customers List view
            LoadAllCustomers();
            //Show view
            this.view.Show();
        }
        //Metods
        private void LoadAllCustomers()
        {
            CustomersList=repository.GetAll();
            costBindingSource.DataSource=CustomersList;
        }
        private void SearchCost(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SerchValue);
            if (emptyValue == false)
            {
                CustomersList = repository.GetByValue(this.view.SerchValue);
            }
            else CustomersList = repository.GetAll();
            costBindingSource.DataSource = CustomersList;
        }
        private void AddNewCost(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedCostToEdit(object? sender, EventArgs e)
        {
            var cost = (Customers)costBindingSource.Current;
            view.CostId = cost.ID.ToString();
            view.CostCompName = cost.CostCompName1;
            view.CostNip = cost.CostNip1;
            view.CostContry = cost.CostContry1;
            view.CostStreetAdres = cost.CostStreatAdres1;
            view.CostCity = cost.CostCity1;
            view.CostProvince = cost.CostProvince1;
            view.CostPostal = cost.CostPostal1;
            view.CostEmail = cost.CostEmial1;
            view.CostPhonneNum = cost.CostPhoneNumer1;

            view.IsEdit = true;
        }
        private void SaveCost(object? sender, EventArgs e)
        {
            var model = new Customers();
            model.ID = Convert.ToInt32(view.CostId);
            model.CostCompName1 = view.CostCompName;
            model.CostNip1 = view.CostNip;
            model.CostContry1 = view.CostContry;
            model.CostStreatAdres1 = view.CostStreetAdres;
            model.CostCity1 = view.CostCity;
            model.CostProvince1 = view.CostProvince;
            model.CostPostal1 = view.CostPostal;
            model.CostEmial1 = view.CostEmail;
            model.CostPhoneNumer1 = view.CostPhonneNum;

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
                LoadAllCustomers();
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
            view.CostId = "0";
            view.CostCompName = "";
            view.CostNip = "";
            view.CostContry = "";
            view.CostStreetAdres = "";
            view.CostCity = "";
            view.CostProvince = "";
            view.CostPostal = "";
            view.CostEmail = "";
            view.CostPhonneNum = "";

        }
        private void CancaelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void DeleteSelectedCost(object? sender, EventArgs e)
        {
            try
            {
                var Cost = (Customers)costBindingSource.Current;
                repository.Delete(Cost.ID);
                view.IsSuccessful = true;
                view.Message = "Customers deleted successfully";
                LoadAllCustomers() ;
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error ocurred, could not delete Cusotmers";
            }
        }


    }
}
