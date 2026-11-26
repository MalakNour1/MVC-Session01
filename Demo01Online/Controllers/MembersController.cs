using Microsoft.AspNetCore.Mvc;

namespace Demo01Online.Controllers
{
    public class MembersController : Controller
    {

        //BaseUrl/Members/Index
        public IActionResult Index()
        {
            return View();
        }



        //BaseUrl/Members/GetMembers/5
        public IActionResult GetMembers(int id)
        {
            return View();
        }


        //BaseUrl/Members/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
