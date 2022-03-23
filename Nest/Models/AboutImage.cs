using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Nest.Models
{
    public class AboutImage
    {
        public int Id { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        public int AboutId { get; set; }
        public About About { get; set; }
    }
}
