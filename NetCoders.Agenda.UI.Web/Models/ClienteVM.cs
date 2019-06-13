using NetCoders.Agenda.Model;
using System.Collections.Generic;

namespace NetCoders.Agenda.UI.Web.Models
{
    public class ClienteVM
    {
        public ClienteMOD Cliente { get; set; }
        public IEnumerable<ClienteMOD> Clientes { get; set; }
    }
}