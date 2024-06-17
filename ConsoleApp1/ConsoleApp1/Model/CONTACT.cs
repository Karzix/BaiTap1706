using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class CONTACT
    {
        public Guid Id { get; set; }
        public string? CustomerSalutation { get; set; }
        public string? CustomerLastName { get; set; }
        public string? CustomerFirstName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerEveningPhone{ get; set; }
        public string? CustomerDayPhone { get; set; }
        public string? CustomerMobile { get;set; }
        public string? CustomerEmail2 { get; set; }
        public string? CustomerEmail3 { get; set; }
        public string?  CustomerTitle { get; set; }
        public string? CustomerDear { get; set; }
        [ForeignKey("HEADER")]
        public Guid HeaderId { get; set; }
        [ForeignKey("HeaderId")]
        public HEADER? HEADER { get; set; }
    }
}
