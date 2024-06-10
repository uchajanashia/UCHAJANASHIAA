using System.ComponentModel.DataAnnotations;
using System.Reflection;
using UCHAJANASHIA.FINAL.Data.Enum;

namespace UCHAJANASHIA.FINAL.Models
{
    public class Cat
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly? Birhtday { get; set; }
        public Gender? Gender { get; set; }
        public string? Breed { get; set; }

        public string? Color { get; set; }

        public List<Toy>? CatToysList { get; set; }


    }
}
