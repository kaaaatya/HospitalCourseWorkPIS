using HospitalModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace HospitalController
{
    public class ArchieveController
    {
        private HospitalDbContext context;
        public ArchieveController(HospitalDbContext context)
        {
            this.context = context;
        }

        public void delElement(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    SicknessHistory element = context.SicknessHistories.FirstOrDefault(rec => rec.Id ==
                   id);
                    if (element != null)
                    {
                        context.SicknessHistories.Remove(element);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Элемент не найден");
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public async Task SaveToJsonAsync(string fileName)
        {
            DataContractJsonSerializer formatterPeople = new DataContractJsonSerializer(typeof(List<SicknessHistory>));
            MemoryStream msPeople = new MemoryStream();
            formatterPeople.WriteObject(msPeople, await context.SicknessHistories.ToListAsync());
            msPeople.Position = 0;
            StreamReader srHistory = new StreamReader(msPeople);
            string historyJSON = srHistory.ReadToEnd();
            srHistory.Close();
            msPeople.Close();

            File.WriteAllText(fileName, "{\n" +
                "    \"SicknessHistory\": " + historyJSON + ",\n" +
                "}");
        }
    }
}
