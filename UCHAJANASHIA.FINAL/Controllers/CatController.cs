using Microsoft.AspNetCore.Mvc;
using static UCHAJANASHIA.FINAL.Data.DTo.CatDTO;
using UCHAJANASHIA.FINAL.Data.interfaces;

namespace UCHAJANASHIA.FINAL.Controllers
{
    public class CatController : Controller
    {
        private readonly ICatAndToyService _catAndToyService;

        public CatController(ICatAndToyService catAndToyService)
        {
            _catAndToyService = catAndToyService;
        }

        public IActionResult Index()
        {
            var CatList = _catAndToyService.GetCats();
            return View(CatList);
        }
        public IActionResult AddCat()
        {
            return View();
        }
        [Route("Cat/ToyList/{id}")]

        public IActionResult ToyList( int id)
        {
            var toyList = _catAndToyService.getToys(id);
            return View(toyList);
        }
        [Route("Cat/UpdateCat/{id}")]
        public IActionResult UpdateCat(int id)
        {
            var GetCatDto = _catAndToyService.GetCat(id);
            return View(GetCatDto);
        }

        [HttpPost]
        public IActionResult AddCat(AddCatDto addCatDto)
        {
            _catAndToyService.AddCat(addCatDto);
            return RedirectToAction("Index"); ;

        }
        [HttpPost]
        public IActionResult DeleteCat(int id)
        {
            _catAndToyService.DeleteCat(id); 
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteToy(int id)
        {
            _catAndToyService.DeleteCat(id);
            return RedirectToAction("ToyList/"+id);
        }
        [HttpPost]
        public IActionResult UpdateCat(GetCatDto getCatDto)
        {
            _catAndToyService.UpdateCat(getCatDto);
            return RedirectToAction("Index");
        }
    }
}
