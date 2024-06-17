using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.data
{
    public class ApplicationDBContext : DbContext 
    {
        public ApplicationDBContext()
        {

        }
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<IDENT> identifiers { get; set; }
        public DbSet<HEADER> header { get; set; }
        public DbSet<VEHICLE> vehicle { get; set; }
        public DbSet<CUSTOMER> customer { get; set; }
        public DbSet<CONTACT> contact { get; set; }
        public DbSet<PRIVACY> privacy { get; set; }
        public DbSet<CCR> CCR { get; set; }
        public DbSet<CONTACT> Contact { get; set; }
        public DbSet<JOB> job { get; set; }
        public DbSet<LABORLINE> laborline { get; set; }
        public DbSet<MISC> misc { get; set; }
        public DbSet<PARTLINE> partline { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-TMN6UG6G;Initial Catalog=BaiTap1706;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
