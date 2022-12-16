using Birak_Exam_Backend.Models;
using System.Collections.Generic;

namespace Birak_Exam_Backend.Repositories
{
    public interface IClothesRepository
    {
        public IEnumerable<Clothes> GetAll();

        public Clothes GetById(int id);

        public void Add(Clothes clothes);

        public void Update(Clothes clothes);

        public void DeleteById(int id);
    }
}
