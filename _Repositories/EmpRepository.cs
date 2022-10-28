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
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("AddEmployeesDB"))
            {
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
        }

        public void Delete(int id)
        {
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("DeleteEmployes"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
        }

        public void Edit(Employees employees)
        {
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("UpdateEMP"))
            {
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
         
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var empModel = new Employees();
                        empModel.Id = (int)reader[0];
                        empModel.Firname1 = reader[1].ToString();
                        empModel.LasNane1 = reader[2].ToString();
                        empModel.Streat1 = reader[3].ToString();
                        empModel.City1= reader[4].ToString();
                        empModel.Province1 = reader[5].ToString();
                        empModel.Postal1 = reader[6].ToString();
                        empModel.Emial1 = reader[7].ToString();
                        empModel.PhoneNumer1 = reader[8].ToString();
                        empModel.Position1 = reader[9].ToString();
                        EmpList.Add(empModel);
                    }
                }
            }
            return EmpList;

        }
        public IEnumerable<Employees> GetByValue(string value)
        {
            var EmpList = new List<Employees>();
            int EmpID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string EmpFirstNam = value;
            //Search by Id
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectEmployessEmpID"))
            {
                connecction.Open();
                command.Connection = connecction;

                
                    
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", EmpID);
                
                   
               
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var empModel = new Employees();
                        empModel.Id = (int)reader[0];
                        empModel.Firname1 = reader[1].ToString();
                        empModel.LasNane1 = reader[2].ToString();
                        empModel.Streat1 = reader[3].ToString();
                        empModel.City1 = reader[4].ToString();
                        empModel.Province1 = reader[5].ToString();
                        empModel.Postal1 = reader[6].ToString();
                        empModel.Emial1 = reader[7].ToString();
                        empModel.PhoneNumer1 = reader[8].ToString();
                        empModel.Position1 = reader[9].ToString();
                        EmpList.Add(empModel);
                    }
                }
                
            }
            //Search ny first name 
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectEmployessEmpIDorName"))
            {
                connecction.Open();
                command.Connection = connecction;



                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", EmpFirstNam);

                using (var readerV2 = command.ExecuteReader())
                {
                    while (readerV2.Read())
                    {
                        var empModel = new Employees();
                        empModel.Id = (int)readerV2[0];
                        empModel.Firname1 = readerV2[1].ToString();
                        empModel.LasNane1 = readerV2[2].ToString();
                        empModel.Streat1 = readerV2[3].ToString();
                        empModel.City1 = readerV2[4].ToString();
                        empModel.Province1 = readerV2[5].ToString();
                        empModel.Postal1 = readerV2[6].ToString();
                        empModel.Emial1 = readerV2[7].ToString();
                        empModel.PhoneNumer1 = readerV2[8].ToString();
                        empModel.Position1 = readerV2[9].ToString();
                        EmpList.Add(empModel);
                    }
                }
            }
            return EmpList;

        }

      
            
        
    }
}
