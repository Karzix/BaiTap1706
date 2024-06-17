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

        public void Add(string line, ref Guid CrHeaderId)
        {
            var element = line.Split(new char[] { ',' }).ToList();
            var newVEHICLE = new CCR
            {
                Complaint = element[1],
                Cause = element[2],
                Resolution = element[3],
                HeaderId = CrHeaderId,
                Id = Guid.NewGuid(),
            };
            repository.Create(newVEHICLE);

        }
    }
}
