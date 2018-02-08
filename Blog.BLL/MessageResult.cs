using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL
{
    public class MessageResult
    {
        public List<string> ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        public bool IsSucceed { get; set; }
    }
}
