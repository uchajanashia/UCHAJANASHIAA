using System;
using UCHAJANASHIA.FINAL.Data.interfaces;
using static UCHAJANASHIA.FINAL.Data.DTo.CatDTO;
using UCHAJANASHIA.FINAL.Models;
using UCHAJANASHIA.FINAL.Data;
using static UCHAJANASHIA.FINAL.Data.DTo.ToyDto;

namespace UCHAJANASHIA.FINAL.Service
{
    public class CatAndToyService : ICatAndToyService
    {
        private readonly IConfiguration _configuration;

        public CatAndToyService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void AddCat(AddCatDto addCatDto)
        {
            using (var context = new ApplicationDbContext(_configuration))
            {
                var cat = new Cat
                {
                    Name = addCatDto.Name,
                    Gender = addCatDto.Gender,
                    Birhtday = addCatDto.Birhtday,
                    Color = addCatDto.Color,
                    Breed = addCatDto.Breed,
                };
                context!.Cat.Add(cat);
                context!.SaveChanges();
            }
        }

        public List<GetCatDto> GetCats()
        {
            List<GetCatDto> getCatDtos = new List<GetCatDto>();
            using (var context = new ApplicationDbContext(_configuration))
            {
                var CatList = context.Cat.ToList();
                foreach (var cat in CatList ?? [])
                {
                    getCatDtos.Add(new GetCatDto
                    {
                        Id = cat.Id,
                        Name = cat.Name,
                        Gender = cat.Gender,
                        Birhtday = cat.Birhtday,
                        Color = cat.Color,
                        Breed = cat.Breed
                    }
                    );
                }
            }
            return getCatDtos;
        }

        public List<GetToyDto> getToys(int id)
        {   

            List<GetToyDto> getToys = new List<GetToyDto>();
            using (var context = new ApplicationDbContext(_configuration))
            {
                var cat = context.Cat.Find(id);
                var toyList = cat.CatToysList;
                foreach (var item in toyList ?? [])
                {
                    getToys.Add(new GetToyDto
                    {
                        Id = item.Id,
                        ToyName = item.ToyName,
                        ToyColor = item.ToyColor,
                        ToyWeight = item.ToyWeight,
                    });
                }
            }
            return getToys;


        }
        public void DeleteCat(int id)
        {
            using (var context = new ApplicationDbContext(_configuration))
            {

                var cat = context.Cat.Find(id);
                if (cat != null)
                {
                    context.Cat.Remove(cat);
                    context.SaveChanges();
                }

            }
        }
        public void DeleteToy(int id)
        {
            using (var context = new ApplicationDbContext(_configuration))
            {

                var toy = context.Toy.Find(id);
                if (toy != null)
                {
                    context.Toy.Remove(toy);
                    context.SaveChanges();
                }

            }
        }

        public GetCatDto GetCat(int id)
        {
            var getCat = new GetCatDto();
            using (var context = new ApplicationDbContext(_configuration))
            {
                var cat = context.Cat.Find(id);
                if (cat != null)
                {
                    getCat = new GetCatDto
                    {
                        Id = cat.Id,
                        Name = cat.Name,
                        Gender = cat.Gender,
                        Birhtday = cat.Birhtday,
                        Color = cat.Color,
                        Breed = cat.Breed
                    };
                }

            }
            return getCat;
        }

        public void UpdateCat(GetCatDto getCat)
        {
            using (var context = new ApplicationDbContext(_configuration))
            {
                var cat = context.Cat.Find(getCat.Id);

                if (cat == null)
                    return;

                cat.Birhtday = getCat.Birhtday;
                cat.Color = getCat.Color;
                cat.Gender = getCat.Gender;
                cat.Breed = getCat.Breed;
                cat.Name = getCat.Name;

                context.Cat.Update(cat);
                context.SaveChanges();
            }
        }
    }
}
