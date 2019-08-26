using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Primo_Progetto_ASPNETCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // questo metodo è chiamato dal runtime: aggiunge servizi al contenitore
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

        // questo metodo è chiamato dal runtime: configura la pipeline delle richieste HTTP
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
            {
                app.UseExceptionHandler("/Error");
                /* il valore HSTS predefinito è 30 giorni, è possibile modificare questa
                 * impostazione per gli scenari di produzione, vedere https://aka.ms/aspnetcore-hsts */
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}