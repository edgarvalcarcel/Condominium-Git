﻿using Condominium.Application;
using Condominium.Application.Common.Models;
using System;
using System.Threading.Tasks;

namespace Condominium.WebUI.IntegrationTests
{
    public class TestIdentityService : IIdentityService
    {
        public Task<string> GetUserNameAsync(string userId)
        {
            return Task.FromResult("jason@clean-architecture");
        }

        public Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Result> DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}