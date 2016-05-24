using AuthorizationData.Enities;
using AuthorizationData.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationData
{

    public class AuthorizationDbContext : DbContext
    {
        public AuthorizationDbContext()
        {
            Database.SetInitializer(new AuthorizationDbInitializer());
        }

        public DbSet<Authorization> Authorizations { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<ActivityProfile> ActivityProfiles { get; set; }
    }

}
