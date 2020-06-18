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
    public partial class FormOrders_P : Form
    {
        public FormOrders_P()
        {
            InitializeComponent();
            textBoxDate.Text = "ДД.ММ.ГГГГ";
            textBoxDate.ForeColor = Color.Gray;
            showProd();
            showOrders();
            ShowOrdersP();
        }
        void showProd()
        {
            comboBoxProduction.Items.Clear();
            foreach (Production production in Program.wtfDb.Production)
            {
                string[] item = { production.Id.ToString() + ". ", production.Address };
                comboBoxProduction.Items.Add(string.Join(" ", item));
            }
        }
        void showOrders()
        {
            comboBoxOrder.Items.Clear();
            foreach (Orders orders in Program.wtfDb.Orders)
            {
                int k = 0;
                foreach(Order_F orders1 in Program.wtfDb.Order_F)
                {
                    if (orders.Id == orders1.Id) k += 1;
                }
                if (k == 0)
                {
                        string[] item = { orders.Id.ToString() + ". ", orders.Characteristics.Name };
                        comboBoxOrder.Items.Add(string.Join(" ", item));
                }
            }
        }
        void ShowOrdersP()
        {
            listViewOrdersP.Items.Clear();
            foreach (Order_F orders in Program.wtfDb.Order_F)
            {
                if(orders.Date!=null)
                {
                    ListViewItem item = new ListViewItem(new string[]
                        {
                        orders.Id.ToString(),"Id: "+orders.id_production.ToString()+" "+orders.Production.Address,orders.Date.ToString().Substring(0,8)
                        });
                    item.Tag = orders;
                    listViewOrdersP.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        orders.Id.ToString(),"Id: "+orders.id_production.ToString()+" "+orders.Production.Address
                    });
                    item.Tag = orders;
                    listViewOrdersP.Items.Add(item);
                }

            }
            listViewOrdersP.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewOrdersP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrdersP.SelectedItems.Count == 1)
            {
                Order_F orders = listViewOrdersP.SelectedItems[0].Tag as Order_F;
                comboBoxProduction.SelectedIndex = comboBoxProduction.FindString(orders.id_production.ToString());
                comboBoxOrder.SelectedIndex = comboBoxOrder.FindString(orders.Id.ToString());
                if(orders.Date!=null)
                {
                    textBoxDate.Text = Convert.ToString(orders.Date).Substring(0, 10);
                }
            }
            else
            {
                comboBoxOrder.SelectedItem = null;
                comboBoxProduction.SelectedItem = null;
                textBoxDate.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxOrder.SelectedItem != null && comboBoxProduction.SelectedItem != null)
            {
                Order_F orders = new Order_F();

                orders.Id = Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]);
                orders.id_production = Convert.ToInt32(comboBoxProduction.SelectedItem.ToString().Split('.')[0]);
                if (textBoxDate.Text.Length ==10)
                {
                    orders.Date = Convert.ToDateTime(textBoxDate.Text);
                }
                Program.wtfDb.Order_F.Add(orders);
                Program.wtfDb.SaveChanges();
                ShowOrdersP();
                showOrders();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrdersP.SelectedItems.Count == 1)
                {
                    Order_F FL = listViewOrdersP.SelectedItems[0].Tag as Order_F;
                    Program.wtfDb.Order_F.Remove(FL);
                    Program.wtfDb.SaveChanges();
                    ShowOrdersP();
                }
                comboBoxOrder.SelectedItem = null;
                comboBoxProduction.SelectedItem = null;
                textBoxDate.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tBDate_Enter(object sender, EventArgs e)
        {
            textBoxDate.Text = null;
            textBoxDate.ForeColor = Color.Black;
        }

        private void tBDateControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != '.' && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }
    }
}
