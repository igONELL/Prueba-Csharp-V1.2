using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace pruebaIgor
{
    class Rueda : VehiculoComponentes
    {
        private string _recubrimiento;
        private int _menorDurometro;
        private int _mayorDurometro;

        public Rueda(float estadoComponente, string recubrimiento, 
                    int menorDurometro, int mayorDurometro ) 
                    : base(estadoComponente) {

            //El durómetro es un rango entre un número menor entero y un número mayor entero.
            //Ej. 100 – 180.
            //El primer número del rango no debe ser mayor al segundo.

            _recubrimiento = recubrimiento;
            _menorDurometro = menorDurometro;
            _mayorDurometro = mayorDurometro;

            if (menorDurometro < mayorDurometro)
            {
                _menorDurometro = menorDurometro;
                _mayorDurometro = mayorDurometro;
            }
            else
            {
                _menorDurometro = mayorDurometro;
                _mayorDurometro = menorDurometro;
            }
        }

        public string Recubrimiento { get => _recubrimiento; set => _recubrimiento = value; }
        public int MenorDurometro { get => _menorDurometro; set => _menorDurometro = value; }
        public int MayorDurometro { get => _mayorDurometro; set => _mayorDurometro = value; }
    }
}
