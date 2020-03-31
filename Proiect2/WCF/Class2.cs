using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelFirst;

namespace WCF
{
    class Class2: InterfaceWCF
    {
        void InterfaceWCF.AddFile(string Nume_fisier, string Cale, System.DateTime Data_creare, string Locatie, string Eveniment, string Peisaj, string Descriere)
        {
            Class1 c = new Class1();
            c.AddFile(Nume_fisier, Cale, Data_creare, Locatie, Eveniment, Peisaj, Descriere);
        }
        void InterfaceWCF.AddPersoane(string Nume_persoana)
        {
            Class1 c = new Class1();
            c.AddPersoane(Nume_persoana);
        }
        void InterfaceWCF.AddUser(string numeU, string mailU, string parolaU)
        {
            Class1 c = new Class1();
            c.AddUser(numeU, mailU, parolaU);
        }
        void InterfaceWCF.DeleteFile(int id)
        {
            Class1 c = new Class1();
            c.DeleteFile(id);
        }
        void InterfaceWCF.DeletePerson(int id)
        {
            Class1 c = new Class1();
            c.DeletePerson(id);
        }
        void InterfaceWCF.DeleteUseri(int id)
        {
            Class1 c = new Class1();
            c.DeleteUseri(id);
        }
        string InterfaceWCF.GetFiles(string Nume_fisier, string Cale, string Locatie, string Eveniment, string Peisaj)
        {
            Class1 c = new Class1();
            return c.GetFiles(Nume_fisier, Cale, Locatie, Eveniment, Peisaj);
        }
        string InterfaceWCF.GetPerson(string Nume_persoana)
        {
            Class1 c = new Class1();
            return c.GetPerson(Nume_persoana);
        }
        string InterfaceWCF.GetUser(string Nume, string Mail)
        {
            Class1 c = new Class1();
            return c.GetUser(Nume, Mail);
        }
        void InterfaceWCF.UpdateFiles(int id, string Nume_fisier, string Cale, System.DateTime Data_creare, string Locatie, string Eveniment, string Peisaj, string Descriere)
        {
            Class1 c = new Class1();
            c.UpdateFiles(id, Nume_fisier, Cale, Data_creare, Locatie, Eveniment, Peisaj, Descriere);
        }
        void InterfaceWCF.UpdatePersoana(int id, string Nume_persoana)
        {
            Class1 c = new Class1();
            c.UpdatePersoana(id, Nume_persoana);
        }
        void InterfaceWCF.UpdateUseri(int id, string Nume_complet, string Mail, string Parola)
        {
            Class1 c = new Class1();
            c.UpdateUseri(id, Nume_complet, Mail, Parola);
        }
    }
}
