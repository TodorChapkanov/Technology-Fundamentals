using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ToDoList.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void MigrateDatabase(this IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();

            using (scope)
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ToDoDbContext>();

                dbContext.Database.Migrate();
            }
        }
    }
}
