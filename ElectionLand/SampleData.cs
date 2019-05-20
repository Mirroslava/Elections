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
            if (!context.Watchers.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Id = 1,
                        FirstName = "Anton",
                        LastName = "Totbin",
                        PIN = 1234567890123,
                        BirthDate = new DateTime(1976, 8, 11),
                        Login = "Anton",
                        Email = "Anton@gmail.com",
                        Password = "123456"

                    },
                    new User
                    {
                        Id = 2,
                        FirstName = "Alex",
                        LastName = "Toto",
                        PIN = 1111111111111,
                        BirthDate = new DateTime(1996, 6, 10),
                        Login = "Alex",
                        Email = "Alex@gmail.com",
                        Password = "123456"
                    },
                    new User
                    {
                        Id = 3,
                        FirstName = "Ivan",
                        LastName = "Lopert",
                        PIN = 1111111111112,
                        BirthDate = new DateTime(1996, 6, 10),
                        Login = "Ivan",
                        Email = "Ivan@gmail.com",
                        Password = "123456"
                    },
                    new User
                    {
                        Id = 4,
                        FirstName = "Olena",
                        LastName = "Varneva",
                        PIN = 1111111111113,
                        BirthDate = new DateTime(1983, 5, 07),
                        Login = "Olena",
                        Email = "Olena@gmail.com",
                        Password = "123456"
                    },
                    new User
                    {
                        Id = 5,
                        FirstName = "Vika",
                        LastName = "Petrenko",
                        PIN = 1111111111114,
                        BirthDate = new DateTime(1973, 1, 12),
                        Login = "Vika",
                        Email = "Vika@gmail.com",
                        Password = "123456"
                    },
                    new User
                    {
                        Id = 6,
                        FirstName = "Yulia",
                        LastName = "Stahiv",
                        PIN = 1111111111115,
                        BirthDate = new DateTime(2000, 11, 03),
                        Login = "Yulia",
                        Email = "Yulia@gmail.com",
                        Password = "123456"
                    },
                    new User
                    {
                        Id = 7,
                        FirstName = "Oleg",
                        LastName = "Lesiv",
                        PIN = 1111111111116,
                        BirthDate = new DateTime(1968, 1, 03),
                        Login = "Oleg",
                        Email = "Oleg@gmail.com",
                        Password = "123456"
                    },
                    new User
                    {
                        Id = 8,
                        FirstName = "Vadim",
                        LastName = "Pushka",
                        PIN = 1111111111117,
                        BirthDate = new DateTime(1989, 10, 02),
                        Login = "Vadim",
                        Email = "Vadim@gmail.com",
                        Password = "123456"
                    },
                    new User
                    {
                        Id = 9,
                        FirstName = "Andrii",
                        LastName = "Virt",
                        PIN = 1111111111118,
                        BirthDate = new DateTime(1959, 10, 09),
                        Login = "Andrii",
                        Email = "Andrii@gmail.com",
                        Password = "123456"
                    },
                     new User
                     {
                         Id = 10,
                         FirstName = "Oksana",
                         LastName = "Virtlaeva",
                         PIN = 1111111111119,
                         BirthDate = new DateTime(1980, 12, 05),
                         Login = "Oksana",
                         Email = "Oksana@gmail.com",
                         Password = "123456"
                     }
                );
                context.Roles.AddRange(
                    new Role
                    {
                        Id = 1,
                        Title = "Admin"
                    },
                    new Role
                    {
                        Id = 2,
                        Title = "User"
                    }
                );
                context.UserToRoles.AddRange(
                    new UserToRole
                    {
                        Id = 1,
                        UserId = 1,
                        RoleId = 1
                    },
                    new UserToRole
                    {
                        Id = 2,
                        UserId = 2,
                        RoleId = 1
                    },
                    new UserToRole
                    {
                        Id = 3,
                        UserId = 3,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 4,
                        UserId = 4,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 5,
                        UserId = 5,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 6,
                        UserId = 6,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 7,
                        UserId = 7,
                        RoleId = 2
                    },
                     new UserToRole
                     {
                         Id = 8,
                         UserId = 8,
                         RoleId = 2
                     },
                      new UserToRole
                      {
                          Id = 9,
                          UserId = 9,
                          RoleId = 2
                      },
                       new UserToRole
                       {
                           Id = 10,
                           UserId = 10,
                           RoleId = 2
                       }

                    );
                context.UserStatuses.AddRange(
                   new UserStatus
                   {
                       Id = 1,
                       Title = "Elector"
                   },
                    new UserStatus
                    {
                        Id = 2,
                        Title = "Chairman of district commission"
                    },
                    new UserStatus
                    {
                        Id = 3,
                        Title = "Chairman of polling station commission"
                    },
                    new UserStatus
                    {
                        Id = 4,
                        Title = "Chairman of the central commission"
                    },
                    new UserStatus
                    {
                        Id = 5,
                        Title = "Watcher"
                    }
                );


                context.StatusToUsers.AddRange(
                    new StatusToUser
                    {
                        Id = 1,
                        UserId = 3,
                        UserStatusId = 1,
                        ElectionId = 1
                    },
                     new StatusToUser
                     {
                         Id = 2,
                         UserId = 4,
                         UserStatusId = 1,
                         ElectionId = 1
                     },
                      new StatusToUser
                      {
                          Id = 3,
                          UserId = 5,
                          UserStatusId = 1,
                          ElectionId = 1
                      },
                       new StatusToUser
                       {
                           Id = 4,
                           UserId = 6,
                           UserStatusId = 1,
                           ElectionId = 1
                       },
                        new StatusToUser
                        {
                            Id = 5,
                            UserId = 7,
                            UserStatusId = 1,
                            ElectionId = 1
                        },
                         new StatusToUser
                         {
                             Id = 6,
                             UserId = 8,
                             UserStatusId = 1,
                             ElectionId = 1
                         },
                          new StatusToUser
                          {
                              Id = 7,
                              UserId = 9,
                              UserStatusId = 1,
                              ElectionId = 1
                          },
                           new StatusToUser
                           {
                               Id = 8,
                               UserId = 10,
                               UserStatusId = 1,
                               ElectionId = 1
                           }
                    );
                context.VirtualCantons.AddRange(
                    new VirtualCanton
                    {
                        Id = 1,
                        Title = "PMP-32",
                        Adress = "Lviv",
                        Centre = "LNU",

                    },
                     new VirtualCanton
                     {
                         Id = 2,
                         Title = "PMP-31",
                         Adress = "Lviv",
                         Centre = "LNU",

                     }
                );
                context.VirtualDistricts.AddRange(
                    new VirtualDistrict
                    {
                        Id = 1,
                        Title = "LoKoMoTyV",
                        Adress = "Lviv",
                        VirtualCantonId = 1
                    },
                    new VirtualDistrict
                    {
                        Id = 2,
                        Title = "Master Splinter",
                        Adress = "Lviv",
                        VirtualCantonId = 1
                    },
                    new VirtualDistrict
                    {
                        Id = 3,
                        Title = "Bit and Byte",
                        Adress = "Lviv",
                        VirtualCantonId = 1
                    },
                     new VirtualDistrict
                     {
                         Id = 4,
                         Title = "Select",
                         Adress = "Lviv",
                         VirtualCantonId = 1
                     }
                );
                context.Elections.AddRange(
                    new Election
                    {
                        Id = 1,
                        Title = "Вибори2019",
                        Year = 2019,
                        StartElection = new DateTime(2019, 3, 28, 8, 0, 0),
                        EndElection = new DateTime(2019, 3, 28, 20, 0, 0),
                        ChairmanСVK = 1
                    }
                    );
                context.Candidates.AddRange(
                    new Candidate
                    {
                        Id = 1,
                        UserId = 1,
                        ElectionId = 1,
                        NumberInTheList = 1
                    },
                    new Candidate
                    {
                        Id = 2,
                        UserId = 2,
                        ElectionId = 1,
                        NumberInTheList = 1

                    },
                    new Candidate
                    {
                        Id = 3,
                        UserId = 3,
                        ElectionId = 1,
                        NumberInTheList = 1

                    },
                    new Candidate
                    {
                        Id = 4,
                        UserId = 4,
                        ElectionId = 1,
                        NumberInTheList = 1
                    }
                    );
                context.Voices.AddRange(
                    new Voice
                    {
                        Id = 1,
                        UserId = 1,
                        CandidatId = 1,
                        ElectionId = 1,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 2,
                        UserId = 2,
                        CandidatId = 1,
                        ElectionId = 1,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 3,
                        UserId = 3,
                        CandidatId = 1,
                        ElectionId = 1,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 4,
                        UserId = 4,
                        CandidatId = 2,
                        ElectionId = 1,
                        VirtualDistrictId = 2
                    },
                    new Voice
                    {
                        Id = 5,
                        UserId = 5,
                        CandidatId = 2,
                        ElectionId = 1,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 6,
                        UserId = 6,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 1
                    }
                    );
                context.Watchers.AddRange
                    (
                    new Watcher
                    {
                        Id = 1,
                        CandidateId = 1,
                        ElectionId = 1,
                        UserId = 1,
                        VirtualCantonId = 1,

                    }
                    );
                context.SaveChanges();
            }
        }


    }
}

