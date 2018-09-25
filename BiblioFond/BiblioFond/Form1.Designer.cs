namespace BiblioFond
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSeach = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnBookRe = new System.Windows.Forms.Button();
            this.btnBookOut = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnDelName = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvBooks = new System.Windows.Forms.ListView();
            this.BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Arendator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 404);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работа с книжным фондом";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox4.Controls.Add(this.btnSeach);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Location = new System.Drawing.Point(7, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 185);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск на наличие";
            // 
            // btnSeach
            // 
            this.btnSeach.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSeach.Location = new System.Drawing.Point(110, 106);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(155, 33);
            this.btnSeach.TabIndex = 9;
            this.btnSeach.Text = "Поиск";
            this.btnSeach.UseVisualStyleBackColor = false;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(110, 80);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(155, 20);
            this.textBox9.TabIndex = 9;
            this.textBox9.Text = "Автор";
            this.textBox9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox9_MouseDown);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(110, 54);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(155, 20);
            this.textBox10.TabIndex = 8;
            this.textBox10.Text = "Название";
            this.textBox10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox10_MouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.btnBookRe);
            this.groupBox3.Controls.Add(this.btnBookOut);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(395, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 185);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Учет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата выдачи книги";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(11, 119);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(158, 20);
            this.maskedTextBox1.TabIndex = 9;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // btnBookRe
            // 
            this.btnBookRe.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBookRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBookRe.Location = new System.Drawing.Point(248, 80);
            this.btnBookRe.Name = "btnBookRe";
            this.btnBookRe.Size = new System.Drawing.Size(164, 36);
            this.btnBookRe.TabIndex = 8;
            this.btnBookRe.Text = "Вернули";
            this.btnBookRe.UseVisualStyleBackColor = false;
            this.btnBookRe.Click += new System.EventHandler(this.btnBookRe_Click);
            // 
            // btnBookOut
            // 
            this.btnBookOut.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBookOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBookOut.Location = new System.Drawing.Point(11, 145);
            this.btnBookOut.Name = "btnBookOut";
            this.btnBookOut.Size = new System.Drawing.Size(158, 34);
            this.btnBookOut.TabIndex = 3;
            this.btnBookOut.Text = "Забрали";
            this.btnBookOut.UseVisualStyleBackColor = false;
            this.btnBookOut.Click += new System.EventHandler(this.btnBookOut_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(253, 54);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(159, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Автор";
            this.textBox8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox8_MouseDown);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(253, 28);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(159, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Название";
            this.textBox7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox7_MouseDown);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(10, 80);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(159, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Фамилия читающего";
            this.textBox6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox6_MouseDown);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(10, 54);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Автор";
            this.textBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox5_MouseDown);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Название";
            this.textBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox4_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDelAll);
            this.groupBox2.Controls.Add(this.btnDelName);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(444, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите название книги,\r\nкоторую желаете удалить";
            // 
            // btnDelAll
            // 
            this.btnDelAll.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelAll.Location = new System.Drawing.Point(14, 87);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(334, 32);
            this.btnDelAll.TabIndex = 5;
            this.btnDelAll.Text = "Удалить все книги";
            this.btnDelAll.UseVisualStyleBackColor = false;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnDelName
            // 
            this.btnDelName.BackColor = System.Drawing.Color.Black;
            this.btnDelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelName.Location = new System.Drawing.Point(164, 25);
            this.btnDelName.Name = "btnDelName";
            this.btnDelName.Size = new System.Drawing.Size(184, 59);
            this.btnDelName.TabIndex = 4;
            this.btnDelName.Text = "Удалить книгу по названию";
            this.btnDelName.UseVisualStyleBackColor = false;
            this.btnDelName.Click += new System.EventHandler(this.btnDelName_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(23, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 29);
            this.textBox3.TabIndex = 2;
            this.textBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.btnAddBook);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(75, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление книги";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddBook.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddBook.FlatAppearance.BorderSize = 3;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddBook.Location = new System.Drawing.Point(6, 87);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(233, 32);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Добавить в список";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Автор";
            this.textBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Название";
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvBooks);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(845, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список книг";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvBooks
            // 
            this.lvBooks.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookName,
            this.Author,
            this.Nal,
            this.Arendator,
            this.data});
            this.lvBooks.Location = new System.Drawing.Point(6, 0);
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.Size = new System.Drawing.Size(839, 382);
            this.lvBooks.TabIndex = 0;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            this.lvBooks.View = System.Windows.Forms.View.Details;
            // 
            // BookName
            // 
            this.BookName.Text = "Название";
            this.BookName.Width = 243;
            // 
            // Author
            // 
            this.Author.Text = "Автор";
            this.Author.Width = 216;
            // 
            // Nal
            // 
            this.Nal.Text = "Наличие";
            this.Nal.Width = 106;
            // 
            // Arendator
            // 
            this.Arendator.Text = "У кого";
            this.Arendator.Width = 108;
            // 
            // data
            // 
            this.data.Text = "Дата выдачи";
            this.data.Width = 168;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(877, 420);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Учет книжного фонда библиотеки";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnBookRe;
        private System.Windows.Forms.Button btnBookOut;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnDelName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.ColumnHeader BookName;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Nal;
        private System.Windows.Forms.ColumnHeader Arendator;
        private System.Windows.Forms.ColumnHeader data;
    }
}

