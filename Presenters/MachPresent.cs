using Projects.Models;
using Projects.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Presenters
{
    internal class MachPresent
    {
        //Fields
        //Truck
        private MachineryView view;
        private IMachRepository repository;
        private BindingSource machBindingSource;
        private IEnumerable<Machinery> machineryList;
        //constructor
        public MachPresent(MachineryView view, IMachRepository repository)
        {
            this.machBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchMach;
            this.view.AddNewEvent += AddNewMach;
            this.view.EditEvent += LoadSelectedMachToEdit;
            this.view.DeleteEvent += DeleteSelectedTruck;
            this.view.SaveEvent += SaveMach;
            this.view.CancelEvent += CancaelAction;

            //Set emploice bindnig source
            this.view.SetMachListBindingSource(machBindingSource);

            //Load Employe list view
            LoadAllMachList();
            //Show view
            this.view.Show();
        }
        private void LoadAllMachList()
        {
            machineryList = repository.GetAll();
            machBindingSource.DataSource = machineryList;
        }
        private void SearchMach(object? sender, EventArgs e)
        {
            bool machValue = string.IsNullOrWhiteSpace(this.view.SerchValue);
            if (machValue == false)
            {
                machineryList = repository.GetByValue(this.view.SerchValue);
            }
            else machineryList = repository.GetAll();
            machBindingSource.DataSource = machineryList;
        }
        private void AddNewMach(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedMachToEdit(object? sender, EventArgs e)
        {
            var mach = (Machinery)machBindingSource.Current;
            view.TrId = mach.TrId1.ToString();
            view.TrName = mach.TrName1;
            view.TrRegistration = mach.TrRegistration1;
            view.TrServ = mach.TrServ1;
            view.IsEdit = true;
        }
        private void SaveMach(object? sender, EventArgs e)
        {
            var model = new Machinery();
            model.TrId1 = Convert.ToInt32(view.TrId);
            model.TrName1 = view.TrName;
            model.TrRegistration1 = view.TrRegistration;
            model.TrServ1 = view.TrServ;

            try
            {
                new Common.ModelDataVaildation().Vaildate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Truck edit successfuly";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Truck added successfuly";
                }
                view.IsSuccessful = true;
                LoadAllMachList();
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
            view.TrId = "0";
            view.TrName = "";
            view.TrRegistration = "";
            view.TrServ = "";
        }
        private void CancaelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void DeleteSelectedTruck(object? sender, EventArgs e)
        {
            try
            {
                var mach = (Machinery)machBindingSource.Current;
                repository.Delete(mach.TrId1);
                view.IsSuccessful = true;
                view.Message = "Truck deleted successfully";
                LoadAllMachList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error ocurred, could not delete Truck";
            }
        }
        
    }


    }
