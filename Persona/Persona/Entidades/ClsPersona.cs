using System;
using System.Collections.Generic;
using System.Text;

namespace Persona.Entidades
{
    class ClsPersona
    {
        private String nombre;
        private String apellido;
        private int edad;
        private String sexo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
    }
}
