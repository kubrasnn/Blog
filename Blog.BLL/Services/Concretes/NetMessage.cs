using Blog.BLL.Services.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.Services.Concretes
{
    public class NetMessage : IMessage
    {
        private bool _isSucceed = false;
        public string To { get; set; }

        public bool IsSucceed
        {
            get
            {
                return _isSucceed;
            }
        }

        public bool SendMessage(string konu , string mesaj)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("***@gmail.com");
            message.To.Add(To);
            message.Body = konu;
            message.Subject = mesaj;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("***@gmail.com", "sifre");

       

            try
            {
                client.Send(message);
                _isSucceed = true;
                return true;
            }
            catch (Exception)
            {
                _isSucceed = false;
                return false;
            }
        }
    }
}
