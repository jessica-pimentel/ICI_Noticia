using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ICI.ProvaCandidato.Dados.Context;
using ICI.ProvaCandidato.Negocio.Interfaces.Repository;
using ICI.ProvaCandidato.Dados.Repository.cs;
using ICI.ProvaCandidato.Negocio.Service;
using ICI.ProvaCandidato.Negocio.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace ICI.ProvaCandidato.Web
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
            services.AddControllersWithViews();
            services.AddDbContext<NoticiaContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionStringNoticia")));

            //Interfaces
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<INoticiaTagRepository, NoticiaTagRepository>();
            services.AddScoped<INoticiaTagService, NoticiaTagService>();
			services.AddScoped<INoticiaRepository, NoticiaRepository>();
            services.AddScoped<INoticiaService, NoticiaService>();

            // Configuração para permitir requisições PUT com corpo vazio
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressConsumesConstraintForFormFileParameters = true;
                options.SuppressInferBindingSourcesForParameters = true;
                options.SuppressModelStateInvalidFilter = true;
                options.SuppressMapClientErrors = true;

                // Adicione essa linha para habilitar a leitura do corpo da requisição PUT
                services.Configure<MvcOptions>(options =>
                {
                    options.AllowEmptyInputInBodyModelBinding = true;
                });

                services.AddControllers().AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = null; // Mantém a capitalização original das propriedades
                });
            });
        }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseDeveloperExceptionPage();

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "noticia",
                    pattern: "Noticia/{action=Index}/{id?}",
                    defaults: new { controller = "Noticia" }); // Adicionando rota para o controller de Notícia

                endpoints.MapControllerRoute(
                                    name: "default",
                                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                                    name: "GetAllTags",
                                    pattern: "Tag/GetAll",
                                    defaults: new { controller = "Tag", action = "GetAll" });

                endpoints.MapControllerRoute(
                                    name: "EditTag",
                                    pattern: "Tag/Edit/{id}",
                                    defaults: new { controller = "Tag", action = "Edit" });
            });
		}
	}
}
