using Nest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.ViewModels
{
    public class ShopVM
    {
        public List<Shop> Shops { get; set; }
        public List<Deals> Deals { get; set; }
    }
}
