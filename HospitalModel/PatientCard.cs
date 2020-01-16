using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HospitalModel
{
    [DataContract]
    public class PatientCard
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FIO { get; set; }
        [DataMember]
        public string InsuranceCompany { get; set; }
        [DataMember]
        public string InsuranceNumber { get; set; }
        [DataMember]
        public string Passport { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public bool IsTreatedNow { get; set; }

        [ForeignKey("PatientCardId")]
        public virtual List<SicknessHistory> SicknessHistories { get; set; }

    }
}
