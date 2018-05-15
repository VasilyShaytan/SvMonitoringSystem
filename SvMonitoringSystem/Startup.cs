using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SvMonitoringSystem.Models;

namespace SvMonitoringSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // регистрирует сервисы, которые используются приложением
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<MonitoringContext>(options => options.UseNpgsql(connection));
            services.AddMvc();  //Метод services.AddMvc() добавляет в коллекцию сервисов сервисы MVC. После добавления в коллекцию сервисов добавленные севисы становятся доступными для приложения.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Метод Configure устанавливает, как приложение будет обрабатывать запрос.
        // IHostingEnvironment: позволяет взаимодействовать со средой, в которой запускается приложение
        // ILoggerFactory: предоставляет механизм логгирования в приложении
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // если приложение в процессе разработки
            if (env.IsDevelopment())
            {
                // // то выводим информацию об ошибке, при наличии ошибки
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // установка обработчика ошибок
                app.UseExceptionHandler("/Home/Error");
            }
            // установка обработчика статических файлов
            app.UseStaticFiles();
            // установка аутентификации пользователя на основе куки
            // app.UseAuthentication();

            // устанавливает компоненты MVC для обработки запроса и, в частности, настраивает систему маршрутизации в приложении.
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
