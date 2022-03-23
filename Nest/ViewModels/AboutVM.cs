using Nest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.ViewModels
{
    public class AboutVM
    {
        public About About { get; set; }
        public List<Provider> Providers { get; set; }
        //public List<Performances> Performances { get; set; }
        public Performances Performances { get; set; }
        public List<History> Histories { get; set; }
        public TeamInfo TeamInfos { get; set; }
        public List<TeamMembers> TeamMembers { get; set; }
       
    }
}
