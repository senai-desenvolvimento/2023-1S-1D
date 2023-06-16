using gamer.Infra;
using gamer.Models;
using Microsoft.AspNetCore.Mvc;

namespace gamer.Controllers
{
    [Route("Equipe")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }
        
        [TempData]
        public string Mensagem { get; set; }
       
        Context c = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            ViewBag.Equipe = c.Equipe.ToList();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            
            if (form["Nome"].ToString().Trim().Length == 0)
            {             
                return LocalRedirect("~/Equipe/Listar");
            }
            else
            {
                Equipe novaEquipe = new Equipe();

                novaEquipe.Nome = form["Nome"].ToString();

                if (form.Files.Count > 0)
                {
                    var file = form.Files[0];
                    var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    novaEquipe.Imagem = file.FileName;
                }
                else
                {
                    novaEquipe.Imagem = "padrao.png";
                }

                c.Add(novaEquipe);
                c.SaveChanges();
                ViewBag.Equipe = c.Equipe.ToList();

            }

            return LocalRedirect("~/Equipe/Listar");

        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            Equipe equipe = c.Equipe.FirstOrDefault(e => e.IdEquipe == id)!;
            c.Remove(equipe);
            c.SaveChanges();
            return LocalRedirect("~/Equipe/Listar");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            novaEquipe.Nome = form["Nome"].ToString();

            //upload da imagem na equipe nova(atualizada)
            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }


            Equipe equipeBuscada = c.Equipe.First(x => x.IdEquipe == novaEquipe.IdEquipe);

            equipeBuscada.Nome = novaEquipe.Nome;
            equipeBuscada.Imagem = novaEquipe.Imagem;

            c.Equipe.Update(equipeBuscada);

            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }


        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            Equipe equipe = c.Equipe.First(x => x.IdEquipe == id);

            ViewBag.Equipe = equipe;

            return View("Edit");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}