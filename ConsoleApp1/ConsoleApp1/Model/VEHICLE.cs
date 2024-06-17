using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class VEHICLE
    {
        [Key]
        public Guid Id { get; set; }
        public string? RepairOrderVIN { get; set; }
        public string? DMSMakeCode { get; set; }
        public string? ModelYear { get; set; }
        public string? VehicleModel { get; set; }
        public string? LicenseNumber { get; set; }
        public string? DeliveryDate { get; set; }

        [ForeignKey("HEADER")]
        public Guid HeaderId { get; set; }
        [ForeignKey("HeaderId")]
        public HEADER? HEADER { get; set; }
    }
}
