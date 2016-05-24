using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationUI
{
    class AuthorisationModel
    {
        [DisplayName("ASVF")]
        public string ASVF { get; set; }

        [DisplayName("Agent Economic")]
        public string AgentName { get; set; }

        [DisplayName("Adresa agent Economic")]
        public string AgentAddress { get; set; }

        [DisplayName("Telefon agent Economic")]
        public string AgentPhone { get; set; }

        [DisplayName("Obiect Autorizat")]
        public string AuthorzatedObjectName { get; set; }

        [DisplayName("Adresa obiect autorizat")]
        public string AuthorizatedObjectAddress { get; set; }

        [DisplayName("Telefon obiect autrizat")]
        public string AuthorizatedObjectPhone { get; set; }

        [DisplayName("Subdiviziune")]
        public string SubdivisionName { get; set; }

        [DisplayName("Data Eliberarii")]
        public DateTime EliberationDate { get; set; }

        [DisplayName("Data Expirarii")]
        public DateTime ExpirationDate { get; set; }

        [DisplayName("Profilul Activitatii")]
        public string Activities { get; set; }

    }
}
