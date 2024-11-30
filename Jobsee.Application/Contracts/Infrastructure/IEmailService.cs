﻿using Jobsee.Application.Models;

namespace Jobsee.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
