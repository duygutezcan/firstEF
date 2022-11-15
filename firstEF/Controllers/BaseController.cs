using firstEF.Context;
using Microsoft.AspNetCore.Mvc;

namespace firstEF.Controllers
{
    public class BaseController : Controller
    {
        public PerContext _db;
        public BaseController(PerContext db)
        {
          _db = db;
        }
    }
}
