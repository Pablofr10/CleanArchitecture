using System;

namespace CleanArchitecture.Core.Entities
{
    public class Product
    {

        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Active { get; set; }
    }
}
