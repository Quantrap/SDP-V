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
    public partial class FormPersons : Form
    {
        public FormPersons()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            if (FormAuthorization.users.type=="Manager")
            {
                comboBoxType.Enabled = false;
                buttonEdit.Enabled = false;
                buttonDel.Enabled = false;
            }
            
            ShowPersons();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewPersons.SelectedItems.Count==1)
            {
                Users users = listViewPersons.SelectedItems[0].Tag as Users;
                textBoxLogin.Text = users.Login;
            }
            else
            {
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
        }
        void ShowPersons()
        {
            listViewPersons.Items.Clear();
            foreach(Users users in Program.wtfDb.Users)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        users.Id.ToString(),users.Login,users.Type
                    });
                item.Tag = users;
                listViewPersons.Items.Add(item);
            }
            listViewPersons.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text!="" && textBoxPassword.Text!="" && comboBoxType.SelectedItem != null)
            {
                Users users = new Users();
                users.Login = textBoxLogin.Text;
                users.Password = textBoxPassword.Text;
                if(comboBoxType.SelectedIndex==0)
                {
                    users.Type = "Worker";
                }
                else if(comboBoxType.SelectedIndex == 1)
                {
                    users.Type = "Manager";
                }
                else if(comboBoxType.SelectedIndex==2)
                {
                    users.Type = "Administrator";
                }
                Program.wtfDb.Users.Add(users);
                Program.wtfDb.SaveChanges();
                ShowPersons();
            }
            else
            {
                MessageBox.Show("Данные не введены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "" && comboBoxType.SelectedItem!=null)
            {
                Users users = listViewPersons.SelectedItems[0].Tag as Users;
                users.Login = textBoxLogin.Text;
                users.Password = textBoxPassword.Text;
                if (comboBoxType.SelectedIndex == 0)
                {
                    users.Type = "Worker";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    users.Type = "Manager";
                }
                else if (comboBoxType.SelectedIndex == 2)
                {
                    users.Type = "Administrator";
                }
                Program.wtfDb.SaveChanges();
                ShowPersons();
            }
            else
            {
                MessageBox.Show("Данные не введены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPersons.SelectedItems.Count == 1)
                {
                    Users FL = listViewPersons.SelectedItems[0].Tag as Users;
                    Program.wtfDb.Users.Remove(FL);
                    Program.wtfDb.SaveChanges();
                    ShowPersons();
                }
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tBLetterControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number)  && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }
    }
}
