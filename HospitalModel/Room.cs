using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HospitalModel
{
    [DataContract]
    public class Room
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int RoomNumber { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public int Capacity { get; set; }
        [DataMember]
        public int Available { get; set; }

        [ForeignKey("RoomId")]
        public virtual List<SicknessHistory> SicknessHistories { get; set; }
    }
}
