using NetCoders.Agenda.Model;
using System;
using System.Collections.Generic;

namespace NetCoders.Agenda.Repository
{
    public sealed class AgendaREP
    {
        private List<AgendaMOD> DataBase { get; set; }

        public void Inserir(AgendaMOD _model)
        {
            DataBase.Add(_model);
        }

        public IEnumerable<AgendaMOD> Listar()
        {
            var lstAgenda = new List<AgendaMOD>();

            lstAgenda.Add(new AgendaMOD
            {
                Codigo = 1,
                Cliente = 1,
<<<<<<< HEAD
                Titulo = "ABCD",
                DescricaoSimples = "ABCDescrição simples",
                DescricaoCompleta = "ABCDescrição Completa",
=======
                Titulo = "",
                DescricaoSimples = "",
                DescricaoCompleta = "",
>>>>>>> 199b448c761e984def3565897bfc271d2d9a1f5a
                Data = DateTime.Now,
                Gravado = DateTime.Now,
                Status = string.Empty
            });

            return lstAgenda;
        }

        public AgendaMOD Buscar(int id)
        {
            var query = DataBase.Find(x => x.Codigo == id);

            return new AgendaMOD
            {
                Codigo = query.Codigo,
                Cliente = query.Cliente,
                Titulo = query.Titulo,
                DescricaoSimples = query.DescricaoSimples,
                DescricaoCompleta = query.DescricaoCompleta,
                Data = query.Data,
                Gravado = query.Gravado,
                Status = query.Status
            };
        }

        public void Cancelar(AgendaMOD model)
        {
            model.Status = "Cancelado";
        }
    }
}
