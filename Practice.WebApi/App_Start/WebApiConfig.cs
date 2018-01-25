using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiContrib.Formatting.Jsonp;

namespace Practice.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //To enable basic authentication for the entire web api
            //config.Filters.Add(new BasicAuthenticationAttribute());

            //To enable requires https for the entire web api
            //config.Filters.Add(new RequireHttpsAttribute());

            //To enable CORS for the entire applciation
            //EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");//origins, headers, methods
            //config.EnableCors(cors);//Enable CORS for the entire web api
            config.EnableCors();//Having only this line prepare the Web API to enable CORS. CORS can be enables at each API method.

            //To return JSON instead of xml when requested from browser
            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));

            //To enable JSONP
            //var jsonFormatter = new JsonpMediaTypeFormatter(config.Formatters.JsonFormatter);
            //config.Formatters.Insert(0, jsonFormatter);

            //To Remove Formatters
            //config.Formatters.Remove(config.Formatters.XmlFormatter);
            //config.Formatters.Remove(config.Formatters.JsonFormatter);

            //To apply custom formatting
            //config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            //config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
