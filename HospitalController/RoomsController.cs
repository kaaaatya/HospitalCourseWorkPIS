using HospitalModel;
using HospitalModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalController
{
    public class RoomsController
    {
        private HospitalDbContext context;
        public RoomsController(HospitalDbContext context)
        {
            this.context = context;
        }

        public List<RoomViewModel> GetList()
        {
            List<RoomViewModel > result = context.Rooms.Select(rec => new
           RoomViewModel
            {
                id = rec.id,
                RoomNumber = rec.RoomNumber,
                Gender = rec.Gender,
                Capacity = rec.Capacity,
                Available = rec.Available
            })
            .ToList();
            return result;
        }
        public void AddElement(Room model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Room element = context.Rooms.FirstOrDefault(rec =>
                   rec.RoomNumber == model.RoomNumber);
                    if (element != null)
                    {
                        throw new Exception("Уже есть палата с таким номером");
                    }
                    element = new Room
                    {
                        RoomNumber = model.RoomNumber,
                        Gender = model.Gender,
                        Capacity = model.Capacity,
                        Available = model.Capacity
                    };
                    context.Rooms.Add(element);
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

        public void DelElement(int number)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Room element = context.Rooms.FirstOrDefault(rec => rec.RoomNumber ==
                   number);
                    if (element != null)
                    {
                        context.Rooms.Remove(element);
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
        public void UpdElement(Room model)
        {
            Room element = context.Rooms.FirstOrDefault(rec => rec.RoomNumber ==
          model.RoomNumber && rec.id != model.id);
            if (element != null)
            {
                throw new Exception("Уже есть такая палата");
            }
            element = context.Rooms.FirstOrDefault(rec => rec.id == model.id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            if ((element.Gender != model.Gender)&&(element.Capacity!=element.Available))
            {
                throw new Exception("Нельзя менять пол палаты если она не свободна на данный момент");
            }
            int wasOccupied = model.Capacity - model.Available;
            if (model.Capacity < wasOccupied)
            {
                throw new Exception("Нельзя делать вместимость палаты меньше, чем в ней находится людей сейчас");
            }
            element.RoomNumber = model.RoomNumber;
            element.Gender = model.Gender;
            element.Capacity = model.Capacity;
            element.Available = model.Capacity - wasOccupied;
            context.SaveChanges();
        }

        public List<RoomViewModel> CountPationsInEachRoom()
        {
            List<RoomViewModel> result = context.Rooms.Select(rec => new
          RoomViewModel
            {
                id = rec.id,
                RoomNumber = rec.RoomNumber,
                Gender = rec.Gender,
                Capacity = rec.Capacity,
                Available = rec.Capacity - rec.Available
            })
            .ToList();
            return result;
        }
    }
}
