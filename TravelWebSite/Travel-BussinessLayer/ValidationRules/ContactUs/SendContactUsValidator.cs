using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelsalDTOLayer.DTO_s.ContactDTOs;

namespace Travel_BussinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator:AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Alanı boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı boş geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj Alanı boş geçilemez");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu Alanına en az 5 karakter girmelisiniz");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu Alanına en fazla 100 karakter girebilirsiniz");
        }
    }
}
