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
        public List<WokerViewModel> GetWokersForComboBox()
        {
            List<WokerViewModel> result = context.Workers.Where(rec => rec.Role == "Медперсонал").Select(rec => new
           WokerViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                Role = rec.Role,
                Position = rec.Position,
                Login = rec.Login,
                Password = rec.Password
            })
            .ToList();
            return result;
        }
        public List<RoomViewModel> GetRoomsForComboBox(string Gender)
        {
            List<RoomViewModel> result = context.Rooms.Where(rec => rec.Available >= 1 && rec.Gender == Gender).Select(rec => new
           RoomViewModel
            {
                id = rec.id,
                RoomNumber = rec.RoomNumber,
                Capacity = rec.Capacity,
                Available = rec.Available,
                Gender = rec.Gender
            })
            .ToList();
            return result;
        }
        public List<PatientCardViewModel> GetList()
        {
            List<PatientCardViewModel> result = context.PatientCards.Where(rec => rec.IsTreatedNow == false).Select(rec => new
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
        public void AddElement(SicknessHistory model)
        {
            int good = 1;
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    SicknessHistory element = context.SicknessHistories.FirstOrDefault(rec =>
                   rec.DateReception == model.DateReception && rec.Id == model.Id && model.Datedischarge == null);
                    if (element != null)
                    {
                        throw new Exception("Этот пациент уже принят. Выберите другого или выпишите этого, а потом принимайте заново.");
                    }
                    element = new SicknessHistory
                    {
                        DateReception = model.DateReception,
                        Temperature = model.Temperature,
                        Datedischarge = model.DateReception,
                        PatientCardId = model.PatientCardId,
                        RoomId = model.RoomId,
                        WorkerId = model.WorkerId
                        
                    };
                    context.SicknessHistories.Add(element);
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    good = 2;
                    transaction.Rollback();
                    throw;
                }
                if (good == 1)
                {
                    Room element = context.Rooms.FirstOrDefault(rec => rec.id == model.RoomId);                 
                    element.Available = element.Available - 1;
                    context.SaveChanges();

                    PatientCard element1 = context.PatientCards.FirstOrDefault(rec => rec.Id == model.PatientCardId);
                    element1.IsTreatedNow = true;
                    context.SaveChanges();
                }
            }
        }
        public int GetIdByRoomNumber(int number)
        {
            Room element = context.Rooms.FirstOrDefault(rec => rec.RoomNumber == number);
            int result = element.id;
            return result;
        }
        public int GetIdByDoctorName(string name)
        {
            Worker element = context.Workers.FirstOrDefault(rec => rec.FIO == name);
            int result = element.Id;
            return result;
        }
        public int GetIdByPatientName(string name)
        {
            PatientCard element = context.PatientCards.FirstOrDefault(rec => rec.FIO == name);
            int result = element.Id;
            return result;
        }

        public int GetRoomIdByPatientId(int patienId)
        {
            SicknessHistory element = context.SicknessHistories.FirstOrDefault(rec => rec.PatientCardId == patienId);
            int result = element.RoomId;
            return result;
        }

        public List<PatientCardViewModel> getTreatedNowOrderByFIO()
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
            }).OrderBy(rec => rec.FIO)
            .ToList();
            return result;
        }

        public void findSicknessHistory(int patientId, DateTime dateDis)
        {
            SicknessHistory element = context.SicknessHistories.FirstOrDefault(rec => rec.PatientCardId ==
         patientId && rec.DateReception==rec.Datedischarge);
            if (element == null)
            {
                throw new Exception("Не удалось найти пациента");
            }
            freePatient(element, dateDis);
            return;
        }

        public void freePatient(SicknessHistory model, DateTime date)
        {
            SicknessHistory element = context.SicknessHistories.FirstOrDefault(rec => rec.Id ==
          model.Id);
            if(date < element.DateReception)
            {
                throw new Exception("Дата выписки должна быть больше даты приема");
            }
            element.Datedischarge = date;
            context.SaveChanges();

            Room element1 = context.Rooms.FirstOrDefault(rec => rec.id == model.RoomId);
            element1.Available = element1.Available + 1;
            context.SaveChanges();

            PatientCard element2 = context.PatientCards.FirstOrDefault(rec => rec.Id == model.PatientCardId);
            element2.IsTreatedNow = false;
            context.SaveChanges();
        }
    }
}
