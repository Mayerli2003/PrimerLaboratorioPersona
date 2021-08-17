using Persona.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persona.Negocio
{
    class NClsPersona
    {
        //Para el segundo ejercicio se va a describir a una “persona”, el repositorio se llamara 
        //“PrimerLaboratorioPersona”, el proyecto se llamara, Persona, las propiedades serán : tiene nombre, apellido, edad,
        //sexo, las acciones que las personas pueden hacer serán, hablar, caminar, reír, observar, deveras crear todas, pero
        //solamente utilizaras una la cual será, hablar, la cual tendrá un mensaje el cual será, “Las persona “Colocar acá el
        //nombre de la persona” está hablando”, llamar el método Persona el Main, y llamar sus propiedades, de las cual
        //solamente utilizaras la propiedad de nombre y al nombre le asignaras “Martin” e imprime el mensaje en pantalla que
        //trae el método Hablar.
        public String Hablar(ClsPersona persona)
        {
            return "La persona " + persona.Nombre + " esta hablando";
        }
        public String Caminar(ClsPersona persona)
        {
            return persona.Nombre+" de "+ persona.Edad+" camina todos los dias";
        }
        public String Reir (ClsPersona persona)
        {
            return persona.Nombre + persona.Apellido + " se esta riendo";
        }
        public String Observar(ClsPersona persona)
        {
            return persona.Nombre + " de sexo " + persona.Sexo + " es observativo";
        }
}   }