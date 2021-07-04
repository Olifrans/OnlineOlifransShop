using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OlifransShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransShop.Database
{
    public class OlifransShopDbContext : IdentityDbContext
    {
        public OlifransShopDbContext(DbContextOptions<OlifransShopDbContext> options)
            : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
