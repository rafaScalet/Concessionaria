using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consecionaria.models
{
    public class Veiculos
    {
        public Veiculos(int ano, string modelo, string marca)
        {
            Ano = ano;
            Modelo = modelo;
            Marca = marca;
        }

        public int Ano { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
    }
}