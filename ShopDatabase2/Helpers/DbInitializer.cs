using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDatabase2.Helpers
{
    public static class DbInitializer
    {
        public static void SeedPositions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(
             new Position[]
             {
                    new Position()
                    {
                        Id = 1,
                       Name= "x",
                    },
                    new Position()
                    {
                        Id = 2,
                        Name = "Boeing 765",
                      
                    }
             });
        }
        public static void SeedCity(this ModelBuilder modelBuilder)
        {
            new Position[]
             {
                    new Position()
                    {
                        Id = 1,
                       Name= "x"
                    },
                    new Position()
                    {
                        Id = 2,
                        Name = "Boeing 765",

                    }
             });
        }
    }
