using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key] // [] -> attribute kullanımı -- bunun kullanılabilmes için "EntityFreamwork6" nugetinin yüklenmesi gerekmektedir.
        public int AboutId { get; set; }

        [StringLength(1000)]
        public string AboutDetail { get; set; }

        [StringLength(1000)]
        public string AboutDetail2 { get; set; }

        [StringLength(100)]
        public string AboutImage { get; set; }

        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}
