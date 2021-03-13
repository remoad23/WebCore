using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebCore.Models;

namespace WebCore.Seeder
{
    public class CheckSeeder : ISeeder
    {
        public void Seed(ModelBuilder builder)
        {
            builder.Entity<Check>().HasData(
                new Check
                {
                    CheckId = 1,
                    text = "Placeholder 1",
                    ChecklistId = 1,
                },
                new Check
                {
                    CheckId = 2,
                    text = "Placeholder 2",
                    ChecklistId = 1,
                },
                new Check
                {
                    CheckId = 3,
                    text = "Placeholder 3",
                    ChecklistId = 1,
                },
                new Check
                {
                    CheckId = 4,
                    text = "Placeholder 1",
                    ChecklistId = 2,
                },
                new Check
                {
                    CheckId = 5,
                    text = "Placeholder 2",
                    ChecklistId = 2,
                },
                new Check
                {
                    CheckId = 6,
                    text = "Placeholder 3",
                    ChecklistId = 2,
                },
                new Check
                {
                    CheckId = 7,
                    text = "Placeholder 4",
                    ChecklistId = 2,
                });
        }
    }
}
