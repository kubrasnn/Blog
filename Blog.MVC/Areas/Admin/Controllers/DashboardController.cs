using Blog.MVC.Controllers;
using Blog.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.MVC.Areas.Admin.Controllers
{
    [Authorize]
    public class DashboardController : BaseController
    {
        public DashboardController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        // GET: Admin/Dashboard
        [OutputCache(Duration = 30)]
        public ActionResult Index() 
        {
            ViewBag.Kullanici = "Admin";
            return View();
        }
    }
}