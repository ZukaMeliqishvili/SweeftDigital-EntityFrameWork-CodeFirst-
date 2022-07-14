using EntityFrameWorkApplication.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkApplication
{
    internal class ApplicationDbContext:DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Pupil>  Pupils { get; set; }
        public DbSet<PupilTeacherRel> PupilTeacherRels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-01OQQMQ\SQLEXPRESS;Database=SweeftDigital;Trusted_Connection=True;");
        }
    }
}
