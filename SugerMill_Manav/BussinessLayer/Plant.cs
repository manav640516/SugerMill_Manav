using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SugerMill_Manav.BussinessLayer
{
    public class Plant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Staff> Staffs { get; set; }
    }
}
