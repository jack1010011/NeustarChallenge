using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class AvailableItemsList
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool isCompleted { get; set; }
        public bool isFavorite { get; set; }
        public int Rate { get; set; }
        public int Price { get; set; }
        public int Purchases { get; set; }
        public string Comments { get; set; }
        public string ImagesSource { get; set; }
        public string VideosSource { get; set; }

        
    }
}
