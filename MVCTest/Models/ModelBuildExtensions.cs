using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Models
{
    public static class ModelBuildExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentModel>().HasData(
              new StudentModel
              {
                  id = 1,
                  Name = "admin",
                  ClassName = ClassNameEnum.One,
                  Email = "admin@syinpo.com"
              },
              new StudentModel
              {
                  id = 2,
                  Name = "psycheeeee",
                  ClassName = ClassNameEnum.One,
                  Email = "psyche@syinpo.com"
              },
            new StudentModel
            {
                id = 3,
                Name = "psycheeeee123",
                ClassName = ClassNameEnum.One,
                Email = "psyche123@syinpo.com"
            }
              );
        }
    }
}
