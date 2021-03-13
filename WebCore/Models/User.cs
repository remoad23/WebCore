using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WebCore.Models
{
    public class User : IdentityUser
    {

        // Entities

        public static void InitRelationships(ModelBuilder modelBuilder)
        {
        //    modelBuilder.Entity<User>()
          //      .HasMany(b => b.Posts)
            //    .WithOne();
        }
    }
}
