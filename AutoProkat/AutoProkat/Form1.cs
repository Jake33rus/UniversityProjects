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


namespace AutoProkat
{
    public partial class Form1 : Form
    {
        string UsersDirectory = Environment.CurrentDirectory;
        public Form1()
        {
            InitializeComponent();
            parseItems();
        }
        bool isWrite = false;
        private void save()
        {
            isWrite = true;
            StringBuilder listViewContent = new StringBuilder();
            foreach (ListViewItem item in this.lvAuto.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    listViewContent.Append(subItem.Text);
                    listViewContent.Append('|');
                }
                listViewContent.Append(Environment.NewLine);
            }
            using (TextWriter tw = new StreamWriter(UsersDirectory + "\\prokat.txt"))
            {
                tw.WriteLine(listViewContent.ToString());
                tw.Close();
            }
        }
        private void parseItems()
        {
            lvAuto.Items.Clear();
            using (StreamReader sReader = new StreamReader("prokat.txt"))
            {
                string line;
                while ((line = sReader.ReadLine()) != null)
                {
                    string[] values = line.Split('|');
                    lvAuto.Items.Add(new ListViewItem(values));
                }
            }
        }
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//запускается при закрытии программы
        {
            if (isWrite)
            {
                StreamReader sReader = new StreamReader("prokat.txt");
                string str = sReader.ReadToEnd();
                sReader.Close();
                TextWriter tw = new StreamWriter(UsersDirectory + "\\prokat.txt");
                tw.Write(str.Remove(str.Length - 4, 4));
                tw.Close();
            }
        }

        private void btnAddAuto_Click(object sender, EventArgs e)//функция добавления автомобиля
        {
            ListViewItem ListItem = new ListViewItem(tbAddModel.Text);
            ListItem.SubItems.Add(tbAddMarka.Text);
            ListItem.SubItems.Add("В наличии");
            ListItem.SubItems.Add("Находится в автопарке");
            ListItem.SubItems.Add("Находится в автопарке");
            ListItem.SubItems.Add(cbAutoPrice.Text);
            lvAuto.Items.Add(ListItem);
            MessageBox.Show("Автомобиль добавлен!", "Автопрокат");
            save();
            tbAddMarka.Text = "Марка";
            tbAddModel.Text = "Модель";
            cbAutoPrice.Text = "Стоимость проката";
        }

        private void btnSeach_Click(object sender, EventArgs e)//функция поика на наличие автомобиля 
        {
            bool seach = false;
            string l = tbMarkaSeach.Text, m = tbModelSeach.Text;
            foreach (ListViewItem item in this.lvAuto.Items)
            {
                if ((item.SubItems[0].Text == m) && (item.SubItems[1].Text == l) && (item.SubItems[2].Text == "В наличии"))
                { seach = true; }
            }
            if (seach == true)
                MessageBox.Show("Модель - " + m + ", Марки - " + l + "; В наличии ", "Прокат автомобилей");
            else
                MessageBox.Show("Модель - " + m + ", Марки - " + l + "; Взята в прокат ", "Прокат автомобилей");
            tbMarkaSeach.Text = "Марка";
            tbModelSeach.Text = "Модель";
        }

        private void btnOutAuto_Click(object sender, EventArgs e)//функция сдачи авто в прокат
        {
                if (tbOutModel.Text == string.Empty)
                    return;
                if (tbOutMarka.Text == string.Empty)
                    return;
                string date = mtbDateOut.Text;

                foreach (ListViewItem item in this.lvAuto.Items)
                {
                    if ((item.SubItems[0].Text == tbOutModel.Text) && (item.SubItems[1].Text == tbOutMarka.Text))
                    {
                        item.SubItems[2].Text = "В прокате";
                        item.SubItems[3].Text = date;
                        item.SubItems[4].Text = tbFIO.Text;
                    }
                }
                save();
            tbFIO.Text = "ФИО арендатора";
            mtbDateOut.Text = "";
            tbOutModel.Text = "Модель";
            tbOutMarka.Text = "Марка";
        }

        private void btnBackAuto_Click(object sender, EventArgs e)//функция возврата авто
        {
            {
                if (tbModelBack.Text == string.Empty)//проверка на наличие текста в textBox
                    return;
                if (tbMarkaBack.Text == string.Empty)//проверка на наличие текста в textBox
                    return;
                foreach (ListViewItem item in this.lvAuto.Items)//пробегаем по всем эл-там листвью пока не найдем автомобиль который вернули и меняем значения строк
                {
                    if ((item.SubItems[0].Text == tbModelBack.Text) && (item.SubItems[1].Text == tbMarkaBack.Text))
                    {
                        item.SubItems[2].Text = "В наличии";
                        item.SubItems[3].Text = "Находится в автопарке";
                        item.SubItems[4].Text = "Находится в автопарке";
                    }
                }
            }
            save();
            tbModelBack.Text = "Модель";
            tbMarkaBack.Text = "Марка";
        }

        private void tbAddMarka_MouseDown(object sender, MouseEventArgs e)//обнуление textBox при нажатии на него мышкой
        {
            tbAddMarka.Text = "";
        }

        private void tbAddModel_MouseDown(object sender, MouseEventArgs e)
        {
            tbAddModel.Text = "";
        }

        private void tbOutMarka_MouseDown(object sender, MouseEventArgs e)
        {
            tbOutMarka.Text = "";
        }

        private void tbOutModel_MouseDown(object sender, MouseEventArgs e)
        {
            tbOutModel.Text = "";
        }

        private void tbFIO_MouseDown(object sender, MouseEventArgs e)
        {
            tbFIO.Text = "";
        }

        private void tbMarkaBack_MouseDown(object sender, MouseEventArgs e)
        {
            tbMarkaBack.Text = "";
        }

        private void tbModelBack_MouseDown(object sender, MouseEventArgs e)
        {
            tbModelBack.Text = "";
        }

        private void tbModelSeach_MouseDown(object sender, MouseEventArgs e)
        {
            tbModelBack.Text = "";
        }

        private void tbMarkaSeach_MouseDown(object sender, MouseEventArgs e)
        {
            tbMarkaSeach.Text = "";
        }
    }
}

