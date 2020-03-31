using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelFirst;
using System.ServiceModel;

namespace WCF
{
    [ServiceContract]
    interface InterfaceWCF
    {
        [OperationContract]
        void AddFile(string Nume_fisier, string Cale, System.DateTime Data_creare, string Locatie, string Eveniment, string Peisaj, string Descriere);
        [OperationContract]
        void AddPersoane(string Nume_persoana);
        [OperationContract]
        void AddUser(string numeU, string mailU, string parolaU);
        [OperationContract]
        void DeleteFile(int id);
        [OperationContract]
        void DeletePerson(int id);
        [OperationContract]
        void DeleteUseri(int id);
        [OperationContract]
        string GetFiles(string Nume_fisier, string Cale, string Locatie, string Eveniment, string Peisaj);
        [OperationContract]
        string GetPerson(string Nume_persoana);
        [OperationContract]
        string GetUser(string Nume, string Mail);
        [OperationContract]
        void UpdateFiles(int id, string Nume_fisier, string Cale, System.DateTime Data_creare, string Locatie, string Eveniment, string Peisaj, string Descriere);
        [OperationContract]
        void UpdatePersoana(int id, string Nume_persoana);
        [OperationContract]
        void UpdateUseri(int id, string Nume_complet, string Mail, string Parola);
    }
}
