using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    [Table("Caps")]
    public class Cap
    {
        #region Prop
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Technology { get; set; }

        [Required(ErrorMessage = "Field is mustn't be null.")]
        public string Image { get; set; }
        #endregion

        #region Navigation properties 
        //public key
        public Guid UserId { get; set; }
        public User User { get; set; }
        #endregion

        public Cap(Guid id, string description, string model, string brand, string technology, string image)
        {
            Id = id;
            Description = description;
            Model = model;
            Brand = brand;
            Technology = technology;
            Image = image;
        }

        public Cap()
        {

        }

        #region Methods
        public override string ToString()
        {
            return $"{Id} {Description} {Model} {Brand} {Technology}";
        }
        #endregion
    }
}
