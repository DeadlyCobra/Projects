using Projects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects._Repositories
{
    internal class CosRepository:BaseRepository , ICosRepository
    {
        //Constructor
        public CosRepository(string connectionString)
        {
            this.ConnectingString = connectionString;
        }
        //Methods
        public void Add(Customers Customers)
        {
            using var connecction = new SqlConnection(ConnectingString);
            using var command = new SqlCommand("AddCustomersDB");
            connecction.Open();
            command.Connection = connecction;
            command.CommandType = CommandType.StoredProcedure;


            command.Parameters.AddWithValue("@CompanyName", Customers.CostCompName1);
            command.Parameters.AddWithValue("@NIP", Customers.CostNip1);
            command.Parameters.AddWithValue("@Country", Customers.CostContry1);
            command.Parameters.AddWithValue("@StreetAddress", Customers.CostStreatAdres1);
            command.Parameters.AddWithValue("@City", Customers.CostCity1);
            command.Parameters.AddWithValue("@Province", Customers.CostProvince1);
            command.Parameters.AddWithValue("@Postal", Customers.CostPostal1);
            command.Parameters.AddWithValue("@Email", Customers.CostEmial1);
            command.Parameters.AddWithValue("@PhonneNum", Customers.CostPhoneNumer1);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connecction = new SqlConnection(ConnectingString);
            using var command = new SqlCommand("DeleteCustomers");
            connecction.Open();
            command.Connection = connecction;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
        }

        public void Edit(Customers Customers)
        {
            using var connecction = new SqlConnection(ConnectingString);
            using var command = new SqlCommand("EditCustomers");
            connecction.Open();
            command.Connection = connecction;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID", Customers.ID);
            command.Parameters.AddWithValue("@CompanyName", Customers.CostCompName1);
            command.Parameters.AddWithValue("@NIP", Customers.CostNip1);
            command.Parameters.AddWithValue("@StreetAddress", Customers.CostStreatAdres1);
            command.Parameters.AddWithValue("@Country", Customers.CostContry1);
            command.Parameters.AddWithValue("@City", Customers.CostCity1);
            command.Parameters.AddWithValue("@Province", Customers.CostProvince1);
            command.Parameters.AddWithValue("@Postal", Customers.CostPostal1);
            command.Parameters.AddWithValue("@Email", Customers.CostEmial1);
            command.Parameters.AddWithValue("@PhonneNum", Customers.CostPhoneNumer1);
            command.ExecuteNonQuery();
        }

        public IEnumerable<Customers> GetAll()
        {
            var CusList = new List<Customers>();
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectCustomers"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var cusModel = new Customers
                    {
                        ID = (int)reader[0],
                        CostCompName1 = reader[1].ToString(),
                        CostNip1 = reader[2].ToString(),
                        CostContry1 = reader[3].ToString(),
                        CostStreatAdres1 = reader[4].ToString(),
                        CostCity1 = reader[5].ToString(),
                        CostProvince1 = reader[6].ToString(),
                        CostPostal1 = reader[7].ToString(),
                        CostEmial1 = reader[8].ToString(),
                        CostPhoneNumer1 = reader[9].ToString()
                    };
                    CusList.Add(cusModel);
                }
            }
            return CusList;
        }

        public IEnumerable<Customers> GetByValue(string value)
        {
            var CusList= new List<Customers>();
            int CusID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string CustCompnayName = value;
            //Serch by Id
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectCostomersID"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ID", SqlDbType.Int).Value= CusID;

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var cusModel = new Customers
                    {
                        ID = (int)reader[0],
                        CostCompName1 = reader[1].ToString(),
                        CostNip1 = reader[2].ToString(),
                        CostContry1 = reader[3].ToString(),
                        CostStreatAdres1 = reader[4].ToString(),
                        CostCity1 = reader[5].ToString(),
                        CostProvince1 = reader[6].ToString(),
                        CostPostal1 = reader[7].ToString(),
                        CostEmial1 = reader[8].ToString(),
                        CostPhoneNumer1 = reader[9].ToString()
                    };
                    CusList.Add(cusModel);
                }
            }
            //Serch by name
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectCostomersName"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CostomersName",CustCompnayName);

                using var readerv2 = command.ExecuteReader();
                while (readerv2.Read())
                {
                    var cusModel = new Customers
                    {
                        ID = (int)readerv2[0],
                        CostCompName1 = readerv2[1].ToString(),
                        CostNip1 = readerv2[2].ToString(),
                        CostContry1 = readerv2[3].ToString(),
                        CostStreatAdres1 = readerv2[4].ToString(),
                        CostCity1 = readerv2[5].ToString(),
                        CostProvince1 = readerv2[6].ToString(),
                        CostPostal1 = readerv2[7].ToString(),
                        CostEmial1 = readerv2[8].ToString(),
                        CostPhoneNumer1 = readerv2[9].ToString()
                    };
                    CusList.Add(cusModel);
                }
            }
            return CusList;
        }
    }
}
