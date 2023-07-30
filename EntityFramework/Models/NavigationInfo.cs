using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class NavigationInfo
    {
        public string? Id { get; set; }
        public bool HasStandings { get; set; }
        public bool IsKnockout { get; set; }
    }
}
