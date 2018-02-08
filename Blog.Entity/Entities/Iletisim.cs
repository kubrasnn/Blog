using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class Iletisim
    {
        public int MailId { get; set; }
        public string IletisimKonu { get; set; }
        public string IletisimMail { get; set; }
        public string Mesaj { get; set; }

    }
}
