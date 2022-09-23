using Homework4.Core.Entities;
using Homework4.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Homework4.Controllers
{
    [Route("[controller]")]
    public class ParrotController : Controller
    {
        private readonly IParrotService _parrotService;

        public ParrotController(IParrotService parrotService)
        {
            _parrotService = parrotService;
        }

        [HttpGet("Details/{id}")]
        public IActionResult Details([FromRoute] int id)
        {
            return View(_parrotService.Get(id));
        }

        [HttpGet]
        [Authorize(Roles = "user")]
        public IActionResult List()
        {
            var model = _parrotService.GetAll();

            return View(model);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(Parrot parrot)
        {
            _parrotService.Create(parrot);

            return View("Success");
        }

        [HttpGet("Update")]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost("Update")]
        public IActionResult Update(Parrot parrot)
        {
            _parrotService.Update(parrot);

            return View("Success");
        }

        [HttpGet("Delete")]
        public IActionResult Delete(int id)
        {
            Parrot parrot = _parrotService.Get(id);
            return View(parrot);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Parrot parrot)
        {
            _parrotService.Delete(parrot.Id);

            return View("Success");
        }
    }
}
