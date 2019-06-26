using Ajax.Models;
using System.Collections.Generic;

namespace Ajax.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Ajax.Models.StudentEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ajax.Models.StudentEntities context)
        {
           var student = new List<Student>
           {
               new Student{Id = 1,FullName = "Nguyen Van A",Gender = "Nam"},
               new Student{Id = 2,FullName = "Nguyen Van B",Gender = "Nu"},
               new Student{Id = 3,FullName = "Nguyen Van C",Gender = "Nam"},
               new Student{Id = 4,FullName = "Nguyen Van D",Gender = "Nu"},
               new Student{Id = 5,FullName = "Nguyen Van E",Gender = "Nam"},
               new Student{Id = 6,FullName = "Nguyen Van F",Gender = "Nu"},
               new Student{Id = 7,FullName = "Nguyen Van G",Gender = "Nam"},
               new Student{Id = 8,FullName = "Nguyen Van H",Gender = "Nu"},
               new Student{Id = 9,FullName = "Nguyen Van I",Gender = "Nam"},
           };
            context.Studens.AddRange(student);
            context.SaveChanges();
        }
    }
}
