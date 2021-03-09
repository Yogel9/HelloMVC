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

        public string Welcome()
            {
                return "This is the Welcome action method...";
            }
        }

    }