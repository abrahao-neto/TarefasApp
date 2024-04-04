using Microsoft.OpenApi.Models;

namespace TarefasApp.API.Extensions
{
    /// <summary>
    /// Classe de extensão para configuração do Swagger
    /// </summary>
    public static class SwaggerDocExtension
    {
        public static IServiceCollection AddSwaggerDoc(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options => options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "TarefasApp - Treinamento C# Avançado Formação Arquiteto",
                Description = "API para controle de tarefas de usuários",
                Version = "1.0",
                Contact = new OpenApiContact
                {
                    Name = "COTI Informática",
                    Email = "contato@cotiinformatica.com.br",
                    Url = new Uri("http://www.cotiinformatica.com.br")
                }
            }));

            return services;
        }

        public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options => 
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "TarefasApp");
            });

            return app;
        }
    }
}
