using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;

[assembly: OwinStartup(typeof(_507SA.App_Start.Startup))]
namespace _507SA.App_Start
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseCookieAuthentication(new CookieAuthenticationOptions
			{
				AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
				LoginPath = new PathString("/home/index"),
				SlidingExpiration = false,
				ExpireTimeSpan = TimeSpan.FromDays(20)
			});
        }
	}
}