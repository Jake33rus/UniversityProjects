namespace AutoProkat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addAuto = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAutoPrice = new System.Windows.Forms.ComboBox();
            this.tbAddMarka = new System.Windows.Forms.TextBox();
            this.btnAddAuto = new System.Windows.Forms.Button();
            this.tbAddModel = new System.Windows.Forms.TextBox();
            this.uchet = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mtbDateOut = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.tbOutMarka = new System.Windows.Forms.TextBox();
            this.tbOutModel = new System.Windows.Forms.TextBox();
            this.btnOutAuto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMarkaBack = new System.Windows.Forms.TextBox();
            this.tbModelBack = new System.Windows.Forms.TextBox();
            this.btnBackAuto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbMarkaSeach = new System.Windows.Forms.TextBox();
            this.btnSeach = new System.Windows.Forms.Button();
            this.tbModelSeach = new System.Windows.Forms.TextBox();
            this.auto = new System.Windows.Forms.TabPage();
            this.lvAuto = new System.Windows.Forms.ListView();
            this.model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.avaible = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arendator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addAuto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.uchet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.auto.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addAuto
            // 
            this.addAuto.BackColor = System.Drawing.Color.DarkGray;
            this.addAuto.Controls.Add(this.groupBox1);
            this.addAuto.Location = new System.Drawing.Point(4, 22);
            this.addAuto.Name = "addAuto";
            this.addAuto.Padding = new System.Windows.Forms.Padding(3);
            this.addAuto.Size = new System.Drawing.Size(697, 410);
            this.addAuto.TabIndex = 3;
            this.addAuto.Text = "Расширение автопарка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAutoPrice);
            this.groupBox1.Controls.Add(this.tbAddMarka);
            this.groupBox1.Controls.Add(this.btnAddAuto);
            this.groupBox1.Controls.Add(this.tbAddModel);
            this.groupBox1.Location = new System.Drawing.Point(237, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление авто в автопарк";
            // 
            // cbAutoPrice
            // 
            this.cbAutoPrice.FormattingEnabled = true;
            this.cbAutoPrice.Items.AddRange(new object[] {
            "800Р/день",
            "1600Р/день",
            "2000Р/день",
            "5000Р/день"});
            this.cbAutoPrice.Location = new System.Drawing.Point(7, 72);
            this.cbAutoPrice.Name = "cbAutoPrice";
            this.cbAutoPrice.Size = new System.Drawing.Size(187, 21);
            this.cbAutoPrice.TabIndex = 3;
            this.cbAutoPrice.Text = "Стоимость проката";
            // 
            // tbAddMarka
            // 
            this.tbAddMarka.Location = new System.Drawing.Point(6, 19);
            this.tbAddMarka.Name = "tbAddMarka";
            this.tbAddMarka.Size = new System.Drawing.Size(188, 20);
            this.tbAddMarka.TabIndex = 0;
            this.tbAddMarka.Text = "Марка";
            this.tbAddMarka.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbAddMarka_MouseDown);
            // 
            // btnAddAuto
            // 
            this.btnAddAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAuto.Location = new System.Drawing.Point(6, 97);
            this.btnAddAuto.Name = "btnAddAuto";
            this.btnAddAuto.Size = new System.Drawing.Size(188, 23);
            this.btnAddAuto.TabIndex = 2;
            this.btnAddAuto.Text = "Добавить авто";
            this.btnAddAuto.UseVisualStyleBackColor = false;
            this.btnAddAuto.Click += new System.EventHandler(this.btnAddAuto_Click);
            // 
            // tbAddModel
            // 
            this.tbAddModel.Location = new System.Drawing.Point(6, 45);
            this.tbAddModel.Name = "tbAddModel";
            this.tbAddModel.Size = new System.Drawing.Size(188, 20);
            this.tbAddModel.TabIndex = 1;
            this.tbAddModel.Text = "Модель";
            this.tbAddModel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbAddModel_MouseDown);
            // 
            // uchet
            // 
            this.uchet.BackColor = System.Drawing.Color.DarkGray;
            this.uchet.Controls.Add(this.pictureBox1);
            this.uchet.Controls.Add(this.groupBox4);
            this.uchet.Controls.Add(this.groupBox3);
            this.uchet.Controls.Add(this.groupBox2);
            this.uchet.Location = new System.Drawing.Point(4, 22);
            this.uchet.Name = "uchet";
            this.uchet.Padding = new System.Windows.Forms.Padding(3);
            this.uchet.Size = new System.Drawing.Size(697, 410);
            this.uchet.TabIndex = 1;
            this.uchet.Text = "Учет";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mtbDateOut);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbFIO);
            this.groupBox4.Controls.Add(this.tbOutMarka);
            this.groupBox4.Controls.Add(this.tbOutModel);
            this.groupBox4.Controls.Add(this.btnOutAuto);
            this.groupBox4.Location = new System.Drawing.Point(17, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 171);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Сдача в прокат";
            // 
            // mtbDateOut
            // 
            this.mtbDateOut.Location = new System.Drawing.Point(7, 116);
            this.mtbDateOut.Mask = "00/00/0000";
            this.mtbDateOut.Name = "mtbDateOut";
            this.mtbDateOut.Size = new System.Drawing.Size(187, 20);
            this.mtbDateOut.TabIndex = 11;
            this.mtbDateOut.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата сдачи в прокат";
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(6, 71);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(188, 20);
            this.tbFIO.TabIndex = 8;
            this.tbFIO.Text = "ФИО арендатора";
            this.tbFIO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbFIO_MouseDown);
            // 
            // tbOutMarka
            // 
            this.tbOutMarka.Location = new System.Drawing.Point(6, 19);
            this.tbOutMarka.Name = "tbOutMarka";
            this.tbOutMarka.Size = new System.Drawing.Size(188, 20);
            this.tbOutMarka.TabIndex = 1;
            this.tbOutMarka.Text = "Марка";
            this.tbOutMarka.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbOutMarka_MouseDown);
            // 
            // tbOutModel
            // 
            this.tbOutModel.Location = new System.Drawing.Point(6, 45);
            this.tbOutModel.Name = "tbOutModel";
            this.tbOutModel.Size = new System.Drawing.Size(188, 20);
            this.tbOutModel.TabIndex = 2;
            this.tbOutModel.Text = "Модель";
            this.tbOutModel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbOutModel_MouseDown);
            // 
            // btnOutAuto
            // 
            this.btnOutAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutAuto.Location = new System.Drawing.Point(6, 142);
            this.btnOutAuto.Name = "btnOutAuto";
            this.btnOutAuto.Size = new System.Drawing.Size(188, 23);
            this.btnOutAuto.TabIndex = 7;
            this.btnOutAuto.Text = "Взяли в прокат";
            this.btnOutAuto.UseVisualStyleBackColor = false;
            this.btnOutAuto.Click += new System.EventHandler(this.btnOutAuto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMarkaBack);
            this.groupBox3.Controls.Add(this.tbModelBack);
            this.groupBox3.Controls.Add(this.btnBackAuto);
            this.groupBox3.Location = new System.Drawing.Point(217, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Возврат";
            // 
            // tbMarkaBack
            // 
            this.tbMarkaBack.Location = new System.Drawing.Point(6, 19);
            this.tbMarkaBack.Name = "tbMarkaBack";
            this.tbMarkaBack.Size = new System.Drawing.Size(188, 20);
            this.tbMarkaBack.TabIndex = 4;
            this.tbMarkaBack.Text = "Марка";
            this.tbMarkaBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbMarkaBack_MouseDown);
            // 
            // tbModelBack
            // 
            this.tbModelBack.Location = new System.Drawing.Point(6, 45);
            this.tbModelBack.Name = "tbModelBack";
            this.tbModelBack.Size = new System.Drawing.Size(188, 20);
            this.tbModelBack.TabIndex = 5;
            this.tbModelBack.Text = "Модель";
            this.tbModelBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbModelBack_MouseDown);
            // 
            // btnBackAuto
            // 
            this.btnBackAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackAuto.Location = new System.Drawing.Point(6, 71);
            this.btnBackAuto.Name = "btnBackAuto";
            this.btnBackAuto.Size = new System.Drawing.Size(188, 23);
            this.btnBackAuto.TabIndex = 6;
            this.btnBackAuto.Text = "Авто вернули";
            this.btnBackAuto.UseVisualStyleBackColor = false;
            this.btnBackAuto.Click += new System.EventHandler(this.btnBackAuto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMarkaSeach);
            this.groupBox2.Controls.Add(this.btnSeach);
            this.groupBox2.Controls.Add(this.tbModelSeach);
            this.groupBox2.Location = new System.Drawing.Point(417, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск на наличие";
            // 
            // tbMarkaSeach
            // 
            this.tbMarkaSeach.Location = new System.Drawing.Point(6, 19);
            this.tbMarkaSeach.Name = "tbMarkaSeach";
            this.tbMarkaSeach.Size = new System.Drawing.Size(188, 20);
            this.tbMarkaSeach.TabIndex = 8;
            this.tbMarkaSeach.Text = "Марка";
            this.tbMarkaSeach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbMarkaSeach_MouseDown);
            // 
            // btnSeach
            // 
            this.btnSeach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeach.Location = new System.Drawing.Point(6, 71);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(188, 23);
            this.btnSeach.TabIndex = 10;
            this.btnSeach.Text = "Поиск";
            this.btnSeach.UseVisualStyleBackColor = false;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // tbModelSeach
            // 
            this.tbModelSeach.Location = new System.Drawing.Point(6, 45);
            this.tbModelSeach.Name = "tbModelSeach";
            this.tbModelSeach.Size = new System.Drawing.Size(188, 20);
            this.tbModelSeach.TabIndex = 9;
            this.tbModelSeach.Text = "Модель";
            this.tbModelSeach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbModelSeach_MouseDown);
            // 
            // auto
            // 
            this.auto.Controls.Add(this.lvAuto);
            this.auto.Location = new System.Drawing.Point(4, 22);
            this.auto.Name = "auto";
            this.auto.Padding = new System.Windows.Forms.Padding(3);
            this.auto.Size = new System.Drawing.Size(697, 410);
            this.auto.TabIndex = 0;
            this.auto.Text = "Список автомобилей";
            this.auto.UseVisualStyleBackColor = true;
            // 
            // lvAuto
            // 
            this.lvAuto.BackColor = System.Drawing.Color.DarkGray;
            this.lvAuto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.model,
            this.marka,
            this.avaible,
            this.date,
            this.arendator,
            this.price});
            this.lvAuto.Location = new System.Drawing.Point(0, 0);
            this.lvAuto.Name = "lvAuto";
            this.lvAuto.Size = new System.Drawing.Size(691, 410);
            this.lvAuto.TabIndex = 0;
            this.lvAuto.UseCompatibleStateImageBehavior = false;
            this.lvAuto.View = System.Windows.Forms.View.Details;
            // 
            // model
            // 
            this.model.Text = "Модель";
            this.model.Width = 94;
            // 
            // marka
            // 
            this.marka.Text = "Марка";
            this.marka.Width = 112;
            // 
            // avaible
            // 
            this.avaible.Text = "Наличие";
            this.avaible.Width = 108;
            // 
            // date
            // 
            this.date.Text = "Дата сдачи в прокат";
            this.date.Width = 139;
            // 
            // arendator
            // 
            this.arendator.Text = "У кого";
            this.arendator.Width = 123;
            // 
            // price
            // 
            this.price.Text = "Стоимость в сутки";
            this.price.Width = 111;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.auto);
            this.tabControl1.Controls.Add(this.uchet);
            this.tabControl1.Controls.Add(this.addAuto);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(707, 438);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Прокат автомобилей";
            this.addAuto.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.uchet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.auto.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage addAuto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAddMarka;
        private System.Windows.Forms.Button btnAddAuto;
        private System.Windows.Forms.TextBox tbAddModel;
        private System.Windows.Forms.TabPage uchet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox mtbDateOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.TextBox tbOutMarka;
        private System.Windows.Forms.TextBox tbOutModel;
        private System.Windows.Forms.Button btnOutAuto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbMarkaBack;
        private System.Windows.Forms.TextBox tbModelBack;
        private System.Windows.Forms.Button btnBackAuto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMarkaSeach;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TextBox tbModelSeach;
        private System.Windows.Forms.TabPage auto;
        private System.Windows.Forms.ListView lvAuto;
        private System.Windows.Forms.ColumnHeader marka;
        private System.Windows.Forms.ColumnHeader avaible;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader model;
        private System.Windows.Forms.ColumnHeader arendator;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox cbAutoPrice;
    }
}

