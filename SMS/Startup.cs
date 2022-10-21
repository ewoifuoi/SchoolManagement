using Microsoft.AspNetCore.Builder;
using SMS.Models;
using SMS.DataRepositories;

namespace SMS
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            
            app.UseRouting();
            app.UseMvc();
            app.Run(async (context) =>
            {

            });
            

        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(a=>a.EnableEndpointRouting = false);
            services.AddSingleton<IStudentRepository, MockStudentRepository>();
        }
        
    }
}
