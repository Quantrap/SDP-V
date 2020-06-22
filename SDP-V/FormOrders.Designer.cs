namespace SDP_V
{
    partial class FormOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelFL = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxFL = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelTovar = new System.Windows.Forms.Label();
            this.comboBoxTovar = new System.Windows.Forms.ComboBox();
            this.labelUL = new System.Windows.Forms.Label();
            this.comboBoxUL = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Green;
            this.buttonDel.ForeColor = System.Drawing.Color.LawnGreen;
            this.buttonDel.Location = new System.Drawing.Point(691, 114);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(97, 45);
            this.buttonDel.TabIndex = 19;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Green;
            this.buttonEdit.ForeColor = System.Drawing.Color.LawnGreen;
            this.buttonEdit.Location = new System.Drawing.Point(691, 63);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(97, 45);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.ForeColor = System.Drawing.Color.LawnGreen;
            this.buttonAdd.Location = new System.Drawing.Point(691, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(97, 45);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelFL
            // 
            this.labelFL.AutoSize = true;
            this.labelFL.Location = new System.Drawing.Point(400, 47);
            this.labelFL.Name = "labelFL";
            this.labelFL.Size = new System.Drawing.Size(98, 13);
            this.labelFL.TabIndex = 16;
            this.labelFL.Text = "Физические лица";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(145, 47);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(117, 13);
            this.labelSum.TabIndex = 15;
            this.labelSum.Text = "Общая сумма заказа";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(145, 8);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(66, 13);
            this.labelQuantity.TabIndex = 14;
            this.labelQuantity.Text = "Количество";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(145, 63);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(121, 20);
            this.textBoxSum.TabIndex = 13;
            this.textBoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDControl_KeyPress);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(144, 24);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(122, 20);
            this.textBoxQuantity.TabIndex = 12;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDControl_KeyPress);
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.GridLines = true;
            this.listViewOrders.Location = new System.Drawing.Point(27, 114);
            this.listViewOrders.MultiSelect = false;
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(658, 351);
            this.listViewOrders.TabIndex = 11;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            this.listViewOrders.SelectedIndexChanged += new System.EventHandler(this.listViewOrders_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Количество";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Товар";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Общая сумма заказа";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id Юр. лица";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id Физ. лица";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Дата заказа";
            // 
            // comboBoxFL
            // 
            this.comboBoxFL.FormattingEnabled = true;
            this.comboBoxFL.Location = new System.Drawing.Point(399, 63);
            this.comboBoxFL.Name = "comboBoxFL";
            this.comboBoxFL.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFL.TabIndex = 10;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(272, 8);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(72, 13);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "Дата заказа";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(272, 24);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(121, 20);
            this.textBoxDate.TabIndex = 20;
            this.textBoxDate.Enter += new System.EventHandler(this.tBDate_Enter);
            this.textBoxDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDateControl_KeyPress);
            // 
            // labelTovar
            // 
            this.labelTovar.AutoSize = true;
            this.labelTovar.Location = new System.Drawing.Point(274, 47);
            this.labelTovar.Name = "labelTovar";
            this.labelTovar.Size = new System.Drawing.Size(38, 13);
            this.labelTovar.TabIndex = 23;
            this.labelTovar.Text = "Товар";
            // 
            // comboBoxTovar
            // 
            this.comboBoxTovar.FormattingEnabled = true;
            this.comboBoxTovar.Location = new System.Drawing.Point(272, 63);
            this.comboBoxTovar.Name = "comboBoxTovar";
            this.comboBoxTovar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTovar.TabIndex = 22;
            // 
            // labelUL
            // 
            this.labelUL.AutoSize = true;
            this.labelUL.Location = new System.Drawing.Point(400, 9);
            this.labelUL.Name = "labelUL";
            this.labelUL.Size = new System.Drawing.Size(102, 13);
            this.labelUL.TabIndex = 25;
            this.labelUL.Text = "Юридические лица";
            // 
            // comboBoxUL
            // 
            this.comboBoxUL.FormattingEnabled = true;
            this.comboBoxUL.Location = new System.Drawing.Point(399, 25);
            this.comboBoxUL.Name = "comboBoxUL";
            this.comboBoxUL.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUL.TabIndex = 24;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.labelUL);
            this.Controls.Add(this.comboBoxUL);
            this.Controls.Add(this.labelTovar);
            this.Controls.Add(this.comboBoxTovar);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelFL);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.comboBoxFL);
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelFL;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ComboBox comboBoxFL;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelTovar;
        private System.Windows.Forms.ComboBox comboBoxTovar;
        private System.Windows.Forms.Label labelUL;
        private System.Windows.Forms.ComboBox comboBoxUL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}