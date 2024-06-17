using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class LABORLINE
    {
        public Guid Id { get; set; }
        public string? LabourOperationCodeType { get; set; }
        [ForeignKey("HEADER")]
        public Guid HeaderId { get; set; }
        [ForeignKey("HeaderId")]
        public HEADER? HEADER { get; set; }

    }
}
