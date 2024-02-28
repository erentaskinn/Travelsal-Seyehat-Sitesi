using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelsalDTOLayer.DTO_s.AnnouncementDTOs
{
    public class AnnouncementUptadeDto
    {
        public int AnnouncementId { get; set; }
        public string Title { get; set; }
        public string Conetent { get; set; }
        public DateTime Date { get; set; }
    }
}
