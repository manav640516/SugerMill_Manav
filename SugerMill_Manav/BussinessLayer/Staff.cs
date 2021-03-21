using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SugerMill_Manav.BussinessLayer
{
    public class Staff
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int CompanyID { get; set; }
        public int PlantID { get; set; }

        public Company Company { get; set; }
        public Plant Plant { get; set; }
        
    }
}
