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
    public partial class FormUL : Form
    {
        public FormUL()
        {
            InitializeComponent();
            textBoxAddress.Text = "г. **** ул. **** д. *****";
            textBoxAddress.ForeColor = Color.Gray;
            showUL();
        }

        private void listViewUL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUL.SelectedItems.Count == 1)
            {
                Customers_UL_ UL = listViewUL.SelectedItems[0].Tag as Customers_UL_;
                textBoxName.Text = UL.Name;
                textBoxPhone.Text = UL.Phone;
                textBoxEmail.Text = UL.Email;
                textBoxAddress.Text = UL.Address;
            }
            else
            {
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxAddress.Text = "";
            }
        }
        void showUL()
        {
            listViewUL.Items.Clear();
            foreach (Customers_UL_ UL in Program.wtfDb.Customers_UL_)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        UL.Id.ToString(),UL.Name,UL.Phone,UL.Email,UL.Address
                    });
                item.Tag = UL;
                listViewUL.Items.Add(item);


            }
            listViewUL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {if (textBoxAddress.Text != "" && textBoxName.Text != "")
            {
                Customers_UL_ UL = new Customers_UL_();
                UL.Name = textBoxName.Text;
                UL.Phone = textBoxPhone.Text;
                UL.Email = textBoxEmail.Text;
                UL.Address = textBoxAddress.Text;
                Program.wtfDb.Customers_UL_.Add(UL);
                Program.wtfDb.SaveChanges();
                showUL();
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {if (textBoxAddress.Text != "" && textBoxName.Text != "")
            {
                Customers_UL_ UL = listViewUL.SelectedItems[0].Tag as Customers_UL_;
                UL.Name = textBoxName.Text;
                UL.Phone = textBoxPhone.Text;
                UL.Email = textBoxEmail.Text;
                UL.Address = textBoxAddress.Text;
                Program.wtfDb.SaveChanges();
                showUL();
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
                if (listViewUL.SelectedItems.Count == 1)
                {
                    Customers_UL_ UL = listViewUL.SelectedItems[0].Tag as Customers_UL_;
                    Program.wtfDb.Customers_UL_.Remove(UL);
                    Program.wtfDb.SaveChanges();
                    showUL();
                }
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxAddress.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tBAddress_Enter(object sender, EventArgs e)
        {
            textBoxAddress.Text = null;
            textBoxAddress.ForeColor = Color.Black;
        }

        private void tBDigitControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)  && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }
    }
}
