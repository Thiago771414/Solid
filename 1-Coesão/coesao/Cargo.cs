using System;
using System.Collections.Generic;
using System.Text;

namespace solid3
{
    
    public abstract class Cargo 
    {
        public ICalculadoraDeSalario Regra { get; private set; }
        public Cargo(ICalculadoraDeSalario regra)
        {
            this.Regra = regra;      
        }
    }
}
