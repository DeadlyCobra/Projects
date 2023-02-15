using Projects._Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace Projects.Models
{   public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class Dashboard : DasRepository
    {


        //Fields & Propertis 
        private DateTime startdate;
        private DateTime enddate;
        private int numberDay;

        public int NumCustomers { get; private set; }
        public int NumTrucks { get; private set; }
        public int NumEmployes { get; private set; }

        public List<KeyValuePair<string, int>> TopCustomersList { get; private set; }
        public List<KeyValuePair<string, int>> AvailabletruckList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfits { get; set; }

        //Cousntructor
        public Dashboard()
        {

        }
        //Private metdos
        private void GetNummberIteams()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Get Total Number of Customers
                    command.CommandText = "Select COUNT(CostId) from Costomers";
                    NumCustomers = (int)command.ExecuteScalar();

                    //Get Total Number of Employers
                    command.CommandText = "Select COUNT(EmpId) from Employees where EmpPosition=5";
                    NumEmployes = (int)command.ExecuteScalar();

                    //Get Total Number of Machins
                    command.CommandText = "Select COUNT(TrId) from Trucks";
                    NumTrucks = (int)command.ExecuteScalar();

                    //Get Total Number of Orders
                    command.CommandText = "Select COUNT(OrdId) from Orders";
                    NumOrders = (int)command.ExecuteScalar();

                    command.CommandText = "Select Count(OrdId) from Orders where DateOfDeparture BETWEEN @fromDate and @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.Text).Value = startdate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.Text).Value = enddate;
                    NumOrders = (int)command.ExecuteScalar();

                }
            }
        }
        private void GetOrdersAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfits = 0;
            TotalRevenue = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = (@"Select DateOfDeparture,SUM(CarriagePrice) from Orders where DateOfDeparture BETWEEN @fromdate and @todate GROUP BY DateOfDeparture");
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.Text).Value = startdate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.Text).Value = enddate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<string, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<string, decimal>((string)reader[0], (decimal)reader[1]));
                        TotalRevenue += (decimal)reader[0];

                    }
                    TotalProfits += TotalRevenue * 0.2m;//20%
                    reader.Close();
                    //group by dayes
                    if (numberDay <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            GrossRevenueList.Add(new RevenueByDate()
                            {
                                Date = item.Key.ToString(),
                                TotalAmount = item.Value
                            });
                        }
                    }
                    else if (numberDay <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList
                                          into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week" + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //group by months
                    else if (numberDay <= (365 * 2))
                    {
                        bool isYear = numberDay <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString()
                                          into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();

                    }
                    //group By Years 
                    else
                    {

                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList
                                          into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();

                    }
                }
            }
        }
        private void GetTransportAnalis()
        {
            TopCustomersList = new List<KeyValuePair<string, int>>();
            AvailabletruckList = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandText = @"SELECT top 5 C.CostCompName, count(o.ComapnyName) as numberofenterprises  from Orders O inner join Costomers C on                                          O.ComapnyName=C.CostId where  DeliveryDate BETWEEN @fromdate and @todate  GROUP by c.CostCompName order by numberofenterprises desc";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.Text).Value = startdate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.Text).Value = enddate;
                    reader= command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopCustomersList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                       
                    }
                    reader.Close();

                }
            }
        }

        //public methods
        public bool LoadData(DateTime startDate,DateTime endDate)
        {
            endDate = new DateTime(endDate.Day, endDate.Month, endDate.Year, endDate.Hour, endDate.Minute, 59);
            if (startdate != this.startdate || endDate != this.enddate)
            {
                this.startdate = startDate;
                this.enddate = endDate;
                this.numberDay = (enddate - startdate).Days;
                GetNummberIteams();
                GetTransportAnalis();
                GetOrdersAnalisys();
                Console.WriteLine("Refreshed Data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {

               Console.WriteLine("Data not refreshed,some: {0} - {1}", startDate.ToString(), endDate.ToString() );
                return false;
            }
        }
    }

}
