using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using Birak_Exam_Backend.Models;
using System.Linq;

namespace Birak_Exam_Backend.Repositories
{
    public class ClothesRepository : IClothesRepository
    {
        private readonly DbSet<Clothes> _dbSet;
        private readonly ShopDbContext _context;

        public ClothesRepository(ShopDbContext context)
        {
            _context = context;
            _dbSet = context.ClothesItems;
        }

        public IEnumerable<Clothes> GetAll()
        {
            return _dbSet.AsNoTracking().AsEnumerable();
        }

        public Clothes GetById(int id)
        {
            return _dbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Add(Clothes clothes)
        {
            _dbSet.Add(clothes);
            _context.SaveChanges();
        }

        public void Update(Clothes clothes)
        {
            _dbSet.Update(clothes);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var clothes = GetById(id);

            if (clothes != null)
            {
                _dbSet.Remove(clothes);
                _context.SaveChanges();
            }
        }
    }
}
