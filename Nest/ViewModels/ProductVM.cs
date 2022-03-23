using Nest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
        public List<NewProducts> NewProducts { get; set; }
        public List<Related> Relateds { get; set; }
    }
}
