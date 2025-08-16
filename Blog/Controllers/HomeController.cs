using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Blog.Models;

namespace Blog.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Categoria tecnologia = new ();
        tecnologia.Id = 1;
        tecnologia.Nome = "Tecnologia";
        Categoria ia = new()
        {
            Id = 2,
            Nome = "IA"
        };

        Categoria webnovel = new ()
        {
            Id = 3,
            Nome = "Webnovel"
        };
        
        Categoria anime = new ()
        {
            Id = 4,
            Nome = "Anime"
        };
        
        Categoria hq = new ()
        {
            Id = 5,
            Nome = "Hq"
        };
        Categoria serie = new ()
        {
            Id = 6,
            Nome = "Série"
        };
        
        List<Postagem> postagens = [
            new () {
                Id = 1,
                Nome = "Saiu o ChatGPT 5",
                CategoriaId = 2,
                Categoria = ia,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "  dsf g~kfdgoijads ao",
                Texto = " sdlkjslk fklsdj",
                Thumbnail = "/img/1.png",
                Foto = "/img/1.png"
            },
            new () {
                Id = 3,
                Nome = "Lord of Mysteries",
                CategoriaId = 3,
                Categoria = webnovel,
                DataPostagem = DateTime.Parse("13/08/2025"),
                Descricao = "Lord of the Mysteries é uma webnovel chinesa de fantasia e mistério",
                Texto = " A história segue Klein Moretti, que acorda em um mundo desconhecido<br> e se vê envolvido em uma sociedade secreta que lida com poderes místicos, artefatos selados e a busca por se tornar um Beyonder.",
                Thumbnail = "/img/3.png",
                Foto = "/img/3.png"
            },
            new () {
                Id = 4,
                Nome = "Naruto",
                CategoriaId = 4,
                Categoria = anime,
                DataPostagem = DateTime.Parse("13/08/2025"),
                Descricao = " Naruto é um anime e manga sobre ninjas",
                Texto = "Naruto é um anime e mangashonen que conta a história de Naruto Uzumaki,<br>um jovem ninja órfão da Vila Oculta da Folha, que sonha em se tornar o Hokage, o líder da vila, e obter o reconhecimento de todos.",
                Thumbnail = "/img/4.png",
                Foto = "/img/4.png"
            },
            new () {
                Id = 5,
                Nome = "Sandman",
                CategoriaId = 5,
                Categoria = hq,
                DataPostagem = DateTime.Parse("13/08/2025"),
                Descricao = "Sandman é uma publicação em série de história em quadrinhos.",
                Texto = "A história é vista do ponto de vista de Sonho, um dos sete perpétuos, a representação antropomórfica do sonho, inicialmente preso por um grupo<br> de humanos que almejava prender sua irmã mais velha Morte para que se tornassem imortais, mas falham e capturam sonho.",
                Thumbnail = "/img/5.png",
                Foto = "/img/5.png"
            },
            new () {
                Id = 6,
                Nome = "Cobra Kai",
                CategoriaId = 6,
                Categoria = serie,
                DataPostagem = DateTime.Parse("13/08/2025"),
                Descricao = "Cobra Kai é uma série de televisão americana.",
                Texto = "Cobra Kai é uma série que se passa mais de 30 anos após os eventos do filme Karatê Kid, focando na rivalidade entre Daniel LaRusso e Johnny Lawrence. Johnny, buscando redenção, reabre o dojo Cobra Kai, o que reacende sua antiga rivalidade com Daniel, que agora é um empresário de sucesso.",
                Thumbnail = "/img/6.png",
                Foto = "/img/6.png"
            },

        ];
        return View(postagens);
    }

    public IActionResult Postagem(int id)
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
