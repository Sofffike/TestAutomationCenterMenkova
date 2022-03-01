using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestAutomationCenterMenkova.Models;

namespace TestAutomationCenterMenkova.Controllers
{
    public class HomeController : Controller
    {
        UsersContext db;
        public HomeController(UsersContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Users.ToList());
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            db.Users.Add(user);        
            db.SaveChanges();
            return View(db.Users.ToList());
        }

        [HttpGet]
        public IActionResult Chat(int? id)  
        {
            //List < UsersName > ListUsersName = new List<UsersName>()
            //{
            //    new UsersName() {IdName = (int)id, Name= user.Id },             
            //};             
            //    ViewBag.UsersName = new SelectList(ListUsersName, "IdName", "Name");
                
            if (id == null) return RedirectToAction("Index");        
            ViewBag.UserId = id;         
            return View(db.Chats.ToList()); 
        }

        [HttpPost]
        public IActionResult Chat(Chat chat, int? id)
        {
                chat.Time = DateTime.Now;
                db.Chats.Add(chat);
                db.SaveChanges();
                return View(db.Chats.ToList());        
        }
    }
}