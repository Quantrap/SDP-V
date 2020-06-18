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
    public partial class FormChar : Form
    {
        public FormChar()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowProjects();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxCost.Text != "" && textBoxName.Text != "" )
            {
                Characteristics characteristics = new Characteristics();
                characteristics.Name = textBoxName.Text;
                characteristics.Cost = Convert.ToDouble(textBoxCost.Text);
                
                if (comboBoxType.SelectedIndex == 0 && textBoxSheetsNumber.Text != "" && textBoxPaperDensity.Text != "" && textBoxListHeight.Text != "" && textBoxListWidth.Text != "")
                {
                    characteristics.list_height = Convert.ToDouble(textBoxListHeight.Text);
                    characteristics.list_width = Convert.ToDouble(textBoxListWidth.Text);
                    characteristics.Type_Project = 0;
                    characteristics.number_of_sheets = Convert.ToInt32(textBoxSheetsNumber.Text);
                    characteristics.density_paper = Convert.ToDouble(textBoxPaperDensity.Text);
                    Program.wtfDb.Characteristics.Add(characteristics);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                else if (comboBoxType.SelectedIndex == 1 && textBoxSheetsNumber.Text != "" && textBoxPaperDensity.Text != "" && textBoxListHeight.Text != "" && textBoxListWidth.Text != "")
                {
                    characteristics.list_height = Convert.ToDouble(textBoxListHeight.Text);
                    characteristics.list_width = Convert.ToDouble(textBoxListWidth.Text);
                    characteristics.Type_Project = 1;
                    characteristics.number_of_sheets = Convert.ToInt32(textBoxSheetsNumber.Text);
                    characteristics.density_paper = Convert.ToDouble(textBoxPaperDensity.Text);
                    Program.wtfDb.Characteristics.Add(characteristics);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                else if (comboBoxType.SelectedIndex == 2 && textBoxSheetsNumber.Text != "" && textBoxPaperDensity.Text != "" && textBoxListHeight.Text != "" && textBoxListWidth.Text != "")
                {
                    characteristics.list_height = Convert.ToDouble(textBoxListHeight.Text);
                    characteristics.list_width = Convert.ToDouble(textBoxListWidth.Text);
                    characteristics.Type_Project = 2;
                    characteristics.number_of_sheets = Convert.ToInt32(textBoxSheetsNumber.Text);
                    characteristics.density_paper = Convert.ToDouble(textBoxPaperDensity.Text);
                    Program.wtfDb.Characteristics.Add(characteristics);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                else if (comboBoxType.SelectedIndex == 3 && textBoxCardboardDensity.Text != "" && textBoxListHeight.Text != "" && textBoxListWidth.Text != "")
                {
                    characteristics.list_height = Convert.ToDouble(textBoxListHeight.Text);
                    characteristics.list_width = Convert.ToDouble(textBoxListWidth.Text);
                    characteristics.Type_Project = 3;
                    characteristics.Cardboard_density = Convert.ToDouble(textBoxCardboardDensity.Text);
                    Program.wtfDb.Characteristics.Add(characteristics);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                else if (comboBoxType.SelectedIndex == 4)
                {
                    characteristics.Type_Project = 4;
                    characteristics.number_of_sheets = Convert.ToInt32(textBoxSheetsNumber.Text);
                    characteristics.density_paper = Convert.ToDouble(textBoxPaperDensity.Text);
                    characteristics.Cardboard_density = Convert.ToDouble(textBoxCardboardDensity.Text);
                    characteristics.Poster_size_height_met = Convert.ToDouble(textBoxPosterHeight.Text);
                    characteristics.Poster_size_width_met = Convert.ToDouble(textBoxPosterWidth.Text);
                    Program.wtfDb.Characteristics.Add(characteristics);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                else
                {
                    MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowProjects()
        {
            listViewBH.Items.Clear();
            listViewBL.Items.Clear();
            listViewBrosh.Items.Clear();
            listViewCB.Items.Clear();
            listViewIP.Items.Clear();
            foreach (Characteristics characteristic in Program.wtfDb.Characteristics)
            {
                if (characteristic.Type_Project == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        "Id: "+ characteristic.Id.ToString()+" "+characteristic.Name,
                        characteristic.Cost.ToString()+" р",
                        characteristic.list_height.ToString()+" см",
                        characteristic.list_width.ToString()+" см",
                        characteristic.density_paper.ToString(),
                        characteristic.number_of_sheets.ToString()
                    });
                    item.Tag = characteristic;
                    listViewBH.Items.Add(item);
                }
                else if (characteristic.Type_Project == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        "Id: "+ characteristic.Id.ToString()+" "+characteristic.Name,
                        characteristic.Cost.ToString()+" р",
                        characteristic.list_height.ToString()+" см",
                        characteristic.list_width.ToString()+" см",
                        characteristic.density_paper.ToString(),
                        characteristic.number_of_sheets.ToString()
                    });
                    item.Tag = characteristic;
                    listViewBL.Items.Add(item);
                }
                else if (characteristic.Type_Project == 2)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        "Id: "+ characteristic.Id.ToString()+" "+characteristic.Name,
                        characteristic.Cost.ToString()+" р",
                        characteristic.list_height.ToString()+" см",
                        characteristic.list_width.ToString()+" см",
                        characteristic.density_paper.ToString(),
                        characteristic.number_of_sheets.ToString()
                    });
                    item.Tag = characteristic;
                    listViewBrosh.Items.Add(item);
                }
                else if (characteristic.Type_Project == 3)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        "Id: "+ characteristic.Id.ToString()+" "+characteristic.Name,
                        characteristic.Cost.ToString()+" р",
                        characteristic.list_height.ToString()+" см",
                        characteristic.list_width.ToString()+" см",
                        characteristic.Cardboard_density.ToString()
                    });
                    item.Tag = characteristic;
                    listViewCB.Items.Add(item);
                }
                else if (characteristic.Type_Project == 4)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        "Id: "+ characteristic.Id.ToString()+" "+characteristic.Name,
                        characteristic.Cost.ToString()+" р",
                        characteristic.list_height.ToString()+" см",
                        characteristic.list_width.ToString()+" см",
                        characteristic.density_paper.ToString(),
                        characteristic.number_of_sheets.ToString(),
                        characteristic.Poster_size_height_met.ToString(),
                        characteristic.Poster_size_width_met.ToString(),
                        characteristic.Cardboard_density.ToString()
                    });
                    item.Tag = characteristic;
                    listViewIP.Items.Add(item);
                }
            }
            listViewBH.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewBL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewBrosh.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewCB.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewIP.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewBH.Visible = true;
                labelPaperDensity.Visible = true;
                textBoxPaperDensity.Visible = true;
                labelSheetsNumber.Visible = true;
                textBoxSheetsNumber.Visible = true;

                listViewBL.Visible = false;
                listViewBrosh.Visible = false;
                listViewCB.Visible = false;
                listViewIP.Visible = false;
                labelPosterHeight.Visible = false;
                textBoxPosterHeight.Visible = false;
                labelPosterWidth.Visible = false;
                textBoxPosterWidth.Visible = false;
                labelCardboardDensity.Visible = false;
                textBoxCardboardDensity.Visible = false;

                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxName.Text = "";
                textBoxPaperDensity.Text = "";
                textBoxSheetsNumber.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewBL.Visible = true;
                labelPaperDensity.Visible = true;
                textBoxPaperDensity.Visible = true;
                labelSheetsNumber.Visible = true;
                textBoxSheetsNumber.Visible = true;

                listViewBH.Visible = false;
                listViewBrosh.Visible = false;
                listViewCB.Visible = false;
                listViewIP.Visible = false;
                labelPosterHeight.Visible = false;
                textBoxPosterHeight.Visible = false;
                labelPosterWidth.Visible = false;
                textBoxPosterWidth.Visible = false;
                labelCardboardDensity.Visible = false;
                textBoxCardboardDensity.Visible = false;

                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxName.Text = "";
                textBoxPaperDensity.Text = "";
                textBoxSheetsNumber.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewBrosh.Visible = true;
                labelPaperDensity.Visible = true;
                textBoxPaperDensity.Visible = true;
                labelSheetsNumber.Visible = true;
                textBoxSheetsNumber.Visible = true;

                listViewBH.Visible = false;
                listViewBL.Visible = false;
                listViewCB.Visible = false;
                listViewIP.Visible = false;
                labelPosterHeight.Visible = false;
                textBoxPosterHeight.Visible = false;
                labelPosterWidth.Visible = false;
                textBoxPosterWidth.Visible = false;
                labelCardboardDensity.Visible = false;
                textBoxCardboardDensity.Visible = false;

                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxName.Text = "";
                textBoxPaperDensity.Text = "";
                textBoxSheetsNumber.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 3)
            {
                listViewCB.Visible = true;
                labelCardboardDensity.Visible = true;
                textBoxCardboardDensity.Visible = true;

                listViewBH.Visible = false;
                listViewBL.Visible = false;
                listViewBrosh.Visible = false;
                listViewIP.Visible = false;
                labelPosterHeight.Visible = false;
                textBoxPosterHeight.Visible = false;
                labelPosterWidth.Visible = false;
                textBoxPosterWidth.Visible = false;
                labelPaperDensity.Visible = false;
                textBoxPaperDensity.Visible = false;
                labelSheetsNumber.Visible = false;
                textBoxSheetsNumber.Visible = false;

                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxName.Text = "";
                textBoxCardboardDensity.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 4)
            {
                listViewIP.Visible = true;
                labelCardboardDensity.Visible = true;
                textBoxCardboardDensity.Visible = true;
                listViewBH.Visible = true;
                listViewBL.Visible = true;
                listViewBrosh.Visible = true;
                listViewIP.Visible = true;
                labelPosterHeight.Visible = true;
                textBoxPosterHeight.Visible = true;
                labelPosterWidth.Visible = true;
                textBoxPosterWidth.Visible = true;
                labelCardboardDensity.Visible = true;
                textBoxCardboardDensity.Visible = true;
                labelPaperDensity.Visible = true;
                textBoxPaperDensity.Visible = true;
                labelSheetsNumber.Visible = true;
                textBoxSheetsNumber.Visible = true;

                listViewBH.Visible = false;
                listViewBL.Visible = false;
                listViewBrosh.Visible = false;
                listViewCB.Visible = false;

                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxName.Text = "";
                textBoxPaperDensity.Text = "";
                textBoxSheetsNumber.Text = "";
                textBoxCardboardDensity.Text = "";
                textBoxPosterHeight.Text = "";
                textBoxPosterWidth.Text = "";

            }
        }

        private void listViewBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBH.SelectedItems.Count == 1)
            {
                Characteristics characteristics = listViewBH.SelectedItems[0].Tag as Characteristics;
                textBoxName.Text = characteristics.Name;
                textBoxCost.Text = characteristics.Cost.ToString();
                textBoxListHeight.Text = characteristics.list_height.ToString();
                textBoxListWidth.Text = characteristics.list_width.ToString();
                textBoxSheetsNumber.Text = characteristics.number_of_sheets.ToString();
                textBoxPaperDensity.Text = characteristics.density_paper.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxSheetsNumber.Text = "";
                textBoxPaperDensity.Text = "";
            }
        }

        private void listViewBL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBL.SelectedItems.Count == 1)
            {
                Characteristics characteristics = listViewBL.SelectedItems[0].Tag as Characteristics;
                textBoxName.Text = characteristics.Name;
                textBoxCost.Text = characteristics.Cost.ToString();
                textBoxListHeight.Text = characteristics.list_height.ToString();
                textBoxListWidth.Text = characteristics.list_width.ToString();
                textBoxSheetsNumber.Text = characteristics.number_of_sheets.ToString();
                textBoxPaperDensity.Text = characteristics.density_paper.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxSheetsNumber.Text = "";
                textBoxPaperDensity.Text = "";
            }
        }

        private void listViewBrosh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBrosh.SelectedItems.Count == 1)
            {
                Characteristics characteristics = listViewBrosh.SelectedItems[0].Tag as Characteristics;
                textBoxName.Text = characteristics.Name;
                textBoxCost.Text = characteristics.Cost.ToString();
                textBoxListHeight.Text = characteristics.list_height.ToString();
                textBoxListWidth.Text = characteristics.list_width.ToString();
                textBoxSheetsNumber.Text = characteristics.number_of_sheets.ToString();
                textBoxPaperDensity.Text = characteristics.density_paper.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxSheetsNumber.Text = "";
                textBoxPaperDensity.Text = "";
            }
        }

        private void listViewCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCB.SelectedItems.Count == 1)
            {
                Characteristics characteristics = listViewCB.SelectedItems[0].Tag as Characteristics;
                textBoxName.Text = characteristics.Name;
                textBoxCost.Text = characteristics.Cost.ToString();
                textBoxListHeight.Text = characteristics.list_height.ToString();
                textBoxListWidth.Text = characteristics.list_width.ToString();
                textBoxCardboardDensity.Text = characteristics.Cardboard_density.ToString();

            }
            else
            {
                textBoxName.Text = "";
                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxCardboardDensity.Text = "";
            }
        }

        private void listViewIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewIP.SelectedItems.Count == 1)
            {
                Characteristics characteristics = listViewIP.SelectedItems[0].Tag as Characteristics;
                textBoxName.Text = characteristics.Name;
                textBoxCost.Text = characteristics.Cost.ToString();
                textBoxListHeight.Text = characteristics.list_height.ToString();
                textBoxListWidth.Text = characteristics.list_width.ToString();
                textBoxCardboardDensity.Text = characteristics.Cardboard_density.ToString();
                textBoxSheetsNumber.Text = characteristics.number_of_sheets.ToString();
                textBoxPaperDensity.Text = characteristics.density_paper.ToString();
                textBoxPosterHeight.Text = characteristics.Poster_size_height_met.ToString();
                textBoxPosterWidth.Text = characteristics.Poster_size_width_met.ToString();

            }
            else
            {
                textBoxName.Text = "";
                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxCardboardDensity.Text = "";
                textBoxSheetsNumber.Text = "";
                textBoxPaperDensity.Text = "";
                textBoxPosterHeight.Text = "";
                textBoxPosterWidth.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewBH.SelectedItems.Count == 1 && textBoxSheetsNumber.Text != "" && textBoxPaperDensity.Text != "" && textBoxListHeight.Text != "" && textBoxListWidth.Text != ""&& textBoxCost.Text != "" && textBoxName.Text != "")
                {
                    Characteristics characteristics = listViewBH.SelectedItems[0].Tag as Characteristics;
                    characteristics.Name = textBoxName.Text;
                    characteristics.Cost = Convert.ToDouble(textBoxCost.Text);
                    characteristics.list_height = Convert.ToDouble(textBoxListHeight.Text);
                    characteristics.list_width = Convert.ToDouble(textBoxListWidth.Text);
                    characteristics.number_of_sheets = Convert.ToInt32(textBoxSheetsNumber.Text);
                    characteristics.density_paper = Convert.ToDouble(textBoxPaperDensity.Text);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                else
                {
                    MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewBL.SelectedItems.Count == 1 && textBoxSheetsNumber.Text != "" && textBoxPaperDensity.Text != "" && textBoxListHeight.Text != "" && textBoxListWidth.Text != "" && textBoxCost.Text != "" && textBoxName.Text != "")
                {
                    Characteristics characteristics = listViewBL.SelectedItems[0].Tag as Characteristics;
                    characteristics.Name = textBoxName.Text;
                    characteristics.Cost = Convert.ToDouble(textBoxCost.Text);
                    characteristics.list_height = Convert.ToDouble(textBoxListHeight.Text);
                    characteristics.list_width = Convert.ToDouble(textBoxListWidth.Text);
                    characteristics.number_of_sheets = Convert.ToInt32(textBoxSheetsNumber.Text);
                    characteristics.density_paper = Convert.ToDouble(textBoxPaperDensity.Text);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                else
                {
                    MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                if (listViewBrosh.SelectedItems.Count == 1 && textBoxSheetsNumber.Text != "" && textBoxPaperDensity.Text != "" && textBoxListHeight.Text != "" && textBoxListWidth.Text != "" && textBoxCost.Text != "" && textBoxName.Text != "")
                {
                    Characteristics characteristics = listViewBrosh.SelectedItems[0].Tag as Characteristics;
                    characteristics.Name = textBoxName.Text;
                    characteristics.Cost = Convert.ToDouble(textBoxCost.Text);
                    characteristics.list_height = Convert.ToDouble(textBoxListHeight.Text);
                    characteristics.list_width = Convert.ToDouble(textBoxListWidth.Text);
                    characteristics.number_of_sheets = Convert.ToInt32(textBoxSheetsNumber.Text);
                    characteristics.density_paper = Convert.ToDouble(textBoxPaperDensity.Text);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                else
                {
                    MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxType.SelectedIndex == 3)
            {
                if (listViewCB.SelectedItems.Count == 1 && textBoxCardboardDensity.Text!="" && textBoxListHeight.Text != "" && textBoxListWidth.Text != "" && textBoxCost.Text != "" && textBoxName.Text != "")
                {
                    Characteristics characteristics = listViewCB.SelectedItems[0].Tag as Characteristics;
                    characteristics.Name = textBoxName.Text;
                    characteristics.Cost = Convert.ToDouble(textBoxCost.Text);
                    characteristics.list_height = Convert.ToDouble(textBoxListHeight.Text);
                    characteristics.list_width = Convert.ToDouble(textBoxListWidth.Text);
                    characteristics.Cardboard_density = Convert.ToDouble(textBoxCardboardDensity.Text);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();

                }
                else
                {
                    MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxType.SelectedIndex == 4)
            {
                if (listViewIP.SelectedItems.Count == 1 && textBoxCost.Text != "" && textBoxName.Text != "")
                {
                    Characteristics characteristics = listViewIP.SelectedItems[0].Tag as Characteristics;
                    characteristics.Name = textBoxName.Text;
                    characteristics.Cost = Convert.ToDouble(textBoxCost.Text);
                    characteristics.list_height = Convert.ToDouble(textBoxListHeight.Text);
                    characteristics.list_width = Convert.ToDouble(textBoxListWidth.Text);
                    characteristics.Cardboard_density = Convert.ToDouble(textBoxCardboardDensity.Text);
                    characteristics.number_of_sheets = Convert.ToInt32(textBoxSheetsNumber.Text);
                    characteristics.density_paper = Convert.ToDouble(textBoxPaperDensity.Text);
                    characteristics.Poster_size_height_met = Convert.ToDouble(textBoxPosterHeight.Text);
                    characteristics.Poster_size_width_met = Convert.ToDouble(textBoxPosterWidth.Text);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                else
                {
                    MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите тип проекта!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewBH.SelectedItems.Count == 1)
                {
                    Characteristics characteristics = listViewBH.SelectedItems[0].Tag as Characteristics;
                    Program.wtfDb.Characteristics.Remove(characteristics);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                textBoxName.Text = "";
                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxSheetsNumber.Text = "";
                textBoxPaperDensity.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewBL.SelectedItems.Count == 1)
                {
                    Characteristics characteristics = listViewBL.SelectedItems[0].Tag as Characteristics;
                    Program.wtfDb.Characteristics.Remove(characteristics);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                textBoxName.Text = "";
                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxSheetsNumber.Text = "";
                textBoxPaperDensity.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                if (listViewBrosh.SelectedItems.Count == 1)
                {
                    Characteristics characteristics = listViewBrosh.SelectedItems[0].Tag as Characteristics;
                    Program.wtfDb.Characteristics.Remove(characteristics);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                textBoxName.Text = "";
                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxSheetsNumber.Text = "";
                textBoxPaperDensity.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 3)
            {
                if (listViewCB.SelectedItems.Count == 1)
                {
                    Characteristics characteristics = listViewCB.SelectedItems[0].Tag as Characteristics;
                    Program.wtfDb.Characteristics.Remove(characteristics);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                textBoxName.Text = "";
                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxCardboardDensity.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 4)
            {
                if (listViewIP.SelectedItems.Count == 1)
                {
                    Characteristics characteristics = listViewIP.SelectedItems[0].Tag as Characteristics;
                    Program.wtfDb.Characteristics.Remove(characteristics);
                    Program.wtfDb.SaveChanges();
                    ShowProjects();
                }
                textBoxName.Text = "";
                textBoxCost.Text = "";
                textBoxListHeight.Text = "";
                textBoxListWidth.Text = "";
                textBoxCardboardDensity.Text = "";
                textBoxSheetsNumber.Text = "";
                textBoxPaperDensity.Text = "";
                textBoxPosterHeight.Text = "";
                textBoxPosterWidth.Text = "";
            }
        }

        private void textBoxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number!=',' && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxlh_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != ',' && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxlw_keyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != ',' && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void tBPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != ',' && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void tBNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) &&  !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void tBPH_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != ',' && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void tBPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != ',' && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void tBCBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != ',' && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }
    }
}
