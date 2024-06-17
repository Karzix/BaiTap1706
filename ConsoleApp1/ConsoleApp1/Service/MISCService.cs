using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;

namespace ConsoleApp1.Service
{
    public class MISCService
    {
        private GenericRepository<MISC> repository = new GenericRepository<MISC>();

        public void Add(string line, ref Guid CrHeaderId)
        {
            var element = line.Split(new char[] { ',' }).ToList();
            var newVEHICLE = new MISC
            {
                MiscellaneousCode = element[1],
                MiscellaneousDescription = element[2],
                MiscellaneousPrice = element[3],
                MiscellaneousPriceAfterSplit = element[4],
                MiscellaneousSplitPercentage = element[5],
                MiscellaneounsCostOfSale = element[6],

                HeaderId = CrHeaderId,
                Id = Guid.NewGuid(),
            };
            repository.Create(newVEHICLE);

        }
    }
}
