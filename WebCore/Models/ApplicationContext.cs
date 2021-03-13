using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebCore.Seeder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebCore.Models 
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        /**
         * Seed tables with data and give relationships
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ChecklistSeeder cs = new ChecklistSeeder();
            CheckSeeder qs = new CheckSeeder();
            UserSeeder us = new UserSeeder();

            Check.InitRelationships(modelBuilder);
            User.InitRelationships(modelBuilder);
            Checklist.InitRelationships(modelBuilder);

            cs.Seed(modelBuilder);
            qs.Seed(modelBuilder);
            us.Seed(modelBuilder);
        }

        public override DbSet<User> Users { get; set; }
        public DbSet<Checklist> CheckLists { get; set; }
        public DbSet<Check> Checks { get; set; }

    }
}
