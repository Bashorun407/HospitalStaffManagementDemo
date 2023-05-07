using HSMD.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Staff : AuditableBaseEntity
    {
        [ForeignKey(nameof(Staff_Address))]
        public long Staff_Address { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime Date_Joined { get; set; }
        public DateTime Date_Left { get; set;}
        public string? Department { get; set; }
        public string? StaffPosition { get; set; }

        public StaffAddress? StaffAddress { get; set; }
    }
}
