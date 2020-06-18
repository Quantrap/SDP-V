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
    public partial class FormDrivers : Form
    {
        public FormDrivers()
        {
            InitializeComponent();
            ShowDrivers();
        }
        void ShowDrivers()
        {
            listViewDrivers.Items.Clear();
            foreach(Drivers drivers in Program.wtfDb.Drivers)
            {
                ListViewItem item = new ListViewItem(new string[]
                        {
                        drivers.Id.ToString(),drivers.FirstName,drivers.MiddleName,
                        drivers.LastName,drivers.Phone,drivers.Email
                        });
                item.Tag = drivers;
                listViewDrivers.Items.Add(item);
            }
            listViewDrivers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxMiddleName.Text != "") 
            {
                Drivers FL = new Drivers();
                FL.FirstName = textBoxFirstName.Text;
                FL.MiddleName = textBoxMiddleName.Text;
                FL.LastName = textBoxLastName.Text;
                FL.Phone = textBoxPhone.Text;
                FL.Email = textBoxEmail.Text;
                Program.wtfDb.Drivers.Add(FL);
                Program.wtfDb.SaveChanges();
                ShowDrivers();
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewDrivers.SelectedItems.Count==1)
            {
                Drivers drivers = listViewDrivers.SelectedItems[0].Tag as Drivers;
                textBoxEmail.Text = drivers.Email;
                textBoxFirstName.Text = drivers.FirstName;
                textBoxLastName.Text = drivers.LastName;
                textBoxMiddleName.Text = drivers.MiddleName;
                textBoxPhone.Text = drivers.Phone;
            }
            else
            {
                textBoxEmail.Text = "";
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDrivers.SelectedItems.Count == 1 && textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxMiddleName.Text != "")
            {
                Drivers FL = listViewDrivers.SelectedItems[0].Tag as Drivers;
                FL.FirstName = textBoxFirstName.Text;
                FL.MiddleName = textBoxMiddleName.Text;
                FL.LastName = textBoxLastName.Text;
                FL.Phone = textBoxPhone.Text;
                FL.Email = textBoxEmail.Text;
                Program.wtfDb.SaveChanges();
                ShowDrivers();
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
                if (listViewDrivers.SelectedItems.Count == 1)
                {
                    Drivers FL = listViewDrivers.SelectedItems[0].Tag as Drivers;
                    Program.wtfDb.Drivers.Remove(FL);
                    Program.wtfDb.SaveChanges();
                    ShowDrivers();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBFN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void tBMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void tBLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void tBP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }
    }
}
