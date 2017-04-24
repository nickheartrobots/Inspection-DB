using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace WebAPI.Models
{
    public class WebAPIContextInitializer : DropCreateDatabaseAlways<WebAPIContext>
    {
        public WebAPIContextInitializer()
        {
            Console.WriteLine("Test");
        }

        protected override void Seed(WebAPIContext context)
        {
            var inspections = new List<Inspection>
            {
                new Inspection { Id = 10001, AddressId = 1001, Date = "01/01/17", TimeIn = "07:10AM", TimeOut = "07:45AM" }
            };

            inspections.ForEach(i => context.Inspections.Add(i));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}