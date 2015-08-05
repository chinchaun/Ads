using System.Web.Http;
using Newtonsoft.Json.Serialization;


namespace Ads.UI.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "api",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(null, "api/{controller}/{action}");
            config.Formatters.JsonFormatter.SerializerSettings.NullValueHandling
                = Newtonsoft.Json.NullValueHandling.Ignore;

            var json = config.Formatters.JsonFormatter;

            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            json.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            DefaultContractResolver resolver = (DefaultContractResolver)json.SerializerSettings.ContractResolver;
            resolver.IgnoreSerializableAttribute = true;
        }
    }
}