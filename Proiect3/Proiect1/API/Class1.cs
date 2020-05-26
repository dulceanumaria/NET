using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    public class Class1
    {
        public void AddUser(String numeU, String mailU, String parolaU)
        {
            using (Model1Container context = new Model1Container())
            {
                Useri p = new Useri()
                {
                    nume_complet = numeU,
                    mail = mailU,
                    parola = parolaU
                };
                context.Useris.Add(p);
                context.SaveChanges();
                var items = context.Useris;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.nume_complet);
            }
        }
        public void AddFile(String Nume_fisier, String Cale, DateTime Data_creare, String Locatie, String Eveniment, String Peisaj, String Descriere)
        {
            using (Model1Container context = new Model1Container())
            {
                Files p = new Files()
                {
                    nume_fisier = Nume_fisier,
                    cale = Cale,
                    data_creare = Data_creare,
                    locatie = Locatie,
                    eveniment = Eveniment,
                    peisaj = Peisaj,
                    descriere = Descriere
                };
                context.Files.Add(p);
                context.SaveChanges();
                var items = context.Files;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.nume_fisier);
            }
        }
        public void AddPersoane(String Nume_persoana)
        {
            using (Model1Container context = new Model1Container())
            {
                Persoane p = new Persoane()
                {
                    nume_persoana = Nume_persoana
                };
                context.Persoanes.Add(p);
                context.SaveChanges();
                var items = context.Persoanes;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.nume_persoana);
            }
        }
        public void UpdateUseri(int id, string Nume_complet, string Mail, string Parola)
        {
            using (Model1Container context = new Model1Container())
            {
                var std = context.Useris
                       .Where(s => s.Id == id)
                       .FirstOrDefault<Useri>();
                std.nume_complet = Nume_complet;
                std.mail = Mail;
                std.parola = Parola;
                context.SaveChanges();
            }
        }
        public void UpdateFiles(int id, String Nume_fisier, String Cale, DateTime Data_creare, String Locatie, String Eveniment, String Peisaj, String Descriere)
        {
            using (Model1Container context = new Model1Container())
            {
                var std = context.Files
                       .Where(s => s.Id == id)
                       .FirstOrDefault<Files>();
                std.nume_fisier = Nume_fisier;
                std.cale = Cale;
                std.data_creare = Data_creare;
                std.locatie = Locatie;
                std.eveniment = Eveniment;
                std.peisaj = Peisaj;
                std.descriere = Descriere;
                context.SaveChanges();
            }
        }
        public void UpdatePersoana(int id, String Nume_persoana)
        {
            using (Model1Container context = new Model1Container())
            {
                var std = context.Persoanes
                       .Where(s => s.Id == id)
                       .FirstOrDefault<Persoane>();
                std.nume_persoana = Nume_persoana;
                context.SaveChanges();
            }
        }
        public void DeleteUseri(int id)
        {
            using (Model1Container context = new Model1Container())
            {
                var std = context.Useris
                       .Where(s => s.Id == id)
                       .FirstOrDefault<Useri>();
                std.del = 1;
                context.SaveChanges();
            }
        }
        public void DeletePerson(int id)
        {
            using (Model1Container context = new Model1Container())
            {
                var std = context.Persoanes
                       .Where(s => s.Id == id)
                       .FirstOrDefault<Persoane>();
                std.del = 1;
                context.SaveChanges();
            }
        }
        public void DeleteFile(int id)
        {
            using (Model1Container context = new Model1Container())
            {
                var std = context.Files
                       .Where(s => s.Id == id)
                       .FirstOrDefault<Files>();
                std.del = 1;
                context.SaveChanges();
            }
        }
        public List<Files> GetFiles(String Nume_fisier, String Cale, String Locatie, String Eveniment, String Peisaj)
        {
            using (Model1Container context = new Model1Container())
            {
                var rs = context.Files.Where(s => s.nume_fisier == Nume_fisier).Where(s => s.cale == Cale).Where(s => s.locatie == Locatie).Where(s => s.eveniment == Eveniment).Where(s => s.peisaj == Peisaj).Where(s => s.del == 0).ToList();
                return rs;
            }
        }
        public List<Files> GetAllFiles()
        {
            using (Model1Container context = new Model1Container())
            {
                var rs = context.Files.Where(s => s.del == 0).ToList();
                return rs;
            }
        }
        public List<Files> GetFilesByLocatie(string Locatie)
        {
            using (Model1Container context = new Model1Container())
            {
                var rs = context.Files.Where(s => s.locatie == Locatie).Where(s => s.del == 0).ToList();
                return rs;
            }
        }
        public List<Files> GetFilesByPeisaj(string Peisaj)
        {
            using (Model1Container context = new Model1Container())
            {
                var rs = context.Files.Where(s => s.peisaj == Peisaj).Where(s => s.del == 0).ToList();
                return rs;
            }
        }
        public List<Files> GetFilesByEveniment(string Eveniment)
        {
            using (Model1Container context = new Model1Container())
            {
                var rs = context.Files.Where(s => s.eveniment == Eveniment).Where(s => s.del == 0).ToList();
                return rs;
            }
        }
        public List<Persoane> GetPerson(String Nume_persoana)
        {
            using (Model1Container context = new Model1Container())
            {
                var rs = context.Persoanes.Where(s => s.nume_persoana == Nume_persoana).Where(s => s.del == 0).ToList();
                return rs;
            }

        }
        public List<Useri> GetUser(String Nume, String Mail)
        {
            using (Model1Container context = new Model1Container())
            {
                List<Useri> rs;
                if (Nume != "" && Mail == "")
                {
                    rs = context.Useris.Where(s => s.nume_complet == Nume).Where(s => s.del == 0).ToList();
                }
                if (Mail != "" && Nume == "")
                {
                    rs = context.Useris.Where(s => s.mail == Mail).Where(s => s.del == 0).ToList();
                }
                if (Mail != "" && Nume != "")
                {
                    rs = context.Useris.Where(s => s.mail == Mail).Where(s => s.nume_complet == Nume).Where(s => s.del == 0).ToList();
                }
                else
                {
                    rs = context.Useris.Where(s => s.del == 0).ToList();
                }
                return rs;
            }

        }
    }
}
