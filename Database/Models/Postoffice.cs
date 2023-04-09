using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    [Table("Postoffices")]
    public class Postoffice
    {
        #region Prop
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Number { get; set; }
        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Region { get; set; }
        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string House { get; set; }
        #endregion

        #region Nav prop
        public Guid AdressId { get; set; }
        public Adress Adress { get; set; }
        #endregion

        public Postoffice(Guid id, string number, string company, string country, string region, string city,
            string street, string house)
        {
            Id = id;
            Number = number;
            Company = company;
            Country = country;
            Region = region;
            City = city;
            Street = street;
            House = house;
        }

        public Postoffice()
        {

        }

        public override string ToString()
        {
            return $"{Id} {Number} {Company} {Country} {Region} {City} {Street} {House}";
        }
    }
}
