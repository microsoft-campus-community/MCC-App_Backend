﻿namespace Microsoft.CampusCommunity.Infrastructure.Configuration
{
    public class AadAuthenticationConfiguration
    {
        public string Instance { get; set; }
        public string Domain { get; set; }
        public string TenantId { get; set; }
        public string ClientId { get; set; }

        public string AuthorizationUrl => $"https://login.microsoftonline.com/{TenantId}/oauth2/v2.0/authorize";

        public string Authority => $"https://login.microsoftonline.com/{TenantId}/v2.0";
        public string ApplicationIdUri => $"https://{Domain}/Api"; //https://campus-community.org/Api
    }
}