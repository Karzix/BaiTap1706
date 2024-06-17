using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;

namespace ConsoleApp1.Service
{
    public class PARTLINEService
    {
        private GenericRepository<PARTLINE> repository = new GenericRepository<PARTLINE>();

        public void Add(string line, ref Guid CrHeaderId)
        {
            var element = line.Split(new char[] { ',' }).ToList();
            var newVEHICLE = new PARTLINE
            {
                PartNumber = element[1],
                PartDescription = element[2],
                Count = element[3],
                PartUnitCost = element[7],
                PartUnitPrice = element[9],
                PartsWarehouse = element[12],
                PartsBin = element[15],
                RelatedVINForThisOrder = element[14],

                HeaderId = CrHeaderId,
                Id = Guid.NewGuid(),
            };
            repository.Create(newVEHICLE);

        }
    }
}
