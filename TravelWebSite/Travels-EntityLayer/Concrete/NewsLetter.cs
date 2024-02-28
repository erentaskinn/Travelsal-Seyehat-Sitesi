using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travels_EntityLayer.Concrete
{
    public class NewsLetter
    {
        [Key]
        public int NewLetterId { get; set; }
        public string Email { get; set; }
    }
}
