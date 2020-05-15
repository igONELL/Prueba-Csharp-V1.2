using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaIgor
{

    class Motor : VehiculoComponentes
    {
        private float _id;
        private string _tipo;
        private float _cilindrada;

        public Motor(float estadoComponente, float id, string tipo, float cilindrada) : base(estadoComponente)
        {
            _id = id;
            _tipo = tipo;
            _cilindrada = cilindrada;

        }

        public float Id { get => _id; set => _id = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public float Cilindrada { get => _cilindrada; set => _cilindrada = value; }
    }
}
