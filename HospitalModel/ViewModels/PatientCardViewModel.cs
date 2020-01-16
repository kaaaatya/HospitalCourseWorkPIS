using System;

namespace HospitalModel.ViewModels
{
    public class PatientCardViewModel
    {
        public int Id { get; set; }      
        public string FIO { get; set; }
        public string InsuranceCompany { get; set; }
        public string InsuranceNumber { get; set; }
        public string Passport { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string Gender { get; set; }
        public bool IsTreatedNow { get; set; }
    }
}
