using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HelloWorld.Domain
{
    public class Message
    {
        public string[] DisplayText { get; set; }
        public Message()
        {
            DisplayText = ConfigurationManager.AppSettings["message"].Split(';');
        }
    }
}
