using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationData.Entities
{
    public class Subdivision
    {
        public Subdivision()
        {
            Authorizations = new HashSet<Authorization>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string LeaderFirstName { get; set; }

        public string LeaderLastName { get; set; }

        public virtual ICollection<Authorization> Authorizations { get; set; }
    }
}
