using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consecionaria.models
{
    public class Moto : Veiculos
    {
        public Moto(int ano, string modelo, string marca) : base(ano, modelo, marca)
        {
        }

        public int Cilindradas { get; set; }
    }
}