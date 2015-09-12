using Microsoft.Owin;
using Owin;
using MyWebApplication;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup( typeof( Startup ) )]

namespace MyWebApplication
{
   public class Startup
   {
      public void Configuration( IAppBuilder app )
      {
         app.MapSignalR();
         GlobalHost.DependencyResolver.UseRedis( "[provide hostname]", 6379, "[provide key]", "testkey" );
      }
   }
}