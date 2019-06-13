using NetCoders.Agenda.Model;
using System.Collections.Generic;
using System.Linq;

namespace NetCoders.Agenda.Repository
{
    public class ClienteREP
    {

        private List<ClienteMOD> _lstClientes;

        public void Inserir(ClienteMOD _model)
        {
            var tbCliente = new ClienteMOD
            {
                Id = _model.Id,
                Nome = _model.Nome,
                Sobrenome = _model.Sobrenome,
                Documento = _model.Documento,
                Celular = _model.Celular,
                Endereco = _model.Endereco
            };

            _lstClientes.Add(tbCliente);
        }

        public IEnumerable<ClienteMOD> Listar()
        {
            return _lstClientes.ToList().ConvertAll(m => new ClienteMOD
            {
                Id = m.Id,
                Nome = m.Nome,
                Sobrenome = m.Sobrenome,
                Celular = m.Celular,
                Documento = m.Documento,
                Endereco = m.Endereco
            });
        }

        public ClienteMOD Buscar(int id)
        {
            return Listar().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
