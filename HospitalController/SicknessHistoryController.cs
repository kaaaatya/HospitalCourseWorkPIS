using HospitalModel;
using HospitalModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalController
{
    public class SicknessHistoryController
    {
        private HospitalDbContext context;
        public SicknessHistoryController(HospitalDbContext context)
        {
            this.context = context;
        }

        public List<PatientCardViewModel> getTreatedNow()
        {
            List<PatientCardViewModel> result = context.PatientCards.Where(rec => rec.IsTreatedNow == true).Select(rec => new
           PatientCardViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                InsuranceCompany = rec.InsuranceCompany,
                InsuranceNumber = rec.InsuranceNumber,
                Passport = rec.Passport,
                BirthDate = rec.BirthDate,
                Address = rec.Address,
                PhoneNumber = rec.PhoneNumber,
                Status = rec.Status,
                Gender = rec.Gender,
                IsTreatedNow = rec.IsTreatedNow
            })
            .ToList();
            return result;
        }
    }
}
