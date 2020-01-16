using System;
using System.Runtime.Serialization;

namespace HospitalModel
{
    [DataContract]
    public class SicknessHistory
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime DateReception { get; set; }
        [DataMember]
        public string Temperature { get; set; }
        [DataMember]
        public DateTime Datedischarge { get; set; }
        [DataMember]
        public int PatientCardId { get; set; }
        [DataMember]
        public int RoomId { get; set; }
        [DataMember]
        public int WorkerId { get; set; }
        public virtual PatientCard PatientCard { get; set; }
        public virtual Room Room { get; set; }
        public virtual Worker Worker { get; set; }

    }
}
