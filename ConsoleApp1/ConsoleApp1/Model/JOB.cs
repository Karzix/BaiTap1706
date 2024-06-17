using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class JOB
    {
        public Guid Id { get; set; }
        public string? DMSJobNumber { get; set; }
        public string? DMSOperationCode{ get; set; }
        public string? DMSOperationDescription{ get; set; }
        public string? JobLabourPrice { get;set; }
        public string? JobPartsPrice { get;set; }
        public string? JobSubletPrice { get; set; }
        public string? JobMiscellaneousPrice { get; set; }
        public string? JobGOGPrice { get; set; }
        public string? JobsSundryPrice { get; set; }
        public string? JobLabourCOS {  get; set; }
        [ForeignKey("HEADER")]
        public Guid HeaderId { get; set; }
        [ForeignKey("HeaderId")]
        public HEADER? HEADER { get; set; }
    }
}
