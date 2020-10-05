using System;
using System.Management.Instrumentation;

namespace ExpendedoraProyectoG4
{
    class Program
    {
        static void Main()
        {
            //Expendedora expendedoraAMS= new Expendedora();
            Snack miSnack = new Snack();
            Console.WriteLine("Ingrese la temperatura: ");
            byte temperatura = byte.Parse(Console.ReadLine());
            for(int i=0; i <= temperatura; i++)
            {
                miSnack.ElevarTemperatura();
            }
            miSnack.MostrarTemperatura();
            Cafe cafeVainilla = new Cafe();
            Console.WriteLine("¿Desea entrar en modo mantenimiento? (s/n) ");
            char seleccionM = char.Parse(Console.ReadLine());
            bool mantenimiento = false;
            if( seleccionM == 's'   )
            {
                mantenimiento = true;
            }
            else if(seleccionM == 'n')
            {
                mantenimiento = false;
            }

            Cafe cafeMantenimiento = new Cafe(mantenimiento);




        }
    }


}
