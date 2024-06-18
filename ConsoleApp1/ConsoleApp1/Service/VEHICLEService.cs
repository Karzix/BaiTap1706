using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;

namespace ConsoleApp1.Service
{
    public class VEHICLEService
    {
        private GenericRepository<VEHICLE> repository = new GenericRepository<VEHICLE>();

        public void Add(string line,ref Guid CrHeaderId, ref List<VEHICLE> VEHICLEs)
        {
            var element = line.Split(new char[] { ',' }).ToList();
            var newVEHICLE = new VEHICLE
            {
                RepairOrderVIN = element[1],
                DMSMakeCode = element[2],
                ModelYear = element[3],
                VehicleModel = element[4],
                LicenseNumber = element[9],
                DeliveryDate = element[10],
                HeaderId = CrHeaderId,
                Id = Guid.NewGuid(),
            };
            //repository.Create(newVEHICLE);

        }
    }
}
