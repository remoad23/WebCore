using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebCore.Models
{
    public class Check
    {
        // Properties
        public int CheckId { get; set; }
        public int ChecklistId { get; set; }
        public string text { get; set; }

        // Entities
        [ForeignKey("ChecklistId")]
        public virtual Checklist Checklist { get; set; }

        public static void InitRelationships(ModelBuilder modelBuilder)
        {

        }
    }


}
