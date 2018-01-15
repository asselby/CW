using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DAO
{
    public class SupplierDAO 
    {
        private SqlConnection sqlConnection = null;

        public void Create(SupplierDTO t)
        {
            using (sqlConnection = DataBaseConnectionFactory.Connection())
            {
                string createQuery = string.Format(@"insert into  Suppliers
            (CompanyName,ContactName )
            Values('{0}', '{1}')",  t.CompanyName, t.ContactName);
                sqlConnection.Open();
                try
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {

                        sqlCommand.CommandText = createQuery;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Введены повторяющиеся значения");
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

        public SupplierDTO Read(string id)
        {
            SupplierDTO supplierToReturn = null;
            using (sqlConnection = DataBaseConnectionFactory.Connection())
            {
                int num;
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    string readQuery = string.Format(@"SELECT * FROM Suppliers
                                     WHERE [RegionID] = {0}", id);

                    sqlCommand.CommandText = readQuery;
                    sqlCommand.CommandType = CommandType.Text;

                    SqlDataReader reader = sqlCommand.ExecuteReader();
               
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Int32.TryParse(reader["SupplierID"].ToString(), out num);
                        supplierToReturn = new SupplierDTO()
                        {                           
                            SupplierId=num,
                            CompanyName = reader["CompanyName"].ToString(),
                            ContactName = reader["ContactName"].ToString()
                        };
                    }
                }
                sqlConnection.Close();
            }
            return supplierToReturn;
        }
       

        public void Update(SupplierDTO t)
        {
            using (sqlConnection = DataBaseConnectionFactory.Connection())
            {
                string updateQuery = string.Format(@"UPDATE Customers
                SET  CompanyName='{0}', ContactName='{1}'
                WHERE CustomerID='{2}';", t.CompanyName, t.ContactName, t.SupplierId);
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

