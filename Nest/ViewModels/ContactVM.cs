using Nest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.ViewModels
{
    public class ContactVM
    {
        public Contact Contact { get; set; }
        public List<Office> Offices { get; set; }
        public Form Form { get; set; }
    }
}
