namespace SDP_V
{
    partial class FormDelivery
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
            this.labelDriver = new System.Windows.Forms.Label();
            this.comboBoxDriver = new System.Windows.Forms.ComboBox();
            this.labelOrder_P = new System.Windows.Forms.Label();
            this.comboBoxOrder_P = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewDelivery = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelDriver
            // 
            this.labelDriver.AutoSize = true;
            this.labelDriver.Location = new System.Drawing.Point(134, 43);
            this.labelDriver.Name = "labelDriver";
            this.labelDriver.Size = new System.Drawing.Size(55, 13);
            this.labelDriver.TabIndex = 8;
            this.labelDriver.Text = "Водитель";
            // 
            // comboBoxDriver
            // 
            this.comboBoxDriver.FormattingEnabled = true;
            this.comboBoxDriver.Location = new System.Drawing.Point(137, 59);
            this.comboBoxDriver.Name = "comboBoxDriver";
            this.comboBoxDriver.Size = new System.Drawing.Size(154, 21);
            this.comboBoxDriver.TabIndex = 7;
            // 
            // labelOrder_P
            // 
            this.labelOrder_P.AutoSize = true;
            this.labelOrder_P.Location = new System.Drawing.Point(134, 5);
            this.labelOrder_P.Name = "labelOrder_P";
            this.labelOrder_P.Size = new System.Drawing.Size(38, 13);
            this.labelOrder_P.TabIndex = 10;
            this.labelOrder_P.Text = "Заказ";
            // 
            // comboBoxOrder_P
            // 
            this.comboBoxOrder_P.FormattingEnabled = true;
            this.comboBoxOrder_P.Location = new System.Drawing.Point(137, 21);
            this.comboBoxOrder_P.Name = "comboBoxOrder_P";
            this.comboBoxOrder_P.Size = new System.Drawing.Size(154, 21);
            this.comboBoxOrder_P.TabIndex = 9;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(297, 6);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(83, 13);
            this.labelDate.TabIndex = 14;
            this.labelDate.Text = "Дата доставки";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(298, 44);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(88, 13);
            this.labelAddress.TabIndex = 13;
            this.labelAddress.Text = "Адрес доставки";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(297, 22);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(192, 20);
            this.textBoxDate.TabIndex = 12;
            this.textBoxDate.Enter += new System.EventHandler(this.textBoxDate_Enter);
            this.textBoxDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBD_KeyPress);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(297, 60);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(192, 20);
            this.textBoxAddress.TabIndex = 11;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            this.textBoxAddress.Enter += new System.EventHandler(this.textBoxAddress_Enter);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Green;
            this.buttonDel.ForeColor = System.Drawing.Color.LawnGreen;
            this.buttonDel.Location = new System.Drawing.Point(691, 110);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(97, 45);
            this.buttonDel.TabIndex = 18;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Green;
            this.buttonEdit.ForeColor = System.Drawing.Color.LawnGreen;
            this.buttonEdit.Location = new System.Drawing.Point(691, 59);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(97, 45);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.ForeColor = System.Drawing.Color.LawnGreen;
            this.buttonAdd.Location = new System.Drawing.Point(691, 8);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(97, 45);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewDelivery
            // 
            this.listViewDelivery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDelivery.FullRowSelect = true;
            this.listViewDelivery.GridLines = true;
            this.listViewDelivery.Location = new System.Drawing.Point(12, 110);
            this.listViewDelivery.MultiSelect = false;
            this.listViewDelivery.Name = "listViewDelivery";
            this.listViewDelivery.Size = new System.Drawing.Size(673, 323);
            this.listViewDelivery.TabIndex = 15;
            this.listViewDelivery.UseCompatibleStateImageBehavior = false;
            this.listViewDelivery.View = System.Windows.Forms.View.Details;
            this.listViewDelivery.SelectedIndexChanged += new System.EventHandler(this.listViewDelivery_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Доставки";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Водитель";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Выполненный заказ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Адрес доставки";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата доставки";
            // 
            // FormDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDelivery);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelOrder_P);
            this.Controls.Add(this.comboBoxOrder_P);
            this.Controls.Add(this.labelDriver);
            this.Controls.Add(this.comboBoxDriver);
            this.Name = "FormDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Доставка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDriver;
        private System.Windows.Forms.ComboBox comboBoxDriver;
        private System.Windows.Forms.Label labelOrder_P;
        private System.Windows.Forms.ComboBox comboBoxOrder_P;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewDelivery;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}