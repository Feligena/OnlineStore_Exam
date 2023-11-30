using Microsoft.AspNetCore.Components.Forms;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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

                var category = context.Categories.Where(c => c.Title == "Diorams").FirstOrDefault();
                context.Images.Add(new Images { Name = "diopams", Url = "/uploads/diorama.jpg", CategoryId = category.Id});

                category = context.Categories.Where(c => c.Title == "Figures").FirstOrDefault();
                context.Images.Add(new Images { Name = "figures_people", Url = "/uploads/figures_people.jpeg", CategoryId = category.Id });

                category = context.Categories.Where(c => c.Title == "Lamps").FirstOrDefault();
                context.Images.Add(new Images { Name = "lamp_moon", Url = "/uploads/lamp_moon.jpg", CategoryId = category.Id });
                context.SaveChanges();
            }
        }
    }
}
