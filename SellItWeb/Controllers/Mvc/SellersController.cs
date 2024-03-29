﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SellItCore.Entities;
using SellItWeb.Database.LocalDb;

namespace SellItWeb.Controllers.Mvc
{
    public class SellersController : Controller
    {
        private SellItWebLocalDb db = new SellItWebLocalDb();

        // GET: Sellers
        public async Task<ActionResult> Index()
        {
            return View(await db.Sellers.ToListAsync());
        }

        // GET: Sellers/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seller seller = await db.Sellers.FindAsync(id);
            if (seller == null)
            {
                return HttpNotFound();
            }
            return View(seller);
        }

        // GET: Sellers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sellers/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Login,Password,Firstname,Lastname,Email,DateOfBirth")] Seller seller)
        {
            if (ModelState.IsValid)
            {
                db.Sellers.Add(seller);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(seller);
        }

        // GET: Sellers/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seller seller = await db.Sellers.FindAsync(id);
            if (seller == null)
            {
                return HttpNotFound();
            }
            return View(seller);
        }

        // POST: Sellers/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Login,Password,Firstname,Lastname,Email,DateOfBirth")] Seller seller)
        {
            if (ModelState.IsValid)
            {
                db.Entry(seller).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(seller);
        }

        // GET: Sellers/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seller seller = await db.Sellers.FindAsync(id);
            if (seller == null)
            {
                return HttpNotFound();
            }
            return View(seller);
        }

        // POST: Sellers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            Seller seller = await db.Sellers.FindAsync(id);
            db.Sellers.Remove(seller);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
