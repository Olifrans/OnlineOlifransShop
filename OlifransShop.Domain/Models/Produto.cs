using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransShop.Domain.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}



//Comando CIL cmd na inteface .Web - dotnet ef migrations add initial
//Comando CIL cmd na inteface .Database - dotnet ef migrations add initial