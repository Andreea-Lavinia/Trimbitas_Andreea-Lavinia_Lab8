using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trimbitas_Andreea_Lavinia_Lab8.Models;

namespace Trimbitas_Andreea_Lavinia_Lab8.Data
{
    public class Trimbitas_Andreea_Lavinia_Lab8Context : DbContext
    {
        public Trimbitas_Andreea_Lavinia_Lab8Context (DbContextOptions<Trimbitas_Andreea_Lavinia_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Trimbitas_Andreea_Lavinia_Lab8.Models.Book> Book { get; set; }

        public DbSet<Trimbitas_Andreea_Lavinia_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
