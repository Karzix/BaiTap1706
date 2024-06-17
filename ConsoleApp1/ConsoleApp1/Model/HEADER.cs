using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ConsoleApp1.Model
{
    public class HEADER
    {
        [Key]
        public Guid Id { get; set; }
        public string RecordIdentifier { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DocumentOpenDate { get; set; }
        public string? DocumentCompletedDate{ get; set; }
        public string? DocumentInvoiceDate { get; set; }
        public string? RepairOrderCustomerPayTotalPrice { get; set; }
        public string? ServiceAdvisorEmpIDCode { get; set; }
        public string? ServiceAdvisorName { get; set; }
        public string? DocumentType { get; set; }
        public string? InvoiceOrCredit {  get; set; }

        [ForeignKey("identifiers")]
        public Guid IDENTID { get; set; }
        [ForeignKey("IDENTID")]
        public IDENT? IDENT { get; set; }
    }
}
