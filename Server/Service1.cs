using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    public class Service1 : IService1
    {
        string path = @"Data Source=SMMcompany1.mssql.somee.com;Initial Catalog=SMMcompany1;User Id=GODTHOMVS_SQLLogin_1;Password=t21vwte5ra";

        public void ConnectionInfo(string name, string port, string localPath, string uri, string scheme)
        {
            Console.WriteLine();
            Console.WriteLine("***** Host Info *****");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Port: {port}");
            Console.WriteLine($"LocalPath: {localPath}");
            Console.WriteLine($"Uri: {uri}");
            Console.WriteLine($"Scheme: {scheme}");
            Console.WriteLine("***********************************");
            Console.WriteLine();
        }
        public DataTable GetData()
        {
            string query = "SELECT * FROM Orders";
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(path))
            {
                SqlCommand command = new SqlCommand(query);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                command.Connection = connection;
                dataAdapter.SelectCommand = command;
                DataTable dataTable = new DataTable();
                dataTable.TableName = "Orders";
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetComboValue()
        {
            string query = "SELECT ServiceName FROM Services";
            using (SqlConnection connection = new SqlConnection(path))
            {
                SqlCommand command = new SqlCommand(query);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                command.Connection = connection;
                dataAdapter.SelectCommand = command;
                DataTable dataTable = new DataTable();
                dataTable.TableName = "Services";
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void NewRec(string cname, string service, string count, string date)
        {
            string ServicePrice = $"(select[Price] from Services where [ServiceName] = '{service}')";
            string query = $"INSERT INTO Orders ([ClientName], [ServiceName], [Price], [Count], [Sum], [Date])" +
                $"VALUES ('{cname}', '{service}', {ServicePrice},'{count}',{ServicePrice}*{count},'{date}')";
            using (SqlConnection con = new SqlConnection(path))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
