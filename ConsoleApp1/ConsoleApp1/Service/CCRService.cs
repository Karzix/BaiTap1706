using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;

namespace ConsoleApp1.Service
{
    public class CCRService
    {
        private GenericRepository<CCR> repository = new GenericRepository<CCR>();

        public void Add(string line, ref Guid CrHeaderId, ref List<CCR> CCRs)
        {
            var element = line.Split(new char[] { ',' }).ToList();
            var newCCR = new CCR
            {
                Complaint = element[1],
                Cause = element[2],
                Resolution = element[3],
                HeaderId = CrHeaderId,
                Id = Guid.NewGuid(),
            };
            //repository.Create(newVEHICLE);
            CCRs.Add(newCCR);
        }
    }
}
