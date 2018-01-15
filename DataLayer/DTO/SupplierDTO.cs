using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DTO
{
    public class SupplierDTO
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }

        public SupplierDTO( string companyName, string contactName)
        {
            CompanyName = companyName;
            ContactName = contactName;
        }
        public SupplierDTO()
        {

        }
        public override string ToString()
        {
            return $"{SupplierId} - {CompanyName} - { ContactName}";
        }


    }
}
