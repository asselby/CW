using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DTO
{
    public class CustomerDTO
    {
        public string CustomerId { get; set; }
        public string CompanyName{get; set;}
        public string ContactName { get; set;}
        public CustomerDTO(string customerId, string companyName, string contactName)
        {
            CustomerId = customerId;
            CompanyName = companyName;
            ContactName = contactName;
        }


        public CustomerDTO()
        {

        }
        public override string ToString()
        {
            return $"{CustomerId} - {CompanyName} - { ContactName}";
        }


    }
}
