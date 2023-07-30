using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Meta
    {
        public string? Id { get; set; }
        public long UpdateId { get; set; }
        public bool UpdateIdSpecified { get; set; }
        public string? UpdateAction { get; set; }
        public DateTime UpdateDate { get; set; }
        public string? Language { get; set; }
    }
}
