using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DAO;
namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            SupplierDAO customer = new SupplierDAO();
            SupplierDTO customerDto = new SupplierDTO(20, "assel", "assel");
            customer.Create(customerDto);
        }
    }
}
