using System;

namespace Birak_Exam_Backend.Models
{
    public class Clothes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }
        public DateTime Date { get; set;}
        public double Size { get; set;}
        public string Model { get; set;}
        public int Quantity { get; set; }
        public bool IsBought { get; set; }
        public int Discount { get; set; }

    }
}
