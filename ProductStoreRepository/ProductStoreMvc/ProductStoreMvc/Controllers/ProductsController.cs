using ProductStoreMvc.DAL;
using ProductStoreMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductStoreMvc.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products

        private _IAllRepository<tbl_Product> ProductTblModel;
        private _IAllRepository<tbl_Category> CategoryTblModel;
        private _IAllRepository<tbl_Unit> UnitTblModel;

        public ProductsController()
        {
            ProductTblModel = new AllRepository<tbl_Product>();
            CategoryTblModel = new AllRepository<tbl_Category>();
            UnitTblModel = new AllRepository<tbl_Unit>();
        }

        public ActionResult Index()
        {
            return View(ProductTblModel.GetAll());
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            List<tbl_Category> categoryList = CategoryTblModel.GetAll().ToList();
            ViewBag.list = new SelectList(categoryList, "CategoryId", "CategoryName");

            List<tbl_Unit> unitList = UnitTblModel.GetAll().ToList();
            ViewBag.list = new SelectList(unitList, "UnitId", "UnitName");

            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(tbl_Product product)
        {
            try
            {
                // TODO: Add insert logic here
                ProductTblModel.Insert(product);
                ProductTblModel.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            List<tbl_Category> categoryList = CategoryTblModel.GetAll().ToList();
            ViewBag.list = new SelectList(categoryList, "CategoryId", "CategoryName");

            List<tbl_Unit> unitList = UnitTblModel.GetAll().ToList();
            ViewBag.list = new SelectList(unitList, "UnitId", "UnitName");

            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, tbl_Product pEdit)
        {
            try
            {
                // TODO: Add update logic here
                ProductTblModel.Update(pEdit);
                ProductTblModel.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id, tbl_Product pDelete)
        {
            try
            {
                // TODO: Add delete logic here
                ProductTblModel.Delete(Id);
                ProductTblModel.Save();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
