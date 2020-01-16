using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModel.ViewModels
{
    public class RoomViewModel
    {        
        public int id { get; set; }
        public int RoomNumber { get; set; }
        public string Gender { get; set; }
        public int Capacity { get; set; }
        public int Available { get; set; }
    }
}
