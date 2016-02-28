using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Zolla.Data.Entities;

namespace Zolla.Web.Infrastructure
{
    public class ZollaDbContext:DbContext
    {
        public ZollaDbContext():base("Zolla")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }

        //Можно сделать настройку Fluent API но тут используем DataAnotation (одновременно не рекомендуется использовать два подхода)
    }
}