using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using System.Globalization;


namespace agentstvonedvizh
{
    public partial class Form1 : Form
    {
        string UsersDirectory = Environment.CurrentDirectory;

        public Form1()
        {
            InitializeComponent();
            parseItems();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        bool isWrite = false;
        private void saveToolStripMenu()//записывает данные в файл.
        {
            isWrite = true;
            StringBuilder listViewContent = new StringBuilder();
            //StringBuilder - Предоставляет изменяемую строку символов.
            // ListView - Класс.
            //Предоставляет элемент управления списка Windows, отображающий коллекцию элементов, которые могут быть выведены на экран при использовании одного из четырех различных представлений.
            //ListViewItem - Инициализирует новый экземпляр класса ListViewItem значениями по умолчанию.
            //ListViewItem.ListViewSubItem - Инициализирует новый экземпляр класса ListViewItem.ListViewSubItem значениями по умолчанию.

            foreach (ListViewItem item in this.listView1.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    listViewContent.Append(subItem.Text); // метод класса StringBuilder, добавляет строку к текущей строке.
                    listViewContent.Append('|');
                }
                listViewContent.Append(Environment.NewLine);
            }
            //TextWriter - Представляет модуль записи, который может записывать последовательные наборы символов.Это абстрактный класс.
            //StreamWriter - Реализует TextWriter для записи символов в поток в определенной кодировке.
            using (TextWriter tw = new StreamWriter(UsersDirectory + "\\base.txt"))
            {

                tw.WriteLine(listViewContent.ToString()); // Возвращает текущую строку в виде объекта System.String и записывает в файл.
                tw.Close();

            }

        }

        private void parseItems()//выводит данные из файла в таблицу ( listView ).
        {
            listView1.Items.Clear(); // Удаляет все составляющие элементы и столбцы.
            using (StreamReader sReader = new StreamReader("base.txt")) //Реализует объект TextReader, который считывает символы из потока байтов в определенной кодировке.
            {
                string line;
                while ((line = sReader.ReadLine()) != null)
                {
                    string[] values = line.Split('|'); // Возвращает строковый массив, содержащий подстроки данного экземпляра, разделенные элементами заданной строки или массива знаков Юникода.
                    listView1.Items.Add(new ListViewItem(values));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.Text == string.Empty)
                return;
            if (comboBox2.Text == string.Empty)
                return;
            if (comboBox3.Text == string.Empty)
                return;
            foreach (ListViewItem item in listView1.Items)
            {
                if ((item.SubItems[0].Text == comboBox2.Text) && (item.SubItems[1].Text == comboBox1.Text) && (item.SubItems[2].Text == comboBox3.Text))
                {
                    item.ForeColor = Color.Red;
                    listBox1.Items.Add(item.SubItems[0].Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text + " " + item.SubItems[3].Text + " " + item.SubItems[4].Text + " " + item.SubItems[5].Text);
                }
                else
                    item.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem ListItem = new ListViewItem(comboBox4.Text);
            ListItem.SubItems.Add(comboBox5.Text);
            ListItem.SubItems.Add(comboBox6.Text);
            ListItem.SubItems.Add(textBox1.Text);
            ListItem.SubItems.Add(comboBox7.Text);
            ListItem.SubItems.Add(maskedTextBox1.Text);
            listView1.Items.Add(ListItem);
            MessageBox.Show("Данные добавлены!", "Агентство недвижимости");
            saveToolStripMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox4.Text = "Вид недвижимости";
            comboBox5.Text = "Местоположения";
            comboBox6.Text = "Состояние";
            comboBox7.Text = "Кол-во комнат";
            textBox1.Text = "";
            maskedTextBox1.Clear();
            MessageBox.Show("Поля очищены!", "Агентство недвижимости");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MessageBox.Show("Все данные удалены! ", "Агентство недвижимости");
            saveToolStripMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string m = textBox2.Text;
            int b = Convert.ToInt32(m);
            int r = b - 1;
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.Items[r]);
            MessageBox.Show("Строка номер " + b + " удалена! ", "Агентство недвижимости");
            saveToolStripMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.Items[0]);
            MessageBox.Show("Первая строка удалена! ", "Агентство недвижимости");
            saveToolStripMenu();
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox4.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StreamReader ticket = File.OpenText(UsersDirectory + "\\pokupka.txt");
            while (!ticket.EndOfStream)
                richTextBox1.Text += ticket.ReadLine() + "\n";
            ticket.Close();

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)//создания текстового файла и информацией о покупатели и недвижимосте.
        {
            StreamWriter ticket = File.CreateText(UsersDirectory + "\\pokupka.txt");
            ticket.WriteLine("                     Данные о покупателе                          ");
            ticket.WriteLine("Фамилия - " + textBox3.Text);
            ticket.WriteLine("Имя - " + textBox4.Text);
            ticket.WriteLine("Дата рождения - " + dateTimePicker1.Value.Date.ToShortDateString());
            ticket.WriteLine("                   Информация о покупке");
            ticket.WriteLine(listBox1.SelectedItem);
            ticket.Flush();
            ticket.Close();

        }

        private void button8_Click(object sender, EventArgs e)//очистка полей информации о покупателе
        {
            textBox3.Text = "Фамилия";
            textBox4.Text = "Имя";
            dateTimePicker1.Value = System.DateTime.Now;
            richTextBox1.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isWrite)
            {
                StreamReader sReader = new StreamReader("base.txt");
                string str = sReader.ReadToEnd();
                sReader.Close();
                TextWriter tw = new StreamWriter(UsersDirectory + "\\base.txt");
                tw.Write(str.Remove(str.Length - 4, 4));
                tw.Close();
            }
        }

    }
}

