using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FunMessengerAlphaOmega.Models
{
    public class MessageItem
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string SenderImageUrl { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DateTimeStamp { get; set; }
    }
}