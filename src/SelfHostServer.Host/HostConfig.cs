using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace SelfHostServer.Host
{
    public static class HostConfig
    {
        private static string _url = "http://localhost:5009";

        public static HttpSelfHostConfiguration SetConfiguration()
        {
            var config = new HttpSelfHostConfiguration(_url);

            config.Routes.MapHttpRoute("Default", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            return config;
        }

        public static void RunServer(HttpSelfHostConfiguration hostConfiguration)
        {
            var server = new HttpSelfHostServer(hostConfiguration);

            server.OpenAsync().Wait();
        }
    }
}
