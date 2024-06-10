using UCHAJANASHIA.FINAL.Data.Enum;

namespace UCHAJANASHIA.FINAL.Data.DTo
{
    public class CatDTO
    {
        public class GetCatDto
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public DateOnly? Birhtday { get; set; }
            public Gender? Gender { get; set; }
            public string? Breed { get; set; }

            public string? Color { get; set; }


        }

        public class AddCatDto
        {
            public string? Name { get; set; }
            public DateOnly? Birhtday { get; set; }
            public Gender? Gender { get; set; }
            public string? Breed { get; set; }
            public string? Color { get; set; }
        }
    }
}
