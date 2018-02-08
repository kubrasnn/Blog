using Blog.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.Validations
{
    public class YorumValidator : AbstractValidator<Yorum>
    {
        public YorumValidator()
        {
            RuleFor(x => x.YorumIcerigi).NotEmpty().WithMessage("Yorum boş geçilemez!");
            RuleFor(x => x.AdSoyad).MaximumLength(50).WithMessage("AdSoyad alanı en fazla 50 karakter olabilir!");
        }
    }
}
