using NetCoders.Aenda.Business;
using NetCoders.Agenda.UI.Web.Models;
using System.Web.Mvc;

namespace NetCoders.Agenda.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteBUS business_;
        private static ClienteVM _viewModel;

        public ClienteController()
        {
            business_ = new ClienteBUS();
            _viewModel = new ClienteVM { Clientes = business_.Listar() };
            business_._mensagem += (msg_, tipo_) => CriarTempData(msg_, tipo_);
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

        public ViewResult Detalhes(int id)
        {
            _viewModel.Cliente = business_.Buscar(id);

            return View(_viewModel);
        }

        public ActionResult Inserir(ClienteVM _model)
        {
            business_.Inserir(_model.Cliente);
            return RedirectToAction("Listar");
        }
    }
}
