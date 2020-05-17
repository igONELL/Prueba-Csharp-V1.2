using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace pruebaIgor
{
    class Automovil : Vehiculo
    {
        private string _marca;
        private float _ano;
        private float _kilometraje;

        public Automovil(Estanque estanque, Mezclador mezclador, 
                        Rueda rueda, Motor motor, string marca, 
                        float ano, float kilometraje) 
                        : base(estanque, mezclador, rueda, motor)
        
        { 
       
            _marca = marca;
            _ano = ano;
            _kilometraje = kilometraje;
        }

        public string Marca { get => _marca; set => _marca = value; }
        public float Ano { get => _ano; set => _ano = value; }
        public float Kilometraje { get => _kilometraje; set => _kilometraje = value; }
    }
}
