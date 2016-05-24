using System.Collections.Generic;
using System.Net;

namespace AuthorizationData.Entities
{
    public class Agent
    {
        public Agent()
        {
            Authorizations = new HashSet<Authorization>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Authorization> Authorizations { get; set; }
    }
}