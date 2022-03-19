using Derivco_Roulette.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Derivco_Roulette.Data
{
    public class RouletteContext : DbContext
    {

        public RouletteContext(DbContextOptions<RouletteContext> options)
            :base(options)
        {
                
        }

        public DbSet<Bet> Bets { get; set; }

        public DbSet<WinningNumber> WinningNumbers { get; set; }



    }
}
