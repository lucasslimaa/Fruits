using Application.DTOs.Fruits;
using Application.Interfaces;
using Domain.Interfaces;
using System;

namespace Application.Services
{
    public class FruitService : IFruitService
    {
        public IFruitRepository _fruitRepository;

        public FruitService(IFruitRepository fruitRepository)
        {
            _fruitRepository = fruitRepository;
        }

        public FruitDTO GetFruits()
        {
            return new FruitDTO()
            {
                Fruits = _fruitRepository.GetFruits()
            };
        }
    }
}
