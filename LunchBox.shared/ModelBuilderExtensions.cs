using LunchBox.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SeedUser(this ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Fullname = "Thusi Selvaratnam",
                    UserName = "admin",
                    CreatedTime = DateTime.Now,
                    Active = 1,
                    City = "Struer",
                    LastModifiedTime = DateTime.Now,
                    Password = "password",
                    ZipCode = "7600",
                    Street = "Kjelding Høj 10",
                    Phone = "23469055",
                    Role = Role.SuperAdmin,
                    Newsletter = 0,
                }
            );
            */
        }
    }
}
