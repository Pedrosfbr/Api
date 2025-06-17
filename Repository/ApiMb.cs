using Domain;
using Repository.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal static class ApiMb
    {
        public static void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder mb) 
        {
            new CfgProduto().Configure(mb.Entity<Produto>());
            new CfgCars().Configure(mb.Entity<Cars>());
            new CfgLocation().Configure(mb.Entity<Location>());
        }

      
            
 
    }
}
