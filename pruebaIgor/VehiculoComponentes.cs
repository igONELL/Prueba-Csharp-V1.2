using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaIgor
{
    abstract class VehiculoComponentes
    {
        private float _estadoComponente;

        protected VehiculoComponentes(float estadoComponente)
        {
            _estadoComponente = estadoComponente;
        }

        public float EstadoComponente { get => _estadoComponente; set => _estadoComponente = value; }
    }
}
