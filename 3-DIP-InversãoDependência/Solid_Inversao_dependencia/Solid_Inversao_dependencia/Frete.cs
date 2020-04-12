using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_Inversao_dependencia
{
    class Frete : IServicoDeEntrega
    {
        public double Para(string cidade)
        {
            cidade = "SAO PAULO";

            if ("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
           
            return 30;
        }
    }
}
