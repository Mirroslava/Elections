using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionLand.Models
{

    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Будь ласка, вкажість ваше ім'я")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Будь ласка, вкажість ваше прізвище")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Будь ласка, вкажість дату вашого народження")]
        [Remote(action: "BirthDateCheck", controller:"Cabinet")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Будь ласка, вкажість ваш код ")]
        [Remote(action:"UniquePINCheck", controller:"Cabinet")]
        [Range(1000000000000,9999999999999,ErrorMessage ="Код містить 13 цифр")]
        public long PIN { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = "Будь ласка, вкажість ваш логін")]
        [Remote(action:"UniqueLoginCheck", controller:"Cabinet", HttpMethod ="POST",ErrorMessage ="Account with such login has already been created")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Будь ласка, вкажість ваш пароль")]
        [StringLength(30, MinimumLength =6 ,ErrorMessage ="Пароль має вміщувати хоча б 6 символів")]
        public string Password { get; set; }


        public List<StatusToUser> StatusToUsers { get; set; }
        public List<UserToRole> UserToRoles { get; set; }
        public List<Watcher> Watchers { get; set; }
        public List<Voice> Voices { get; set; }
        public List<UsetToVirtualDistrict> UsetToVirtualDistricts { get; set; }
        public List<CharmanDC> CharmanDCs { get; set; }
        public List<ChairmanCC> ChairmanCCs { get; set; }
        public List<Election> Elections { get; set; }
        public List<Appeal> Appeals { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
