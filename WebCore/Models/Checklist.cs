using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebCore.Models
{
    public class Checklist
    {
        // Properties
        public int ChecklistId { get; set; }
        public string name { get; set; }


        // Entitys
        public virtual ICollection<Check> Checks { get; set; }

        public static void InitRelationships(ModelBuilder modelBuilder)
    {
          //  modelBuilder.Entity<Checklist>()
           // .HasMany(b => b.Posts)
            //    .WithOne();
    }

    }

    
}
