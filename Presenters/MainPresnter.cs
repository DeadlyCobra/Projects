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
        }

        private void ShowEmpsView(object? sender, EventArgs e)
        {

            EmployeesView view = EmployeesForm.GetInstance((MainView)mainView);
            IEmpRepository repository = new EmpRepository(sqlConnectingString);
            new EmpPresenter(view, repository);

        }
    }
}
