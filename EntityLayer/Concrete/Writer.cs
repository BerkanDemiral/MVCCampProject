using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {

        [Key]
        public int WriterId { get; set; }

        [StringLength(40)]
        public string NickName { get; set; }

        [StringLength(100)]
        public string WriterImage { get; set; }

        [StringLength(250)]
        public String AboutWriter { get; set; }

        [StringLength(50)]
        public string WriterEmail { get; set; }

        [StringLength(300)]
        public string WriterPassword { get; set; }

        [StringLength(100)]
        public String WriterTitle { get; set; }

        public ICollection<Heading> Headings { get; set; } // başlığı bir yazar açacak ve başlığı açam yazarı bulabileceğiz. 
                                                           // ve 1 yazar birden fazla başlık açabileceği için bunu yaptık(bu yazarın açtığı başlıklar vs..) 

       public ICollection<Content> Contents { get; set; } // bir yazar birden çok içerik yazabilir
}
}
