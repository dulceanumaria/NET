using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WebApplication.Models
{
    [DataContract(IsReference = true)]
    public partial class PersoaneDTO
    {
        public PersoaneDTO()
        {
            this.Files = new List<FilesDTO>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string nume_persoana { get; set; }
        [DataMember]
        public int del { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FilesDTO> Files { get; set; }
    }

}
