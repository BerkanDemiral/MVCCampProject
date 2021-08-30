using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(100)]
        public string CategoryName{ get; set; }

        [StringLength(1000)]
        public string CategoryDetail{ get; set; }
        public bool CategoryStatus{ get; set; } // ilişkili tablolarda silme işlemi yaparken kullanılacak..

        public ICollection<Heading> Headings { get; set; } // 1'e çok bir ilişki (1 başlıkta birden çok kategori bulunabilir) -- 1 OLAN BURASI(ICOLLECTİON) 
    }
}
