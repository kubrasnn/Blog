using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.Services.Abstracts
{
    public interface IMessage
    {
        bool IsSucceed { get; }
        bool SendMessage(string konu,string mesaj);
        
    }

    //public class MessageTemplate
    //{
    //    public string From { get; set; }
    //    public List<string> To { get; set; }
    //    public string MessageBody { get; set; }
    //    public string MessageSubject { get; set; }


    //}

}
