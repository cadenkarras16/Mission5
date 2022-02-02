using System;
using Microsoft.EntityFrameworkCore;

namespace DateMe.Models
{
    public class DateApplicationContext : DbContext
    {
        //Constructor
       public DateApplicationContext (DbContextOptions<DateApplicationContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Major> Majors { get; set; }


        //seeding the data
        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Major>().HasData(
                new Major { MajorID=1, MajorName="Information Systems"},
                new Major { MajorID=2, MajorName="Ancient Near Eastern Studies: Greek New Testament"},
                new Major { MajorID=3, MajorName="Accounting"},
                new Major { MajorID=4, MajorName="Actuarial Science"},
                new Major { MajorID=5, MajorName="Undeclared"}
            );

            mb.Entity<ApplicationResponse>().HasData(

                  new ApplicationResponse
                  {
                      ApplicationID = 1,
                      FirstName = "Michael",
                      LastName = "Scott",
                      Age = 45,
                      Phone = "555-123-4567",
                      MajorID = 4,
                      CreeperStalker = false

                  },

                  new ApplicationResponse
                  {
                      ApplicationID = 2,
                      FirstName = "Creed",
                      LastName = "Bratton",
                      Age = 90,
                      Phone = "123-555-4567",
                      MajorID = 5,
                      CreeperStalker = true
                  }
             ) ;
        }
    }
}
