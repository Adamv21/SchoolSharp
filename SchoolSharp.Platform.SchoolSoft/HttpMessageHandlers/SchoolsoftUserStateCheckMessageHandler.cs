using SchoolSharp.Abstractions.Components.Login;
using SchoolSharp.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolSharp.Platform.SchoolSoft.HttpMessageHandlers
{
    internal class SchoolsoftUserStateCheckMessageHandler : DelegatingHandler
    {
        private const string LoginFailedRedirect = "../../html/redirect_login.htm";

        public SchoolsoftUserStateCheckMessageHandler(SchoolSoftSchoolPlatformClient client) : base()
        {
            this.Client = client;
        }

        public SchoolSoftSchoolPlatformClient Client { get; }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var result = await base.SendAsync(request, cancellationToken);

            if (result.StatusCode == System.Net.HttpStatusCode.Redirect && result.Headers.TryGetValues("Location", out var values)
                && values.Contains(LoginFailedRedirect))
            {
                var component = Client.GetComponent<ILoginComponent>();
                var loginResult = await component.LoginAsync(Client.Crededentials);

                if (!loginResult.Success)
                    throw new AuthorizationFailedException();

                result = await base.SendAsync(request, cancellationToken);
            }

            return result;
        }
    }
}
