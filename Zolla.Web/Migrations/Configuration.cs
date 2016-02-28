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
                new Client { Id = 1, Name = "�����������", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 2, Name = "�������", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 3, Name = "������ �����", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 4, Name = "����", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 5, Name = "������", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 6, Name = "�����", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 7, Name = "��������", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 8, Name = "��������", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 9, Name = "��������", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 10, Name = "���� �����", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 11, Name = "�������", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 12, Name = "��������", DateAdd = DateTime.Parse("2016-02-28") },
                new Client { Id = 13, Name = "�������", DateAdd = DateTime.Parse("2016-02-28") }
            );
            context.SaveChanges();

            Random rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                context.Orders.AddOrUpdate(c => c.Id,
                    new Order { Id = i, Description = "������ ��� ���������", Status = (Status)rnd.Next(1,4),ClientId = rnd.Next(1,13) }
                    );

            }
            
           
        }
    }
}
