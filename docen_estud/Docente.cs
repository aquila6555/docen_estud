using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//codigo realizado por JD

namespace docen_estud
{
    class Docente:Persona
    {
        private int _especialidad;
        private int _sueldoBasico;
        public int Especialidad
        {
            get
            {
                return this._especialidad;
            }
            set
            {
                this._especialidad = value;
            }
        }
        public int SueldoBasico
        {
            get
            {
                return this._sueldoBasico;
            }
            set
            {
                this._sueldoBasico = value;
            }
        }
        public double CalcularLiquidoPagable(double sueldo) => sueldo - sueldo * 0.13;
    }
}
