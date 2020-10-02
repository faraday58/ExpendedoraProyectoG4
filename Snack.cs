using System;

namespace ExpendedoraProyectoG4
{
    class Snack:Expendedora
    {
        public Snack()
        {
            
            Marca = "AMS";
            Temperatura = 14;
            Precio = 10;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0}", Marca);
            TiempoDespliegue();
            Console.WriteLine("Temperatura: {0} C", Temperatura);
            TiempoDespliegue();
            string codigo = MostrarCodigo();
            TiempoDespliegue();
            MostrarPrecio(codigo);
            TiempoDespliegue();
        }

    }
}
