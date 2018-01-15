using ControlWork.Shared.Utils;
using DataLayer.DAO;
using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SignIN
    {
        private readonly CustomerDAO customerDao;
        public string RegisterNewCustomer(CustomerDTO customerDto)
        {
            customerDto.CustomerId = CustomerIdGenerate.GenerateUniqueId(
                customerDto.CompanyName,
                customerDto.ContactName
                );

            return customerDao.Create(customerDto);
        }
    }
}
