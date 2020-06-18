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
    public partial class FormDelivery : Form
    {
        public FormDelivery()
        {
            InitializeComponent();
            textBoxDate.Text = "ДД.ММ.ГГГГ";
            textBoxDate.ForeColor = Color.Gray;
            textBoxAddress.Text = "г. **** ул. **** д. *****";
            textBoxAddress.ForeColor = Color.Gray;
            ShowDrivers();
            showOrder();
            ShowDelivery();
        }
        void ShowDrivers()
        {
            comboBoxDriver.Items.Clear();
            foreach (Drivers drivers in Program.wtfDb.Drivers)
            {
                string[] item = { drivers.Id.ToString() + ". ", drivers.LastName+" "+drivers.FirstName };
                comboBoxDriver.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDelivery()
        {
            listViewDelivery.Items.Clear();
            foreach (Delivery delivery in Program.wtfDb.Delivery)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        delivery.Id.ToString(),"Id: "+delivery.Id_Driver.ToString()+" "+delivery.Drivers.LastName+" "+delivery.Drivers.FirstName,
                        delivery.Id_Order_F.ToString(),delivery.Address,delivery.Date.ToString().Substring(0,8)
                    });
                item.Tag = delivery;
                listViewDelivery.Items.Add(item);
            }
            listViewDelivery.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void showOrder()
        {
            comboBoxOrder_P.Items.Clear();
            foreach (Order_F drivers in Program.wtfDb.Order_F)
            {
                string[] item = { drivers.Id.ToString() + ". ", drivers.Production.Address };
                comboBoxOrder_P.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxOrder_P.SelectedItem != null && comboBoxDriver.SelectedItem != null && textBoxAddress.Text!="" && textBoxDate.Text!="")
            {
                Delivery orders = new Delivery();

                orders.Id_Driver = Convert.ToInt32(comboBoxDriver.SelectedItem.ToString().Split('.')[0]);
                orders.Id_Order_F = Convert.ToInt32(comboBoxOrder_P.SelectedItem.ToString().Split('.')[0]);
                orders.Address = textBoxAddress.Text;
                orders.Date = Convert.ToDateTime(textBoxDate.Text);
                
                Program.wtfDb.Delivery.Add(orders);
                Program.wtfDb.SaveChanges();
                ShowDelivery();
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxOrder_P.SelectedItem != null && comboBoxDriver.SelectedItem != null && textBoxAddress.Text != "" && textBoxDate.Text != "")
            {
                Delivery orders = listViewDelivery.SelectedItems[0].Tag as Delivery;
                orders.Id_Driver = Convert.ToInt32(comboBoxDriver.SelectedItem.ToString().Split('.')[0]);
                orders.Id_Order_F = Convert.ToInt32(comboBoxOrder_P.SelectedItem.ToString().Split('.')[0]);
                orders.Address = textBoxAddress.Text;
                orders.Date = Convert.ToDateTime(textBoxDate.Text);
                Program.wtfDb.SaveChanges();
                ShowDelivery();
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDelivery.SelectedItems.Count == 1)
                {
                    Delivery FL = listViewDelivery.SelectedItems[0].Tag as Delivery;
                    Program.wtfDb.Delivery.Remove(FL);
                    Program.wtfDb.SaveChanges();
                    ShowDelivery();
                }
                comboBoxOrder_P.SelectedItem = null;
                comboBoxDriver.SelectedItem = null;
                textBoxDate.Text = "";
                textBoxAddress.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDelivery.SelectedItems.Count == 1)
            {
                Delivery orders = listViewDelivery.SelectedItems[0].Tag as Delivery;
                comboBoxDriver.SelectedIndex = comboBoxDriver.FindString(orders.Id_Driver.ToString());
                comboBoxOrder_P.SelectedIndex = comboBoxOrder_P.FindString(orders.Id_Order_F.ToString());
                textBoxDate.Text = Convert.ToString(orders.Date);
                textBoxAddress.Text = orders.Address;
            }
            else
            {
                comboBoxOrder_P.SelectedItem = null;
                comboBoxDriver.SelectedItem = null;
                textBoxDate.Text = "";
                textBoxAddress.Text = "";
            }
        }

        private void textBoxDate_Enter(object sender, EventArgs e)
        {
            textBoxDate.Text = null;
            textBoxDate.ForeColor = Color.Black;
        }

        private void tBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != '.' && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxAddress_Enter(object sender, EventArgs e)
        {
            textBoxAddress.Text = null;
            textBoxAddress.ForeColor = Color.Black;
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
