using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace TestAutomationCenterMenkova.Models
{
    public class Chat
    {
        public int ChatId { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; } 
        public DateTime Time { get; set; } 

        public int UserId { get; set; } // ссылка на связанного пользователя
        public User User { get; set; }
      
    }
}
