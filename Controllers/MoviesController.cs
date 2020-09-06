using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using Movies.Models.ViewModels;
using Microsoft.Extensions.Primitives;
using Microsoft.Net.Http.Headers;
using Movies.Models.Entities;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        MoviesService service;
        public MoviesController(MoviesService service)
        {
            this.service = service;
        }

        [Route("")]
        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            var model = service.GetAllMovies();
            return View(model);
        }

        [Route("create")]
        [HttpGet]
        public IActionResult Create()
        {
            // Show empty form
            return View();
        }

        [Route("create")]
        [HttpPost]
        public IActionResult Create(MoviesCreateVM model) // Model binding
        {
            // Validate (server-side)
            if (!ModelState.IsValid)
                return View(model);

            // Add customer to DB
            service.Create(model);

            // Redirect to index
            return RedirectToAction("Index");
        }

        [Route("timebox")]
        [HttpGet]
        public IActionResult Timebox()
        {
            // Show empty form
            return PartialView("_TimeBox", DateTime.Now);
        }

        [Route("timebox-data")]
        [HttpGet]
        public IActionResult TimeboxData()
        {
            // Show empty form
            var model = new
            {
                Time = DateTime.Now.ToString()
            };
            return Json(model);
        }
    }
}
