using OlifransShop.Database;
using OlifransShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransShop.Application.Produtos
{
    public class CreateProduto
    {
        private OlifransShopDbContext _context;
        public CreateProduto(OlifransShopDbContext context)
        {
            _context = context;
        }

        public async Task Do(string Nome, string Descricao, decimal Valor)
        {
            _context.Produtos.Add(new Produto
            {                
                Nome = Nome,
                Descricao = Descricao,
                Valor = Valor,
            });

            await _context.SaveChangesAsync();
        }
    }
}
