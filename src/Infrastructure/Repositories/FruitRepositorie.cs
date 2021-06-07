using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;

namespace Infrastructure.Repositories
{
    public class FruitRepository : IFruitRepository
    {
        public ApplicationDbContext _context;

        public FruitRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Fruit> GetFruits()
        {
            return _context.Fruits;
        }
    }
}
