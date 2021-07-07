using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using smartfy.portal_api.domain.Entities;
using smartfy.portal_api.domain.Enums;
using smartfy.portal_api.Infra.CrossCutting.Identity.Data;
using smartfy.portal_api.presentation.UI.Web.Controllers.Api;
using smartfy.portal_api.presentation.UI.Web.DataTables;
using smartfy.portal_api.presentation.UI.Web.Extensions;
using smartfy.portal_api.presentation.UI.Web.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace smartfy.portal_api.presentation.UI.Web.Controllers
{
    public class AlunoController : BaseController
    {
        public AlunoController(ApplicationDbContext db) : base(db)
        {
        }

        [HttpGet]
        public IActionResult Index() => View();

        [HttpGet]
        public IActionResult Pesquisa()
        {
            LoadViewBags();

            return View(new AlunoVM()
            {
              
                Alunos = Db.Alunos.ToList(),
                FilterMatricula = string.Empty,
                FilterIdade = string.Empty,
                FilterNome = string.Empty // AMADOR => ""
            }); //Model da View = List de Produtos
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Pesquisa(AlunoVM vm)
        {
            LoadViewBags();

            //Filters - BEGINS
            var alunosFiltrados = Db.Alunos.Where(r => !r.Excluded);

            alunosFiltrados = alunosFiltrados.Where(c => c.Matricula.ToString().Contains(vm.FilterMatricula.ToString()));
            alunosFiltrados = alunosFiltrados.Where(c => c.Idade.ToString().Contains(vm.FilterIdade.ToString()));
            alunosFiltrados = alunosFiltrados.Where(c => c.Nome.ToUpper().Contains(vm.FilterNome.ToUpper()));

            //Filters - ENDS
            //filtro parou aqui preciso verificar (ocorreu um erro)
            vm.Alunos = alunosFiltrados.ToList();

            //vm.Alunos = alunosFiltrados.ToList();
            return View(vm); //Model da View = List de Produtos
        }

        [HttpPost]
        public async Task<JsonResult> List(GridDataRequest request = null)
        {
            return Json(await Db.Alunos.Where(r => r.Excluded != true)
                .Select(r => new
                {
                    nome = r.Nome,
                    idade = r.Idade,
                    matricula = r.Matricula
                }).ToDataSourceAsync(request));
        }
        #region CRUD
        [HttpGet]
        public IActionResult Create()
        {
            LoadViewBags();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Aluno vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            Db.Alunos.Add(vm);
            Db.SaveChanges();

            LoadViewBags();
            NotifySuccess("Sucesso:", "Cadastro inserido com sucesso!");

            return RedirectToAction("Index");
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateBulkInsert(AlunoVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            foreach (var aluno in vm.Alunos)
            {
                Db.Alunos.Add(aluno);
            }

            Db.SaveChanges();

            LoadViewBags();
            NotifySuccess("Sucesso:", "Cadastro inserido com sucesso!");

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var person = Db.Alunos.FirstOrDefault(c => c.Id == id);

            if (person == null) return BadRequest();

            LoadViewBags();

            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Aluno vm)
        {

            if (!ModelState.IsValid)
            {
                LoadViewBags();
                return View(vm);
            }
            var partner = Db.Alunos.AsNoTracking().Where(c => c.Id == vm.Id);
            if (partner == null) return BadRequest();

            Db.Entry(vm).State = EntityState.Modified;
            Db.SaveChanges();

            LoadViewBags();
            NotifySuccess("Sucesso", "Cadastro atualizado com sucesso!");

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var person = Db.Alunos.FirstOrDefault(c => c.Id == id);

            if (person == null) return BadRequest();

            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(DeleteViewModel vm)
        {
            Entity entity = new Entity();

            var person = Db.Alunos.FirstOrDefault(c => c.Id == vm.Id);

            if (person == null) return BadRequest();

            //Utilizei a função Delete da Classe Entity
            //Função utiliza o campo excluded

            person.Excluded = entity.Delete();
            Db.Alunos.Update(person);
            //Db.Produtos.Remove(item);
            Db.SaveChanges();


            NotifySuccess("Sucesso", "Produto removido com sucesso.");

            return RedirectToAction("Index");
        }

        #endregion
        private void LoadViewBags()
        {
        }
    }
}
