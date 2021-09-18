using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [StringLength(70)]
        public string SenderMail{ get; set; }

        [StringLength(70)]
        public string RecieverMail { get; set; }

        [StringLength(70)]
        public string Subject { get; set; }

        [StringLength(500)]
        public string MessageContent { get; set; }

        public DateTime MessageDate { get; set; }
    }
}
