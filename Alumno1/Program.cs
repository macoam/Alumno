using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumnoa = new Alumno();
            alumnoa.Nombre = "Juan De Dios Pantoja";
            alumnoa.Matricula = "179024";

            Console.WriteLine("Nombre: " + alumnoa.Nombre);
            Console.WriteLine("Matrícula: " + alumnoa.Matricula);

            Console.Read();
        }
    }
}
