using CodingApp.Models;
using Microsoft.AspNetCore.Mvc;
using CodingDecodingDLL;



namespace CodingApp.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public ViewResult Encoding()
        {
            return View("Encoding", new InputOutput());
        }

        [HttpGet]
        public ViewResult Decoding()
        {
            return View("Decoding", new InputOutput());
        }

        [HttpPost]
        public ViewResult Encoding(InputOutput response)
        {    

            response.Output = CodingDecoding.Base64Encode(response.Input);
            return View("Encoding", response);
        }

        
        [HttpPost]
        public ViewResult Decoding(InputOutput response)
        {
            response.Output = CodingDecoding.Base64Decode(response.Input);
            return View("Decoding", response);
        }


  






    }
}
