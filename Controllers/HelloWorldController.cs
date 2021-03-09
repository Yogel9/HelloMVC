using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace HelloMVC.Controllers
{

    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/


        public IActionResult Index()//ВЫЗЫВАЕМ ИДЕКС ИЗ VIEWS ПАПКИ
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        //https://localhost:44324/HelloWorld/Welcome?name=Rick&numtimes=4
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}