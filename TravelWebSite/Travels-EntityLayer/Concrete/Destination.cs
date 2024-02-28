using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Travels_EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }
        public string City { get; set; }
        public string DateNight { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
        public string? ColorImage { get; set; }
        public string? Details1 { get; set; }
        public string? Details2 { get; set;}
        public string? Image2 { get; set; }
        public List<Comment> Comment { get; set; }
        public List<Rezervation> Rezervations { get; set; }
        public int? GuidId { get; set; }
        public Guide Guide { get; set; }



    }
}
