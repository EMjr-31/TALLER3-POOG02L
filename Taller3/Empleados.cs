using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3
{
    class Empleados
    {
        string nombre;
        DateTime fechaNac;
        string dUI;
        string correo;
        string tel;
        DateTime fechaCont;
        float sueldoBase;
        float renta;
        float iSSS;
        float descuentos;
        float sueldoNeto;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string DUI { get => dUI; set => dUI = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Tel { get => tel; set => tel = value; }
        public DateTime FechaCont { get => fechaCont; set => fechaCont = value; }
        public float SueldoBase { get => sueldoBase; set => sueldoBase = value; }
        public float Renta { get => renta; set => renta = value; }
        public float ISSS { get => iSSS; set => iSSS = value; }
        public float Descuentos { get => descuentos; set => descuentos = value; }
        public float SueldoNeto { get => sueldoNeto; set => sueldoNeto = value; }
    }
}
