using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading // diğer sınıflar tarafından erişilmesi için başına public ibaresi koyduk
    {

        [Key]
        public int HeadingId { get; set; }

        [StringLength(100)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate  { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public bool HeadingStatus { get; set; }

        public ICollection<Content> Contents { get; set; } // bu sefer 1 olan başlık çok olan içerik(mesajlar) kısmı

        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
