using HotelFinder.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelFinder.Entities;

namespace HotelLogin_MVC.Controllers
{
    public class Login : Controller
    {

        HotelDbContext c = new HotelDbContext();
        

        [HttpGet]
        public IActionResult GirisYao()
        {
            return View();
        }

        public async Task<IActionResult> GirisYap(Login login)
        {
           // var bilgiler = c.logins.FirstOrDefault(x => x.ad == logi);
            return View();
        }
    }
}
