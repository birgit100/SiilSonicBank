using System;
using Microsoft.AspNetCore.Authentication;
namespace Open.Tests.Sentry {

    public static class AuthenticationExtensionsTest {

        public static AuthenticationBuilder AddTestAuth(this AuthenticationBuilder builder,
            Action<TestAuthenticationOptions> configureOptions) {
            return builder.AddScheme<TestAuthenticationOptions, AuthenticationHandlerTest> (
                "Test Scheme", "Test Auth", configureOptions);
        }

    }

}




