using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Hosting;
using System.Web.Http.Routing;

namespace ChallengeWillianHill.Helper
{
    public class ControllerRequest
    {
        public ControllerRequest()
        {
        }

        public ControllerRequest(ApiController controller)
        {
            Controller = controller;
            Controller.ControllerContext = new HttpControllerContext {Configuration = new HttpConfiguration()};

            Controller.Request = new HttpRequestMessage();
            Controller.Request.Properties[HttpPropertyKeys.HttpConfigurationKey] =
                Controller.ControllerContext.Configuration;
            Controller.Request.Content = new HttpMessageContent(Controller.Request);
        }

        public ControllerRequest(
            ApiController controller,
            HttpMethod method,
            string requestUri = "",
            string routeTemplate = "",
            object defaults = null)
            : this(controller)
        {
            SetRequest(method, requestUri);
            SetRoute(routeTemplate, defaults);
        }

        protected ApiController Controller { get; set; }

        public static ControllerRequest CreateRequest(ApiController controller)
        {
            return new ControllerRequest(controller);
        }

        public static ControllerRequest CreateRequest(
            ApiController controller,
            HttpMethod method,
            string requestUri = "",
            string routeTemplate = "",
            object defaults = null)
        {
            return new ControllerRequest(controller, method, requestUri, routeTemplate, defaults);
        }


        public void SetRequest(HttpMethod method, string requestUri)
        {
            var request = new HttpRequestMessage(method, requestUri);
            Controller.ControllerContext.Request = request;
            Controller.Request = request;
        }

        public void SetRoute(string routeTemplate, object defaults)
        {
            IHttpRoute route = Controller.ControllerContext.Configuration.Routes.MapHttpRoute("ControllerRequest",
                routeTemplate, defaults);
            Controller.ControllerContext.RouteData = new HttpRouteData(route);
        }

        public void SetHttpContentType(string contentType)
        {
            Controller.Request.Content.Headers.ContentType = new MediaTypeHeaderValue(contentType);
        }

        internal void SetHttpMethod(string method)
        {
            Controller.Request.Method = new HttpMethod(method);
        }
    }
}