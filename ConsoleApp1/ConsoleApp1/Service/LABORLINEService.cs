using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;

namespace ConsoleApp1.Service
{
    public class LABORLINEService
    {
        private GenericRepository<LABORLINE> repository = new GenericRepository<LABORLINE>();

        public void Add(string line, ref Guid CrHeaderId)
        {
            var element = line.Split(new char[] { ',' }).ToList();
            var newVEHICLE = new LABORLINE
            {
                LabourOperationCodeType = element[2],
                HeaderId = CrHeaderId,
                Id = Guid.NewGuid(),
            };
            repository.Create(newVEHICLE);

        }
    }
}
