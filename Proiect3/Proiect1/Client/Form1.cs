using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ModelFirst;


namespace Client
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nume_complet = textBox2.Text;
            string mail = textBox4.Text;
            string parola = maskedTextBox1.Text;
            string mesaj = "";
            if (nume_complet != "" && mail != "" && parola != "")
            {
                InterfaceWCFClient p = new InterfaceWCFClient();
                p.AddUser(nume_complet, mail, parola);
                mesaj = "User adaugat cu succes!";
            }
            else
            {
                mesaj = "Trebuie completate toate datele!";
            }
            textBox33.Text = mesaj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume_fisier = textBox14.Text;
            string cale = textBox13.Text;
            DateTime data_creare = dateTimePicker1.Value;
            string locatie = textBox11.Text;
            string eveniment = textBox10.Text;
            string peisaj = textBox9.Text;
            string descriere = textBox8.Text;
            string mesaj = "";
            if (nume_fisier != "" && cale != "" && locatie != "" && eveniment != "" && peisaj != "" && descriere != "")
            {
                InterfaceWCFClient p = new InterfaceWCFClient();
                p.AddFile(nume_fisier, cale, data_creare, locatie, eveniment, peisaj, descriere);
                mesaj = "Fisier adaugat cu succes!";
            }
            else
            {
                mesaj = "Trebuie completate toate datele!";
            }
            textBox33.Text = mesaj;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Nume_persoana = textBox7.Text;
            string mesaj = "";
            if (Nume_persoana != "")
            {
                InterfaceWCFClient p = new InterfaceWCFClient();
                var rs = p.GetPerson(Nume_persoana);
                foreach (var i in rs)
                {
                    mesaj += i.nume_persoana + " ";
                }
            }
            else
            {
                mesaj = "Nu exista aceste persoane!";
            }
            textBox33.Text = mesaj;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nume_persoana = textBox1.Text;
            string mesaj = "";
            if (nume_persoana != "")
            {
                InterfaceWCFClient p = new InterfaceWCFClient();
                p.AddPersoane(nume_persoana);
                mesaj = "Persoana adaugata cu succes!";
            }
            else
            {
                mesaj = "Trebuie completate toate datele!";
            }
            textBox33.Text = mesaj;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (textBox29.Text != "")
            {
                id = Int32.Parse(textBox29.Text);
            }
            string nume_complet = textBox28.Text;
            string mail = textBox27.Text;
            string parola = maskedTextBox2.Text;
            string mesaj = "";
            if (id != 0 && nume_complet != "" && mail != "" && parola != "")
            {
                InterfaceWCFClient p = new InterfaceWCFClient();
                p.UpdateUseri(id, nume_complet, mail, parola);
                mesaj = "User modificat cu succes!";
            }
            else
            {
                mesaj = "Trebuie completate toate datele!";
            }
            textBox33.Text = mesaj;
        }

        private void textBox25_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (textBox26.Text != "")
            {
                id = Int32.Parse(textBox26.Text);
            }
            string nume_persoana = textBox25.Text;
            string mesaj = "";
            if (id != 0 && nume_persoana != "")
            {
                InterfaceWCFClient p = new InterfaceWCFClient();
                p.UpdatePersoana(id, nume_persoana);
                mesaj = "Persoana modificata cu succes!";
            }
            else
            {
                mesaj = "Trebuie completate toate datele!";
            }
            textBox33.Text = mesaj;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (textBox24.Text != "")
            {
                id = Int32.Parse(textBox24.Text);
            }
            string nume_fisier = textBox18.Text;
            string cale = textBox19.Text;
            DateTime data_creare = dateTimePicker2.Value;
            string locatie = textBox20.Text;
            string eveniment = textBox21.Text;
            string peisaj = textBox22.Text;
            string descriere = textBox23.Text;
            string mesaj = "";
            if (id != 0 && nume_fisier != "" && cale != "" && locatie != "" && eveniment != "" && peisaj != "" && descriere != "")
            {
                InterfaceWCFClient p = new InterfaceWCFClient();
                p.UpdateFiles(id, nume_fisier, cale, data_creare, locatie, eveniment, peisaj, descriere);
                mesaj = "Fisier modificat cu succes!";
            }
            else
            {
                mesaj = "Trebuie completate toate datele!";
            }
            textBox33.Text = mesaj;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            int id = 0;
            if (textBox30.Text != "")
            {
                id = Int32.Parse(textBox30.Text);
            }
            if (id != 0)
            {
                InterfaceWCFClient p = new InterfaceWCFClient();
                p.DeleteUseri(id);
                mesaj = "User sters cu succes!";
            }
            else
            {
                mesaj = "Trebuie completate toate datele!";
            }
            textBox33.Text = mesaj;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            int id = 0;
            if (textBox31.Text != "")
            {
                id = Int32.Parse(textBox31.Text);
            }
            if (id != 0)
            {
                InterfaceWCFClient p = new InterfaceWCFClient();
                p.DeletePerson(id);
                mesaj = "Persoana stearsa cu succes!";
            }
            else
            {
                mesaj = "Trebuie completate toate datele!";
            }
            textBox33.Text = mesaj;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            int id = 0;
            if (textBox32.Text != "")
            {
                id = Int32.Parse(textBox32.Text);
            }
            if (id != 0)
            {
                InterfaceWCFClient p = new InterfaceWCFClient();
                p.DeleteFile(id);
                mesaj = "Fisier sters cu succes!";
            }
            else
            {
                mesaj = "Trebuie completate toate datele!";
            }
            textBox33.Text = mesaj;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Nume_fisier = textBox3.Text;
            string Cale = textBox17.Text;
            string Locatie = textBox16.Text;
            string Eveniment = textBox12.Text;
            string Peisaj = textBox15.Text;
            string mesaj = "";
            if (Nume_fisier != "" || Cale != "" || Locatie != "" || Eveniment != "" || Peisaj != "")
            {
                InterfaceWCFClient p = new InterfaceWCFClient();
                var rs = p.GetFiles(Nume_fisier, Cale, Locatie, Eveniment, Peisaj);
                foreach (var i in rs)
                {
                    mesaj += i.nume_fisier + " " + i.cale + " " + i.locatie + " " + i.eveniment + " " + i.peisaj;
                }
            }
            else
            {
                mesaj = "Nu exista aceste fisiere!";
            }
            textBox33.Text = mesaj;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nume = textBox6.Text;
            string Mail = textBox5.Text;
            string mesaj = "";
            if (nume != "" && Mail != "")
            {
                InterfaceWCFClient p = new InterfaceWCFClient();
                var rs = p.GetUser(nume, Mail);
                foreach (var i in rs)
                {
                    mesaj += i.nume_complet + " " + i.mail;
                }
            }
            else
            {
                mesaj = "Nu exista acesti useri!";
            }
            textBox33.Text = mesaj;
        }
    }
}
