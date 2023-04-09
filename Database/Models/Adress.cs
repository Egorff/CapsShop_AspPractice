using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    [Table("Adresses")]
    public class Adress
    {
        #region Prop
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Region { get; set; }
        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        public Postoffice PostOffice { get; set; }
        #endregion

        #region Nav prop
        //public key
        public Guid UserId { get; set; }
        public User User { get; set; }
        #endregion

        public Adress(Guid id, string country, string region, string city, Postoffice postoffice)
        {
            Id = id;
            Country = country;
            Region = region;
            City = city;
            PostOffice = postoffice;
        }

        public Adress()
        {

        }

        public override string ToString()
        {
            return $"{Id} {Country} {Region} {City}";
        }
    }
}
