using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using DAL;

namespace Controllers
{
    public class HomeController : DefaultController
    {
        private readonly TestService _service;
        private readonly Context _db;

        public HomeController(Context db, TestService service)
        {
            _db = db;
            _service = service;
        }

        public IActionResult Index()
        {
            _service.Test();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            throw new NotImplementedException();
        }
    }
}
