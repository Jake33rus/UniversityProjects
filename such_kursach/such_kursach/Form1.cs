using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace such_kursach
{
    public partial class Form1 : Form{
  

        public Form1()
        {
            InitializeComponent();
            refreshMassive();
        }

        void refreshMassive()
        {
            clientList.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db");
            FileInfo[] fia = di.GetFiles();
            for (int i = 0; i < fia.Count(); i++)
            {
                StreamReader fr = new StreamReader(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db\" + fia[i].ToString());
                clientList.Items.Add(fr.ReadLine() + " " + fr.ReadLine() + " " + fr.ReadLine());
                fr.Close();
            }

        }
        void deleteClient() 
        {
            int z = clientList.SelectedIndex;
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db");
            FileInfo[] fia = di.GetFiles();
            fia[z].Delete();

            refreshMassive();
        }

        private void addChange_Click(object sender, EventArgs e)
        {

            FileInfo fi = new FileInfo(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db" + PassNum.Text + ".txt");
            StreamWriter w = fi.CreateText();
            w.WriteLine(FName.Text);
            w.WriteLine(SName.Text);
            w.WriteLine(FathName.Text);
            if (PassNum.Text.Length == 8)
            {
                w.WriteLine(PassNum.Text);
            }
            else return;
            if(Male.Checked)w.WriteLine("Мужской");
            else w.WriteLine("Женский");
           
            w.Close();

            refreshMassive();
        }

        private void showClInf_Click(object sender, EventArgs e)
        {
            raceInf.Clear();
            if (clientList.SelectedIndex == -1) return;
            int i = clientList.SelectedIndex;

            DirectoryInfo di = new DirectoryInfo(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db");
            FileInfo[] fia = di.GetFiles();

            StreamReader fr = new StreamReader(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db\" + fia[i].ToString());
            FName.Text = fr.ReadLine();
            SName.Text = fr.ReadLine();
            FathName.Text = fr.ReadLine();
            PassNum.Text = fr.ReadLine();
            if (fr.ReadLine() == "Мужской") Male.Checked = true;
            else Female.Checked = true;

            while ( fr.ReadLine() != null)
            {  
                raceInf.Text += "Место старта - "+fr.ReadLine()+"\n";
                raceInf.Text += "Место путешествия - " + fr.ReadLine() + "\n";
                raceInf.Text += "Время путешествия (в днях) - " + fr.ReadLine() + "\n";
                raceInf.Text += "Место возвращения - " + fr.ReadLine() + "\n";
                raceInf.Text += "До места добрался на  " + fr.ReadLine() + "\n";
                raceInf.Text += "Тур  - " + fr.ReadLine() + "\n";
                raceInf.Text += "Дата начала путешествия - " + fr.ReadLine() + "\n";
                raceInf.Text += "Дата прибытия - " + fr.ReadLine() + "\n";
                raceInf.Text += "Место остановки - " + fr.ReadLine() + "\n";
                raceInf.Text += "Дата возвращения - " + fr.ReadLine() + "\n";
                raceInf.Text += "Цена путешествия - " + fr.ReadLine() +" рублей."+ "\n";
                raceInf.Text += "\n";
        }

            fr.Close();

            refreshMassive();
        }

        private void search_Click(object sender, EventArgs e)
        {
            clientList.Items.Clear();

            switch(searchTag.SelectedIndex)
            {
                case 0: 
                    DirectoryInfo di = new DirectoryInfo(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db");
                    FileInfo[] fia = di.GetFiles();
                    for (int i = 0; i < fia.Count(); i++)
                    {
                        StreamReader fr = new StreamReader(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db\" + fia[i].ToString());
                        if (searchTab.Text == fr.ReadLine())
                        {
                            fr = new StreamReader(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db\" + fia[i].ToString());
                            clientList.Items.Add(fr.ReadLine() + " " + fr.ReadLine() + " " + fr.ReadLine());
                            fr.Close();
                        }
                        else   fr.Close();
                        
                        
                    }
                break;

                case 1:
                di = new DirectoryInfo(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db");
                fia = di.GetFiles();
                for (int i = 0; i < fia.Count(); i++)
                {
                    StreamReader fr = new StreamReader(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db\" + fia[i].ToString());
                    fr.ReadLine();
                    {
                        fr.Close();
                        fr = new StreamReader(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db\" + fia[i].ToString());
                        clientList.Items.Add(fr.ReadLine() + " " + fr.ReadLine() + " " + fr.ReadLine());
                    }
                    fr.Close();
                }
                break;

                case 2:
                di = new DirectoryInfo(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db");
                fia = di.GetFiles();
                for (int i = 0; i < fia.Count(); i++)
                {
                    StreamReader fr = new StreamReader(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db\" + fia[i].ToString());
                    fr.ReadLine();
                    fr.ReadLine();
                    {
                        fr.Close();
                        fr = new StreamReader(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db" + fia[i].ToString());
                        clientList.Items.Add(fr.ReadLine() + " " + fr.ReadLine() + " " + fr.ReadLine());
                    }
                    fr.Close();
                }
                break;

                case 3:
                di = new DirectoryInfo(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db");
                fia = di.GetFiles();
                for (int i = 0; i < fia.Count(); i++)
                {
                    StreamReader fr = new StreamReader(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db" + fia[i].ToString());
                    fr.ReadLine();
                    fr.ReadLine();
                    fr.ReadLine();
                    {
                        fr.Close();
                        fr = new StreamReader(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db" + fia[i].ToString());
                        clientList.Items.Add(fr.ReadLine() + " " + fr.ReadLine() + " " + fr.ReadLine());
                    }
                    fr.Close();
                }
                break;

                case 4:
                di = new DirectoryInfo(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db");
                fia = di.GetFiles();

                for (int i = 0; i < fia.Count(); i++)
                {
                    StreamReader fr = new StreamReader(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db" + fia[i].ToString());
                    fr.ReadLine();
                    fr.ReadLine();
                    fr.ReadLine();
                    fr.ReadLine();
                    {
                        fr.Close();
                        fr = new StreamReader(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db" + fia[i].ToString());
                        clientList.Items.Add(fr.ReadLine() + " " + fr.ReadLine() + " " + fr.ReadLine());
                    }
                    fr.Close();
                }
                break;

            }
        }

        private void refreshSearch_Click(object sender, EventArgs e)
        {
            refreshMassive();
            searchTag.Text = null;
            toolTip.Text = "Подсказка поиска";
            searchTab.Text = null;
        }

        private void searchTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (searchTag.SelectedIndex) 
            {
                case 0: toolTip.Text = "Введите имя."; break;
                case 1: toolTip.Text = "Введите фамилию."; break;
                case 2: toolTip.Text = "Введите отчество."; break;
                case 3: toolTip.Text = "Номер паспорта."; break;
                case 4: toolTip.Text = "Введите пол (мужской/женский)"; break;
            }
        }

      

        private void delete_Click(object sender, EventArgs e)
        {
            deleteClient();
        }

        private void addRace_Click(object sender, EventArgs e)
        {
            if(FName.Text == null || SName.Text == null || FathName.Text == null||PassNum.Text.Length != 8) return;

            else 
            {
                FileInfo fi = new FileInfo(@"C:\Users\htcvive\Documents\Visual Studio 2017\such_kursach\such_kursach\db\" + PassNum.Text + ".txt");
                StreamWriter w = fi.AppendText();
                w.WriteLine("|");
                w.WriteLine(startingPlace.Text);
                w.WriteLine(targetPlace.Text);
                w.WriteLine(travelTime.Text);
                w.WriteLine(returnPlace.Text);
                w.WriteLine(travelType.SelectedItem);
                w.WriteLine(tour.Text);
                w.WriteLine(startDate.Value.Date);
                w.WriteLine(targetDate.Value.Date);
                w.WriteLine(stayPlace.Text);
                w.WriteLine(returnDate.Value.Date);
                w.WriteLine(price.Text);

                w.Close();
            }
            
        }
    }
}
