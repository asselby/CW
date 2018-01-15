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
            DisconnectedCustomerDao customer = new DisconnectedCustomerDao();
            CustomerDTO customerDto = new CustomerDTO();
            customer.Delete("asd");
            Console.ReadLine();
        }
    }
}
