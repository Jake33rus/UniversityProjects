namespace AVIAKASSA1
{
    partial class Aviakassa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aviakassa));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearStrAll = new System.Windows.Forms.Button();
            this.btnClearStrNum = new System.Windows.Forms.Button();
            this.btnClearStr1 = new System.Windows.Forms.Button();
            this.tbNumStr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearReis = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mtbPrice = new System.Windows.Forms.MaskedTextBox();
            this.mtbDateIn = new System.Windows.Forms.MaskedTextBox();
            this.mtbDateOut = new System.Windows.Forms.MaskedTextBox();
            this.cbKlass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTypeAir = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlusIn = new System.Windows.Forms.ComboBox();
            this.cbPlusOut = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtbDateOut = new System.Windows.Forms.DateTimePicker();
            this.cbSeachKlass = new System.Windows.Forms.ComboBox();
            this.cbSeachIn = new System.Windows.Forms.ComboBox();
            this.cbSeachOut = new System.Windows.Forms.ComboBox();
            this.btnSeachReis = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lv_raspisanie = new System.Windows.Forms.ListView();
            this.otkuda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kuda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tip_sam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classTic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbCheckReis = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBuyTic = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rtbTiccet = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpSrok = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBithday = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNumDoc = new System.Windows.Forms.TextBox();
            this.tbGrazh = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFamily = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(890, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройка расписания";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Khaki;
            this.groupBox3.Controls.Add(this.btnClearStrAll);
            this.groupBox3.Controls.Add(this.btnClearStrNum);
            this.groupBox3.Controls.Add(this.btnClearStr1);
            this.groupBox3.Controls.Add(this.tbNumStr);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(597, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 574);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удаление рейса";
            // 
            // btnClearStrAll
            // 
            this.btnClearStrAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearStrAll.Location = new System.Drawing.Point(9, 135);
            this.btnClearStrAll.Name = "btnClearStrAll";
            this.btnClearStrAll.Size = new System.Drawing.Size(260, 23);
            this.btnClearStrAll.TabIndex = 17;
            this.btnClearStrAll.Text = "Удалить все строки";
            this.btnClearStrAll.UseVisualStyleBackColor = true;
            this.btnClearStrAll.Click += new System.EventHandler(this.btn_clearStrAll_Click_1);
            // 
            // btnClearStrNum
            // 
            this.btnClearStrNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearStrNum.Location = new System.Drawing.Point(9, 106);
            this.btnClearStrNum.Name = "btnClearStrNum";
            this.btnClearStrNum.Size = new System.Drawing.Size(260, 23);
            this.btnClearStrNum.TabIndex = 16;
            this.btnClearStrNum.Text = "Удалить строку по №";
            this.btnClearStrNum.UseVisualStyleBackColor = true;
            this.btnClearStrNum.Click += new System.EventHandler(this.btn_clearStrNum_Click_1);
            // 
            // btnClearStr1
            // 
            this.btnClearStr1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearStr1.Location = new System.Drawing.Point(9, 77);
            this.btnClearStr1.Name = "btnClearStr1";
            this.btnClearStr1.Size = new System.Drawing.Size(260, 23);
            this.btnClearStr1.TabIndex = 14;
            this.btnClearStr1.Text = "Удалить первую строку";
            this.btnClearStr1.UseVisualStyleBackColor = true;
            this.btnClearStr1.Click += new System.EventHandler(this.btn_clearStr1_Click_1);
            // 
            // tbNumStr
            // 
            this.tbNumStr.Location = new System.Drawing.Point(150, 44);
            this.tbNumStr.Name = "tbNumStr";
            this.tbNumStr.Size = new System.Drawing.Size(119, 20);
            this.tbNumStr.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Введите номер строки, \r\nкоторую желаете удалить";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Khaki;
            this.groupBox2.Controls.Add(this.btnClearReis);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.mtbPrice);
            this.groupBox2.Controls.Add(this.mtbDateIn);
            this.groupBox2.Controls.Add(this.mtbDateOut);
            this.groupBox2.Controls.Add(this.cbKlass);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbTypeAir);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbPlusIn);
            this.groupBox2.Controls.Add(this.cbPlusOut);
            this.groupBox2.Location = new System.Drawing.Point(303, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 574);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление рейса";
            // 
            // btnClearReis
            // 
            this.btnClearReis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearReis.Location = new System.Drawing.Point(148, 253);
            this.btnClearReis.Name = "btnClearReis";
            this.btnClearReis.Size = new System.Drawing.Size(119, 23);
            this.btnClearReis.TabIndex = 13;
            this.btnClearReis.Text = "Очистить";
            this.btnClearReis.UseVisualStyleBackColor = true;
            this.btnClearReis.Click += new System.EventHandler(this.btnClearReis_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(10, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // mtbPrice
            // 
            this.mtbPrice.Location = new System.Drawing.Point(87, 218);
            this.mtbPrice.Mask = "000000₽";
            this.mtbPrice.Name = "mtbPrice";
            this.mtbPrice.Size = new System.Drawing.Size(180, 20);
            this.mtbPrice.TabIndex = 12;
            // 
            // mtbDateIn
            // 
            this.mtbDateIn.Location = new System.Drawing.Point(90, 126);
            this.mtbDateIn.Mask = "00/00/0000 90:00";
            this.mtbDateIn.Name = "mtbDateIn";
            this.mtbDateIn.Size = new System.Drawing.Size(180, 20);
            this.mtbDateIn.TabIndex = 11;
            this.mtbDateIn.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDateOut
            // 
            this.mtbDateOut.Location = new System.Drawing.Point(90, 99);
            this.mtbDateOut.Mask = "00/00/0000 90:00";
            this.mtbDateOut.Name = "mtbDateOut";
            this.mtbDateOut.Size = new System.Drawing.Size(180, 20);
            this.mtbDateOut.TabIndex = 10;
            this.mtbDateOut.ValidatingType = typeof(System.DateTime);
            // 
            // cbKlass
            // 
            this.cbKlass.FormattingEnabled = true;
            this.cbKlass.Items.AddRange(new object[] {
            "ECO",
            "ECO+",
            "BUISNESS"});
            this.cbKlass.Location = new System.Drawing.Point(6, 184);
            this.cbKlass.Name = "cbKlass";
            this.cbKlass.Size = new System.Drawing.Size(264, 21);
            this.cbKlass.TabIndex = 9;
            this.cbKlass.Text = "Класс билета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена билета:";
            // 
            // cbTypeAir
            // 
            this.cbTypeAir.FormattingEnabled = true;
            this.cbTypeAir.Items.AddRange(new object[] {
            "Аэробус",
            "Боинг",
            "Ил",
            "Ту"});
            this.cbTypeAir.Location = new System.Drawing.Point(6, 157);
            this.cbTypeAir.Name = "cbTypeAir";
            this.cbTypeAir.Size = new System.Drawing.Size(264, 21);
            this.cbTypeAir.TabIndex = 5;
            this.cbTypeAir.Text = "Тип самолета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата прилета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата вылета:";
            // 
            // cbPlusIn
            // 
            this.cbPlusIn.FormattingEnabled = true;
            this.cbPlusIn.Items.AddRange(new object[] {
            "Москва",
            "Дубаи",
            "Варшава",
            "Копенгаген",
            "Барселона",
            "Бангкок",
            "Лиссабон",
            "Шарм-эль-Шейх",
            "Бхукет",
            "Прага",
            "Нью-Йорк"});
            this.cbPlusIn.Location = new System.Drawing.Point(6, 65);
            this.cbPlusIn.Name = "cbPlusIn";
            this.cbPlusIn.Size = new System.Drawing.Size(264, 21);
            this.cbPlusIn.TabIndex = 5;
            this.cbPlusIn.Text = "Куда";
            // 
            // cbPlusOut
            // 
            this.cbPlusOut.FormattingEnabled = true;
            this.cbPlusOut.Items.AddRange(new object[] {
            "Москва",
            "Дубаи",
            "Варшава",
            "Копенгаген",
            "Барселона",
            "Бангкок",
            "Лиссабон",
            "Шарм-эль-Шейх",
            "Бхукет",
            "Прага",
            "Нью-Йорк"});
            this.cbPlusOut.Location = new System.Drawing.Point(6, 38);
            this.cbPlusOut.Name = "cbPlusOut";
            this.cbPlusOut.Size = new System.Drawing.Size(264, 21);
            this.cbPlusOut.TabIndex = 5;
            this.cbPlusOut.Text = "Откуда";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.dtbDateOut);
            this.groupBox1.Controls.Add(this.cbSeachKlass);
            this.groupBox1.Controls.Add(this.cbSeachIn);
            this.groupBox1.Controls.Add(this.cbSeachOut);
            this.groupBox1.Controls.Add(this.btnSeachReis);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 574);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск рейса";
            // 
            // dtbDateOut
            // 
            this.dtbDateOut.Location = new System.Drawing.Point(7, 120);
            this.dtbDateOut.Name = "dtbDateOut";
            this.dtbDateOut.Size = new System.Drawing.Size(263, 20);
            this.dtbDateOut.TabIndex = 4;
            // 
            // cbSeachKlass
            // 
            this.cbSeachKlass.FormattingEnabled = true;
            this.cbSeachKlass.Items.AddRange(new object[] {
            "ECO",
            "ECO+",
            "BUISNESS"});
            this.cbSeachKlass.Location = new System.Drawing.Point(6, 92);
            this.cbSeachKlass.Name = "cbSeachKlass";
            this.cbSeachKlass.Size = new System.Drawing.Size(264, 21);
            this.cbSeachKlass.TabIndex = 3;
            this.cbSeachKlass.Text = "Класс билета";
            // 
            // cbSeachIn
            // 
            this.cbSeachIn.FormattingEnabled = true;
            this.cbSeachIn.Items.AddRange(new object[] {
            "Москва",
            "Дубаи",
            "Варшава",
            "Копенгаген",
            "Барселона",
            "Бангкок",
            "Лиссабон",
            "Шарм-эль-Шейх",
            "Бхукет",
            "Прага",
            "Нью-Йорк"});
            this.cbSeachIn.Location = new System.Drawing.Point(6, 65);
            this.cbSeachIn.Name = "cbSeachIn";
            this.cbSeachIn.Size = new System.Drawing.Size(264, 21);
            this.cbSeachIn.TabIndex = 2;
            this.cbSeachIn.Text = "Куда";
            // 
            // cbSeachOut
            // 
            this.cbSeachOut.FormattingEnabled = true;
            this.cbSeachOut.Items.AddRange(new object[] {
            "Москва",
            "Дубаи",
            "Варшава",
            "Копенгаген",
            "Барселона",
            "Бангкок",
            "Лиссабон",
            "Шарм-эль-Шейх",
            "Бхукет",
            "Прага",
            "Нью-Йорк"});
            this.cbSeachOut.Location = new System.Drawing.Point(6, 38);
            this.cbSeachOut.Name = "cbSeachOut";
            this.cbSeachOut.Size = new System.Drawing.Size(264, 21);
            this.cbSeachOut.TabIndex = 1;
            this.cbSeachOut.Text = "Откуда";
            // 
            // btnSeachReis
            // 
            this.btnSeachReis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeachReis.Location = new System.Drawing.Point(3, 155);
            this.btnSeachReis.Name = "btnSeachReis";
            this.btnSeachReis.Size = new System.Drawing.Size(267, 23);
            this.btnSeachReis.TabIndex = 0;
            this.btnSeachReis.Text = "Подобрать рейс";
            this.btnSeachReis.UseVisualStyleBackColor = true;
            this.btnSeachReis.Click += new System.EventHandler(this.btnSeachReis_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lv_raspisanie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(890, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расписание самолетов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lv_raspisanie
            // 
            this.lv_raspisanie.BackColor = System.Drawing.Color.Khaki;
            this.lv_raspisanie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.otkuda,
            this.kuda,
            this.dateOut,
            this.dateIn,
            this.tip_sam,
            this.classTic,
            this.price});
            this.lv_raspisanie.Location = new System.Drawing.Point(0, 0);
            this.lv_raspisanie.Name = "lv_raspisanie";
            this.lv_raspisanie.Size = new System.Drawing.Size(890, 604);
            this.lv_raspisanie.TabIndex = 0;
            this.lv_raspisanie.UseCompatibleStateImageBehavior = false;
            this.lv_raspisanie.View = System.Windows.Forms.View.Details;
            // 
            // otkuda
            // 
            this.otkuda.Text = "Откуда";
            this.otkuda.Width = 140;
            // 
            // kuda
            // 
            this.kuda.Text = "Куда";
            this.kuda.Width = 105;
            // 
            // dateOut
            // 
            this.dateOut.Text = "Дата вылета";
            this.dateOut.Width = 128;
            // 
            // dateIn
            // 
            this.dateIn.Text = "Дата прилета";
            this.dateIn.Width = 126;
            // 
            // tip_sam
            // 
            this.tip_sam.Text = "Тип самолета";
            this.tip_sam.Width = 144;
            // 
            // classTic
            // 
            this.classTic.Text = "Класс билета";
            this.classTic.Width = 121;
            // 
            // price
            // 
            this.price.Text = "Цена";
            this.price.Width = 126;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Khaki;
            this.tabPage3.Controls.Add(this.lbCheckReis);
            this.tabPage3.Controls.Add(this.btnClear);
            this.tabPage3.Controls.Add(this.btnBuyTic);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(890, 600);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Покупка билета";
            // 
            // lbCheckReis
            // 
            this.lbCheckReis.BackColor = System.Drawing.Color.Khaki;
            this.lbCheckReis.FormattingEnabled = true;
            this.lbCheckReis.Location = new System.Drawing.Point(238, 4);
            this.lbCheckReis.Name = "lbCheckReis";
            this.lbCheckReis.Size = new System.Drawing.Size(640, 238);
            this.lbCheckReis.TabIndex = 5;
            this.lbCheckReis.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_checkReis_MouseDoubleClick_1);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(582, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(296, 66);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить поля";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBuyTic
            // 
            this.btnBuyTic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyTic.Location = new System.Drawing.Point(18, 249);
            this.btnBuyTic.Name = "btnBuyTic";
            this.btnBuyTic.Size = new System.Drawing.Size(296, 66);
            this.btnBuyTic.TabIndex = 3;
            this.btnBuyTic.Text = "Купить билет";
            this.btnBuyTic.UseVisualStyleBackColor = true;
            this.btnBuyTic.Click += new System.EventHandler(this.btnBuyTic_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rtbTiccet);
            this.groupBox5.Location = new System.Drawing.Point(9, 321);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(875, 276);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Билет";
            // 
            // rtbTiccet
            // 
            this.rtbTiccet.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtbTiccet.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbTiccet.ForeColor = System.Drawing.SystemColors.Info;
            this.rtbTiccet.Location = new System.Drawing.Point(9, 16);
            this.rtbTiccet.Name = "rtbTiccet";
            this.rtbTiccet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbTiccet.Size = new System.Drawing.Size(860, 252);
            this.rtbTiccet.TabIndex = 1;
            this.rtbTiccet.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpSrok);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dtpBithday);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbNumDoc);
            this.groupBox4.Controls.Add(this.tbGrazh);
            this.groupBox4.Controls.Add(this.tbName);
            this.groupBox4.Controls.Add(this.tbFamily);
            this.groupBox4.Location = new System.Drawing.Point(9, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 239);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Данные о пассажире";
            // 
            // dtpSrok
            // 
            this.dtpSrok.Location = new System.Drawing.Point(6, 197);
            this.dtpSrok.Name = "dtpSrok";
            this.dtpSrok.Size = new System.Drawing.Size(211, 20);
            this.dtpSrok.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Срок действия документа";
            // 
            // dtpBithday
            // 
            this.dtpBithday.Location = new System.Drawing.Point(6, 90);
            this.dtpBithday.Name = "dtpBithday";
            this.dtpBithday.Size = new System.Drawing.Size(211, 20);
            this.dtpBithday.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата рождения";
            // 
            // tbNumDoc
            // 
            this.tbNumDoc.Location = new System.Drawing.Point(6, 142);
            this.tbNumDoc.Name = "tbNumDoc";
            this.tbNumDoc.Size = new System.Drawing.Size(210, 20);
            this.tbNumDoc.TabIndex = 3;
            this.tbNumDoc.Text = "Серия и № документа";
            this.tbNumDoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_NumDoc_MouseDown_1);
            // 
            // tbGrazh
            // 
            this.tbGrazh.Location = new System.Drawing.Point(6, 116);
            this.tbGrazh.Name = "tbGrazh";
            this.tbGrazh.Size = new System.Drawing.Size(210, 20);
            this.tbGrazh.TabIndex = 2;
            this.tbGrazh.Text = "Гражданство";
            this.tbGrazh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_Grazh_MouseDown_1);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 46);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(210, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "Имя";
            this.tbName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_Name_MouseDown_1);
            // 
            // tbFamily
            // 
            this.tbFamily.Location = new System.Drawing.Point(7, 20);
            this.tbFamily.Name = "tbFamily";
            this.tbFamily.Size = new System.Drawing.Size(210, 20);
            this.tbFamily.TabIndex = 0;
            this.tbFamily.Text = "Фамилия";
            this.tbFamily.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_Family_MouseDown_1);
            // 
            // Aviakassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(900, 624);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Aviakassa";
            this.Text = "Авиакасса";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeachReis;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnClearStrAll;
        private System.Windows.Forms.Button btnClearStrNum;
        private System.Windows.Forms.Button btnClearStr1;
        private System.Windows.Forms.TextBox tbNumStr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearReis;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox mtbPrice;
        private System.Windows.Forms.MaskedTextBox mtbDateIn;
        private System.Windows.Forms.MaskedTextBox mtbDateOut;
        private System.Windows.Forms.ComboBox cbKlass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTypeAir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPlusIn;
        private System.Windows.Forms.ComboBox cbPlusOut;
        private System.Windows.Forms.DateTimePicker dtbDateOut;
        private System.Windows.Forms.ComboBox cbSeachKlass;
        private System.Windows.Forms.ComboBox cbSeachIn;
        private System.Windows.Forms.ComboBox cbSeachOut;
        private System.Windows.Forms.ListView lv_raspisanie;
        private System.Windows.Forms.ColumnHeader otkuda;
        private System.Windows.Forms.ColumnHeader kuda;
        private System.Windows.Forms.ColumnHeader dateOut;
        private System.Windows.Forms.ColumnHeader dateIn;
        private System.Windows.Forms.ColumnHeader tip_sam;
        private System.Windows.Forms.ColumnHeader classTic;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ListBox lbCheckReis;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBuyTic;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rtbTiccet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpSrok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBithday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNumDoc;
        private System.Windows.Forms.TextBox tbGrazh;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbFamily;
    }
}

