
using DotNet_Assignment.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace DotNet_Assignment.Controllers
{
    [Route("[controller]")]
    public class EquipmentController : Controller
    {
       public readonly AppDbContext AppDbContext;
        public EquipmentController(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }


        public async Task<IActionResult> Index()
        {
            var equipments =await AppDbContext.Equipments.Include(c => c.customer).ToListAsync();
            return View(equipments);
        }



        [HttpGet, Route("{id}")]
        public async Task<IActionResult> Index([FromRoute]int id)
        {
            var equipments =await AppDbContext.Equipments.Where(e => e.CustomerId == id).Include(c => c.customer).ToListAsync();
            return View(equipments);
        }






    }
}