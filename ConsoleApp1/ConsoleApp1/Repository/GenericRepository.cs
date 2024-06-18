using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.data;
using EFCore.BulkExtensions;

namespace ConsoleApp1.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private ApplicationDBContext _context = new ApplicationDBContext();

        //public GenericRepository(ApplicationDBContext context)
        //{
        //    _context = context;
        //}
        public void Create(TEntity item)
        {
            if (item != null)
            {
                _context.Add(item);
                _context.SaveChanges();
            }
        }


        public void Delete(TEntity entity)
        {
            if (entity != null)
            {
                _context.Attach(entity);
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }

        public void Edit(TEntity entity)
        {
            if (entity != null)
            {
                _context.Update(entity);
                _context.SaveChanges();
            }
        }

        public void BulkInsert(List<TEntity> entities) 
        { 
           _context.BulkInsert(entities, new BulkConfig { BatchSize = 200 } );
        }
    }
}
