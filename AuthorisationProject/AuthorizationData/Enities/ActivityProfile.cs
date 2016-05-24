using AuthorizationData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Authorization = AuthorizationData.Entities.Authorization;

namespace AuthorizationData.Enities
{
    public class ActivityProfile
    {
        public ActivityProfile()
        {
            Authorizations = new HashSet<Authorization>();
        }

        public int Id { get; set; }

        public string Activity { get; set; }

        public virtual ICollection<Authorization> Authorizations { get; set; }
    }
}
