using Nest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.ViewModels
{
    public class HomeVM
    {
        public List<Home> Homes { get; set; }
        public List<DealsHome>  DealsHomes { get; set; }
    }
}
