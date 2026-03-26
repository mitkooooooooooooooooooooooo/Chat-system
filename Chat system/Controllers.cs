using Microsoft.AspNetCore.Mvc;
using ChatApp.Models;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
        private static List<KeyValuePair<string, string>> messages = new();

        public IActionResult Show()
        {
            var model = new ChatViewModel();
            foreach (var msg in messages)
            {
                model.Messages.Add(new MessageViewModel 
                { 
                    Sender = msg.Key, 
                    MessageText = msg.Value 
                });
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Send(ChatViewModel model)
        {
            messages.Add(new KeyValuePair<string, string>(
                model.CurrentMessage.Sender, 
                model.CurrentMessage.MessageText));

            return RedirectToAction("Show");
        }
    }
}
