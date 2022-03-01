using System;
using System.Linq;
using TestAutomationCenterMenkova.Models;

namespace TestAutomationCenterMenkova
{
    public class SampleData
    {
        public static void Initialize(UsersContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Name = "Петр",
                        Login = "PetrPPP",
                        Password = "123456789"
                    }
                );
                context.SaveChanges();
            }

                if (!context.Chats.Any())   
                {
                    context.Chats.AddRange(
                        new Chat
                        {
                            UserName = "Петр",
                            Time = DateTime.Now,
                            Message = "Я люблю печеньки",
                            UserId = 1
                        }
                    );
                context.SaveChanges();
            }
                
            }
        }
    }
