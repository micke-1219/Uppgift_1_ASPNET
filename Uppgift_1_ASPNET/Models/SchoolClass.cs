using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Uppgift_1_ASPNET.Data;

namespace Uppgift_1_ASPNET.Models
{
    public class SchoolClass
    {
        [Key]
        [Required]
        public string Id { get; set; }

        public ApplicationUser Teacher { get; set; }

        public virtual ICollection<ApplicationUser> Students { get; set; }
    }
}
