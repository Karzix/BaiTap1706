using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;

namespace ConsoleApp1.Service
{
    public class CUSTOMERService
    {
        private GenericRepository<CUSTOMER> repository = new GenericRepository<CUSTOMER>();

        public void Add(string line, ref Guid CrHeaderId, ref List<CUSTOMER> CUSTOMERs)
        {
            var element = line.Split(new char[] { ',' }).ToList();
            var newVEHICLE = new CUSTOMER
            {
                ServiceCustomerSalutation = element[1],
                CompanyName = element[3],
                ServiceCustomerLastName = element[5],
                ServiceCustomerFirstName = element[6],
                ServiceCustomerAddress1 = element[10],
                ServiceCustomerAddress2 = element[11],
                ServiceCustomerCity = element[12],
                ServiceCustomerStateCode = element[13],
                ServiceCustomerPostCode = element[14],
                ServiceCustomerEveningPhone = element[17],
                ServiceCustomerDayPhone = element[18],
                ServiceCustomerEmail = element[20],
                ServiceCustomerMobile = element[21],
                DMSCustomerID = element[32],
                ABN = element[33],
                CustomerContactType = element[34],
                AssociatedDealerCode = element[35],
                CustomerEmail2 = element[36],
                CustomerEmail3 = element[37],

                HeaderId = CrHeaderId,
                Id = Guid.NewGuid(),
            };
            //repository.Create(newVEHICLE);
            CUSTOMERs.Add(newVEHICLE);

        }
    }
}
