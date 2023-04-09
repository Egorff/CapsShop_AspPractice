using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Database.Models
{
    [Table("Users")]
    public class User : IdentityUser<Guid>
    {
        #region Prop
        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Surename { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        [Phone(ErrorMessage = "Incorrect phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        public List<Cap> Bin { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        public Adress Adress { get; set; }
        #endregion

        public User(string name, string surename, string phone, Adress adress)
        {
            Name = name;
            Surename = surename;
            Phone = phone;
            Adress = adress;
        }

        public User()
        {

        }
    }
}
