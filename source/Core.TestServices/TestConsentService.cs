﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license
 */
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core.Connect.Models;
using Thinktecture.IdentityServer.Core.Models;
using Thinktecture.IdentityServer.Core.Services;

namespace Thinktecture.IdentityServer.TestServices
{
    public class TestConsentService : IConsentService
    {
        public Task<bool> RequiresConsentAsync(Client client, ClaimsPrincipal user, IEnumerable<string> scopes)
        {
            return Task.FromResult(client.RequireConsent);
        }
        
        public Task UpdateConsentAsync(Client client, ClaimsPrincipal user, IEnumerable<string> scopes)
        {
            return Task.FromResult<object>(null);
        }
    }
}