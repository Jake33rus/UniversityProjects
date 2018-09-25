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

namespace BiblioFond
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
            foreach (ListViewItem item in this.lvBooks.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    listViewContent.Append(subItem.Text);
                    listViewContent.Append('|');
                }
                listViewContent.Append(Environment.NewLine);
            }
            using (TextWriter tw = new StreamWriter(UsersDirectory + "\\biblio.txt"))
            {
                tw.WriteLine(listViewContent.ToString());
                tw.Close();
            }
        }
        private void parseItems()
        {
            lvBooks.Items.Clear();
            using (StreamReader sReader = new StreamReader("biblio.txt"))
            {
                string line;
                while ((line = sReader.ReadLine()) != null)
                {
                    string[] values = line.Split('|');
                    lvBooks.Items.Add(new ListViewItem(values));
                }
            }
        }
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Название" && textBox2.Text == "Автор" || textBox1.Text == null && textBox2.Text == null)
                MessageBox.Show("Введите корректные данные", "Библиотека");
            else
            {
                ListViewItem ListItem = new ListViewItem(textBox1.Text);
                ListItem.SubItems.Add(textBox2.Text);
                ListItem.SubItems.Add("В наличии");
                ListItem.SubItems.Add("Находится в библиотеке");
                ListItem.SubItems.Add("Находится в библиотеке");
                lvBooks.Items.Add(ListItem);
                MessageBox.Show("Данные добавлены!", "Библиотека");
                save();
                textBox1.Text = "Название";
                textBox2.Text = "Автор";
            }

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox5_MouseDown(object sender, MouseEventArgs e)
        {
            textBox5.Clear();
        }

        private void textBox7_MouseDown(object sender, MouseEventArgs e)
        {
            textBox7.Clear();
        }

        private void textBox6_MouseDown(object sender, MouseEventArgs e)
        {
            textBox6.Clear();
        }
        private void textBox10_MouseDown(object sender, MouseEventArgs e)
        {
            textBox10.Clear();
        }

        private void textBox9_MouseDown(object sender, MouseEventArgs e)
        {
            textBox9.Clear();
        }
        private void btnBookOut_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
                return;
            if (textBox5.Text == string.Empty)
                return;
            string date = maskedTextBox1.Text;

            foreach (ListViewItem item in this.lvBooks.Items)
            {
                if ((item.SubItems[0].Text == textBox4.Text) && (item.SubItems[1].Text == textBox5.Text))
                {
                    item.SubItems[2].Text = "На руках";
                    item.SubItems[3].Text = textBox6.Text;
                    item.SubItems[4].Text = date;
                }
            }
            save();
        }

        private void btnBookRe_Click(object sender, EventArgs e)
        {
            {
                if (textBox7.Text == string.Empty)
                    return;
                if (textBox8.Text == string.Empty)
                    return;
                foreach (ListViewItem item in this.lvBooks.Items)
                {
                    if ((item.SubItems[0].Text == textBox7.Text) && (item.SubItems[1].Text == textBox8.Text))
                    {
                        item.SubItems[2].Text = "В наличии";
                        item.SubItems[3].Text = "Находится в библиотеке";
                        item.SubItems[4].Text = "Находится в библиотеке";
                    }
                }
            }
            save();
        }

        private void btnDelName_Click(object sender, EventArgs e)
        {
            int i = 0;
            string m = textBox3.Text;
            foreach (ListViewItem item in this.lvBooks.Items)
            {
                if (item.SubItems[0].Text == m)
                {
                    lvBooks.Items.Remove(lvBooks.Items[i]);
                }
                i++;
            }
            MessageBox.Show("Книга " + m + " удалена! ", "Библиотека");
            save();
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            lvBooks.Items.Clear();
            MessageBox.Show("Все книги удалены! ", "Библиотека");
            save();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            bool seach = false;
            string m = textBox10.Text, l = textBox9.Text;
            foreach (ListViewItem item in this.lvBooks.Items)
            {
                if ((item.SubItems[0].Text == m) && (item.SubItems[1].Text == l) && (item.SubItems[2].Text == "В наличии"))
                { seach = true; }
            }
            if (seach == true)
                MessageBox.Show("Книга - " + m + ", Автора - " + l + "; В наличии ", "Библиотека");
            else
                MessageBox.Show("Книга - " + m + ", Автора - " + l + "; Находится на руках ", "Библиотека");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isWrite)
            {
                StreamReader sReader = new StreamReader("biblio.txt");
                string str = sReader.ReadToEnd();
                sReader.Close();
                TextWriter tw = new StreamWriter(UsersDirectory + "\\biblio.txt");
                tw.Write(str.Remove(str.Length - 4, 4));
                tw.Close();
            }
        }

        private void textBox8_MouseDown(object sender, MouseEventArgs e)
        {
            textBox8.Clear();
        }
    }
}
