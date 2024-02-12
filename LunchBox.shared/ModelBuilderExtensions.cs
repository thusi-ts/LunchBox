using LunchBox.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SeedSettings(this ModelBuilder modelBuilder, IConfiguration configuration1)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()) // Set the path to your project directory
            .AddJsonFile("appsettings.json") // Load the appsettings.json file
            .Build();

            // Access configuration settings using the IConfiguration instance
            var superAdminEmail = configuration.GetSection("SecuritySettings:SuperAdminEmail").Value;
            var superAdminPassword = configuration.GetSection("SecuritySettings:SuperAdminPassword").Value;
            var visitorEmail = configuration.GetSection("SecuritySettings:VisitorEmail").Value;
            var visitorPassword = configuration.GetSection("SecuritySettings:VisitorPassword").Value;

            var userSuperId = Guid.NewGuid().ToString();
            var userVisitorId = Guid.NewGuid().ToString();
            var roleSuperId = Guid.NewGuid().ToString();
            var roleVisitorId = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<User>();

            // Api project don't have SecuritySettings
            if (superAdminEmail != null && superAdminPassword != null)
            {
                modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = userSuperId,
                        UserName = superAdminEmail,
                        NormalizedUserName = superAdminEmail.ToUpper(),
                        Email = superAdminEmail,
                        NormalizedEmail = superAdminEmail.ToUpper(),
                        PasswordHash = hasher.HashPassword(null, superAdminPassword),
                        LockoutEnabled = true,
                    }
                );

                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole() { Id = roleSuperId, Name = RolesStore.SuperAdministrator, NormalizedName = RolesStore.SuperAdministrator.ToUpper() });
                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = RolesStore.Administrator, NormalizedName = RolesStore.Administrator.ToUpper() });
                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = RolesStore.CompanyAdministrator, NormalizedName = RolesStore.CompanyAdministrator.ToUpper() });
                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = RolesStore.Customer, NormalizedName = RolesStore.Customer.ToUpper() });
                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole() { Id = roleVisitorId, Name = RolesStore.Visitor, NormalizedName = RolesStore.Visitor.ToUpper() });
                modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>() { RoleId = roleSuperId, UserId = userSuperId }
                );
            }
            if (visitorEmail != null && visitorPassword != null)
            { 
                modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = userVisitorId,
                        UserName = visitorEmail,
                        NormalizedUserName = visitorEmail.ToUpper(),
                        Email = visitorEmail,
                        NormalizedEmail = visitorEmail.ToUpper(),
                        PasswordHash = hasher.HashPassword(null, visitorPassword),
                        LockoutEnabled = true,
                    }
                );

                modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>() { RoleId = roleVisitorId, UserId = userVisitorId }
                );
            }
        }
    }
}
