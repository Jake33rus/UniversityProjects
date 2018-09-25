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


namespace AVIAKASSA1
{
    public partial class Aviakassa : Form
    {

        string UsersDirectory = Environment.CurrentDirectory;

        public Aviakassa()
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

            foreach (ListViewItem item in this.lv_raspisanie.Items)
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
            using (TextWriter tw = new StreamWriter(UsersDirectory + "\\airkassa.txt"))
            {

                tw.WriteLine(listViewContent.ToString()); // Возвращает текущую строку в виде объекта System.String и записывает в файл.
                tw.Close();

            }

        }
        private void parseItems()//выводит данные из файла в таблицу ( listView ).
        {
            lv_raspisanie.Items.Clear(); // Удаляет все составляющие элементы и столбцы.
            using (StreamReader sReader = new StreamReader("airkassa.txt")) //Реализует объект TextReader, который считывает символы из потока байтов в определенной кодировке.
            {
                string line;
                while ((line = sReader.ReadLine()) != null)
                {
                    string[] values = line.Split('|'); // Возвращает строковый массив, содержащий подстроки данного экземпляра, разделенные элементами заданной строки или массива знаков Юникода.
                    lv_raspisanie.Items.Add(new ListViewItem(values));
                }
            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//после закрытия формы перезаписывает файл airkass.txt, хранящий в себе информацию о полетах
        {
            if (isWrite)
            {
                StreamReader sReader = new StreamReader("airkassa.txt");
                string str = sReader.ReadToEnd();
                sReader.Close();
                TextWriter tw = new StreamWriter(UsersDirectory + "\\airkassa.txt");
                tw.Write(str.Remove(str.Length - 4, 4));
                tw.Close();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)//добавляет рейс в расписание
        {
            ListViewItem ListItem = new ListViewItem(cbPlusOut.Text);
            ListItem.SubItems.Add(cbPlusIn.Text);
            ListItem.SubItems.Add(mtbDateOut.Text);
            ListItem.SubItems.Add(mtbDateIn.Text);
            ListItem.SubItems.Add(cbTypeAir.Text);
            ListItem.SubItems.Add(cbKlass.Text);
            ListItem.SubItems.Add(mtbPrice.Text);
            lv_raspisanie.Items.Add(ListItem);
            MessageBox.Show("Данные добавлены!", "Авиакасс");
            saveToolStripMenu();
        }

        private void btnClearReis_Click_1(object sender, EventArgs e)//очищает поля в окне добавления рейса
        {
            cbPlusOut.Text = "Откуда";
            cbPlusIn.Text = "Куда";
            cbTypeAir.Text = "Тип самолета";
            cbKlass.Text = "Класс билета";
            mtbDateOut.Clear();
            mtbDateIn.Clear();
            mtbPrice.Clear();
            MessageBox.Show("Поля очищены!", "Авиакасса");
        }

        private void btnSeachReis_Click_1(object sender, EventArgs e)//осуществляет поиск подходящего покупателю рейса
        {
            lbCheckReis.Items.Clear();
            if (cbSeachOut.Text == string.Empty)
                return;
            if (cbSeachIn.Text == string.Empty)
                return;
            if (cbSeachKlass.Text == string.Empty)
                return;
            string date = dtbDateOut.Value.Date.ToShortDateString();

            foreach (ListViewItem item in this.lv_raspisanie.Items)
            {
                if ((item.SubItems[0].Text == cbSeachOut.Text) && (item.SubItems[1].Text == cbSeachIn.Text) && (item.SubItems[5].Text == cbSeachKlass.Text) && (item.SubItems[2].Text.Remove(10) == date))
                {
                    item.ForeColor = Color.Red;
                    lbCheckReis.Items.Add(item.SubItems[0].Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text + " " + item.SubItems[3].Text + " " + item.SubItems[4].Text + " " + item.SubItems[5].Text + " " + item.SubItems[6].Text);
                }
                else
                    item.ForeColor = Color.Black;
            }
        }

        private void btn_clearStr1_Click_1(object sender, EventArgs e)//удаляет первую строку из расписания
        {
            if (lv_raspisanie.Items.Count > 0)
                lv_raspisanie.Items.Remove(lv_raspisanie.Items[0]);
            MessageBox.Show("Первая строка удалена! ", "Авиакасса");
            saveToolStripMenu();
        }

        private void btn_clearStrNum_Click_1(object sender, EventArgs e)//удаляет строку из расписания по номеру введенному в textBox
        {
            string m = tbNumStr.Text;
            int b = Convert.ToInt32(m);
            int r = b - 1;
            if (lv_raspisanie.Items.Count > 0)
                lv_raspisanie.Items.Remove(lv_raspisanie.Items[r]);
            MessageBox.Show("Строка номер " + b + " удалена! ", "Авиакасса");
            saveToolStripMenu();
            tbNumStr.Text = "";
        }

        private void btn_clearStrAll_Click_1(object sender, EventArgs e)//удаляет все строки из расписания
        {
            lv_raspisanie.Items.Clear();
            MessageBox.Show("Все данные удалены! ", "Авиакасса");
            saveToolStripMenu();
        }

        private void btnBuyTic_Click_1(object sender, EventArgs e)//покупка билета, при нажатии заполняет richTextBox
        {
            rtbTiccet.Text = "";
            StreamReader ticket = File.OpenText(UsersDirectory + "\\ticket.txt");
            while (!ticket.EndOfStream)
                rtbTiccet.Text += ticket.ReadLine() + "\n";
            ticket.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)//очистка информации о пассажире и купленном билете
        {
            tbFamily.Text = "Фамилия";
            tbName.Text = "Имя";
            tbGrazh.Text = "Гражданство";
            tbNumDoc.Text = "Серия и № документа";
            dtpBithday.Value = System.DateTime.Now;
            dtpSrok.Value = System.DateTime.Now;
            rtbTiccet.Text = "";
            lbCheckReis.Items.Clear(); 
        }

        private void tb_Family_MouseDown_1(object sender, MouseEventArgs e)//очиска поля при нажатии на него мышкой
        {
            tbFamily.Text = "";
        }

        private void tb_Name_MouseDown_1(object sender, MouseEventArgs e)//очиска поля при нажатии на него мышкой
        {
            tbName.Text = "";
        }

        private void tb_Grazh_MouseDown_1(object sender, MouseEventArgs e)//очиска поля при нажатии на него мышкой
        {
            tbGrazh.Text = "";
        }

        private void tb_NumDoc_MouseDown_1(object sender, MouseEventArgs e) //очиска поля при нажатии на него мышкой
        {
            tbNumDoc.Text = "";
        }

        private void lb_checkReis_MouseDoubleClick_1(object sender, MouseEventArgs e)//выбор билета для покупки из listBox 
        {
            StreamWriter ticket = File.CreateText(UsersDirectory + "\\ticket.txt");
            ticket.WriteLine("                            Билет                                 ");
            ticket.WriteLine("                     Данные о пассажире                          ");
            ticket.WriteLine("Фамилия - " + tbFamily.Text);
            ticket.WriteLine("Имя - " + tbName.Text);
            ticket.WriteLine("Дата рождения - " + dtpBithday.Value.Date.ToShortDateString());
            ticket.WriteLine("Гражданство - " + tbGrazh.Text);
            ticket.WriteLine("Серия и № документа - " + tbNumDoc.Text);
            ticket.WriteLine("Срок действия документа - " + dtpSrok.Value.Date.ToShortDateString());
            ticket.WriteLine("                   Информация о полете");
            ticket.WriteLine(lbCheckReis.SelectedItem);
            ticket.Flush();
            ticket.Close();
        }
    }
}


