using Blog.Entity.Entities;
using Blog.Repository.Repositories.Abstracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.Validations
{
    public class IletisimValidator : AbstractValidator<Iletisim>
    {
        public IletisimValidator()
        {
            RuleFor(x => x.IletisimMail).NotEmpty().WithMessage("Mail adresi girmelisiniz!");
            RuleFor(x => x.IletisimKonu).NotEmpty().WithMessage("Konunuzu ya da adınızı girmelisiniz!");
            RuleFor(x => x.Mesaj).NotEmpty().WithMessage("Mesajınızı girmelisiniz!");
        }
    }
}
