﻿using Auth.API.Dto.RequestDtos.Auth;
using FluentValidation;

namespace Auth.API.Validators.Auth;

public class PhoneLoginOrRegisterTicketRequestValidator : AbstractValidator<PhoneLoginOrRegisterTicketRequest>
{
    public PhoneLoginOrRegisterTicketRequestValidator()
    {
        RuleFor(x => x.Credentials)
            .MinimumLength(11)
            .WithMessage(ValidationMessages.TooShortPhone)
            .MaximumLength(19)
            .WithMessage(ValidationMessages.TooLongPhone)
            .Matches(@"^(?:\+[\d]{1,3}[\s-])?[\d]{8,15}$")
            .WithMessage(ValidationMessages.IncorrectPhone);
    }
}