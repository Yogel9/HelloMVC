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
        //public string Index() Part2
        //{
        //    return "Это моё действие по умолчанию!";
        //}


        // GET: /HelloWorld/Welcome/ 
        //public string Welcome() Part2
        //{
        //    return "Добро пожаловать, метод Welcome работает!";
        //}


        //https://localhost:44324/HelloWorld/Welcome?name=Rick&numtimes=4
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        // GET: /HelloWorld/Welcome?name=Rick&numtimes=4    Part2
        // Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Привет {name}, ваше числовое значение: {numTimes}");
        //}
    }
}