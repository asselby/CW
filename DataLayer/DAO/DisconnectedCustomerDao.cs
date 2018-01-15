using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DAO
{
   public class DisconnectedCustomerDao 
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        string sqlQuery = "Select * from Customers";
        public void Create(CustomerDTO t)
        {
           
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Customers");

                    DataRow dataRowToAdd = dataSet.Tables["Customers"].NewRow();

                    foreach (var item in t.GetType().GetProperties())
                    {
                        dataRowToAdd[item.Name] = item.GetValue(t, null);
                    }

                    dataSet.Tables["Customers"].Rows.Add(dataRowToAdd);

                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

                    adapter.Update(dataSet.Tables["Customers"]);
                }
                sqlConnection.Close();
            }
        }

        public void Delete(string id)
        {
           
        }

        public CustomerDTO Read(string id)
        {
            CustomerDTO dtoToReturn = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Customer");
                    dataSet.Tables["Customer"].PrimaryKey = new DataColumn[] { dataSet.Tables["Customer"].Columns["CustomerID"] };

                    DataRow dataRowToReturn = dataSet.Tables["Customer"].Rows.Find(id);

                    foreach (var item in dataRowToReturn.ItemArray.ToList())
                    {
                        Console.Write(item);
                        Console.Write(" ");
                    }
                }
                sqlConnection.Close();
            }
            return null;
       }

        public void Update(CustomerDTO t)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    DataColumn[] key = new DataColumn[1];
                    key[0] = dataSet.Tables[0].Columns[0];
                    dataSet.Tables[0].PrimaryKey = key;

                    DataRow dataRow = dataSet.Tables[0].Rows.Find(t.CustomerId);

                    dataRow.BeginEdit();

                    dataRow["CustomerID"] = t.CustomerId;

                    dataRow.EndEdit();
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

                    adapter.Update(dataSet);
                }
                sqlConnection.Close();
            }
        }
    }
}
