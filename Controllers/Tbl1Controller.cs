using Microsoft.AspNetCore.Mvc;
using Test_Entities;
using Test_Model;
namespace Test_ServerSide.Controllers
{
    public class Tbl1Controller : Controller
    {
        Tbl1 tbl1= new Tbl1();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("createTbl1")]
        public JsonResult Get()
        {
            return new JsonResult(tbl1.CreateTbl1());
        }
    }
}
