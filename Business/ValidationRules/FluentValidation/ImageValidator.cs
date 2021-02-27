﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ImageValidator:AbstractValidator<CarImage>
    {
        public ImageValidator()
        {
            RuleFor(p => p.CarId).NotEmpty();
            RuleFor(p => p.ImagePath).NotEmpty();
        }
    }
}
