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
    internal class MachRepository:BaseRepository,IMachRepository
    {
        //Constructor
        public MachRepository(string connectionString)
        {
            this.ConnectingString = connectionString;
        }
        //Methods

        //Truck
        public void Add(Machinery machinery)
        {
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("AddTrucks"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TruckName", machinery.TrName1);
                command.Parameters.AddWithValue("@TruckRegistration", machinery.TrRegistration1);
                command.Parameters.AddWithValue("@TruckServ", machinery.TrServ1);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(int id)
        {
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("DeleteTruck"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID", id); ;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(Machinery machinery)
        {
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("UpdateTruck"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID", machinery.TrId1);
                command.Parameters.AddWithValue("@TruckName", machinery.TrName1);
                command.Parameters.AddWithValue("@TruckRegistration", machinery.TrRegistration1);
                command.Parameters.AddWithValue("@TruckServ", machinery.TrServ1);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Machinery> GetAll()
        {
            var MachList = new List<Machinery>();
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectTrucks"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var machModel = new Machinery();
                        machModel.TrId1 = (int)reader[0];
                        machModel.TrName1 = reader[1].ToString();
                        machModel.TrRegistration1 = reader[2].ToString();
                        machModel.TrServ1 = reader[3].ToString();

                        MachList.Add(machModel);
                    }
                }
            }
            return MachList;
        }
       
        public IEnumerable<Machinery> GetByValue(string value)
        {
            var MachList = new List<Machinery>();
            int MachID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string MachName = value;
            //Search by Id
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectTruckID"))
            {
                connecction.Open();
                command.Connection = connecction;



                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", MachID);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var machModel = new Machinery();
                        machModel.TrId1 = (int)reader[0];
                        machModel.TrName1 = reader[1].ToString();
                        machModel.TrRegistration1 = reader[2].ToString();
                        machModel.TrServ1 = reader[3].ToString();

                        MachList.Add(machModel);
                    }
                }

            }
            //Search ny first name 
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectTruckName"))
            {
                connecction.Open();
                command.Connection = connecction;



                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TruckName", MachName);

                using (var readerV2 = command.ExecuteReader())
                {
                    while (readerV2.Read())
                    {
                        var machModel = new Machinery();
                        machModel.TrId1 = (int)readerV2[0];
                        machModel.TrName1 = readerV2[1].ToString();
                        machModel.TrRegistration1 = readerV2[2].ToString();
                        machModel.TrServ1 = readerV2[3].ToString();
                        MachList.Add(machModel);
                    }
                }
            }
            return MachList;
        }
        //Forklifts
        /*
        public void AddFor(Machinery machinery)
        {
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("Add"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ForkliftsName", machinery.ForName1);
                command.Parameters.AddWithValue("@ForkliftsModel", machinery.ForModel1);
                command.Parameters.AddWithValue("@ForkliftsServ", machinery.ForServ1);
                command.ExecuteNonQuery();
            }
        }
   
        public void DeleteFor(int id)
        {
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("DeleteForklifts"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);

                command.ExecuteNonQuery();
            }
        }

        public void EditFor(Machinery machinery)
        {
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("UpdateForklifts"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID", machinery.ForId1);
                command.Parameters.AddWithValue("@ForkliftsName", machinery.ForName1);
                command.Parameters.AddWithValue("@ForkliftsModel", machinery.ForModel1);
                command.Parameters.AddWithValue("@ForkliftsServ", machinery.ForServ1);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Machinery> GetAllFor(int id)
        {
            var MachList = new List<Machinery>();
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectForklifts"))
            {
                connecction.Open();
                command.Connection = connecction;
                command.CommandType = CommandType.StoredProcedure;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var machModel = new Machinery();
                        machModel.ForId1 = (int)reader[0];
                        machModel.ForName1 = reader[1].ToString();
                        machModel.ForModel1 = reader[2].ToString();
                        machModel.ForServ1 = reader[3].ToString();

                        MachList.Add(machModel);
                    }
                }
            }
            return MachList;
        }

        public IEnumerable<Machinery> GetByValueFor(string value)
        {
            var MachList = new List<Machinery>();
            int MachID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string MachName = value;
            //Search by Id
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectForkliftsID"))
            {
                connecction.Open();
                command.Connection = connecction;



                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", MachID);



                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var machModel = new Machinery();
                        machModel.ForId1 = (int)reader[0];
                        machModel.ForName1 = reader[1].ToString();
                        machModel.ForModel1 = reader[2].ToString();
                        machModel.ForServ1 = reader[3].ToString();

                        MachList.Add(machModel);
                    }
                }

            }
            //Search ny first name 
            using (var connecction = new SqlConnection(ConnectingString))
            using (var command = new SqlCommand("SelectForkliftsName"))
            {
                connecction.Open();
                command.Connection = connecction;



                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ForkliftsName", MachName);

                using (var readerV2 = command.ExecuteReader())
                {
                    while (readerV2.Read())
                    {
                        var machModel = new Machinery();
                        machModel.ForId1 = (int)readerV2[0];
                        machModel.ForName1 = readerV2[1].ToString();
                        machModel.ForModel1 = readerV2[2].ToString();
                        machModel.ForServ1 = readerV2[3].ToString();
                        MachList.Add(machModel);
                    }
                }
            }
            return MachList;
        }*/
    }
}
