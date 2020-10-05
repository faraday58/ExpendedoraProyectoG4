using System;

namespace ExpendedoraProyectoG4
{
    class Cafe:Expendedora
    {
        public override byte Temperatura { 
            get => base.Temperatura;
            set
            {
                if ( value < 60 ||  value > 80   )
                {
                    temperatura = 60;
                }
                else
                {
                    temperatura = value;
                }
                    
            }
        }

        public Cafe()
        {
            Temperatura = 80;
            Precio = 10;
            Marca = "AMS";
            MostrarTemperatura();
            Console.WriteLine("Bienvenido \n Elige tu Café");
            TiempoDespliegue();
            string codigo=MostrarCodigo();
            TiempoDespliegue();
            MostrarPrecio(codigo);
            TiempoDespliegue();
        }
        public Cafe(bool matenimiento)
        {
            Marca = "AMS";
            if(matenimiento )
            {
                TiempoDespliegue();
                Console.WriteLine("Marca: {0}", Marca);
                TiempoDespliegue();
                Console.WriteLine("Modo Mantenimiento");
                TiempoDespliegue();
            }
            else
            {
                TiempoDespliegue();
                Console.WriteLine("Marca: {0}", Marca);
                TiempoDespliegue();
                Console.WriteLine("Saliendo del Modo Mantenimiento");
                TiempoDespliegue();
            }
        }

  
        public override string MostrarCodigo()
        {
            Console.WriteLine(" 1A) Vainilla \n 2A)Moka  ");
            Console.WriteLine("Ingresa el código del produtco");
            string codigo = Console.ReadLine();
            return codigo;
        }

    }
}
