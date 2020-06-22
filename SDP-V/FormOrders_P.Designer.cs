namespace SDP_V
{
    partial class FormOrders_P
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
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.comboBoxProduction = new System.Windows.Forms.ComboBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewOrdersP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelProduction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Location = new System.Drawing.Point(145, 25);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrder.TabIndex = 0;
            // 
            // comboBoxProduction
            // 
            this.comboBoxProduction.FormattingEnabled = true;
            this.comboBoxProduction.Location = new System.Drawing.Point(145, 63);
            this.comboBoxProduction.Name = "comboBoxProduction";
            this.comboBoxProduction.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProduction.TabIndex = 1;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Green;
            this.buttonDel.ForeColor = System.Drawing.Color.LawnGreen;
            this.buttonDel.Location = new System.Drawing.Point(644, 63);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(97, 45);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.ForeColor = System.Drawing.Color.LawnGreen;
            this.buttonAdd.Location = new System.Drawing.Point(644, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(97, 45);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewOrdersP
            // 
            this.listViewOrdersP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewOrdersP.FullRowSelect = true;
            this.listViewOrdersP.GridLines = true;
            this.listViewOrdersP.Location = new System.Drawing.Point(9, 96);
            this.listViewOrdersP.MultiSelect = false;
            this.listViewOrdersP.Name = "listViewOrdersP";
            this.listViewOrdersP.Size = new System.Drawing.Size(629, 307);
            this.listViewOrdersP.TabIndex = 10;
            this.listViewOrdersP.UseCompatibleStateImageBehavior = false;
            this.listViewOrdersP.View = System.Windows.Forms.View.Details;
            this.listViewOrdersP.SelectedIndexChanged += new System.EventHandler(this.listViewOrdersP_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Выполненного заказа";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Производство";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата выполнения";
            this.columnHeader3.Width = 134;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(272, 10);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(98, 13);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "Дата выполнения";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(272, 26);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(122, 20);
            this.textBoxDate.TabIndex = 14;
            this.textBoxDate.Enter += new System.EventHandler(this.tBDate_Enter);
            this.textBoxDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDateControl_KeyPress);
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(145, 9);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(80, 13);
            this.labelOrder.TabIndex = 16;
            this.labelOrder.Text = "Номер заказа";
            // 
            // labelProduction
            // 
            this.labelProduction.AutoSize = true;
            this.labelProduction.Location = new System.Drawing.Point(145, 47);
            this.labelProduction.Name = "labelProduction";
            this.labelProduction.Size = new System.Drawing.Size(80, 13);
            this.labelProduction.TabIndex = 17;
            this.labelProduction.Text = "Производство";
            // 
            // FormOrders_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 415);
            this.Controls.Add(this.labelProduction);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewOrdersP);
            this.Controls.Add(this.comboBoxProduction);
            this.Controls.Add(this.comboBoxOrder);
            this.Name = "FormOrders_P";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выполняющиеся/Выполненные заказы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.ComboBox comboBoxProduction;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewOrdersP;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelProduction;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}