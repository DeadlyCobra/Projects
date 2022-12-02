using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesForms;
using Projects._Repositories;
using Projects.Models;
using Projects.Views;
using System.Windows.Forms;


namespace Projects.Presenters
{
    public class MainPresnter
    {
        private IMainView mainView;
        private readonly string sqlConnectingString;

       

        public MainPresnter(IMainView mainView, string sqlConnectingString)
        {
            this.mainView = mainView;
            this.sqlConnectingString = sqlConnectingString;
       
            this.mainView.ShowEmpForms += ShowEmpsView;
            this.mainView.ShowMachForms += ShowMachView;
            this.mainView.ShowCustForms += ShowCustView;
        }
        

        private void ShowEmpsView(object? sender, EventArgs e)
        {

            EmployeesView view = EmployeesForm.GetInstance((MainView)mainView);
            IEmpRepository repository = new EmpRepository(sqlConnectingString);
            new EmpPresenter(view, repository);
        }
        private void ShowMachView(object? sender, EventArgs e)
        {
            MachineryView view = MachineryForm.GetInstanceMach((MainView)mainView);
            IMachRepository repository = new MachRepository(sqlConnectingString);
            new MachPresent(view, repository);
        }
        private void ShowCustView(object? sender, EventArgs e)
        {
            CustomersView view = CustomersForms.GetInstance((MainView)mainView);
            ICosRepository repository = new CosRepository(sqlConnectingString);
            new CostPreseter(view, repository);
        }
    }
}
