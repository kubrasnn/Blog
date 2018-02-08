using Blog.BLL.Services.Abstracts;
using Blog.BLL.Services.Concretes;
using Blog.Entity.Entities;
using Blog.MVC.Areas.Admin.Models;
using Blog.MVC.Controllers;
using Blog.Repository.Repositories.Abstracts;
using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Unity.Attributes;

namespace Blog.MVC.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
       private readonly IEncryptor _hasher;


        public AccountController(IUnitOfWork unitOfWork,IEncryptor hasher) : base(unitOfWork)
        {
            _hasher = hasher;
      
        }

        // GET: Admin/Account
        public ActionResult Login()
        {

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return Redirect("/Admin/Dashboard");
            }

            return View();
        }
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                model.Password = _hasher.Hash(model.Password);
                var kullanici = _unitOfWork.GetRepo<Kullanici>().Where(x => x.MailAdres == model.Email && x.Parola == model.Password).FirstOrDefault();
                

                if (kullanici != null)
                {
                    FormsAuthentication.SetAuthCookie(kullanici.MailAdres, model.RememberMe);
                    _unitOfWork.Commit();
                    return Redirect("/Admin/Dashboard");
                }
                else
                {
                    ViewBag.FormResult = "Kullanıcı adı veya şifre hatalı";
                    return View();
                }
            }

            return View();
        }

        [Authorize]
        public RedirectResult LogOut()
        {         
            FormsAuthentication.SignOut();

            return Redirect("/Admin/Account/Login");
            
        }
    }
}