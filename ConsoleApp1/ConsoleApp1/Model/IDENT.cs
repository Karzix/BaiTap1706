using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class IDENT
    {
        [Key]
        public Guid Id { get; set; }
        public string? RecordIdentifier { get; set; }
        public string? DateCreate { get; set; }
        public string? TimeCreate { get; set; }
        public string? DealerNumber { get; set; }
        public string? Make {  get; set; }
        public string? Store { get; set; }
        public string? Version { get; set; }

    }
}
