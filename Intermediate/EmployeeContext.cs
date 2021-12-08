using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
   public class EmployeeContext:DbContext
    {

        public EmployeeContext(DbContextOptions<EmployeeContext> context):base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<EmployeeQualification>().HasOne<Employee>(s => s.Employee).WithMany(s => s.EmployeeQualifications);
           
            var employee = modelBuilder.Entity<Employee>();
              employee.Property(e => e.EntryDate).HasDefaultValue(DateTime.Now);
            employee.Property(e => e.id).HasDefaultValue(Guid.NewGuid());
            employee.Property(e => e.Gender).HasConversion<string>();
            employee.Property(e => e.DOB).HasColumnType("Date");
            modelBuilder.Entity<EmployeeQualification>().HasKey(l => new { l.EmployeeId, l.QualificationListId });





        }

       

        public DbSet<Employee>  Employees { get; set; }

        public DbSet<QualificationList> QualificationLists { get; set; }


        public DbSet<EmployeeQualification> EmployeeQualifications { get; set; }
    }
}
