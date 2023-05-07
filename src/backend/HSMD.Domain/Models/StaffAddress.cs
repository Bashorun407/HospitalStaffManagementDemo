using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class StaffAddress
    {
        public int BuildingNumber { get; set; }
        public string? StreetName { get; set; }
        public string? Area_Locality { get; set; }
        public string? LandMark { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int Zip_PostalCode { get; set; }

        public ICollection<Staff>? Staffs { get; set; }
    }
}
