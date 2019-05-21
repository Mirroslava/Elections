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
                        BirthDate = new DateTime(1983, 5, 7),
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
                        BirthDate = new DateTime(1968, 01, 03),
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
                     },
                      new User
                      {
                          Id = 11,
                          FirstName = "Victor",
                          LastName = "Hanyk",
                          PIN = 1234567890183,
                          BirthDate = new DateTime(1999, 06, 01),
                          Login = "Victor",
                          Email = "Victor@gmail.com",
                          Password = "123456"

                      },
                       new User
                       {
                           Id = 12,
                           FirstName = "Vasyl",
                           LastName = "Didur",
                           PIN = 1234567890223,
                           BirthDate = new DateTime(1986, 04, 11),
                           Login = "Vasyl",
                           Email = "Vasyl@gmail.com",
                           Password = "123456"

                       },
                       new User
                       {
                           Id = 13,
                           FirstName = "Kyrylo",
                           LastName = "Vovryk",
                           PIN = 1234567890127,
                           BirthDate = new DateTime(1977, 10, 12),
                           Login = "Kyrylo",
                           Email = "Kyrylo@gmail.com",
                           Password = "123456"

                       },
                       new User
                       {
                           Id = 14,
                           FirstName = "Ruslan",
                           LastName = "Kochevy",
                           PIN = 1234567890128,
                           BirthDate = new DateTime(1965, 8, 11),
                           Login = "Ruslan",
                           Email = "Ruslan@gmail.com",
                           Password = "123456"

                       },
                       new User
                       {
                           Id = 15,
                           FirstName = "Mikle",
                           LastName = "Sheptun",
                           PIN = 1234567890129,
                           BirthDate = new DateTime(1996, 8, 07),
                           Login = "Mikle",
                           Email = "Mikle@gmail.com",
                           Password = "123456"

                       },
                       new User
                       {
                           Id = 16,
                           FirstName = "Volodymyr",
                           LastName = "Sydorko",
                           PIN = 1234567890124,
                           BirthDate = new DateTime(1974, 8, 07),
                           Login = "Volodymyr",
                           Email = "Volodymyr@gmail.com",
                           Password = "123456"

                       },
                       new User
                       {
                           Id = 17,
                           FirstName = "Karl",
                           LastName = "Stopin",
                           PIN = 1234567890122,
                           BirthDate = new DateTime(1958, 08, 11),
                           Login = "Karl",
                           Email = "Karl@gmail.com",
                           Password = "123456"

                       },
                       new User
                       {
                           Id = 18,
                           FirstName = "Kelvin",
                           LastName = "Klien",
                           PIN = 1234567890126,
                           BirthDate = new DateTime(1989, 09, 11),
                           Login = "Kelvin",
                           Email = "Kelvin@gmail.com",
                           Password = "123456"

                       },
                       new User
                       {
                           Id = 19,
                           FirstName = "Zara",
                           LastName = "Nadieva",
                           PIN = 2234567890123,
                           BirthDate = new DateTime(1949, 02, 11),
                           Login = "Zara",
                           Email = "Zara@gmail.com",
                           Password = "123456"

                       },
                       new User
                       {
                           Id = 20,
                           FirstName = "Olesya",
                           LastName = "Dovbko",
                           PIN = 3234567890123,
                           BirthDate = new DateTime(1966, 08, 11),
                           Login = "Olesya",
                           Email = "Olesya@gmail.com",
                           Password = "123456"


                       },
                       new User
                       {
                           Id = 21,
                           FirstName = "Her",
                           LastName = "Deda",
                           PIN = 4234567890123,
                           BirthDate = new DateTime(1956, 08, 11),
                           Login = "Her",
                           Email = "Her@gmail.com",
                           Password = "123456"

                       },
                       new User
                       {
                           Id = 22,
                           FirstName = "Huk",
                           LastName = "Praviy",
                           PIN = 4234567880123,
                           BirthDate = new DateTime(1981, 07, 07),
                           Login = "Huk",
                           Email = "Huk@gmail.com",
                           Password = "123456"

                       },
                       new User
                       {
                           Id = 23,
                           FirstName = "Gid",
                           LastName = "Sex",
                           PIN = 4235567880123,
                           BirthDate = new DateTime(1971, 04, 02),
                           Login = "Gid",
                           Email = "Gid@gmail.com",
                           Password = "123456"

                       },
                       new User
                       {
                           Id = 24,
                           FirstName = "Dira",
                           LastName = "Divky",
                           PIN = 4234567480123,
                           BirthDate = new DateTime(1994, 08, 09),
                           Login = "Dira",
                           Email = "Dira@gmail.com",
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
                    },
                    new UserToRole
                    {
                        Id = 11,
                        UserId = 11,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 12,
                        UserId = 12,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 13,
                        UserId = 13,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 14,
                        UserId = 14,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 15,
                        UserId = 15,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 16,
                        UserId = 16,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 17,
                        UserId = 17,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 18,
                        UserId = 18,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 19,
                        UserId = 19,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 20,
                        UserId = 20,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 21,
                        UserId = 21,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 22,
                        UserId = 22,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 23,
                        UserId = 23,
                        RoleId = 2
                    },
                    new UserToRole
                    {
                        Id = 24,
                        UserId = 24,
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
                        UserStatusId = 2,
                        ElectionId = 1
                    },
                     new StatusToUser
                     {
                         Id = 2,
                         UserId = 4,
                         UserStatusId = 2,
                         ElectionId = 1
                     },
                      new StatusToUser
                      {
                          Id = 3,
                          UserId = 5,
                          UserStatusId = 2,
                          ElectionId = 1
                      },
                       new StatusToUser
                       {
                           Id = 4,
                           UserId = 6,
                           UserStatusId = 2,
                           ElectionId = 1
                       },
                        new StatusToUser
                        {
                            Id = 5,
                            UserId = 7,
                            UserStatusId = 2,
                            ElectionId = 1
                        },
                         new StatusToUser
                         {
                             Id = 6,
                             UserId = 8,
                             UserStatusId = 2,
                             ElectionId = 1
                         },
                          new StatusToUser
                          {
                              Id = 7,
                              UserId = 9,
                              UserStatusId = 3,
                              ElectionId = 1
                          },
                           new StatusToUser
                           {
                               Id = 8,
                               UserId = 10,
                               UserStatusId = 3,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 9,
                               UserId = 11,
                               UserStatusId = 4,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 10,
                               UserId = 12,
                               UserStatusId = 5,
                               ElectionId = 1
                           }, new StatusToUser
                           {
                               Id = 11,
                               UserId = 13,
                               UserStatusId = 5,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 12,
                               UserId = 14,
                               UserStatusId = 5,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 13,
                               UserId = 15,
                               UserStatusId = 5,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 14,
                               UserId = 16,
                               UserStatusId = 1,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 15,
                               UserId = 17,
                               UserStatusId = 1,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 16,
                               UserId = 18,
                               UserStatusId = 1,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 17,
                               UserId = 19,
                               UserStatusId = 1,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 18,
                               UserId = 20,
                               UserStatusId = 1,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 19,
                               UserId = 21,
                               UserStatusId = 1,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 20,
                               UserId = 22,
                               UserStatusId = 1,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 21,
                               UserId = 23,
                               UserStatusId = 1,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 22,
                               UserId = 24,
                               UserStatusId = 1,
                               ElectionId = 1
                           },
                           new StatusToUser
                           {
                               Id = 23,
                               UserId = 3,
                               UserStatusId = 1,
                               ElectionId = 2
                           },
                     new StatusToUser
                     {
                         Id = 24,
                         UserId = 4,
                         UserStatusId = 1,
                         ElectionId = 2
                     },
                      new StatusToUser
                      {
                          Id = 25,
                          UserId = 5,
                          UserStatusId = 1,
                          ElectionId = 2
                      },
                       new StatusToUser
                       {
                           Id = 26,
                           UserId = 6,
                           UserStatusId = 5,
                           ElectionId = 2
                       },
                        new StatusToUser
                        {
                            Id = 27,
                            UserId = 7,
                            UserStatusId = 5,
                            ElectionId = 2
                        },
                         new StatusToUser
                         {
                             Id = 28,
                             UserId = 8,
                             UserStatusId = 5,
                             ElectionId = 2
                         },
                          new StatusToUser
                          {
                              Id = 29,
                              UserId = 9,
                              UserStatusId = 5,
                              ElectionId = 2
                          },
                           new StatusToUser
                           {
                               Id = 30,
                               UserId = 10,
                               UserStatusId = 1,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 31,
                               UserId = 11,
                               UserStatusId = 1,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 32,
                               UserId = 12,
                               UserStatusId = 1,
                               ElectionId = 2
                           }, new StatusToUser
                           {
                               Id = 33,
                               UserId = 13,
                               UserStatusId = 1,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 34,
                               UserId = 14,
                               UserStatusId = 1,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 35,
                               UserId = 15,
                               UserStatusId = 1,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 36,
                               UserId = 16,
                               UserStatusId = 4,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 37,
                               UserId = 17,
                               UserStatusId = 3,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 38,
                               UserId = 18,
                               UserStatusId = 3,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 39,
                               UserId = 19,
                               UserStatusId = 2,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 40,
                               UserId = 20,
                               UserStatusId = 2,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 41,
                               UserId = 21,
                               UserStatusId = 2,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 42,
                               UserId = 22,
                               UserStatusId = 2,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 43,
                               UserId = 23,
                               UserStatusId = 2,
                               ElectionId = 2
                           },
                           new StatusToUser
                           {
                               Id = 44,
                               UserId = 24,
                               UserStatusId = 2,
                               ElectionId = 2
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
                         VirtualCantonId = 2
                     },
                     new VirtualDistrict
                     {
                         Id = 5,
                         Title = "AlterAgo",
                         Adress = "Lviv",
                         VirtualCantonId = 2
                     },
                     new VirtualDistrict
                     {
                         Id = 6,
                         Title = "Dauny",
                         Adress = "Lviv",
                         VirtualCantonId = 2
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
                        ChairmanСVK = 11
                    },
                    new Election
                    {
                        Id = 2,
                        Title = "Вибори2018",
                        Year = 2018,
                        StartElection = new DateTime(2018, 3, 28, 8, 0, 0),
                        EndElection = new DateTime(2018, 3, 28, 20, 0, 0),
                        ChairmanСVK = 16
                    }
                    );
                context.Candidates.AddRange(
                    new Candidate
                    {
                        Id = 1,
                        UserId = 16,
                        ElectionId = 1,
                        NumberInTheList = 1
                    },
                    new Candidate
                    {
                        Id = 2,
                        UserId = 17,
                        ElectionId = 1,
                        NumberInTheList = 1

                    },
                    new Candidate
                    {
                        Id = 3,
                        UserId = 18,
                        ElectionId = 1,
                        NumberInTheList = 1

                    },
                    new Candidate
                    {
                        Id = 4,
                        UserId = 19,
                        ElectionId = 1,
                        NumberInTheList = 1
                    },
                    new Candidate
                    {
                        Id = 5,
                        UserId = 3,
                        ElectionId = 2,
                        NumberInTheList = 1
                    },
                    new Candidate
                    {
                        Id = 6,
                        UserId = 4,
                        ElectionId = 2,
                        NumberInTheList = 1
                    },
                    new Candidate
                    {
                        Id = 7,
                        UserId = 5,
                        ElectionId = 2,
                        NumberInTheList = 1
                    },
                    new Candidate
                    {
                        Id = 8,
                        UserId = 10,
                        ElectionId = 2,
                        NumberInTheList = 1
                    }

                    );
                context.Voices.AddRange(
                    new Voice
                    {
                        Id = 1,
                        UserId = 3,
                        CandidatId = 1,
                        ElectionId = 1,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 2,
                        UserId = 4,
                        CandidatId = 1,
                        ElectionId = 1,
                        VirtualDistrictId = 2
                    },
                    new Voice
                    {
                        Id = 3,
                        UserId = 5,
                        CandidatId = 1,
                        ElectionId = 1,
                        VirtualDistrictId = 3
                    },
                    new Voice
                    {
                        Id = 4,
                        UserId = 6,
                        CandidatId = 2,
                        ElectionId = 1,
                        VirtualDistrictId = 4
                    },
                    new Voice
                    {
                        Id = 5,
                        UserId = 7,
                        CandidatId = 2,
                        ElectionId = 1,
                        VirtualDistrictId = 5
                    },
                    new Voice
                    {
                        Id = 6,
                        UserId = 8,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 6
                    },
                    new Voice
                    {
                        Id = 7,
                        UserId = 9,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 8,
                        UserId = 10,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 2
                    },
                    new Voice
                    {
                        Id = 9,
                        UserId = 11,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 3
                    },
                    new Voice
                    {
                        Id = 10,
                        UserId = 12,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 11,
                        UserId = 13,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 2
                    },
                    new Voice
                    {
                        Id = 12,
                        UserId = 14,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 3
                    },
                    new Voice
                    {
                        Id = 13,
                        UserId = 15,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 4
                    },
                    new Voice
                    {
                        Id = 14,
                        UserId = 16,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 5
                    },
                    new Voice
                    {
                        Id = 15,
                        UserId = 17,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 6
                    },
                    new Voice
                    {
                        Id = 16,
                        UserId = 18,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 17,
                        UserId = 19,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 2
                    },
                    new Voice
                    {
                        Id = 18,
                        UserId = 20,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 3
                    },
                    new Voice
                    {
                        Id = 19,
                        UserId = 21,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 4
                    },
                    new Voice
                    {
                        Id = 20,
                        UserId = 22,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 5
                    },
                    new Voice
                    {
                        Id = 21,
                        UserId = 23,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 6
                    },
                    new Voice
                    {
                        Id = 22,
                        UserId = 24,
                        CandidatId = 3,
                        ElectionId = 1,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 23,
                        UserId = 3,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 24,
                        UserId = 4,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 2
                    },
                    new Voice
                    {
                        Id = 25,
                        UserId = 5,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 3
                    },
                    new Voice
                    {
                        Id = 26,
                        UserId = 6,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 27,
                        UserId = 7,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 2
                    },
                    new Voice
                    {
                        Id = 28,
                        UserId = 8,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 4
                    },
                    new Voice
                    {
                        Id = 29,
                        UserId = 9,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 6
                    },
                    new Voice
                    {
                        Id = 30,
                        UserId = 10,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 31,
                        UserId = 11,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 2
                    },
                    new Voice
                    {
                        Id = 32,
                        UserId = 12,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 3
                    },
                    new Voice
                    {
                        Id = 33,
                        UserId = 13,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 4
                    },
                    new Voice
                    {
                        Id = 34,
                        UserId = 14,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 5
                    },
                    new Voice
                    {
                        Id = 35,
                        UserId = 15,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 6
                    },
                    new Voice
                    {
                        Id = 36,
                        UserId = 16,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 37,
                        UserId = 17,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 2
                    },
                    new Voice
                    {
                        Id = 38,
                        UserId = 18,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 3
                    },
                    new Voice
                    {
                        Id = 39,
                        UserId = 19,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 4
                    },
                    new Voice
                    {
                        Id = 40,
                        UserId = 20,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 5
                    },
                    new Voice
                    {
                        Id = 41,
                        UserId = 21,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 6
                    },
                    new Voice
                    {
                        Id = 42,
                        UserId = 22,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 1
                    },
                    new Voice
                    {
                        Id = 43,
                        UserId = 23,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 2
                    },
                    new Voice
                    {
                        Id = 44,
                        UserId = 24,
                        CandidatId = 3,
                        ElectionId = 2,
                        VirtualDistrictId = 3
                    }
                    );
                context.Watchers.AddRange
                    (
                    new Watcher
                    {
                        Id = 1,
                        CandidateId = 1,
                        ElectionId = 1,
                        UserId = 12,
                        VirtualDistrictId = 1
                    },
                    new Watcher
                    {
                        Id = 2,
                        CandidateId = 2,
                        ElectionId = 1,
                        UserId = 13,
                        VirtualDistrictId = 1
                    },
                    new Watcher
                    {
                        Id = 3,
                        CandidateId = 3,
                        ElectionId = 1,
                        UserId = 14,
                        VirtualDistrictId = 1
                    },
                    new Watcher
                    {
                        Id = 4,
                        CandidateId = 4,
                        ElectionId = 1,
                        UserId = 15,
                        VirtualDistrictId = 1
                    },
                    new Watcher
                    {
                        Id = 5,
                        CandidateId = 5,
                        ElectionId = 2,
                        UserId = 6,
                        VirtualDistrictId = 1
                    },
                    new Watcher
                    {
                        Id = 6,
                        CandidateId = 6,
                        ElectionId = 2,
                        UserId = 7,
                        VirtualDistrictId = 1
                    },
                    new Watcher
                    {
                        Id = 7,
                        CandidateId = 7,
                        ElectionId = 2,
                        UserId = 8,
                        VirtualDistrictId = 2
                    },
                    new Watcher
                    {
                        Id = 8,
                        CandidateId = 8,
                        ElectionId = 2,
                        UserId = 9,
                        VirtualDistrictId = 2
                    }
                    );
                context.Appeals.AddRange
                    (

                    new Appeal
                    {
                        Id = 1,
                        Type = "1",
                        Text = "adfsgdsfd",
                        ElectionId = 1,
                        UserId = 17,
                        CandidateId = 3,
                        VirtualDistrictId = 6

                    },
                    new Appeal
                    {
                        Id = 2,
                        Type = "1",
                        Text = "adfsgdsfd",
                        ElectionId = 1,
                        UserId = 19,
                        CandidateId = 2,
                        VirtualDistrictId = 3

                    },
                    new Appeal
                    {
                        Id = 3,
                        Type = "1",
                        Text = "adfsgdsfd",
                        ElectionId = 1,
                        UserId = 20,
                        CandidateId = 1,
                        VirtualDistrictId = 4

                    },
                    new Appeal
                    {
                        Id = 4,
                        Type = "1",
                        Text = "adfsgdsfd",
                        ElectionId = 1,
                        UserId = 22,
                        CandidateId = 4,
                        VirtualDistrictId = 1
                    },
                    new Appeal
                    {
                        Id = 5,
                        Type = "1",
                        Text = "wqewrerq",
                        ElectionId = 2,
                        UserId = 11,
                        CandidateId = 5,
                        VirtualDistrictId = 2
                    },
                    new Appeal
                    {
                        Id = 6,
                        Type = "1",
                        Text = "wqewrerq",
                        ElectionId = 2,
                        UserId = 13,
                        CandidateId = 6,
                        VirtualDistrictId = 4
                    },
                    new Appeal
                    {
                        Id = 7,
                        Type = "1",
                        Text = "wqewrerq",
                        ElectionId = 2,
                        UserId = 15,
                        CandidateId = 7,
                        VirtualDistrictId = 6
                    },
                    new Appeal
                    {
                        Id = 8,
                        Type = "1",
                        Text = "wqewrerq",
                        ElectionId = 2,
                        UserId = 3,
                        CandidateId = 8,
                        VirtualDistrictId = 1
                    }
                    );

                context.Complaintses.AddRange
                    (
                    new Complaints
                    {
                        Id = 1,
                        Type = "1",
                        Text = "qwredws",
                        ElectionId = 1,
                        VirtualDistrictId = 1,
                        WatcherId = 1
                    },
                    new Complaints
                    {
                        Id = 2,
                        Type = "1",
                        Text = "qwredws",
                        ElectionId = 1,
                        VirtualDistrictId = 2,
                        WatcherId = 2
                    },
                    new Complaints
                    {
                        Id = 3,
                        Type = "1",
                        Text = "qwredws",
                        ElectionId = 1,
                        VirtualDistrictId = 3,
                        WatcherId = 3
                    },
                    new Complaints
                    {
                        Id = 4,
                        Type = "1",
                        Text = "qwredws",
                        ElectionId = 1,
                        VirtualDistrictId = 4,
                        WatcherId = 4
                    },
                    new Complaints
                    {
                        Id = 5,
                        Type = "1",
                        Text = "qwredws",
                        ElectionId = 1,
                        VirtualDistrictId = 1,
                        WatcherId = 5
                    },
                    new Complaints
                    {
                        Id = 6,
                        Type = "1",
                        Text = "qwredws",
                        ElectionId = 1,
                        VirtualDistrictId = 2,
                        WatcherId = 6
                    },
                    new Complaints
                    {
                        Id = 7,
                        Type = "1",
                        Text = "qwredws",
                        ElectionId = 1,
                        VirtualDistrictId = 4,
                        WatcherId = 7
                    },
                    new Complaints
                    {
                        Id = 8,
                        Type = "1",
                        Text = "qwredws",
                        ElectionId = 1,
                        VirtualDistrictId = 6,
                        WatcherId = 8
                    }
                    );
                context.UsetToVirtualDistricts.AddRange(
                    new UsetToVirtualDistrict
                    {
                        Id = 1,
                        UserId = 1,
                        VirtualDistrictId = 1
                    },
                    new UsetToVirtualDistrict
                    {
                        Id = 2,
                        UserId = 2,
                        VirtualDistrictId = 1
                    },
                    new UsetToVirtualDistrict
                    {
                        Id = 3,
                        UserId = 3,
                        VirtualDistrictId = 1
                    },
                    new UsetToVirtualDistrict
                    {
                        Id = 4,
                        UserId = 4,
                        VirtualDistrictId = 1
                    },
                    new UsetToVirtualDistrict
                    {
                        Id = 5,
                        UserId = 5,
                        VirtualDistrictId = 2
                    },
                    new UsetToVirtualDistrict
                    {
                        Id = 6,
                        UserId = 6,
                        VirtualDistrictId = 2
                    },
                    new UsetToVirtualDistrict
                    {
                        Id = 7,
                        UserId = 7,
                        VirtualDistrictId = 2
                    },
                    new UsetToVirtualDistrict
                    {
                        Id = 8,
                        UserId = 8,
                        VirtualDistrictId = 2
                    },
                    new UsetToVirtualDistrict
                    {
                        Id = 9,
                        UserId = 9,
                        VirtualDistrictId = 3
                    },
                    new UsetToVirtualDistrict
                    {
                        Id = 10,
                        UserId = 10,
                        VirtualDistrictId = 3
                    },
                     new UsetToVirtualDistrict
                     {
                         Id = 11,
                         UserId = 11,
                         VirtualDistrictId = 3
                     },
                      new UsetToVirtualDistrict
                      {
                          Id = 12,
                          UserId = 12,
                          VirtualDistrictId = 3
                      },
                       new UsetToVirtualDistrict
                       {
                           Id = 13,
                           UserId = 13,
                           VirtualDistrictId = 3
                       },
                        new UsetToVirtualDistrict
                        {
                            Id = 14,
                            UserId = 14,
                            VirtualDistrictId = 3
                        },
                         new UsetToVirtualDistrict
                         {
                             Id = 15,
                             UserId = 15,
                             VirtualDistrictId = 3
                         },
                          new UsetToVirtualDistrict
                          {
                              Id = 16,
                              UserId = 16,
                              VirtualDistrictId = 3
                          },
                           new UsetToVirtualDistrict
                           {
                               Id = 17,
                               UserId = 17,
                               VirtualDistrictId = 4
                           },
                            new UsetToVirtualDistrict
                            {
                                Id = 21,
                                UserId = 21,
                                VirtualDistrictId = 4
                            },
                             new UsetToVirtualDistrict
                             {
                                 Id = 18,
                                 UserId = 18,
                                 VirtualDistrictId = 4
                             },
                              new UsetToVirtualDistrict
                              {
                                  Id = 19,
                                  UserId = 19,
                                  VirtualDistrictId = 4
                              },
                               new UsetToVirtualDistrict
                               {
                                   Id = 20,
                                   UserId = 20,
                                   VirtualDistrictId = 4
                               });
                context.SaveChanges();
            }
        }
    }
}

