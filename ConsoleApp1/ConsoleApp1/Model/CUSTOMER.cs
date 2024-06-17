using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class CUSTOMER
    {
        public Guid Id { get; set; }
        public string? ServiceCustomerSalutation { get; set; }
        public string? CompanyName { get; set; }
        public string? ServiceCustomerLastName { get; set; }
        public string? ServiceCustomerFirstName { get; set; }
        public string? ServiceCustomerAddress1 { get; set; }
        public string? ServiceCustomerAddress2 { get; set; }
        public string? ServiceCustomerCity { get; set; }
        public string? ServiceCustomerStateCode { get; set; }
        public string? ServiceCustomerPostCode { get; set; }
        public string? ServiceCustomerEveningPhone { get; set; }
        public string? ServiceCustomerDayPhone { get; set; }
        public string? ServiceCustomerEmail { get; set; }
        public string? ServiceCustomerMobile { get;set; }
        public string? DMSCustomerID { get;set; }
        public string? ABN { get; set; }
        public string? CustomerContactType { get;set; }
        public string? AssociatedDealerCode { get; set; }
        public string? CustomerEmail2 { get; set; }
        public string? CustomerEmail3 { get; set; }
        [ForeignKey("HEADER")]
        public Guid HeaderId { get; set; }
        [ForeignKey("HeaderId")]
        public HEADER? HEADER { get; set; }
    }
}
