using Microsoft.AspNetCore.Builder;

namespace SMS
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseMvc();

        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(a=>a.EnableEndpointRouting = false);
        }
        
    }
}
