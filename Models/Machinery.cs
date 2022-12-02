using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Models
{
    public class Machinery
    {

        //Fields
        //Trucks
        private int TrId;
        private string TrName;
        private string TrRegistration;
        private string TrServ;
       



        //Propertis- Validations
        //Trucks
        [DisplayName("Id")]
        public int TrId1 { get => TrId; set => TrId = value; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Truck name is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Truck name must be between 2 and 100 characters")]
        public string TrName1 { get => TrName; set => TrName = value; }

        [DisplayName("Registration")]
        [Required(ErrorMessage = "Registration is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Registration must be between 2 and 100 characters")]
        public string TrRegistration1 { get => TrRegistration; set => TrRegistration = value; }

        [DisplayName("Service Date")]
        [Required(ErrorMessage = "Service Date")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Service Date must be between 2 and 100 characters")]
        public string TrServ1 { get => TrServ; set => TrServ = value; }

        

    
    }
    
}
