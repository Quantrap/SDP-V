namespace SDP_V
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonProduction = new System.Windows.Forms.Button();
            this.buttonCharProject = new System.Windows.Forms.Button();
            this.buttonFL = new System.Windows.Forms.Button();
            this.buttonDelivery = new System.Windows.Forms.Button();
            this.buttonOrders_P = new System.Windows.Forms.Button();
            this.buttonPersons = new System.Windows.Forms.Button();
            this.buttonDrivers = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonUL = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProduction
            // 
            this.buttonProduction.Location = new System.Drawing.Point(12, 382);
            this.buttonProduction.Name = "buttonProduction";
            this.buttonProduction.Size = new System.Drawing.Size(107, 54);
            this.buttonProduction.TabIndex = 1;
            this.buttonProduction.Text = "Производство";
            this.buttonProduction.UseVisualStyleBackColor = true;
            this.buttonProduction.Click += new System.EventHandler(this.buttonProduction_Click);
            // 
            // buttonCharProject
            // 
            this.buttonCharProject.Location = new System.Drawing.Point(64, 142);
            this.buttonCharProject.Name = "buttonCharProject";
            this.buttonCharProject.Size = new System.Drawing.Size(107, 54);
            this.buttonCharProject.TabIndex = 3;
            this.buttonCharProject.Text = "Характеристики проекта";
            this.buttonCharProject.UseVisualStyleBackColor = true;
            this.buttonCharProject.Click += new System.EventHandler(this.buttonCharProject_Click);
            // 
            // buttonFL
            // 
            this.buttonFL.Location = new System.Drawing.Point(125, 202);
            this.buttonFL.Name = "buttonFL";
            this.buttonFL.Size = new System.Drawing.Size(107, 54);
            this.buttonFL.TabIndex = 5;
            this.buttonFL.Text = "Заказчики (Физические лица)";
            this.buttonFL.UseVisualStyleBackColor = true;
            this.buttonFL.Click += new System.EventHandler(this.buttonFL_Click);
            // 
            // buttonDelivery
            // 
            this.buttonDelivery.Location = new System.Drawing.Point(125, 262);
            this.buttonDelivery.Name = "buttonDelivery";
            this.buttonDelivery.Size = new System.Drawing.Size(107, 54);
            this.buttonDelivery.TabIndex = 6;
            this.buttonDelivery.Text = "Доставка";
            this.buttonDelivery.UseVisualStyleBackColor = true;
            this.buttonDelivery.Click += new System.EventHandler(this.buttonDelivery_Click);
            // 
            // buttonOrders_P
            // 
            this.buttonOrders_P.Location = new System.Drawing.Point(12, 322);
            this.buttonOrders_P.Name = "buttonOrders_P";
            this.buttonOrders_P.Size = new System.Drawing.Size(107, 54);
            this.buttonOrders_P.TabIndex = 7;
            this.buttonOrders_P.Text = "Выполняющиеся\\Выполненные заказы";
            this.buttonOrders_P.UseVisualStyleBackColor = true;
            this.buttonOrders_P.Click += new System.EventHandler(this.buttonOrders_P_Click);
            // 
            // buttonPersons
            // 
            this.buttonPersons.Location = new System.Drawing.Point(125, 382);
            this.buttonPersons.Name = "buttonPersons";
            this.buttonPersons.Size = new System.Drawing.Size(107, 54);
            this.buttonPersons.TabIndex = 8;
            this.buttonPersons.Text = "Пользователи";
            this.buttonPersons.UseVisualStyleBackColor = true;
            this.buttonPersons.Click += new System.EventHandler(this.buttonPersons_Click);
            // 
            // buttonDrivers
            // 
            this.buttonDrivers.Location = new System.Drawing.Point(125, 322);
            this.buttonDrivers.Name = "buttonDrivers";
            this.buttonDrivers.Size = new System.Drawing.Size(107, 54);
            this.buttonDrivers.TabIndex = 9;
            this.buttonDrivers.Text = "Водители";
            this.buttonDrivers.UseVisualStyleBackColor = true;
            this.buttonDrivers.Click += new System.EventHandler(this.buttonDrivers_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(12, 262);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(107, 54);
            this.buttonOrders.TabIndex = 10;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonUL
            // 
            this.buttonUL.Location = new System.Drawing.Point(12, 202);
            this.buttonUL.Name = "buttonUL";
            this.buttonUL.Size = new System.Drawing.Size(107, 54);
            this.buttonUL.TabIndex = 11;
            this.buttonUL.Text = "Заказчики (Юридические лица)";
            this.buttonUL.UseVisualStyleBackColor = true;
            this.buttonUL.Click += new System.EventHandler(this.buttonUL_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 88);
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 444);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonUL);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonDrivers);
            this.Controls.Add(this.buttonPersons);
            this.Controls.Add(this.buttonOrders_P);
            this.Controls.Add(this.buttonDelivery);
            this.Controls.Add(this.buttonFL);
            this.Controls.Add(this.buttonCharProject);
            this.Controls.Add(this.buttonProduction);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonProduction;
        private System.Windows.Forms.Button buttonCharProject;
        private System.Windows.Forms.Button buttonFL;
        private System.Windows.Forms.Button buttonDelivery;
        private System.Windows.Forms.Button buttonOrders_P;
        private System.Windows.Forms.Button buttonPersons;
        private System.Windows.Forms.Button buttonDrivers;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonUL;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

