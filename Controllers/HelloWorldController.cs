using Microsoft.AspNetCore.Mvc;

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
        /*public string Index() Part2
        {
            return "This is my default action...";
        }*/

        //https://localhost:44324/HelloWorld/Welcome?name=Rick&numtimes=4
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

       /* // Requires using System.Text.Encodings.Web; Part2
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

        }
        */
    }
}