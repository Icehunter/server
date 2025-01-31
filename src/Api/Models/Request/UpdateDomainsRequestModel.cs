﻿using System.Collections.Generic;
using Bit.Core.Entities;
using Bit.Core.Enums;
using Newtonsoft.Json;

namespace Bit.Api.Models.Request
{
    public class UpdateDomainsRequestModel
    {
        public IEnumerable<IEnumerable<string>> EquivalentDomains { get; set; }
        public IEnumerable<GlobalEquivalentDomainsType> ExcludedGlobalEquivalentDomains { get; set; }

        public User ToUser(User existingUser)
        {
            existingUser.EquivalentDomains = EquivalentDomains != null ? JsonConvert.SerializeObject(EquivalentDomains) : null;
            existingUser.ExcludedGlobalEquivalentDomains = ExcludedGlobalEquivalentDomains != null ?
                JsonConvert.SerializeObject(ExcludedGlobalEquivalentDomains) : null;
            return existingUser;
        }
    }
}
