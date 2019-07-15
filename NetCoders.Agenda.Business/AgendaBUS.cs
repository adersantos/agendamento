using NetCoders.Agenda.Model;
using NetCoders.Agenda.Repository;
using System;
using System.Collections.Generic;

namespace NetCoders.Agenda.Business
{
    public sealed class AgendaBUS
    {
        private readonly AgendaREP _repository;

        public Action<string, string> _mensagem;

        public AgendaBUS()
        {
            _repository = new AgendaREP();
        }

        public void Inserir(AgendaMOD _model)
        {
            try
            {
                if (_model.Data.Hour < 8 && _model.Data.Hour > 16)
                {
                    _mensagem("A marcação deve ser feita entre 8h e 16h", "erro");
                    return;
                }

                _model.Status = "Agendado";

                _repository.Inserir(_model);
                _mensagem("Evento gravado com sucesso!", "sucesso");
            }
            catch (Exception)
            {
                _mensagem("Ops!, Ocorreu um erro. Entre em contato com o administrador do sistema", "erro");
            }
        }

        public void Cancelar(AgendaMOD _model)
        {
            try
            {
                _model.Status = "Cancelado";
                _repository.Cancelar(_model);
                _mensagem("Evento cancelado com sucesso.", "sucesso");
            }
            catch (Exception)
            {
                _mensagem("Erro ao cancelar Evento. Contate o administrador do sistema", "erro");
            }
        }

        public IEnumerable<AgendaMOD> Listar()
        {
            try
            {
                return _repository.Listar();
            }
            catch (Exception)
            {
                _mensagem("Ops!, Ocorreu um erro. Entre em contato com o administrador do sistema", "erro");
                return null;
            }

        }

        public AgendaMOD Buscar(int id)
        {
            try
            {
                return _repository.Buscar(id);
            }
            catch (Exception)
            {
                _mensagem("Ops!, Ocorreu um erro. Entre em contato com o administrador do sistema", "erro");
                return new AgendaMOD();
            }


        }
    }
}