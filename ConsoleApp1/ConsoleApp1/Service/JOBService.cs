using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;

namespace ConsoleApp1.Service
{
    public class JOBService
    {
        private GenericRepository<JOB> repository = new GenericRepository<JOB>();

        public void Add(string line, ref Guid CrHeaderId, ref List<JOB> jobs)
        {
            var element = line.Split(new char[] { ',' }).ToList();
            var newVEHICLE = new JOB
            {
                DMSJobNumber = element[1],
                DMSOperationCode = element[2],
                DMSOperationDescription = element[3],
                JobLabourPrice = element[13],
                JobPartsPrice = element[14],
                JobMiscellaneousPrice = element[29],
                JobGOGPrice = element[30],
                JobsSundryPrice = element[31],
                JobLabourCOS = element[35],
                JobSubletPrice = element[15],

                HeaderId = CrHeaderId,
                Id = Guid.NewGuid(),
            };
            //repository.Create(newVEHICLE);
            jobs.Add(newVEHICLE);

        }
    }
}
