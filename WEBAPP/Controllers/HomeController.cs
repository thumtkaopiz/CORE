using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEBAPP.Models;
using DATA.EF;
using DATA.Entities;
using APPLICATION.Book;
using APPLICATION.Book.DTOS;

namespace WEBAPP.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        private readonly IPublicBookService _publicBookService;
        public HomeController(IPublicBookService publicBookService)
        {
            _publicBookService = publicBookService;
        }

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _publicBookService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookViewModel book)
        {
            return View(await _publicBookService.GetAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
