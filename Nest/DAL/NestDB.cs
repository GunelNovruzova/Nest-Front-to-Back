using Microsoft.EntityFrameworkCore;
using Nest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest.DAL
{
    public class NestDB:DbContext
    {
        public NestDB(DbContextOptions<NestDB> options) : base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutImage> AboutImages { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Performances> Performances { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<TeamInfo> TeamInfos { get; set; }
        public DbSet<TeamMembers> TeamMembers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Deals> Deals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NewProducts> NewProducts { get; set; }
        public DbSet<Related> Relateds { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<DealsHome>  DealsHomes { get; set; }
        public DbSet<Selling> Sellings { get; set; }








































    }
}
