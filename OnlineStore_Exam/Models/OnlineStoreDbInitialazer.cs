using Microsoft.AspNetCore.Components.Forms;
using System.Drawing;

namespace OnlineStore_Exam.Models
{
    public static class OnlineStoreDbInitialazer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using var servise = app.ApplicationServices.CreateScope();
            var context = servise.ServiceProvider.GetRequiredService<OnlineStoreDbContext>();

            if(!context.Categories.Any())
            {
                context.Categories.Add(new Category { Title = "Diorams"});
                context.Categories.Add(new Category { Title = "Figures"});
                context.Categories.Add(new Category { Title = "Lamps"});
                context.SaveChanges();
            }
        }
    }
}
