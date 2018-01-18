using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Cache.Startup))]

namespace Cache
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
