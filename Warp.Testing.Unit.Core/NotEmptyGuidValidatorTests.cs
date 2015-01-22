﻿using System;
using System.Collections.Generic;
using FluentValidation;
using FluentValidation.Internal;
using FluentValidation.Results;
using FluentValidation.Validators;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Infrastructure.Util;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Testing.Unit.Core
{
    [Subject("NotEmptyGuidValidator tests")]
    public class NotEmptyGuidValidatorTests
    {
        //public class When_calling__NotNull__with_a_null_parameter : WithSubject<NotEmptyGuidValidator>
        //{
        //    Because of = () => _result = Subject.Validate(new PropertyValidatorContext(new ValidationContext(Guid.Empty), new PropertyRule(), String.Empty));

        //    It should_throw_an_exception = () =>
        //    {
        //        _result.ShouldNotBeNull();
        //    };

        //    static IEnumerable<ValidationFailure> _result;
        //}
    }
}