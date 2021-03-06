﻿using System;
using FluentValidation;
using FluentValidation.Results;
using SpottedCotuca.Application.Services.Definitions;

namespace SpottedCotuca.Application.Contracts.Validator
{
    public static class FluentValidatorExtension
    {
        public static IRuleBuilderOptions<T, TProperty> WithCustomError<T, TProperty>(this IRuleBuilderOptions<T, TProperty> rule, MetaError metaError)
        {
            rule.WithErrorCode(metaError.StatusCode.ToString());
            rule.WithMessage(metaError.Error);
            return rule;
        }

        public static MetaError ToMetaError(this ValidationFailure error)
        {
            return new MetaError(Convert.ToInt32(error.ErrorCode), error.ErrorMessage);
        }
    }
}
