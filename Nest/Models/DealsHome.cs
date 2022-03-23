using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nest.Models
{
    public class DealsHome
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(1000)]
        public string Title { get; set; }
        public double Price { get; set; }

    }
}
