using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Henrique",
                DataNascimento = DateTime.Now,
                Email = "henrique@henriquesd.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            var aluno3 = _contexto.Alunos.FirstOrDefault(a => a.Email == "henrique@henriquesd.com"); // retorna só um - FirstOrDefault pega sempre o primeiro resultado;
            var aluno4 = _contexto.Alunos.Where(a => a.Nome == "Henrique"); // retorna uma coleção (IQueryable);

            aluno.Nome = "João";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno); // o método remove é feito sempre através da entidade, e não pelo Id;
            _contexto.SaveChanges();

            return View();
        }
    }
}