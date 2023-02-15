using Projects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;

namespace Projects._Repositories
{
    internal class OrdRepository:BaseRepository,IOrdRepository
    {
        //Constructor
        public OrdRepository(string connectionString)
        {
            this.ConnectingString = connectionString;
        }

        public void Add(Orders orders)
        {
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("AddOrders"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CompanyName", orders.OrdCompanName);
                command.Parameters.AddWithValue("@CompanyAdres", orders.OrdComAddress);
                command.Parameters.AddWithValue("@CompanyCity", orders.OrdComCity);
                command.Parameters.AddWithValue("@CompanyContry", orders.OrdComCountry);
                command.Parameters.AddWithValue("@CompanyPostPostal", orders.OrdComPostal);
                command.Parameters.AddWithValue("@KindOfCargo", orders.OrdKindOfCargo);
                command.Parameters.AddWithValue("@Trailer", orders.OrdTrailer);
                command.Parameters.AddWithValue("@Weight", orders.OrdWeight);
                command.Parameters.AddWithValue("@DateOfDeparture", orders.OrdDateOfDeparture);
                command.Parameters.AddWithValue("@DeliverDate", orders.OrdDeliveryDate);
                command.Parameters.AddWithValue("@CarriagePrice", orders.OrdCarriagePrice);
                command.Parameters.AddWithValue("@Trucker", orders.OrdtTrucker);
                command.Parameters.AddWithValue("@Truck", orders.OrdtTruck);
                command.Parameters.AddWithValue("@Expenses", orders.OrdtExpenses);
                command.ExecuteNonQuery();
            }
        }

        public void Edit(Orders orders)
        {
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("EditOrders"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@OrdId", orders.Id);
                command.Parameters.AddWithValue("@CompanyName", orders.OrdCompanName);
                command.Parameters.AddWithValue("@CompanyAdres", orders.OrdComAddress);
                command.Parameters.AddWithValue("@CompanyCity", orders.OrdComCity);
                command.Parameters.AddWithValue("@CompanyContry", orders.OrdComCountry);
                command.Parameters.AddWithValue("@CompanyPostPostal", orders.OrdComPostal);
                command.Parameters.AddWithValue("@KindOfCargo", orders.OrdKindOfCargo);
                command.Parameters.AddWithValue("@Trailer", orders.OrdTrailer);
                command.Parameters.AddWithValue("@Weight", orders.OrdWeight);
                command.Parameters.AddWithValue("@DateOfDeparture", orders.OrdDateOfDeparture);
                command.Parameters.AddWithValue("@DeliverDate", orders.OrdDeliveryDate);
                command.Parameters.AddWithValue("@CarriagePrice", orders.OrdCarriagePrice);
                command.Parameters.AddWithValue("@Trucker", orders.OrdtTrucker);
                command.Parameters.AddWithValue("@Truck", orders.OrdtTruck);
                command.Parameters.AddWithValue("@Expenses", orders.OrdtExpenses);
                command.ExecuteNonQuery();
            }
        
        }

        public void Delete(int id)
        {
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("DeleteOrders"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", id); ;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Orders> GetAll()
        {

            var OrdList = new List<Orders>();
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectOrders"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ordModel = new Orders();
                        ordModel.Id = (int)reader[0];
                        ordModel.OrdCompanName= (string)reader[1];
                        ordModel.OrdComAddress= (string)reader[2];
                        ordModel.OrdComCity= (string)reader[3];
                        ordModel.OrdComCountry= (string)reader[4];
                        ordModel.OrdComPostal= (string)reader[5];
                        ordModel.OrdKindOfCargo= (string)reader[6];
                        ordModel.OrdTrailer= (string)reader[7];
                        ordModel.OrdWeight= (string)reader[8];
                        ordModel.OrdDateOfDeparture= (string)reader[9];
                        ordModel.OrdDeliveryDate= (string)reader[10];
                        ordModel.OrdCarriagePrice= (string)reader[11] ;
                        ordModel.OrdtTrucker= (string)reader[12];
                        ordModel.OrdtTruck= (string)reader[13];
                        ordModel.OrdtExpenses = (string)reader[14];
                        OrdList.Add(ordModel);
                    }
                }
            }
            return OrdList;
        }

        public IEnumerable<Orders> GetByValue(string value)
        {
            var OrdList = new List<Orders>();
            int OrdID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string OrdName = value;
            //Search by Id
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectOrdersID"))
            {
                connecction.Open();
                command.Connection = connecction;

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", OrdID);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ordModel = new Orders();
                        ordModel.Id = (int)reader[0];
                        ordModel.OrdCompanName = (string)reader[1];
                        ordModel.OrdComAddress = (string)reader[2];
                        ordModel.OrdComCity = (string)reader[3];
                        ordModel.OrdComCountry = (string)reader[4];
                        ordModel.OrdComPostal = (string)reader[5];
                        ordModel.OrdKindOfCargo = (string)reader[6];
                        ordModel.OrdTrailer = (string)reader[7];
                        ordModel.OrdWeight = (string)reader[8];
                        ordModel.OrdDateOfDeparture = (string)reader[9];
                        ordModel.OrdDeliveryDate = (string)reader[10];
                        ordModel.OrdCarriagePrice = (string)reader[11];
                        ordModel.OrdtTrucker = (string)reader[12];
                        ordModel.OrdtTruck = (string)reader[13];
                        ordModel.OrdtExpenses = (string)reader[14];

                        OrdList.Add(ordModel);
                    }
                }

            }
            //Search ny first name 
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectOrdersCompanyaName"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@OrdersName", OrdName);

                using (var readerV2 = command.ExecuteReader())
                {
                    while (readerV2.Read())
                    {
                        var ordModel = new Orders();
                        ordModel.Id = (int)readerV2[0];
                        ordModel.OrdCompanName = (string)readerV2[1];
                        ordModel.OrdComAddress = (string)readerV2[2];
                        ordModel.OrdComCity = (string)readerV2[3];
                        ordModel.OrdComCountry = (string)readerV2[4];
                        ordModel.OrdComPostal = (string)readerV2[5];
                        ordModel.OrdKindOfCargo = (string)readerV2[6];
                        ordModel.OrdTrailer = (string)readerV2[7];
                        ordModel.OrdWeight = (string)readerV2[8];
                        ordModel.OrdDateOfDeparture = (string)readerV2[9];
                        ordModel.OrdDeliveryDate = (string)readerV2[10];
                        ordModel.OrdCarriagePrice = (string)readerV2[11];
                        ordModel.OrdtTrucker = (string)readerV2[12];
                        ordModel.OrdtTruck = (string)readerV2[13];
                        ordModel.OrdtExpenses = (string)readerV2[14];
                        OrdList.Add(ordModel);
                    }
                }
            }
            return OrdList;
        }
    }
}
