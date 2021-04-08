using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace simpleapps.Models
{
    [Table("shopping")]
    public class shopping
    {
        [Key, Required]
        public string id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
