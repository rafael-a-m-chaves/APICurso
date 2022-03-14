using APICurso.Application.IServices;
using APICurso.Application.Services;
using APICurso.Infra.Contexts;
using APICurso.Infra.IRepositories;
using APICurso.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.Globalization;

namespace APICurso
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Obtem a string de conexão com o banco de dados
            var connection = Configuration["ConnectionStrings:DefaultConnection"];
            //Adiciona o Context e determina o tipo de banco de dados e passa a string de conexão
            services.AddDbContext<Context>(options => options.UseSqlServer(connection));

            // Determina a localização
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("pt-BR");
                options.SupportedCultures = new List<CultureInfo> { new CultureInfo("pt-BR"), new CultureInfo("pt-BR") };
            });

            //Mapeamento dos services e Repositores
            #region Services
            services.AddTransient<ILimiteClienteService, LimiteClienteService>();
            services.AddTransient<ILogService, LogService>();
            #endregion

            #region Repository
            services.AddTransient<ILimiteClienteRepository, LimiteClienteRepository>();
            services.AddTransient<ILogRepository, LogRepository>();
            #endregion

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "APICurso", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "APICurso v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
