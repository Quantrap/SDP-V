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
    public partial class FormFL : Form
    {
        public FormFL()
        {
            InitializeComponent();
            ShowFL();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxMiddleName.Text != "") 
            {
                Customers_FL_ FL = new Customers_FL_();
                FL.FirstName = textBoxFirstName.Text;
                FL.MiddleName = textBoxMiddleName.Text;
                FL.LastName = textBoxLastName.Text;
                FL.Phone = textBoxPhone.Text;
                FL.Email = textBoxEmail.Text;
                Program.wtfDb.Customers_FL_.Add(FL);
                Program.wtfDb.SaveChanges();
                ShowFL();
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowFL()
        {
            listViewFL.Items.Clear();
            foreach (Customers_FL_ FL in Program.wtfDb.Customers_FL_)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        FL.Id.ToString(),FL.FirstName,FL.MiddleName,
                        FL.LastName,FL.Phone,FL.Email
                    });
                item.Tag = FL;
                listViewFL.Items.Add(item);


            }
            listViewFL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewFL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFL.SelectedItems.Count == 1)
            {
                Customers_FL_ FL = listViewFL.SelectedItems[0].Tag as Customers_FL_;
                textBoxFirstName.Text = FL.FirstName;
                textBoxMiddleName.Text = FL.MiddleName;
                textBoxLastName.Text = FL.LastName;
                textBoxPhone.Text = FL.Phone;
                textBoxEmail.Text = FL.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewFL.SelectedItems.Count == 1 && textBoxFirstName.Text!="" && textBoxLastName.Text!="" && textBoxMiddleName.Text!="")
            {
                Customers_FL_ FL = listViewFL.SelectedItems[0].Tag as Customers_FL_;
                FL.FirstName = textBoxFirstName.Text;
                FL.MiddleName = textBoxMiddleName.Text;
                FL.LastName = textBoxLastName.Text;
                FL.Phone = textBoxPhone.Text;
                FL.Email = textBoxEmail.Text;
                Program.wtfDb.SaveChanges();
                ShowFL();
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
                if (listViewFL.SelectedItems.Count == 1)
                {
                    Customers_FL_ FL = listViewFL.SelectedItems[0].Tag as Customers_FL_;
                    Program.wtfDb.Customers_FL_.Remove(FL);
                    Program.wtfDb.SaveChanges();
                    ShowFL();
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

        private void labelLastName_Click(object sender, EventArgs e)
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
