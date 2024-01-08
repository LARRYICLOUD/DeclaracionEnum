using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaracionEnum
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");

            //declaramos una variable del tipo enum
            Semana diaDePago = Semana.Viernes;

            //Ejemplo de uso con una estructura de control
            if(diaDePago == Semana.Viernes)               
                
            {
                string sueldoSemanal = "LARRY 10 MILLONES DE DOLARES";
                Console.WriteLine($"Hoy es dia de pago, recibes: ${sueldoSemanal}");

            }
            else
            {
                Console.WriteLine("Lo sentimos, hoy no es dia de pago");
            }
        }
    }
    //Declaracion de una "enum
    enum Semana
    {
        //Conjunto de constantes con nombre ("enumeradores" o "miembros de enumeracion")
        Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo
    }
}
