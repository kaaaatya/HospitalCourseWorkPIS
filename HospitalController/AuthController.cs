using HospitalModel;
using System;
using System.Linq;

namespace HospitalController
{
    public class AuthController
    {
        private HospitalDbContext context;
        private readonly EncryptionController service;
        public string result = "Неверный логин или пароль";
        public AuthController(HospitalDbContext context, EncryptionController service)
        {
            this.context = context;
            this.service = service;
        }

        public void AddElement(Worker model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Worker element = context.Workers.FirstOrDefault(rec =>
                   rec.Login == model.Login);
                    if (element != null)
                    {
                        throw new Exception("Уже есть пользователь с таким логином");
                    }
                    string encryptedPass = service.Encrypt("Login", model.Password);
                    element = new Worker
                    {
                        FIO = model.FIO,
                        Role = model.Role,
                        Position = model.Position,
                        Login = model.Login,
                        Password = encryptedPass
                    };
                    context.Workers.Add(element);
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

        //проверка совпадения логина и пароля
        public string CheckAuthInfo(string login, string password)
        {
            string pass = service.Encrypt("Login", password);
            Worker element = context.Workers.FirstOrDefault(rec => rec.Login ==
          login && rec.Password == pass);  
            if (element.Role == "Регистратор")
            {
                if (element != null)
                {
                    result = "ok";
                }
                else
                {
                    result = "Неверный логин или пароль";
                }
            }
            else
            {
                result = "На данный момент доступно только АРМ Регистратора";
            }            
            return result;
        }
    }
}
