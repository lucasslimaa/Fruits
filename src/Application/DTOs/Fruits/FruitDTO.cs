using System.Collections.Generic;
using Domain.Entities;

namespace Application.DTOs.Fruits
{
    public class FruitDTO
    {
        public IEnumerable<Fruit> Fruits { get; set; }
    }
}
