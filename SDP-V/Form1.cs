using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_V
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if(FormAuthorization.users.type=="Manager")
            {
                buttonProduction.Enabled = false;
            }
            if(FormAuthorization.users.type=="Worker")
            {
                buttonProduction.Enabled = false;
                buttonDrivers.Enabled = false;
                buttonPersons.Enabled = false;

            }
        }

        private void buttonPersons_Click(object sender, EventArgs e)
        {
            Form formPerson = new FormPersons();
            formPerson.Show();
        }

        private void buttonFL_Click(object sender, EventArgs e)
        {
            Form formPerson = new FormFL();
            formPerson.Show();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            Form formPerson = new FormOrders();
            formPerson.Show();
        }

        

        private void buttonCharProject_Click(object sender, EventArgs e)
        {
            Form formPerson = new FormChar();
            formPerson.Show();
        }

        private void buttonOrders_P_Click(object sender, EventArgs e)
        {
            Form formPerson = new FormOrders_P();
            formPerson.Show();
        }

        private void buttonProduction_Click(object sender, EventArgs e)
        {
            Form formPerson = new FormProduction();
            formPerson.Show();
        }

        private void buttonUL_Click(object sender, EventArgs e)
        {
            Form formPerson = new FormUL();
            formPerson.Show();
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            Form formPerson = new FormDelivery();
            formPerson.Show();
        }

        private void buttonDrivers_Click(object sender, EventArgs e)
        {
            Form formPerson = new FormDrivers();
            formPerson.Show();
        }
    }
}
