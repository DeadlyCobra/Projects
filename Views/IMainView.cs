using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Views
{
    public interface IMainView
    {
        event EventHandler ShowEmpForms;
        event EventHandler ShowMachForms;
        event EventHandler ShowCustForms;
          
    }
}
