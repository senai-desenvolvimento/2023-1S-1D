using Microsoft.AspNetCore.Mvc;
using gamer.Infra;
using gamer.Models;


namespace gamer.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [TempData]
        public string Mensagem { get; set; }

        Context c = new Context();

        [Route("Login")]
        public IActionResult Index()
        {
            //disponibiliza o nome do jogador logado na sessão na view
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            //recebe os dados do formulário do login e armazena nas variáveis
            string email = form["Email"].ToString();
            string senha = form["Senha"].ToString();

            //acessa a tabela e faz uma busca passando como parâmetro o email e senha recebidos e armazena em um objeto
            Jogador? jogadorBuscado = c.Jogador.FirstOrDefault(x => x.Email == email && x.Senha == senha);

            //se o objeto buscado existir ele estará logado
            if (jogadorBuscado != null)
            {         
                //abre a sessão armazenando o nome do jogador logado       
                HttpContext.Session.SetString("UserName", jogadorBuscado.Nome!);
                return LocalRedirect("~/");
            }           

            Mensagem = "Dados inválidos!";
            return LocalRedirect("~/Login/Login");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            //remove a sessão do jogador logado
            HttpContext.Session.Remove("UserName");
            return LocalRedirect("~/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}