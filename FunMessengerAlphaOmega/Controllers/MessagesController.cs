using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FunMessengerAlphaOmega.Models;

namespace FunMessengerAlphaOmega.Controllers
{
    public class MessagesController : ApiController
    {
        MessageItem[] messages = new MessageItem[]
        {
            new MessageItem
            {
                Id = 1,
                SenderName = "Nissan Dookeran",
                SenderImageUrl = "https://pbs.twimg.com/profile_images/340937461/nissan.jpg",
                Title = "Hi",
                Body = "Hello world!",
                DateTimeStamp = DateTime.Now
            },
            new MessageItem
            {
                Id =2,
                SenderName = "Captain Hook",
                SenderImageUrl = "https://sup3rjunior.files.wordpress.com/2013/03/captain-hook.jpg",
                Title = "Question",
                Body = "Ay matey, where to now?",
                DateTimeStamp = DateTime.Now.AddMinutes(30)
            },
            new MessageItem
            {
                Id = 3,
                SenderName = "Peter Pan",
                SenderImageUrl = "https://drakalogia.wikispaces.com/file/view/4c4b3ee3cf63c82d77e04860c699876854bc4b79.jpg/499776162/4c4b3ee3cf63c82d77e04860c699876854bc4b79.jpg",
                Title = "Answer",
                Body = "Second start to the left and straight on till morning",
                DateTimeStamp = DateTime.Now.AddHours(2)
            }

        };

        public IEnumerable<MessageItem> GetAllMessages()
        {
            return messages;
        }

        public IHttpActionResult GetMessage(int id)
        {
            var message = messages.FirstOrDefault(p => p.Id == id);
            if (message == null)
            {
                return NotFound();
            }
            return Ok(message);
        }
    }
}
