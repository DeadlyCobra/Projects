using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Projects.Models
{
    public class Employees
    {
        //Fields
        private int id;
        private string Firname;
        private string LasNane;
        private string Streat;
        private string City;
        private string Province;
        private string Postal;
        private string Emial;
        private string PhoneNumer;
        private string Position;

        //Propertis- Validations
        [DisplayName("ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("FirstName")]
        [Required(ErrorMessage ="First Name is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 100 characters")]
        public string Firname1 { get => Firname; set => Firname = value; }

        [DisplayName("LastName")]
        [Required(ErrorMessage = "Last Name is requerid")]
        [StringLength(100,MinimumLength =2,ErrorMessage ="Last Name must be between 2 and 100 characters")]
        public string LasNane1 { get => LasNane; set => LasNane = value; }

        [DisplayName("StreatAdres")]
        [Required(ErrorMessage = "Streat Addres is requerid")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Streat must be between 5 and 100 characters")]
        public string Streat1 { get => Streat; set => Streat = value; }

        [DisplayName("City")]
        [Required(ErrorMessage = "City is requerid")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "City must be between 5 and 100 characters")]
        public string City1 { get => City; set => City = value; }

        [DisplayName("Province")]
        [Required(ErrorMessage = "Province is requerid")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Province must be between 5 and 100 characters")]
        public string Province1 { get => Province; set => Province = value; }

        [DisplayName("Postal")]
        [Required(ErrorMessage = "Postal is requerid")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Postal must be between 5 and 100 characters")]
        public string Postal1 { get => Postal; set => Postal = value; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Emial is requerid")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Emial must be between 5 and 100 characters")]
        public string Emial1 { get => Emial; set => Emial = value; }

        [DisplayName("PhonneNum")]
        [Required(ErrorMessage = "Phone nummer is requerid")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Phone nummer must be between 9 and 9 characters")]
        public string PhoneNumer1 { get => PhoneNumer; set => PhoneNumer = value; }

        [DisplayName("Position")]
        [Required(ErrorMessage = "Position nummer is requerid")]
        public string Position1 { get => Position; set => Position = value; }
    }
}
