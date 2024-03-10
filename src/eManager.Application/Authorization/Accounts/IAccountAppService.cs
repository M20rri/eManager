﻿using System.Threading.Tasks;
using Abp.Application.Services;
using eManager.Authorization.Accounts.Dto;

namespace eManager.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}