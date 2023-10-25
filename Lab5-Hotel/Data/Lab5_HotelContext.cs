using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab5_Hotel.Models;

namespace Lab5_Hotel.Data
{
    public class Lab5_HotelContext : DbContext
    {
        public Lab5_HotelContext (DbContextOptions<Lab5_HotelContext> options)
            : base(options)
        {
        }

        public DbSet<Lab5_Hotel.Models.Hotel> Hotel { get; set; } = default!;
    }
}
