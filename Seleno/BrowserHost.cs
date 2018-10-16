using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.Configuration;
using TestStack.Seleno.Configuration.WebServers;
using System.Threading;

namespace Seleno
{
    public static class BrowserHost
    {
        public static readonly SelenoHost Instance = new SelenoHost();
        public static readonly string RootUrl;

        static BrowserHost()
        {
            Instance.Run(configure => configure
            .WithWebServer(new InternetWebServer("https://qa-platform.authenticateis.com/")));

            RootUrl = Instance.Application.Browser.Url;
                        
        }
    }
}
