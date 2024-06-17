using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;

namespace ConsoleApp1.Service
{
    public class IDENTService
    {
        private GenericRepository<IDENT> repository = new GenericRepository<IDENT>();

        public void Add(string line, ref Guid identID)
        {
            var element = line.Split(new char[] { ',' }).ToList();
            var newIDENT = new IDENT();
            newIDENT.Id = Guid.NewGuid();
            newIDENT.DateCreate = element[4];
            newIDENT.TimeCreate = element[5];
            newIDENT.DealerNumber = element[6];
            newIDENT.Make = element[7];
            newIDENT.Store = element[8];
            newIDENT.Version = element[9];
            //newIDENT.RecordIdentifier = element[0];
            repository.Create(newIDENT);

            identID = newIDENT.Id;
        }

    }
}
