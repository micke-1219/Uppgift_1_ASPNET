using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uppgift_1_ASPNET.Data;

namespace Uppgift_1_ASPNET.Models
{
    public class EditSchoolClassViewModel
    {
        public SchoolClass CurrentClass { get; set; }
        public IEnumerable<ApplicationUser> Teachers { get; set; }
        public IEnumerable<ApplicationUser> Students { get; set; }
    }
}
