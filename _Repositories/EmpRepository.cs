using Microsoft.VisualBasic.ApplicationServices;
using Projects.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projects.Models;
using System.Windows.Shell;
using Projects.Presenters;

namespace Projects._Repositories
{
    public class EmpRepository : BaseRepository, IEmpRepository 
    {
        //Constructor
        public EmpRepository(string connectionString)
        {
            this.ConnectingString = connectionString;
        }
        //Methods
        public void Add(Employees employees)
        {
            using var connecction = new SqlConnection(ConnectingString);
            using var command = new SqlCommand("AddEmployeesDB");
            connecction.Open();
            command.Connection = connecction;
            command.CommandType = CommandType.StoredProcedure;


            command.Parameters.AddWithValue("@FirstName", employees.Firname1);
            command.Parameters.AddWithValue("@LastName", employees.LasNane1);
            command.Parameters.AddWithValue("@StreatAdres", employees.Streat1);
            command.Parameters.AddWithValue("@City", employees.City1);
            command.Parameters.AddWithValue("@Province", employees.Province1);
            command.Parameters.AddWithValue("@Postal", employees.Postal1);
            command.Parameters.AddWithValue("@Email", employees.Emial1);
            command.Parameters.AddWithValue("@PhonneNum", employees.PhoneNumer1);
            command.Parameters.AddWithValue("@Position", employees.Position1);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connecction = new SqlConnection(ConnectingString);
            using var command = new SqlCommand("DeleteEmployes");
            connecction.Open();
            command.Connection = connecction;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
        }

        public void Edit(Employees employees)
        {
            using var connecction = new SqlConnection(ConnectingString);
            using var command = new SqlCommand("UpdateEMP");
            connecction.Open();
            command.Connection = connecction;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ID", employees.Id);
            command.Parameters.AddWithValue("@FirstName", employees.Firname1);
            command.Parameters.AddWithValue("@LastName", employees.LasNane1);
            command.Parameters.AddWithValue("@StreatAdres", employees.Streat1);
            command.Parameters.AddWithValue("@City", employees.City1);
            command.Parameters.AddWithValue("@Province", employees.Province1);
            command.Parameters.AddWithValue("@Postal", employees.Postal1);
            command.Parameters.AddWithValue("@Email", employees.Emial1);
            command.Parameters.AddWithValue("@PhonneNum", employees.PhoneNumer1);
            command.Parameters.AddWithValue("@Position", employees.Position1);
            command.ExecuteNonQuery();
        }
         
        public IEnumerable<Employees> GetAll()
        {
            var EmpList = new List<Employees>();
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectEmployess"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var empModel = new Employees
                    {
                        Id = (int)reader[0],
                        Firname1 = reader[1].ToString(),
                        LasNane1 = reader[2].ToString(),
                        Streat1 = reader[3].ToString(),
                        City1 = reader[4].ToString(),
                        Province1 = reader[5].ToString(),
                        Postal1 = reader[6].ToString(),
                        Emial1 = reader[7].ToString(),
                        PhoneNumer1 = reader[8].ToString(),
                        Position1 = reader[9].ToString()
                    };
                    EmpList.Add(empModel);
                }
            }
            return EmpList;

        }
        public IEnumerable<Employees> GetByValue(string value)
        {
            var EmpList = new List<Employees>();
            int EmpID = int.TryParse(value,out _) ? Convert.ToInt32(value) : 0;
            string EmpFirstNam = value;

            //Search by Id
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("[dbo].[SelectEmployessEmpID]"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = EmpID;

                using var readerv4 = command.ExecuteReader();
                while (readerv4.Read())
                {
                    var empModel = new Employees
                    {
                        Id = (int)readerv4[0],
                        Firname1 = readerv4[1].ToString(),
                        LasNane1 = readerv4[2].ToString(),
                        Streat1 = readerv4[3].ToString(),
                        City1 = readerv4[4].ToString(),
                        Province1 = readerv4[5].ToString(),
                        Postal1 = readerv4[6].ToString(),
                        Emial1 = readerv4[7].ToString(),
                        PhoneNumer1 = readerv4[8].ToString(),
                        Position1 = readerv4[9].ToString()
                    };
                    EmpList.Add(empModel);
                }

            }
            //Search ny first name 
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectEmployessEmpName"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FirstName", EmpFirstNam);

                using var readerv3 = command.ExecuteReader();
                while (readerv3.Read())
                {
                    var empModel = new Employees
                    {
                        Id = (int)readerv3[0],
                        Firname1 = readerv3[1].ToString(),
                        LasNane1 = readerv3[2].ToString(),
                        Streat1 = readerv3[3].ToString(),
                        City1 = readerv3[4].ToString(),
                        Province1 = readerv3[5].ToString(),
                        Postal1 = readerv3[6].ToString(),
                        Emial1 = readerv3[7].ToString(),
                        PhoneNumer1 = readerv3[8].ToString(),
                        Position1 = readerv3[9].ToString()
                    };
                    EmpList.Add(empModel);
                }
            }
            return EmpList;

        }

            
    }
}
