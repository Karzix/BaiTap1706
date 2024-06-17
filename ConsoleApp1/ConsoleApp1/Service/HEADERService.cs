using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;

namespace ConsoleApp1.Service
{
    public class HEADERService
    {
        private GenericRepository<HEADER> repository = new GenericRepository<HEADER>();


        public void Add(string line, ref Guid identID, ref Guid CrHeaderId)
        {
            var element = line.Split(new char[] { ',' }).ToList();
            var newHEADER = new HEADER();
            newHEADER.IDENTID = identID;

            newHEADER.DocumentNumber = element[1];
            newHEADER.DocumentOpenDate = element[2];
            newHEADER.DocumentCompletedDate = element[3];
            newHEADER.DocumentInvoiceDate = element[4];
            newHEADER.RepairOrderCustomerPayTotalPrice = element[6];
            newHEADER.ServiceAdvisorEmpIDCode = element[7];
            newHEADER.ServiceAdvisorName = element[8];
            newHEADER.DocumentType = element[9];
            newHEADER.InvoiceOrCredit = element[10];
            newHEADER.Id = Guid.NewGuid();
            newHEADER.RecordIdentifier = element[0];
            repository.Create(newHEADER);


            CrHeaderId = newHEADER.Id;
        }
    }
}
