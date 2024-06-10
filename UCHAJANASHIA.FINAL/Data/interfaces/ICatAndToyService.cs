using static UCHAJANASHIA.FINAL.Data.DTo.CatDTO;
using static UCHAJANASHIA.FINAL.Data.DTo.ToyDto;

namespace UCHAJANASHIA.FINAL.Data.interfaces
{
    public interface ICatAndToyService
    {
        public void AddCat(AddCatDto addCatDto);
        public List<GetCatDto> GetCats();
        public void DeleteCat(int id);
        public GetCatDto GetCat(int id);
        public void UpdateCat(GetCatDto getCat);
        public List<GetToyDto> getToys(int id);


    }
}
