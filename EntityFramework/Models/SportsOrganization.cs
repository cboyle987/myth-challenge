using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class SportsOrganization
    {
        public string SportsOrganizationId { get; set; } = null!;
        public string EventDataId { get; set; } = null!;
    }
}
