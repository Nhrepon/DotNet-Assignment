
using DotNet_Assignment.Database;
using DotNet_Assignment.Models;
using Microsoft.AspNetCore.Mvc;


namespace DotNet_Assignment.Controllers
{
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        public readonly AppDbContext AppDbContext;
        public CustomerController(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }


        public IActionResult Index()
        {
            var customers = AppDbContext.Customers.ToList();
            return View(customers);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            AppDbContext.Customers.Add(customer);
            await AppDbContext.SaveChangesAsync();
            return View("Index", AppDbContext.Customers.ToList());
        }


    }
}