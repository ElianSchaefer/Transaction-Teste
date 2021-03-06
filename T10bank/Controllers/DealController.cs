using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using T10bank.Models;

namespace T10bank.Controllers
{

    public class DealController : Controller
    {
        private readonly Context _context;

        public DealController(Context context)
        {
            _context = context;
        }

        //lista Transações
        public async Task<IActionResult> Index()
        {
            return View(await _context.Deals.ToListAsync());
        }

        //[HttpGet]
        //public async Task<IActionResult> Index(string Dealsearch)
        //{
        //    ViewData["Getdealdetails"] = Dealsearch;

        //    var dealquery = from x in _context.Deals select x;
        //    if (!string.IsNullOrEmpty(Dealsearch))
        //    {
        //        dealquery = dealquery.Where(x => x.Company.Contains(Dealsearch));
        //    }
        //    return View(await dealquery.AsNoTracking().ToListAsync());
        //}

        //adicionando transação
        [HttpGet]
        public IActionResult MakeDeal()
        {
            return View();

        }
        //adicionando transação
        [HttpPost]
        public async Task<IActionResult> MakeDeal(Deal deal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return View(deal);
        }

        //removendo transação
        [HttpGet]
        public IActionResult DeleteDeal(int? id)
        {
            if (id != null)
            {
                Deal deal = _context.Deals.Find(id);
                return View(deal);
            }
            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteDeal(int? id, Deal deal)
        {
            if (id != null)
            {
                _context.Remove(deal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }




    }
}
