using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;

namespace ConsoleApp1.Service
{
    public class CONTACTService
    {
        private GenericRepository<CONTACT> repository = new GenericRepository<CONTACT>();

        public void Add(string line, ref Guid CrHeaderId, ref List<CONTACT> cONTACTs)
        {
            var element = line.Split(new char[] { ',' }).ToList();
            var newVEHICLE = new CONTACT
            {
                CustomerSalutation = element[1],
                CustomerLastName = element[5],
                CustomerFirstName = element[6],
                CustomerEveningPhone = element[17],
                CustomerDayPhone = element[18],
                CustomerEmail = element[20],
                CustomerMobile = element[21],
                CustomerEmail2 = element[22],
                CustomerEmail3 = element[23],
                CustomerTitle = element[24],
                CustomerDear = element[25],
                HeaderId = CrHeaderId,
                Id = Guid.NewGuid(),
            };
            //repository.Create(newVEHICLE);
            cONTACTs.Add(newVEHICLE);

        }
    }
}
