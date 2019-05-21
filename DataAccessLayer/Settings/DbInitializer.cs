using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Settings
{
    public class DbInitializer : DropCreateDatabaseAlways<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            Film film1 = new Film { Name = "Titanik", Year = 1997 };
            Film film2 = new Film { Name = "Avatar", Year = 2009 };
            Film film3 = new Film { Name = "Avengers: EndGame", Year = 2019 };
            Film film4 = new Film { Name = "Game Of Thrones", Year = 2011 };

            context.Films.Add(film1);
            context.Films.Add(film2);
            context.Films.Add(film3);
            context.Films.Add(film4);
            context.SaveChanges();
        }
    }
}
