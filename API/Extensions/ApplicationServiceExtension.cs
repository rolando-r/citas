using Core.Interfaces;
using Infrastructure.Repository;
using Infrastructure.UnitOfWork;

namespace API.Extensions;
public static class ApplicationServiceExtension
{
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",builder=>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
        });
        public static void AddAplicacionServices(this IServiceCollection services){
            //services.AddScoped<IAcudiente,AcudienteRepository>();
            //services.AddScoped<IConsultorio,ConsultorioRepository>();
            services.AddScoped<IUnitOfWork,UnitOfWork>();
        }
}