using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebCore.Models;

namespace WebCore.Seeder
{
    public class ChecklistSeeder : ISeeder
    {
        public void Seed(ModelBuilder builder)
        {
            builder.Entity<Checklist>().HasData(
                new Checklist
                {
                    ChecklistId = 1,
                    name = "checklist1",
                },
                new Checklist
                {
                    ChecklistId = 2,
                    name = "checklist2",
                });
        }
    }
}
