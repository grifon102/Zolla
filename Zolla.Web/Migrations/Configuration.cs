namespace Zolla.Web.Migrations
{
    using Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Zolla.Web.Infrastructure.ZollaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            
        }

        protected override void Seed(Zolla.Web.Infrastructure.ZollaDbContext context)
        {
            context.Clients.AddOrUpdate(c => c.Name,
                new Client { Id = 1, Name = "Перекресток", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 2, Name = "Авоська", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 3, Name = "Азбука Вкуса", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 4, Name = "Атак", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 5, Name = "Верный", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 6, Name = "Дикси", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 7, Name = "Зельгрос", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 8, Name = "Карусель", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 9, Name = "Магнолия", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 10, Name = "Фикс прайс", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 11, Name = "Матрица", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 12, Name = "Виктория", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 13, Name = "Копейка", DateAdd = DateTime.Parse("2016-02-28") }
            );
            context.SaveChanges();

            Random rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                context.Orders.AddOrUpdate(c => c.Id,
                    new Order { Id = i, Description = "Заказы для магазинов", Status = (Status)rnd.Next(1,4),ClientId = rnd.Next(1,13) }
                    );

            }
            
           
        }
    }
}
