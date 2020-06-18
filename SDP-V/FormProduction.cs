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
    public partial class FormProduction : Form
    {
        public FormProduction()
        {
            InitializeComponent();
            textBoxAddress.Text = "г. **** ул. **** д. *****";
            textBoxAddress.ForeColor = Color.Gray;
            showProd();
        }

        private void listViewProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProd.SelectedItems.Count == 1)
            {
                Production production = listViewProd.SelectedItems[0].Tag as Production;
                textBoxAddress.Text = production.Address;
            }
            else
            {
                textBoxAddress.Text = "";
            }
            
        }
        void showProd()
        {
            listViewProd.Items.Clear();
            foreach(Production production in Program.wtfDb.Production)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        production.Id.ToString(),production.Address
                    });
                item.Tag = production;
                listViewProd.Items.Add(item);
            }
            listViewProd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAddress.Text != null)
            {
                Production production = new Production();
                production.Address = textBoxAddress.Text;
                Program.wtfDb.Production.Add(production);
                Program.wtfDb.SaveChanges();
                showProd();
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewProd.SelectedItems.Count==1 && textBoxAddress.Text!="")
            {
                Production production = listViewProd.SelectedItems[0].Tag as Production;
                production.Address = textBoxAddress.Text;
                Program.wtfDb.SaveChanges();
                showProd();
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
                if (listViewProd.SelectedItems.Count == 1)
                {
                    Production production = listViewProd.SelectedItems[0].Tag as Production;
                    Program.wtfDb.Production.Remove(production);
                    Program.wtfDb.SaveChanges();
                    showProd();
                }
                textBoxAddress.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tBDate_Enter(object sender, EventArgs e)
        {
            textBoxAddress.Text = null;
            textBoxAddress.ForeColor = Color.Black;
        }
    }
}
