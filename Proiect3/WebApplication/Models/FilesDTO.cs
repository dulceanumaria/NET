using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WebApplication.Models
{
    [DataContract(IsReference = true)]
    public partial class FilesDTO
    {
        public FilesDTO()
        {
            this.del = 0;
            this.Persoanes = new List<PersoaneDTO>();
            this.Useris = new List<UseriDTO>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string nume_fisier { get; set; }
        [DataMember]
        public string cale { get; set; }
        [DataMember]
        public System.DateTime data_creare { get; set; }
        [DataMember]
        public string locatie { get; set; }
        [DataMember]
        public string eveniment { get; set; }
        [DataMember]
        public string peisaj { get; set; }
        [DataMember]
        public string descriere { get; set; }
        [DataMember]
        public int del { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<PersoaneDTO> Persoanes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<UseriDTO> Useris { get; set; }
    }

}
