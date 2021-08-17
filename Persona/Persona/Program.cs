using Persona.Entidades;
using Persona.Negocio;
using System;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsPersona clspersona = new ClsPersona();
            NClsPersona nclspersona= new NClsPersona();
            clspersona.Nombre = "Martin";
            

            Console.WriteLine(nclspersona.Hablar(clspersona));

            Console.ReadLine();


        }
    }
}
