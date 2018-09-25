using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachSerg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int res = 0;
        Boolean dataChange = false, obrChange = false;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Стол" || textBox2.Text == "стол" || textBox2.Text == "СТОЛ")
                res += 25;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "66")
                res += 25;
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "ИЯРИНО" || comboBox3.Text == "иярино")
                res += 25;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            obrChange = true;
            if (checkedListBox1.SelectedItem == "Гуманитарное")
                res += 25;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTest() == true)
            {
                MessageBox.Show("Ошибка, заполните все поля", "Тестирование");
            }
            else
            {
                if (res >= 100)
                {
                    textBox4.ForeColor = Color.Lime;
                    textBox4.Text = "Поздравляем, Вы приняты";
                    res = 0;
                }
                else
                {
                    textBox4.ForeColor = Color.Red;
                    textBox4.Text = "Сожалеем, но Вы нам не подходите";
                    res = 0;
                }
            }
        }
        private Boolean rbCheck()
        {
            if (radioButton1.Checked)
            {
                res += 25;
                return true;
            }
            if (radioButton2.Checked)
                return true;
            else return false;
        }

        private Boolean checkTest()
        {
            if (richTextBox1.Text == "Почему вам интересна работа в нашей компании?" || textBox1.Text == "ФИО" || textBox2.Text == "Ответ:" || textBox3.Text == "Ответ:" || comboBox1.Text == "Образование" || comboBox2.Text == "Пол" || dataChange == false || comboBox3.Text == "Ответ:" || obrChange == false || rbCheck() == false)
                return true;
            else return false;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataChange = true;
        }
    }
}
