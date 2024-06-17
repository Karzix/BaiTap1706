using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class MISC
    {
        public Guid Id { get; set; }
        public string? MiscellaneousCode { get; set; }
        public string? MiscellaneousDescription { get; set; }
        public string? MiscellaneousPrice { get; set; }
        public string? MiscellaneousPriceAfterSplit { get; set; }
        public string? MiscellaneousSplitPercentage { get; set; }
        public string? MiscellaneounsCostOfSale { get; set; }
        [ForeignKey("HEADER")]
        public Guid HeaderId { get; set; }
        [ForeignKey("HeaderId")]
        public HEADER? HEADER { get; set; }
    }
}
