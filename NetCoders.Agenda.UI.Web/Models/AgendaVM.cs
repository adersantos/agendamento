using NetCoders.Agenda.Model;
using System.Collections.Generic;

namespace NetCoders.Agenda.UI.Web.Models
{
    public sealed class AgendaVM
    {
        public AgendaMOD Agenda { get; set; }
        public IEnumerable<AgendaMOD> Agendas { get; set; }
    }
}