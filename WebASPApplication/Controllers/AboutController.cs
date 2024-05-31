using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using WebASPApplication.Models;

namespace WebASPApplication.Controllers
{
    public class AboutController : Controller
    {
        // дефолтный обработчик запросов:   domain/About/index
        public IActionResult Index()
        {
            return View();
        }

        // новый обработчик запросов:   domain/About/contactus
        public IActionResult ContactUs()
        {
            return View();     
        }

        /*[HttpPost]
        public IActionResult GetGuestMessage(string Email, string Fio, string Phone, string Subject, string Message)
        {
            Console.WriteLine(Email, Fio, Phone, Subject, Message);
            // 1. Провести вадилацию
            // 2. Сохранить в бд
            return View("Thanks");
        }*/

        [HttpPost]
        public IActionResult GetGuestMessage(GuestMessage guestMessage)
        {
            // 2. Сохранить в бд
            if (ModelState.IsValid) {
                return View("Thanks", guestMessage);             // успех, данные валидны
            } else {
                return View("Failure", guestMessage);            // неудача, данные не валидны
            }            
        }
    }
}
