using System;

namespace HospitalModel.ViewModels
{
    public class SicknessHistoryViewModel
    {
        public int Id { get; set; }
        public DateTime DateReception { get; set; }
        public string Temperature { get; set; }
        public DateTime Datedischarge { get; set; }
        public int PatientCardId { get; set; }
        public int RoomId { get; set; }
        public int WorkerId { get; set; }
    }
}
