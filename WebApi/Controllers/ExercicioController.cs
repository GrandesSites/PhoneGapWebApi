using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi.Domain.Models;
using WebApiRepository;

namespace WebApi.Controllers
{
    public class ExercicioController : Controller
    {
        //
        // GET: /Exercicio/

        public ActionResult Index()
        {
            var _Banco = new TB_ExerciciosRepository();
            return View(_Banco.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TB_Exercicios itens)
        {
            var _Banco = new TB_ExerciciosRepository();
            _Banco.Add(itens);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var _Banco = new TB_ExerciciosRepository();
            _Banco.Inativar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var _Banco = new TB_ExerciciosRepository();
            return View(_Banco.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(TB_Exercicios itens)
        {
            var _Banco = new TB_ExerciciosRepository();
            _Banco.Update(itens);
            return RedirectToAction("Index");
        }

    }
}
