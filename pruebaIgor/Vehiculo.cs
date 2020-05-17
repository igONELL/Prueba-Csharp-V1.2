using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace pruebaIgor
{
    abstract class Vehiculo
    {
        private Estanque _estanque;
        private Mezclador _mezclador;
        private Rueda _rueda;
        //private Rueda _rueda;
        //private Rueda[] _rueda; se utiliza solo para array 
        private Motor _motor;

        protected Vehiculo(Estanque estanque, Mezclador mezclador, 
                    Rueda rueda, Motor motor)

        {
            _estanque = estanque;
            _mezclador = mezclador;
            _rueda = rueda;
            _motor = motor;
        }

        //_rueda = new Rueda[rueda];
        public Rueda Rueda { get => _rueda; set => _rueda = value; }
        internal Estanque Estanque { get => _estanque; set => _estanque = value; }
        internal Mezclador Mezclador { get => _mezclador; set => _mezclador = value; }
        internal Motor Motor { get => _motor; set => _motor = value; }
        //public object[] Rueda1 { get => this.Rueda; set => this.Rueda = value; }
    }
}
