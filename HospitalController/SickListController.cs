using HospitalModel;
using HospitalModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalController
{
    public class SickListController
    {
        private HospitalDbContext context;
        public SickListController(HospitalDbContext context)
        {
            this.context = context;
        }

        public List<SicknessHistoryViewModel> GetDateReceptionForComboBox(string FIO)
        {
            PatientCard element1 = context.PatientCards.FirstOrDefault(rec => rec.FIO == FIO);
            if (element1 != null)
            {
                int patId = element1.Id;

                List<SicknessHistoryViewModel> result = context.SicknessHistories.Where(rec => rec.PatientCardId == patId && rec.DateReception != rec.Datedischarge).Select(rec => new
                 SicknessHistoryViewModel
                {
                    Id = rec.Id,
                    DateReception = rec.DateReception,
                    Temperature = rec.Temperature,
                    Datedischarge = rec.Datedischarge,
                    PatientCardId = rec.PatientCardId,
                    RoomId = rec.RoomId,
                    WorkerId = rec.WorkerId
                })
                .ToList();
                return result;
            }
            else
            {
                throw new Exception("Ошибка при загрузке дат по этому пациенту");
            }
        }

        public string getBirth(string FIO)
        {
            PatientCard element2 = context.PatientCards.FirstOrDefault(rec => rec.FIO == FIO);
            DateTime birthDate = element2.BirthDate;
            string birth = birthDate.ToString("yyyy-MM-dd");
            return birth;
        }

        public string getGender(string FIO)
        {
            PatientCard element2 = context.PatientCards.FirstOrDefault(rec => rec.FIO == FIO);
            string Gender = element2.Gender;
            return Gender;
        }

        public string getDate2(string FIO, DateTime dateRec)
        {
            PatientCard element2 = context.PatientCards.FirstOrDefault(rec => rec.FIO == FIO);
            int patId = element2.Id;

            SicknessHistory element3 = context.SicknessHistories.FirstOrDefault(rec => rec.PatientCardId == patId && rec.DateReception == dateRec);
            DateTime dateFree = element3.Datedischarge;
            string dateDis = dateFree.ToString("yyyy-MM-dd");
            return dateDis;

        }

        public string getDoctor(string FIO, DateTime dateRec)
        {
            PatientCard element2 = context.PatientCards.FirstOrDefault(rec => rec.FIO == FIO);
            int patId = element2.Id;

            SicknessHistory element3 = context.SicknessHistories.FirstOrDefault(rec => rec.PatientCardId == patId && rec.DateReception == dateRec);
            int doctorId = element3.WorkerId;

            Worker element = context.Workers.FirstOrDefault(rec => rec.Id == doctorId);
            string doctorName = element.FIO;
            return doctorName;

        }

    }
}
