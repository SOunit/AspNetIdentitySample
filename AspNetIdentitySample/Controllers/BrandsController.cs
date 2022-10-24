using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AspNetIdentitySample.Models;

namespace AspNetIdentitySample.Controllers
{
    public class BrandsController : Controller
    {

        // GET: Brands
        public ActionResult Index()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Brand> brands = db.Brands.ToList();
            return View(brands);
        }
    }
}