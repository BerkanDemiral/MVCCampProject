using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext // bu değeri entityfreamwork'ten kalıttık
    {
        public DbSet<About> Abouts { get; set; } // About'u kullanabilmek için EntityLayer katmanını reference olarak eklemeliyiz
                                                 // about sınıfın ismi Abouts ise tablo ismi olarak tanımlanmıştır.

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
