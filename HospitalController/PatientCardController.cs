using HospitalModel;
using HospitalModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalController
{
    public class PatientCardController
    {
        private HospitalDbContext context;

        public PatientCardController(HospitalDbContext context)
        {
            this.context = context;
        }

        public List<PatientCardViewModel> GetList(){
            List<PatientCardViewModel> result = context.PatientCards.Select(rec => new
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

        public void AddElement(PatientCard model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    PatientCard element = context.PatientCards.FirstOrDefault(rec =>
                   rec.InsuranceNumber == model.InsuranceNumber);
                    if (element != null)
                    {
                        throw new Exception("Уже есть пациент с этим страховым номером");
                    }
                    element = new PatientCard
                    {
                        FIO = model.FIO,
                        InsuranceCompany = model.InsuranceCompany,
                        InsuranceNumber = model.InsuranceNumber,
                        Passport = model.Passport,
                        BirthDate = model.BirthDate,
                        Address = model.Address,
                        PhoneNumber = model.PhoneNumber,
                        Status = model.Status,
                        Gender = model.Gender,
                        IsTreatedNow = model.IsTreatedNow
                    };
                    context.PatientCards.Add(element);
                    context.SaveChanges();                    
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public List<PatientCardViewModel> getByFIO(string fio)
        {
            List<PatientCardViewModel> result = context.PatientCards.Where(rec => rec.FIO.StartsWith(fio)).Select(rec => new
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

        public List<PatientCardViewModel> getByNumber(string number)
        {
            List<PatientCardViewModel> result = context.PatientCards.Where(rec => rec.InsuranceNumber == number).Select(rec => new
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
