using System;
using System.Collections.Generic;
using System.Text;

namespace AppCalculadora.Clases
{
    internal class Persona
    {
        private string nombre="";
        private string apellidos="";
        private DateTime fecha;
        private int edad;

       
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime Fecha{ get => fecha; set => fecha = value; }
        public int Edad { get => edad = DateTime.Now.Year - fecha.Year; set => edad = value; }

    }

    
    }
