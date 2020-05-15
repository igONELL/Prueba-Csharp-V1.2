using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaIgor
{
    class Estanque : VehiculoComponentes
    {
        private float _capacidad;
        private float _litros;

        public Estanque(float estadoComponente, float capacidad, float litros) : base(estadoComponente)
        {
            _capacidad = capacidad;
            _litros = litros;
        }

        public float Capacidad { get => _capacidad; set => _capacidad = value; }
        public float Litros { get => _litros; set => _litros = value; }

        public bool MitadCombustible()
        
        {
            float minimoCombustible = 10.5f * _capacidad / 100.0f; //Método “MitadCombustible” que retorne un booleano en el caso de que los 
            float maximoCombustible = 50.0f * _capacidad / 100.0f; //litros sean mayores a 10.5 % de la capacidad y menor o igual al 50.0 % de la capacidad.


            if (_litros > minimoCombustible & _litros <= maximoCombustible)
            {
                return true;
            }

            else{
                return false;
            }

        
        }
        public bool BajoCombustible()
        {
            //Método “BajoCombustible” que retorne un booleano en el caso de que los 
            //litros sean igual o menor a 10.5 % de la capacidad del estanque.
            float minimoCombustible = 10.5f * _capacidad / 100.0f;

            if (_litros <= minimoCombustible)
            {

                return true;
            }

            else {

                return false;
            }
        }
       
    }
}
