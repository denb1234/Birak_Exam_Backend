using AutoMapper;
using Birak_Exam_Backend.Models;
using Birak_Exam_Backend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Birak_Exam_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothesItemsController : ControllerBase
    {
        private readonly IClothesRepository _clothesRepository;
        private readonly IMapper _mapper;

        public ClothesItemsController(IClothesRepository clothesRepository, IMapper mapper)
        {
            _clothesRepository = clothesRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            return Ok(_clothesRepository.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var clothes = _clothesRepository.GetById(id);
            if (clothes == null)
            {
                return NotFound();
            }

            return Ok(clothes);
        }

        [HttpPost]
        public IActionResult Add(ClothesViewModel clothes)
        {
            if (!clothes.IsBought)
            {
                var diff = DateTime.Today - clothes.Date;
                int monthDifference = diff.Days / 30;

                if (monthDifference > 0)
                {
                    clothes.Discount = (int)(Math.Floor(((double)monthDifference) / 2) * 10);
                }
            }

            _clothesRepository.Add(_mapper.Map<ClothesViewModel, Clothes>(clothes));

            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Clothes clothes)
        {

            if (_clothesRepository.GetById(clothes.Id) == null)
            {
                return NotFound();
            };

            if (!clothes.IsBought)
            {
                var diff = DateTime.Today - clothes.Date;
                int monthDifference = diff.Days / 30;

                if (monthDifference > 0)
                {
                    clothes.Discount = (int)(Math.Floor(((double)monthDifference) / 2) * 10);
                }
            }
            
            _clothesRepository.Update(clothes);

            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteById(int id)
        {
            if (_clothesRepository.GetById(id) == null)
            {
                return NotFound();
            };

            _clothesRepository.DeleteById(id);

            return Ok();
        }
    }
}
