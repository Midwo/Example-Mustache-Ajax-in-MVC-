using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleMustache_MVC.Models
{
    public class MessageModel
    {
        public string Nick { get; set; }
        public string Contents { get; set; }
        public DateTime Date { get; set; }
    }
}