using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using demo.Models;

namespace demo.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext (DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<demo.Models.Employee> Employee { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Employee
            modelBuilder.Entity<Employee>().HasData(
                new Employee 
                { 
                    Id = 1,
                    Title = "Mr.",
                    FirstName = "John",
                    LastName = "Heart",
                    BirthDate = new DateTime(1964, 3, 16),
                    Position = "CEO",
                    HireDate = new DateTime(1995, 1, 15),
                    State = "California",
                    Notes = "Company founder and visionary leader with over 25 years of experience",
                    HomeAddress = "1234 Executive Way, Los Angeles, CA 90210"
                },
                new Employee 
                { 
                    Id = 2,
                    Title = "Mrs.",
                    FirstName = "Olivia",
                    LastName = "Peyton",
                    BirthDate = new DateTime(1981, 6, 3),
                    Position = "Sales Assistant",
                    HireDate = new DateTime(2012, 5, 14),
                    State = "California",
                    Notes = "Dedicated sales professional with excellent customer service skills",
                    HomeAddress = "567 Sunset Boulevard, San Francisco, CA 94102"
                },
                new Employee 
                { 
                    Id = 3,
                    Title = "Mr.",
                    FirstName = "Robert",
                    LastName = "Reagan",
                    BirthDate = new DateTime(1974, 9, 7),
                    Position = "CMO",
                    HireDate = new DateTime(2002, 11, 8),
                    State = "Arkansas",
                    Notes = "Strategic marketing leader specializing in digital transformation",
                    HomeAddress = "890 Marketing Drive, Little Rock, AR 72201"
                },
                new Employee 
                { 
                    Id = 4,
                    Title = "Ms.",
                    FirstName = "Greta",
                    LastName = "Sims",
                    BirthDate = new DateTime(1977, 11, 22),
                    Position = "HR Manager",
                    HireDate = new DateTime(1998, 4, 23),
                    State = "Georgia",
                    Notes = "Experienced HR professional focused on employee development and retention",
                    HomeAddress = "123 Peachtree Street, Atlanta, GA 30309"
                },
                new Employee 
                { 
                    Id = 5,
                    Title = "Mr.",
                    FirstName = "Brett",
                    LastName = "Wade",
                    BirthDate = new DateTime(1968, 12, 1),
                    Position = "IT Manager",
                    HireDate = new DateTime(2009, 3, 6),
                    State = "Idaho",
                    Notes = "Technology infrastructure specialist with expertise in cloud solutions",
                    HomeAddress = "456 Technology Lane, Boise, ID 83702"
                },
                new Employee 
                { 
                    Id = 6,
                    Title = "Mrs.",
                    FirstName = "Sandra",
                    LastName = "Johnson",
                    BirthDate = new DateTime(1974, 11, 15),
                    Position = "Controller",
                    HireDate = new DateTime(2005, 5, 11),
                    State = "Utah",
                    Notes = "Financial control expert with CPA certification and audit experience",
                    HomeAddress = "789 Financial Way, Salt Lake City, UT 84101"
                },
                new Employee 
                { 
                    Id = 7,
                    Title = "Mr.",
                    FirstName = "Kevin",
                    LastName = "Carter",
                    BirthDate = new DateTime(1978, 1, 9),
                    Position = "Shipping Manager",
                    HireDate = new DateTime(2009, 8, 11),
                    State = "California",
                    Notes = "Logistics coordination specialist with supply chain optimization skills",
                    HomeAddress = "321 Shipping Street, San Diego, CA 92101"
                },
                new Employee 
                { 
                    Id = 8,
                    Title = "Ms.",
                    FirstName = "Cynthia",
                    LastName = "Stanwick",
                    BirthDate = new DateTime(1985, 6, 5),
                    Position = "HR Assistant",
                    HireDate = new DateTime(2008, 3, 24),
                    State = "Arkansas",
                    Notes = "Detail-oriented HR support specialist with recruitment expertise",
                    HomeAddress = "654 Human Resources Blvd, Fayetteville, AR 72703"
                },
                new Employee 
                { 
                    Id = 9,
                    Title = "Dr.",
                    FirstName = "Kent",
                    LastName = "Samuelson",
                    BirthDate = new DateTime(1972, 9, 11),
                    Position = "Ombudsman",
                    HireDate = new DateTime(2009, 4, 22),
                    State = "Missouri",
                    Notes = "PhD in Organizational Psychology, employee relations specialist",
                    HomeAddress = "987 Mediation Avenue, Kansas City, MO 64108"
                },
                new Employee 
                { 
                    Id = 10,
                    Title = "Mr.",
                    FirstName = "Taylor",
                    LastName = "Riley",
                    BirthDate = new DateTime(1982, 8, 14),
                    Position = "Network Admin",
                    HireDate = new DateTime(2012, 4, 14),
                    State = "California",
                    Notes = "Network infrastructure specialist with cybersecurity certifications",
                    HomeAddress = "147 Network Drive, Sacramento, CA 95814"
                },
                new Employee 
                { 
                    Id = 11,
                    Title = "Mr.",
                    FirstName = "Sam",
                    LastName = "Hill",
                    BirthDate = new DateTime(1984, 2, 17),
                    Position = "Sales Assistant",
                    HireDate = new DateTime(2012, 2, 1),
                    State = "Georgia",
                    Notes = "Customer relationship specialist with strong communication skills",
                    HomeAddress = "258 Sales Circle, Savannah, GA 31401"
                },
                new Employee 
                { 
                    Id = 12,
                    Title = "Ms.",
                    FirstName = "Kelly",
                    LastName = "Rodriguez",
                    BirthDate = new DateTime(1988, 5, 11),
                    Position = "Support Assistant",
                    HireDate = new DateTime(2012, 10, 13),
                    State = "California",
                    Notes = "Technical support specialist with multilingual customer service skills",
                    HomeAddress = "369 Support Street, Fresno, CA 93701"
                },
                new Employee 
                { 
                    Id = 13,
                    Title = "Mrs.",
                    FirstName = "Natalie",
                    LastName = "Maguire",
                    BirthDate = new DateTime(1977, 10, 7),
                    Position = "Trainer",
                    HireDate = new DateTime(2008, 6, 19),
                    State = "Nevada",
                    Notes = "Corporate training specialist with adult education certification",
                    HomeAddress = "741 Training Boulevard, Las Vegas, NV 89101"
                },
                new Employee 
                { 
                    Id = 14,
                    Title = "Mr.",
                    FirstName = "Walter",
                    LastName = "Hobbs",
                    BirthDate = new DateTime(1984, 12, 24),
                    Position = "Programmer",
                    HireDate = new DateTime(2011, 2, 17),
                    State = "Idaho",
                    Notes = "Full-stack developer with expertise in modern web technologies",
                    HomeAddress = "852 Developer Lane, Meridian, ID 83642"
                }
            );
        }
    }
}
