using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Models
{
    internal class Customers
    {
        //Fields
        private int id;
        private string? CostCompName;
        private string? CostNip;
        private string? CostContry;
        private string? CostStreatAdres;
        private string? CostCity;
        private string? CostProvince;
        private string? CostPostal;
        private string? CostEmial;
        private string? CostPhoneNumer;

        //Propertis- Validations
        [DisplayName("ID")]
        public int ID { get => id; set => id = value; }

        [DisplayName("CompanyName")]
        [Required(ErrorMessage = "Company Name is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Company Name must be between 2 and 100 characters")]
        public string? CostCompName1 { get => CostCompName; set => CostCompName = value; }

        [DisplayName("CompanyNip")]
        [Required(ErrorMessage = "Nip is requerid")]
        [StringLength(13, MinimumLength = 8, ErrorMessage = "Nip  must be between 8 and 13 characters")]
        public string? CostNip1 { get => CostNip; set => CostNip = value; }

        [DisplayName("Country")]
        [Required(ErrorMessage = "Country is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Country  must be between 2 and 100 characters")]
        public string? CostContry1 { get => CostContry; set => CostContry = value; }

        [DisplayName("StreetAddres")]
        [Required(ErrorMessage = "StreatAddres is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "StreetAddres  must be between 2 and 100 characters")]
        public string? CostStreatAdres1 { get => CostStreatAdres; set => CostStreatAdres = value; }

        [DisplayName("City")]
        [Required(ErrorMessage = "City is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "City  must be between 2 and 100 characters")]
        public string? CostCity1 { get => CostCity; set => CostCity = value; }

        [DisplayName("City")]
        [Required(ErrorMessage = "City is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "City  must be between 2 and 100 characters")]
        public string? CostProvince1 { get => CostProvince; set => CostProvince = value; }

        [DisplayName("Postal")]
        [Required(ErrorMessage = "Postal is requerid")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Postal  must be between 5 and 10 characters")]
        public string? CostPostal1 { get => CostPostal; set => CostPostal = value; }

        [DisplayName("Postal")]
        [Required(ErrorMessage = "Postal is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Postal  must be between 2 and 100 characters")]
        public string? CostEmial1 { get => CostEmial; set => CostEmial = value; }

        [DisplayName("PhoneNumber")]
        [Required(ErrorMessage = "PhoneNumber is requerid")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "PhoneNumber  must be between 9 and 9 characters")]
        public string? CostPhoneNumer1 { get => CostPhoneNumer; set => CostPhoneNumer = value; }

    }
}
