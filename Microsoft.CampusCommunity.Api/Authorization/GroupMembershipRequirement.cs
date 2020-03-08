﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Microsoft.CampusCommunity.Api.Authorization
{
    public class GroupMembershipRequirement : IAuthorizationRequirement
    {
        public IEnumerable<Guid> GroupMemberships { get; set; }

        public GroupMembershipRequirement(IEnumerable<Guid> groupMemberships)
        {
            GroupMemberships = groupMemberships;
        }
    }
}
