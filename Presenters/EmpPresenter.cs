using Projects.Models;
using Projects.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Presenters
{
    internal class EmpPresenter
    {
        //Fields
        private EmployeesView view;
        private IEmpRepository repository;
        private BindingSource empBindingSource;
        private IEnumerable<Employees> employeesList;
       

        //constructor
        public EmpPresenter(EmployeesView view, IEmpRepository repository)
        {
            this.empBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchEmp;
            this.view.AddNewEvent += AddNewEmp;
            this.view.EditEvent += LoadSelectedEmpToEdit;
            this.view.DeleteEvent += DeleteSelectedEmp;
            this.view.SaveEvent += SaveEmp;
            this.view.CancelEvent += CancaelAction;
            
            //Set emploice bindnig source
            this.view.SetEmpListBindingSource(empBindingSource);
            //Load Employe list view
            LoadAllEmpList();
            //Show view
            this.view.Show();
        }
        //Methods
        private void LoadAllEmpList()
        {
            employeesList = repository.GetAll();
            empBindingSource.DataSource=employeesList;
        }
       
        private void SearchEmp(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SerchValue);
            if (emptyValue == false)
            {
                employeesList = repository.GetByValue(this.view.SerchValue);
            }
            else employeesList = repository.GetAll();
            empBindingSource.DataSource=employeesList;
        }
        private void AddNewEmp(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedEmpToEdit(object? sender, EventArgs e)
        {
            var emp = (Employees)empBindingSource.Current;
            view.EmpId = emp.Id.ToString();
            view.EmpFirstName = emp.Firname1;
            view.EmpLastName = emp.LasNane1;
            view.EmpStreatAdres = emp.Streat1;
            view.EmpCity = emp.City1;
            view.EmpProvince = emp.Province1;
            view.EmpPostal = emp.Postal1;
            view.EmpEmail = emp.Emial1;
            view.EmpPhonneNum = emp.PhoneNumer1;
            view.EmpPosition = emp.Position1;
            view.IsEdit = true;
        }
        private void SaveEmp(object? sender, EventArgs e)
        {
            var model = new Employees();
           
            model.Firname1 = view.EmpFirstName ;
            model.LasNane1 = view.EmpLastName  ;
            model.Streat1 = view.EmpStreatAdres ;
            model.City1 = view.EmpCity ;
            model.Province1 = view.EmpProvince  ;
            model.Postal1 = view.EmpPostal ;
            model.Emial1 = view.EmpEmail ;
            model.PhoneNumer1 = view.EmpPhonneNum  ;
            model.Position1 = view.EmpPosition ;
            try
            {
                new Common.ModelDataVaildation().Vaildate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Employes edit successfuly";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Employes added successfuly";
                }
                view.IsSuccessful = true;
                LoadAllEmpList();
                CleanViewFields();
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message=ex.Message;
            }
        }
        private void CleanViewFields()
        {
            view.EmpId = "0";
            view.EmpFirstName = "";
            view.EmpLastName = "";
            view.EmpStreatAdres = "";
            view.EmpCity = "";
            view.EmpProvince = "";
            view.EmpPostal = "";
            view.EmpEmail = "";
            view.EmpPhonneNum = "";
            view.EmpPosition = "";

        }
        private void CancaelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void DeleteSelectedEmp(object? sender, EventArgs e)
        {
            try
            {
                var emp = (Employees)empBindingSource.Current;
                repository.Delete(emp.Id);
                view.IsSuccessful = true;
                view.Message = "Employes deleted successfully";
                LoadAllEmpList();
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error ocurred, could not delete Employes";
            }
        }


    }
}
