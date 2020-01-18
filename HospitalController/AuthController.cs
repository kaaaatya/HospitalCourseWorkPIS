using HospitalModel;
using System;
using System.Linq;

namespace HospitalController
{
    public class AuthController
    {
        private HospitalDbContext context;
        public string result = "Неверный логин или пароль";
        public AuthController(HospitalDbContext context)
        {
            this.context = context;
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
                    element = new Worker
                    {
                        FIO = model.FIO,
                        Role = model.Role,
                        Position = model.Position,
                        Login = model.Login,
                        Password = model.Password
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
            Worker element = context.Workers.FirstOrDefault(rec => rec.Login ==
          login && rec.Password == password && rec.Role == "Регистратор");            
            if (element!=null)
            {
                result = "ok";
            }
            else
            {
                result = "Неверный логин или пароль";
            }
            return result;
        }
    }
}
