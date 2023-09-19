using MarketLibrary.MarketModels;
using MarketLibrary.MarketRepositoy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Controllers
{
    public class SupermarketController : Controller
    {
        private readonly IEntityframRepository repository;
        public SupermarketController(IEntityframRepository rep)
        {
            repository = rep;
        }
        // GET: SupermarketController
        public ActionResult  List()
        {
            try
            {


                return View("List", repository.SPMarketmodel());

            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        // GET: SupermarketController/Details/5
        public ActionResult Details(int ID)
        {
            try
            {
                var result = repository.SPmarketmodelID(ID);

                return View("Details", result);

            }
            catch
            {
                return View("Error");

            }
        }

        // GET: SupermarketController/Create
        public ActionResult Create()
        {

            var model = new Market();
            return View("Create", model);
        }

        // POST: SupermarketController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Market detail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repository.SPInsert(detail);
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    return View("create", detail);
                }
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { CustomMessage = " Error in Entityfram Insert", ActualMessage = ex.Message }); ;
            }
        }

        // GET: SupermarketController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = new Market();
            return View("Edit", model);
        }

        // POST: SupermarketController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int ID, Market detail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repository.SPupdate(detail);

                    return RedirectToAction(nameof(List));
                }
                else
                {
                    return View("Edit", detail);
                }
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: SupermarketController/Delete/5
        public ActionResult Delete(int ID)
        {
            var result = repository.SPmarketmodelID(ID);
            return View("Delete", result);
        }

        // POST: SupermarketController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int ID, Market Delete)
        {
            try
            {
                repository.SPDelete(ID);

                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View("Error");
            }
        }
    }
}
