using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNETCoreApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Download()
        {
            byte[] bytes;
            using (var ms = new MemoryStream())
            {
                var tw = new StreamWriter(ms);
                tw.WriteLine("Line 1");
                tw.WriteLine("Line 2");
                tw.WriteLine("Line 3");
                tw.Flush();
                bytes = ms.ToArray();
            }

            return File(bytes, "text/plain", "YourFileName.txt");
        }
    }
}
