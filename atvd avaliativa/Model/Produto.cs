using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvd_avaliativa.Model
{
    public class Produto
    {
        //Classe Produto:
        public string CodigodeBarra { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public string ResponsavelCadastro { get; set; }
    }
}
