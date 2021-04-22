using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenIdConectBlazor.Server.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ingreso de dataos de manera manual add-migration, update-database
            //var roleAdmin = new IdentityRole()
            //{ Id = "9883f1bb-4da7-4421-8aca-1ef40839bef4", Name = "admin", NormalizedName = "admin" };
            //modelBuilder.Entity<IdentityRole>().HasData(roleAdmin);
            //base.OnModelCreating(modelBuilder);
            //var roleStudent = new IdentityRole()
            //{ Id = "7679eaaf-26e3-41b8-acfe-1ab21a645619", Name = "student", NormalizedName = "student" };
            //modelBuilder.Entity<IdentityRole>().HasData(roleStudent);
            //base.OnModelCreating(modelBuilder);
            //var roleTeacher = new IdentityRole()
            //{ Id = "8c2e1b6f-50c6-488a-9930-0e6009be3133", Name = "teacher", NormalizedName = "teacher" };
            //modelBuilder.Entity<IdentityRole>().HasData(roleTeacher);
            //base.OnModelCreating(modelBuilder);
        }
    }
}
