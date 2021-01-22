using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EkoWebShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
       
        [DisplayName("In stock")]
        public bool InStock { get; set; }
        public string ImagePath { get; set; }
        public string ImageThumbnailPath { get; set; }


        //Product {Id, name, CategoryId, Description, Price, InStock, ProducerId, Img, ImgThumbnail}
    }
}
