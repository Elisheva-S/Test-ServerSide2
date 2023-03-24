using Microsoft.AspNetCore.Mvc;
using Test_Entities;

namespace Test_ServerSide.Controllers
{
    public class Tbl2Controller : Controller
    {
        Tbl2 tbl2 = new Tbl2();

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("createTbl2")]
        public JsonResult Get()
        {
            return new JsonResult(tbl2.CreateTbl2());
        }
    }
}
