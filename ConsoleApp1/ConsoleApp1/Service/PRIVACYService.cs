using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;

namespace ConsoleApp1.Service
{
    public class PRIVACYService
    {
        private GenericRepository<PRIVACY> repository = new GenericRepository<PRIVACY>();

        public void Add(string line, ref Guid CrHeaderId, ref List<PRIVACY> PRIVACYs)
        {
            var element = line.Split(new char[] { ',' }).ToList();
            var newVEHICLE = new PRIVACY
            {
                PrivacyIndicator= element[1],
                PrivacyType = element[2],

                HeaderId = CrHeaderId,
                Id = Guid.NewGuid(),
            };
            //repository.Create(newVEHICLE);
            PRIVACYs.Add(newVEHICLE);
        }
    }
}
