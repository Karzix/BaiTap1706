using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class PARTLINE
    {
        public Guid Id { get; set; }
        public string? PartNumber { get; set; }
        public string? PartDescription { get; set; }
        public string? Count { get; set; }
        public string? PartUnitCost { get; set; }
        public string? PartUnitPrice { get; set; }
        public string? PartsWarehouse {  get; set; }
        public string? RelatedVINForThisOrder { get; set; }
        public string? PartsBin {  get; set; }
        [ForeignKey("HEADER")]
        public Guid HeaderId { get; set; }
        [ForeignKey("HeaderId")]
        public HEADER? HEADER { get; set; }

    }
}
