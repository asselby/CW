using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DAO
{
    public class CustomerDAO : IDAO<CustomerDTO>
    {
        private SqlConnection sqlConnection = null;

        public void Create(CustomerDTO t)
        {
            using (sqlConnection = DataBaseConnectionFactory.Connection())
            {
                string createQuery = string.Format(@"use [NORTHWNDSDP-162] insert into  Customers
Values('{0}', '{1}', '{2}', null, null, null, null, null, null, null, null)", t.CustomerId, t.ContactName, t.CompanyName) ;
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {

                    sqlCommand.CommandText = createQuery;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }

        public void Delete(string Id)
        {
            using (sqlConnection = DataBaseConnectionFactory.Connection())
            {
                string deleteQuery = string.Format(@"delete from Customers
                where CustomerID='{0}';", Id);
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {

                    sqlCommand.CommandText = deleteQuery;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }

        public CustomerDTO Read(string id)
        {
            CustomerDTO customerToReturn = null;
            using (sqlConnection = DataBaseConnectionFactory.Connection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    string readQuery = string.Format(@"SELECT * FROM Customers
                                     WHERE [RegionID] = {0}", id);

                    sqlCommand.CommandText = readQuery;
                    sqlCommand.CommandType = CommandType.Text;

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        customerToReturn = new CustomerDTO()
                        {
                            CustomerId = reader["CustomerID"].ToString(),
                            CompanyName = reader["CompanyName"].ToString(),
                            ContactName = reader["ContactName"].ToString()
                        };
                    }
                }
                sqlConnection.Close();
            }
            return customerToReturn;
        }


        public void Update(CustomerDTO t)
        {
            using (sqlConnection = DataBaseConnectionFactory.Connection())
            {
                string updateQuery = string.Format(@"UPDATE Customers
                SET  CompanyName='{0}', ContactName='{1}'
                WHERE CustomerID='{2}';", t.CompanyName, t.ContactName, t.CustomerId);
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = updateQuery;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
    }
}
