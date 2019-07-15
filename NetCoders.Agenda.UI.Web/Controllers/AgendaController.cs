﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetCoders.Agenda.Model;
using NetCoders.Agenda.UI.Web.Models;
using NetCoders.Agenda.Business;

namespace NetCoders.Agenda.UI.Web.Controllers
{
    public class AgendaController : Controller
    {
        private readonly AgendaBUS _business;
        private static AgendaVM _viewModel;

        public AgendaController()
        {
            _business = new AgendaBUS();
            _viewModel = new AgendaVM { Agendas = _business.Listar() };
            _business._mensagem += (msg_, tipo_) => CriarTempData(msg_, tipo_);
        }

        [NonAction]
        private void CriarTempData(string msg_, string tipo_)
        {
            TempData[tipo_] = msg_;
        }

        public ViewResult Listar()
        {
            return View(_viewModel);
        }

        public ViewResult Cadastrar()
        {
            return View();
        }

        public ActionResult Cancelar(AgendaVM _model)
        {
            _business.Cancelar(_model.Agenda);
            return RedirectToAction("Listar");
        }

        public ViewResult Detalhes(int id)
        {
            _viewModel.Agenda = _business.Buscar(id);

            return View(_viewModel);
        }

        public ActionResult Inserir(AgendaVM _model)
        {
            _business.Inserir(_model.Agenda);
            return RedirectToAction("Listar");
        }
    }
}