using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//codigo realizado por JD

namespace docen_estud
{
    class Estudiante:Persona
    {
        private int _curso;
        private int _carrera;

        public int Curso
        {
            get
            {
                return this._curso;
            }
            set
            {
                this._curso = value;
            }
        }
        public int Carrera
        {
            get
            {
                return this._carrera;
            }
            set
            {
                this._carrera = value;
            }
        }
        

    }
}
