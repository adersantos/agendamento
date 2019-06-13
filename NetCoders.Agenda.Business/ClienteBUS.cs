using NetCoders.Agenda.Model;
using NetCoders.Agenda.Repository;
using System;
using System.Collections.Generic;

namespace NetCoders.Aenda.Business
{
    public class ClienteBUS
    {
        private readonly ClienteREP repository_;

        public Action<string, string> _mensagem;

        public ClienteBUS()
        {
            repository_ = new ClienteREP();
        }

        public void Inserir(ClienteMOD _model)
        {
            try
            {
                repository_.Inserir(_model);
                _mensagem("Clliente gravado com sucesso!", "sucesso");
            }
            catch (Exception)
            {
                _mensagem("Ops!, Ocorreu um erro. Entre em contato com o administrador do sistema", "erro");
            }
        }

        public IEnumerable<ClienteMOD> Listar()
        {
            try
            {
                return repository_.Listar();
            }
            catch (Exception)
            {
                _mensagem("Ops!, Ocorreu um erro. Entre em contato com o administrador do sistema", "erro");
                return null;
            }

        }

        public ClienteMOD Buscar(int id)
        {
            try
            {
                return repository_.Buscar(id);
            }
            catch (Exception)
            {
                _mensagem("Ops!, Ocorreu um erro. Entre em contato com o administrador do sistema", "erro");
                return new ClienteMOD();
            }


        }
    }
}
