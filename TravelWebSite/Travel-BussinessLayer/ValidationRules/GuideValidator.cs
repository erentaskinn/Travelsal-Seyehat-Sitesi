using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travels_EntityLayer.Concrete;

namespace Travel_BussinessLayer.ValidationRules
{
    public class GuideValidator:AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim kısmı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen açıklama kısmı giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen göresel seçiniz...!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir isim giriniz...!");
        }
    }
}
