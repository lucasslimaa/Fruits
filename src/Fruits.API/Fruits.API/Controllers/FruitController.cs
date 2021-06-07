using Application.DTOs.Fruits;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fruits.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        private IFruitService _fruitService;

        public FruitController(IFruitService fruitService)
        {
            _fruitService = fruitService;
        }


        [HttpGet]
        public FruitDTO GetFruits()
        {
            FruitDTO data = _fruitService.GetFruits();
            return data;
        }

    }
}
