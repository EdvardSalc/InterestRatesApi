using System.Web.Http;
using WebActivatorEx;
using InterestRatesAPI;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace InterestRatesAPI
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>{ c.SingleApiVersion("v1", "InterestRatesAPI");})
                .EnableSwaggerUi(c =>{});
        }
    }
}
