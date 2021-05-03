using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tests;
using ZendeskApi_v2;
using ZendeskApi_v2.Models.OAuthTokens;

namespace Tests
{
    [TestFixture]
    [Category("OAuthTokens")]
    public class OAuthTokenTests
    {
        private readonly ZendeskApi api = new ZendeskApi(Settings.Site, Settings.AdminEmail, Settings.AdminPassword);

        [Test]
        public void CanCreateTokenForPasswordGrantType()
        {
            var passwordGrantType = new OAuthTokenPasswordGrantTypeRequest()
            {
                Username = Settings.AdminEmail,
                Password = Settings.AdminPassword,
                Scope = "read write",
                GrantType = "password",
                ClientId = "",
                ClientSecret = "",
                Token = "fLX1vjTqOJam96yDfkvnCFjeatgjicALzdyu8PE5"
            };
            var result = api.OAuthTokens.CreateTokenForPasswordGrantType(passwordGrantType);
            Assert.NotNull(result);
        }
    }
}
