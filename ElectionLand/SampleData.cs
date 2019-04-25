using ElectionLand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionLand
{
    public static class SampleData
    {
        public static void Initialize(AplicationContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Id = 1,
                        Login ="Anton",
                        Email="Anton@gmail.com",
                        Password="123456"
                    
                    },
                    new User
                    {
                        Id = 2,
                        Login = "ALex",
                        Email = "Alex@gmail.com",
                        Password = "123456"
                    },
                    new User
                    {
                        Id = 3,
                        Login = "Ivan",
                        Email = "Ivan@gmail.com",
                        Password = "123456"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
