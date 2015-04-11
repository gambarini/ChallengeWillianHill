using Owin;
using System.Web.Http;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;

namespace ChallengeWillianHill
{

	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			
			HttpConfiguration config = new HttpConfiguration ();
			config.MapHttpAttributeRoutes ();
			config.EnsureInitialized ();

			app.UseWebApi (config);
			app.UseFileServer (true);

		}
	} 
}
