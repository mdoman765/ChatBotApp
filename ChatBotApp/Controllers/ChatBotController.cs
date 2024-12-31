using ChatBotApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatBotApp.Controllers
{
    public class ChatBotController : Controller
    {
        public IActionResult Index()
        {
            return View(new ChatBotModel());
        }
    }
}

