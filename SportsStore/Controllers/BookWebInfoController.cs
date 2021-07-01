using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class BookWebInfoController : Controller
    {
        private IProductRepository repository;
        public BookWebInfoController(IProductRepository repo)
        {
            repository = repo;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BusinessInfo()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult NewsReleases()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
