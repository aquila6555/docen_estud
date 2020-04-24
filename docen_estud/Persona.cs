using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//codigo realizado por JD

namespace docen_estud
{
    class Persona
    {
        private int _nombre;
        private int _edad;
        public int Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
        public int Edad
        {
            get
            {
                return this._edad;
            }
            set
            {
                this._edad = value;
            }
        }
    }
}
