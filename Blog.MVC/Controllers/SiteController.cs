using Blog.BLL.Services.Abstracts;
using Blog.BLL.Services.Concretes;
using Blog.BLL.Validations;
using Blog.Entity.Entities;
using Blog.MVC.Models;
using Blog.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Blog.MVC.Controllers
{
    public class SiteController : BaseController
    {
        IMessage messageProvider;

        public SiteController(IUnitOfWork unitOfWork) :base(unitOfWork)
        {
            messageProvider = new NetMessage();
        }
        // GET: Site      
        public ActionResult Index()
        {
            var model = new MakaleListViewModel
            {
                Iletisim = new Iletisim(),
                Makaleler = _unitOfWork.GetRepo<Makale>().GetAll()
            };     
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(MakaleListViewModel model)
        {
            var validator = new IletisimValidator().Validate(model.Iletisim);

            if (validator.IsValid)
            {
                _unitOfWork.GetRepo<Iletisim>().Add(model.Iletisim);
                bool IsSuccess = _unitOfWork.Commit();
                ViewBag.IsSuccess = IsSuccess;
                ViewBag.Message = IsSuccess ? "Mesajınız Gönderilmiştir." : "Hata!Tekrar Deneyiniz.";
                if (IsSuccess)
                {
                    string msgString = model.Iletisim.IletisimKonu + " konusu ile " + model.Iletisim.IletisimMail + " mail adresine sahip kişi iletişim kısmından size " + model.Iletisim.Mesaj + " mesajını gönderdi";
                    var msg = (NetMessage)messageProvider;
                    msg.To="***@gmail.com";
                    msg.SendMessage(msgString, "Size biri siteniz üzerinden mesaj gönderdi!");

                }
            }
     
            validator.Errors.ToList().ForEach(a =>
            {
                ModelState.AddModelError(a.PropertyName, a.ErrorMessage);
            });
            return RedirectToAction("Index");
        }
     
     
    }
}