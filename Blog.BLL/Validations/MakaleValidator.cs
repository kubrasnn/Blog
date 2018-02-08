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
    public class MakaleValidator : AbstractValidator<Makale>
    {
        public MakaleValidator()
        {
            RuleFor(x => x.Baslik).NotEmpty().WithMessage("Başlık yazmalısınız!");
            RuleFor(x => x.Icerik).NotEmpty().WithMessage("İçerik yazmalısınız!");
            RuleFor(x => x.Baslik).MaximumLength(500).WithMessage("Başlık en fazla 500 karakter olmalıdır.");
        }
    }
}
