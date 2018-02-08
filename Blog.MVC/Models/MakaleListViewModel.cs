using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.MVC.Models
{
    public class MakaleListViewModel
    {
        public IEnumerable<Makale> Makaleler { get; set; }
        public Makale SecilenMakale { get; set; }
        public Iletisim Iletisim { get; set; }
    }
}