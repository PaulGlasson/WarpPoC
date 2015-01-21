﻿using System;
using System.Web.Mvc;
using FluentValidation;

namespace Warp.WebUI.Infrastructure
{
    public class FluentValidatorFactory : ValidatorFactoryBase
    {
        public override IValidator CreateInstance(Type validatorType)
        {
            return DependencyResolver.Current.GetService(validatorType) as IValidator;
        }
    }
}