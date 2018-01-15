using DataLayer.DAO;
using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class registrationWindow : Form
    {
        public registrationWindow()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string id = customerId.Text;
            string compName = companyName.Text;
            string conName = contactName.Text;
            CustomerDTO customerDto = new CustomerDTO()
            {
                CustomerId = id,
                CompanyName = compName,
                ContactName = conName,
            };
            CustomerDAO custDao = new CustomerDAO();
            custDao.Create(customerDto);            
            MessageBox.Show("Вы успешно зарегистрированы");
        }
    }
}
