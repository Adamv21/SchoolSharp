using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Core.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Platform.SchoolSoft.Components
{
    public class SchoolSoftLoginComponent : BaseLoginComponent
    {
        private readonly HttpClient navigator;
        public SchoolSoftLoginComponent(HttpClient navigator)
        {
            this.navigator = navigator;
        }

        
        public override async Task<LoginResult> LoginAsync(UserCrededentials crededentials)
        {
            const string route = "/Login.jsp";

            var result = await navigator.PostAsync(route, new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "action", "login" },
                { "usertype", crededentials.AccountType },
                { "ssusername", crededentials.Username },
                { "sspassword", crededentials.Password },
                { "button", "Logga in" }
            }));

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                return LoginResult.Build(false);

            return LoginResult.Build(true);
        }
    }
}
