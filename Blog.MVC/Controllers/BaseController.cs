using Blog.Entity.Entities;
using Blog.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.MVC.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IUnitOfWork _unitOfWork;

        public BaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            var model = _unitOfWork.GetRepo<Kullanici>().GetAll().FirstOrDefault();
            ViewBag.Title = model.Adi;

        }


        protected override void Dispose(bool disposing)
        {
            _unitOfWork.Dispose(disposing);
        }
    }
}