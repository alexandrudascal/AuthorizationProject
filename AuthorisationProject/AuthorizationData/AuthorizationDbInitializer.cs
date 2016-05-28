using AuthorizationData.Enities;
using AuthorizationData.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace AuthorizationData
{
    class AuthorizationDbInitializer : CreateDatabaseIfNotExists<AuthorizationDbContext>
    {
        protected override void Seed(AuthorizationDbContext context)
        {
            base.Seed(context);
            var subdivision = new Subdivision
            {
                Id = 1,
                Name = "SA Cimislia",
                Phone = "068753456",
                LeaderFirstName = "Vasile",
                LeaderLastName = "Popa",
            };

            context.Subdivisions.Add(subdivision);

            var agent = new Agent
            {
                Id = 1,
                Name = "Tudor Trandafir",
                Address = "str.Uzinelor",
                Phone = "068345678"
            };

            context.Agents.Add(agent);

            var authorization = new Authorization
            {
                Id = 1,
                ASVF = "12344FRD34F43DWP5",
                EliberationDate = DateTime.Now.Date,
                ExpireDate = new DateTime(2013, 3, 4),
                AuthorizatedObjectName = "SA Bordei",
                AuthorizatedObjectAddress = "Str.Stefan Cel Mare",
                AuthorizatedObjectPhone = "079543478",
                SubdivisionId = 1,
                AgentId = 1,
            };

            context.Authorizations.Add(authorization);

            //var subdivision1 = new Subdivision
            //{
            //    Id = 2,
            //    Name = "SA Chisinau",
            //    Phone = "068753456",
            //    LeaderFirstName = "Vaseile",
            //    LeaderLastName = "Popa",
            //};

            //context.Subdivisions.Add(subdivision1);

            //var agent1 = new Agent
            //{
            //    Id = 2,
            //    Name = "Vasea Trandafir",
            //    Address = "str.Uzinelor",
            //    Phone = "4235312"
            //};

            //context.Agents.Add(agent1);

            //var authorization1 = new Authorization
            //{
            //    Id = 2,
            //    ASVF = "sadsaas",
            //    EliberationDate = DateTime.Now.Date,
            //    ExpireDate = new DateTime(2013, 3, 4),
            //    AuthorizatedObjectName = "SA Bordei",
            //    AuthorizatedObjectAddress = "Str.Stefan Cel Mare",
            //    AuthorizatedObjectPhone = "435324",
            //    SubdivisionId = 2,
            //    AgentId = 2

            //};

            //context.Authorizations.Add(authorization1);

            var activitiesList = new List<ActivityProfile>
            {
                new ActivityProfile {Activity = Activity.Abataj },
                new ActivityProfile {Activity = Activity.Achizitionare },
                new ActivityProfile {Activity = Activity.ComercializareAnimalelor },
                new ActivityProfile {Activity = Activity.Distribuire },
                new ActivityProfile {Activity = Activity.Fabricare },
                new ActivityProfile {Activity = Activity.Pastrare },
                new ActivityProfile {Activity = Activity.Preluare },
                new ActivityProfile {Activity = Activity.ProduseAlimentare },
                new ActivityProfile {Activity = Activity.Transport }
            };

            foreach (var item in activitiesList)
            {
                context.ActivityProfiles.Add(item);
            }

            context.SaveChanges();
        }
    }
}
