using System.Runtime.Serialization;

namespace HospitalModel
{
    [DataContract]
    public class Treatment
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int TotalAmount { get; set; }
        [DataMember]
        public int DailyAmount { get; set; }
        [DataMember]
        public int ServiceId { get; set; }
        [DataMember]
        public int SicknessHistoryId { get; set; }
        public virtual Service Service { get; set; }
        public virtual SicknessHistory SicknessHistory { get; set; }

    }
}
