namespace UCHAJANASHIA.FINAL.Data.DTo
{
    public class ToyDto
    {
        public class GetToyDto
        {
            public int Id { get; set; }
            public string? ToyName { get; set; }
            public string? ToyColor { get; set; }
            public float? ToyWeight { get; set; }
            public int? OwnerCatID { get; set; }

        }


    }
}
