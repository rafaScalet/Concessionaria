using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consecionaria.models
{
    public class Carro : Veiculos
    {
        public Carro(int ano, string modelo, string marca) : base(ano, modelo, marca)
        {
        }

        public int NumPorta { get; set; }
    }
}