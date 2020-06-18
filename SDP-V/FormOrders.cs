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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            textBoxDate.Text = "ДД.ММ.ГГГГ";
            textBoxDate.ForeColor = Color.Gray;
            ShowFL();
            ShowUL();
            ShowTovar();
            showOrders();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxUL.SelectedItem != null && comboBoxTovar.SelectedItem!=null && textBoxDate.Text.Length==10 && textBoxQuantity.Text!="" && textBoxSum.Text!="")
            {
                Orders orders = new Orders();
                
                orders.Id_UL = Convert.ToInt32(comboBoxUL.SelectedItem.ToString().Split('.')[0]);
                orders.Id_Tovar = Convert.ToInt32(comboBoxTovar.SelectedItem.ToString().Split('.')[0]);
                orders.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                orders.Sum = Convert.ToInt64(textBoxSum.Text);
                orders.Date = Convert.ToDateTime(textBoxDate.Text);
                Program.wtfDb.Orders.Add(orders);
                Program.wtfDb.SaveChanges();
                showOrders();
            }
            else if (comboBoxFL.SelectedItem != null && comboBoxTovar.SelectedItem != null && textBoxDate.Text.Length == 10 && textBoxQuantity.Text != "" && textBoxSum.Text != "")
            {
                Orders orders = new Orders();
                orders.Id_FL = Convert.ToInt32(comboBoxFL.SelectedItem.ToString().Split('.')[0]);
                
                orders.Id_Tovar = Convert.ToInt32(comboBoxTovar.SelectedItem.ToString().Split('.')[0]);
                orders.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                orders.Sum = Convert.ToInt64(textBoxSum.Text);
                orders.Date = Convert.ToDateTime(textBoxDate.Text);
                Program.wtfDb.Orders.Add(orders);
                Program.wtfDb.SaveChanges();
                showOrders();
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowTovar()
        {
            comboBoxTovar.Items.Clear();
            foreach (Characteristics characteristics in Program.wtfDb.Characteristics)
            {
                string[] item = { characteristics.Id.ToString() + ". ", characteristics.Name };
                comboBoxTovar.Items.Add(string.Join(" ", item));
            }
        }
        void ShowUL()
        {
            comboBoxUL.Items.Clear();
            foreach (Customers_UL_ UL in Program.wtfDb.Customers_UL_)
            {
                string[] item = { UL.Id.ToString() + ". ", UL.Name };
                comboBoxUL.Items.Add(string.Join(" ", item));
            }
        }
        void ShowFL()
        {
            comboBoxFL.Items.Clear();
            foreach (Customers_FL_ FL in Program.wtfDb.Customers_FL_)
            {
                string[] item = { FL.Id.ToString() + ". ", FL.LastName + " " + FL.FirstName + " " + FL.MiddleName };
                comboBoxFL.Items.Add(string.Join(" ", item));
            }
        }
        void showOrders()
        {
            listViewOrders.Items.Clear();
            foreach (Orders orders in Program.wtfDb.Orders)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        orders.Id.ToString(),orders.Quantity.ToString(),orders.Id_Tovar.ToString(),
                        orders.Sum.ToString(),orders.Id_UL.ToString(),orders.Id_FL.ToString(),orders.Date.ToString().Substring(0,8)
                    });
                item.Tag = orders;
                listViewOrders.Items.Add(item);


            }
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 1)
            {
                Orders orders = listViewOrders.SelectedItems[0].Tag as Orders;
                if (orders.Id_FL != null)
                {
                    textBoxQuantity.Text = orders.Quantity.ToString();
                    textBoxDate.Text = orders.Date.ToString().Substring(0, 10);
                    textBoxSum.Text = orders.Sum.ToString();
                    comboBoxTovar.SelectedIndex = comboBoxTovar.FindString(orders.Id_Tovar.ToString());
                    comboBoxFL.SelectedIndex = comboBoxFL.FindString(orders.Id_FL.ToString());
                    comboBoxUL.SelectedItem = null;
                }
                else if(orders.Id_UL != null)
                {
                    textBoxQuantity.Text = orders.Quantity.ToString();
                    textBoxDate.Text = orders.Date.ToString().Substring(0, 10);
                    textBoxSum.Text = orders.Sum.ToString();
                    comboBoxTovar.SelectedIndex = comboBoxTovar.FindString(orders.Id_Tovar.ToString());
                    comboBoxUL.SelectedIndex = comboBoxFL.FindString(orders.Id_FL.ToString());
                    comboBoxFL.SelectedItem = null;
                    
                }
            }
            else
            {
                textBoxQuantity.Text = "";
                textBoxDate.Text = "";
                textBoxSum.Text = "";
                comboBoxTovar.SelectedItem = null;
                comboBoxFL.SelectedItem = null;
                comboBoxUL.SelectedItem = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxUL.SelectedItem != null && comboBoxTovar.SelectedItem != null && textBoxDate.Text.Length == 10 && textBoxQuantity.Text != "" && textBoxSum.Text != "")
            {
                Orders orders = listViewOrders.SelectedItems[0].Tag as Orders;
                orders.Id_FL = null;
                orders.Id_UL = Convert.ToInt32(comboBoxUL.SelectedItem.ToString().Split('.')[0]);
                orders.Id_Tovar = Convert.ToInt32(comboBoxTovar.SelectedItem.ToString().Split('.')[0]);
                orders.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                orders.Sum = Convert.ToInt64(textBoxSum.Text);
                orders.Date = Convert.ToDateTime(textBoxDate.Text);
                
                Program.wtfDb.SaveChanges();
                showOrders();
            }
            else if (comboBoxFL.SelectedItem != null && comboBoxTovar.SelectedItem != null && textBoxDate.Text.Length == 10 && textBoxQuantity.Text != "" && textBoxSum.Text != "")
            {
                Orders orders = listViewOrders.SelectedItems[0].Tag as Orders;
                orders.Id_UL = null;
                orders.Id_FL = Convert.ToInt32(comboBoxFL.SelectedItem.ToString().Split('.')[0]);
                orders.Id_Tovar = Convert.ToInt32(comboBoxTovar.SelectedItem.ToString().Split('.')[0]);
                orders.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                orders.Sum = Convert.ToInt64(textBoxSum.Text);
                orders.Date = Convert.ToDateTime(textBoxDate.Text);
                
                Program.wtfDb.SaveChanges();
                showOrders();
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
                if (listViewOrders.SelectedItems.Count == 1)
                {
                    bool k = false;
                    Orders orders = listViewOrders.SelectedItems[0].Tag as Orders;
                    foreach (Order_F order_F in Program.wtfDb.Order_F)
                    {
                        if (order_F.Id == orders.Id) k=true;
                    }
                    if (!k)
                    {
                        Program.wtfDb.Orders.Remove(orders);
                        Program.wtfDb.SaveChanges();
                        showOrders();
                    }
                    else { MessageBox.Show("Невозможно удалить, данный заказ уже выполняется/выполнен", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                textBoxQuantity.Text = "";
                textBoxDate.Text = "";
                textBoxSum.Text = "";
                comboBoxTovar.SelectedItem = null;
                comboBoxFL.SelectedItem = null;
                comboBoxUL.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tBDControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void tBDateControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != '.' && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void tBDate_Enter(object sender, EventArgs e)
        {
            textBoxDate.Text = null;
            textBoxDate.ForeColor = Color.Black;
        }
    }
}
