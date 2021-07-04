using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OlifransShop.Application.Produtos;
using OlifransShop.Database;
using OlifransShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlifransShop.Web.Pages
{
    public class IndexModel : PageModel
    {


        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        private OlifransShopDbContext _ctx;
        public IndexModel(OlifransShopDbContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public ProdutoViewModel Produto  { get; set; }

        public class ProdutoViewModel
        {
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public decimal Valor { get; set; }
        }

        public void OnGet()
        {
        }

        public async Task <IActionResult> OnPost()
        {
            await new CreateProduto(_ctx).Do(Produto.Nome, Produto.Descricao, Produto.Valor);

            return RedirectToPage("Index");
        }
    }
}
