using AuthorizationData.Enities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorizationData.Entities
{
    public class Authorization
    {
        public Authorization()
        {
            ActivityProfiles = new HashSet<ActivityProfile>();
        }

        public int Id { get; set; }
        public string ASVF { get; set; }
        public DateTime EliberationDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string AuthorizatedObjectName { get; set; }
        public string AuthorizatedObjectPhone { get; set; }
        public string AuthorizatedObjectAddress { get; set; }
            
        [ForeignKey(nameof(Subdivision))]
        public int SubdivisionId { get; set; }

        [ForeignKey(nameof(Agent))]
        public int AgentId { get; set; }

        public Subdivision Subdivision { get; set; }
        public Agent Agent { get; set; }
        public virtual ICollection<ActivityProfile> ActivityProfiles { get; set; }
       
    }
}
