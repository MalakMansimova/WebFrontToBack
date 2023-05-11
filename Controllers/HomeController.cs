using Microsoft.AspNetCore.Mvc;
using WebFrontToBack.Models;

namespace WebFrontToBack.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _appdbcontext;

        public HomeController(AppDbContext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }
        public async Task<IActionResult>Index()
        {
            List<Slider> sliders = await _appDbContext.Sliders.ToListAsync();
            List<Category>categories=await _appdbcontext.Categories.ToListAsync();
            List<Service>services=await _appdbcontext.Services
                .Include(s=>s.Category)
                .Include(s=>s.ServiceImages)
                .OrderByDescending(s=>s.Id)  //Sondan evvele shekkilleri sirala
                .Take(8)
                
                .ToListAsync();
            return View(sliders);
        }
    }
}
