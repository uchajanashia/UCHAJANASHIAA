using System.ComponentModel.DataAnnotations;

namespace UCHAJANASHIA.FINAL.Models
{
    public class Toy
    {

        [Key] public int Id { get; set; }
        public string? ToyName { get; set; }
        public string? ToyColor { get; set; }
        public float? ToyWeight { get; set; }
        public Cat? OwnerCat { get; set; }
        public int? OwnerCatID { get; set; }

    }
}
