using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Models
{
    internal class Orders
    {
        //Fields
        private int id;
        private string ordCompanName;
        private string ordComAddress;
        private string ordComCity;
        private string ordComCountry;
        private string ordComPostal;
        private string ordKindOfCargo;
        private string ordTrailer;
        private string ordWeight;
        private string ordDateOfDeparture;
        private string ordDeliveryDate;
        private string ordCarriagePrice;
        private string ordtTrucker;
        private string ordtTruck;
        private string ordtExpenses;

        //Propertis- Validations
        [DisplayName("ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("CompanyName")]
        [Required(ErrorMessage = "Company Name is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Company Name must be between 2 and 100 characters")]
        public string OrdCompanName { get => ordCompanName; set => ordCompanName = value; }

        [DisplayName("StreetAddres")]
        [Required(ErrorMessage = "StreatAddres is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "StreetAddres  must be between 2 and 100 characters")]
        public string OrdComAddress { get => ordComAddress; set => ordComAddress = value; }

        [DisplayName("City")]
        [Required(ErrorMessage = "City is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "City  must be between 2 and 100 characters")]
        public string OrdComCity { get => ordComCity; set => ordComCity = value; }

        [DisplayName("Country")]
        [Required(ErrorMessage = "Country is requerid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Country  must be between 2 and 100 characters")]
        public string OrdComCountry { get => ordComCountry; set => ordComCountry = value; }

        [DisplayName("Postal")]
        [Required(ErrorMessage = "Postal is requerid")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Postal  must be between 5 and 10 characters")]
        public string OrdComPostal { get => ordComPostal; set => ordComPostal = value; }

        [DisplayName("KindOfCargo")]
        [Required(ErrorMessage = "KindOfCargo is requerid")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "KindOfCargo  must be between 2 and 100 characters")]
        public string OrdKindOfCargo { get => ordKindOfCargo; set => ordKindOfCargo = value; }

        [DisplayName("Trailer")]
        [Required(ErrorMessage = "Trailer is requerid")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Trailer  must be between 2 and 100 characters")]
        public string OrdTrailer { get => ordTrailer; set => ordTrailer = value; }

        [DisplayName("Weight")]
        [Required(ErrorMessage = "Weight is requerid")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Weight  must be between 2 and 100 characters")]
        public string OrdWeight { get => ordWeight; set => ordWeight = value; }

        [DisplayName("DateOfDeparture")]
        [Required(ErrorMessage = "DateOfDeparture is requerid")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Weight  must be between 2 and 100 characters")]
        public string OrdDateOfDeparture { get => ordDateOfDeparture; set => ordDateOfDeparture = value; }

        [DisplayName("DeliveryDate")]
        [Required(ErrorMessage = "DeliveryDate is requerid")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "DeliveryDate  must be between 2 and 100 characters")]
        public string OrdDeliveryDate { get => ordDeliveryDate; set => ordDeliveryDate = value; }

        [DisplayName("CarriagePrice")]
        [Required(ErrorMessage = "CarriagePrice is requerid")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "CarriagePrice  must be between 2 and 100 characters")]
        public string OrdCarriagePrice { get => ordCarriagePrice; set => ordCarriagePrice = value; }

        [DisplayName("Trucker")]
        [Required(ErrorMessage = "Trucker is requerid")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Trucker  must be between 2 and 100 characters")]
        public string OrdtTrucker { get => ordtTrucker; set => ordtTrucker = value; }

        [DisplayName("Truck")]
        [Required(ErrorMessage = "Truck is requerid")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Truck  must be between 2 and 100 characters")]
        public string OrdtTruck { get => ordtTruck; set => ordtTruck = value; }

        [DisplayName("Expenses")]
        [Required(ErrorMessage = "Expenses is requerid")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Expenses  must be between 2 and 100 characters")]
        public string OrdtExpenses { get => ordtExpenses; set => ordtExpenses = value; }
    }
}
