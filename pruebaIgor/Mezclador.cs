using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaIgor
{
    class Mezclador : VehiculoComponentes
    {
        private string _tipo;

        public Mezclador(float estadoComponente, string tipo ) 
                        : base(estadoComponente)
        {
            _tipo = tipo;    
        }

        public string Tipo { get => _tipo; set => _tipo = value; }
    }
}
