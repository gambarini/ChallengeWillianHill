using Owin;
using System.Web.Http;

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

		}
	} 
}
