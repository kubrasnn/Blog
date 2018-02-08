using Blog.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.Validations
{
    public class RolValidator : AbstractValidator<Rol>
    {
        public RolValidator()
        {
            RuleFor(x => x.RolAdi).NotEmpty().WithMessage("Rol adı boş geçilemez!");
            RuleFor(x => x.RolAdi).MaximumLength(50).WithMessage("Rol adı en fazla 50 karakter olmalıdır!");
        }
    }
}
