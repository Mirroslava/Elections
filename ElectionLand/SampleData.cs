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

            User user1 = new User
            {
                Id = 1,
                FirstName = "Anton",
                LastName = "Totbin",
                PIN = 1234567890123,
               // BirthDate = new DateTime(1976, 8, 11),
                Login = "Anton",
                Email = "Anton@gmail.com",
                Password = "123456"

            };
            User user2 = new User
            {
                Id = 2,
                FirstName = "Alex",
                LastName = "Toto",
                PIN = 1111111111111,
             //  BirthDate = new DateTime(1996, 6, 10),
                Login = "Alex",
                Email = "Alex@gmail.com",
                Password = "123456"
            };
            User user3 = new User
            {
                Id = 3,
                FirstName = "Ivan",
                LastName = "Lopert",
                PIN = 1111111111112,
              //  BirthDate = new DateTime(1996, 6, 10),
                Login = "Ivan",
                Email = "Ivan@gmail.com",
                Password = "123456"
            };
            User user4 = new User
            {
                Id = 4,
                FirstName = "Olena",
                LastName = "Varneva",
                PIN = 1111111111113,
              //  BirthDate = new DateTime(1983, 5, 07),
                Login = "Olena",
                Email = "Olena@gmail.com",
                Password = "123456"
            };
            User user5 = new User
            {
                Id = 5,
                FirstName = "Vika",
                LastName = "Petrenko",
                PIN = 1111111111114,
              //  BirthDate = new DateTime(1973, 1, 12),
                Login = "Vika",
                Email = "Vika@gmail.com",
                Password = "123456"
            };
            User user6 = new User
            {
                Id = 6,
                FirstName = "Yulia",
                LastName = "Stahiv",
                PIN = 1111111111115,
              // BirthDate = new DateTime(2000, 13, 03),
                Login = "Yulia",
                Email = "Yulia@gmail.com",
                Password = "123456"
            };
            User user7 = new User
            {
                Id = 7,
                FirstName = "Oleg",
                LastName = "Lesiv",
                PIN = 1111111111116,
               // BirthDate = new DateTime(1968, 15, 03),
                Login = "Oleg",
                Email = "Oleg@gmail.com",
                Password = "123456"
            };
            User user8 = new User
            {
                Id = 8,
                FirstName = "Vadim",
                LastName = "Pushka",
                PIN = 1111111111117,
              //  BirthDate = new DateTime(1989, 19, 02),
                Login = "Vadim",
                Email = "Vadim@gmail.com",
                Password = "123456"
            };
            User user9 = new User
            {
                Id = 9,
                FirstName = "Andrii",
                LastName = "Virt",
                PIN = 1111111111118,
               // BirthDate = new DateTime(1959, 10, 09),
                Login = "Andrii",
                Email = "Andrii@gmail.com",
                Password = "123456"
            };
            User user10 = new User
            {
                Id = 10,
                FirstName = "Oksana",
                LastName = "Virtlaeva",
                PIN = 1111111111119,
              // BirthDate = new DateTime(1980, 12, 05),
                Login = "Oksana",
                Email = "Oksana@gmail.com",
                Password = "123456"
            };

                context.Users.AddRange(
                        user1,
                        user2,
                        user3,
                        user4,
                        user5,
                        user6,
                        user7,
                        user8,
                        user9,
                        user10
                    );
                context.SaveChanges();
          
           
        }    
        
           
           
    }
}

