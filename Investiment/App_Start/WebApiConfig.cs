using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Investment
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //Retira o XML da saída de dados//
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            //Identação do JSON na saída de dados//
            config.Formatters.JsonFormatter.Indent = true;

            var formatters = GlobalConfiguration.Configuration.Formatters;
           
        }
    }
}
