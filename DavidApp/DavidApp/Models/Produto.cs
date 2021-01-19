using System;
using System.Collections.Generic;
using System.Text;

namespace DavidApp.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string UnidadeMedida { get; set; }
    }
}
