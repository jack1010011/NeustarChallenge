using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Store.Data;
using Store.Models;

namespace Store.Controllers
{
    public class ItemsListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemsListsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ItemsLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemsList.ToListAsync());
        }








        [HttpGet]
        public JsonResult GetFunnelPositions()
        {
            var myJsonList = _context.ItemsList.ToList();
            return Json(myJsonList);
        }













        // GET: ItemsLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemsList = await _context.ItemsList
                .SingleOrDefaultAsync(m => m.ID == id);
            if (itemsList == null)
            {
                return NotFound();
            }

            return View(itemsList);
        }

        // GET: ItemsLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemsLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title")] ItemsList itemsList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemsList);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(itemsList);
        }

        // GET: ItemsLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemsList = await _context.ItemsList.SingleOrDefaultAsync(m => m.ID == id);
            if (itemsList == null)
            {
                return NotFound();
            }
            return View(itemsList);
        }

        // POST: ItemsLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Description,Category,isCompleted,isFavorite,Rate,Price,Purchases,Comments,ImagesSource,ImagesSource2,ImagesSource3,ImagesSource4,VideosSource,ApplicationUserID")] ItemsList itemsList)
        {
            if (id != itemsList.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemsList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemsListExists(itemsList.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(itemsList);
        }

        // GET: ItemsLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemsList = await _context.ItemsList
                .SingleOrDefaultAsync(m => m.ID == id);
            if (itemsList == null)
            {
                return NotFound();
            }

            return View(itemsList);
        }

        // POST: ItemsLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemsList = await _context.ItemsList.SingleOrDefaultAsync(m => m.ID == id);
            _context.ItemsList.Remove(itemsList);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ItemsListExists(int id)
        {
            return _context.ItemsList.Any(e => e.ID == id);
        }
    }
}
