using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
        public Timestamp DataUltimoMovimento { get; set; }

        public Estoque()
        {
            
        }
        public Estoque(decimal quantidade, Timestamp dataUltimoMovimento)
        {
            Quantidade = quantidade;
            DataUltimoMovimento = dataUltimoMovimento;
        }
        public Estoque(Produto produto, decimal quantidade, Timestamp dataUltimoMovimento)
        {
            Produto = produto;
            Quantidade = quantidade;
            DataUltimoMovimento = dataUltimoMovimento;
        }
    }
}
