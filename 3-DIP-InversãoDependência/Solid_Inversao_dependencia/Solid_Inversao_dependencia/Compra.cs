using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_Inversao_dependencia
{
    public class Compra
    {
        private string v1;
        private int v2;

        public Compra(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string Cidade { get; set; }
        public double Valor { get; set; }
        
    }

   
}
