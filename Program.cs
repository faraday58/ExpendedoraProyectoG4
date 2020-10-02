using System;

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

        }
    }


}
