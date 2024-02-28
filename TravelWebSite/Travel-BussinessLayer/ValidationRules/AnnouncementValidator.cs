using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travels_EntityLayer.Concrete;
using TravelsalDTOLayer.DTO_s.AnnouncementDTOs;

namespace Travel_BussinessLayer.ValidationRules
{
    public class AnnouncementValidator:AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlığı boş geçmeyiniz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Duyuru İçeriğini  boş geçmeyiniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Lütfen en az 20 karakter veri girişi yapınız");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter veri girişi yapınız");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen en fazla 500 karakter veri girişi yapınız");
        }
    }
}
