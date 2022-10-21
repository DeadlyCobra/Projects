using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projects.Presenters.Common
{
    public class ModelDataVaildation
    {
        public void Vaildate(object model)
        {
            string errorMassage = "";
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, results, true);
            if (isValid == false)
            {
                foreach (var item in results)
                
                    errorMassage += "- " + item.ErrorMessage + "\n";
                throw new Exception(errorMassage);
            }

        }
    }
}
