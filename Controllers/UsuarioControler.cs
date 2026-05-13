using Microsoft.AspNetCore.Mvc;
using Segundo_App_BancoDados.Models;
using Segundo_App_BancoDados.Repository;
using Segundo_App_BancoDados.Repository.Contract;

namespace segundo_App_BancoDados.Controllers
{
    public class UsuarioControler : Controller
    {
        private IUsuarioRepository _usuarioRepository;
        public UsuarioControler(IUsuarioRepository usuariorepository)
        {
            _usuarioRepository = usuariorepository;
        }

        public IActionResult Index()

        {

            return View();
        }

        public IActionResult CadastrarUsuario()
        {

            return View();
        }
        [httpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepository.Cadastrar(usuario);
                return RedirectToAction("index");
            }
            return View();
        }
    }



}
