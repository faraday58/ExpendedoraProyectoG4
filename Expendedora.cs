using System;
using System.Threading;

namespace ExpendedoraProyectoG4
{
    class Expendedora
    {
        #region Atributos o Campos
        string marca;
        byte ancho;
        byte alto;
        byte fondo;
        ushort peso;
        byte temperatura;
        float precio;
        ushort cantProductos;
        #endregion

        public Expendedora()
        {
            marca = "AMS";
            temperatura = 14;
            precio = 10;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0}", marca);
            TiempoDespliegue();
            Console.WriteLine("Temperatura: {0} C",temperatura);
            TiempoDespliegue();
            string codigo = MostrarCodigo();            
            TiempoDespliegue();
            MostrarPrecio(codigo);
            TiempoDespliegue();
        }

        #region Métodos
        void Saludar()
        {
            Console.WriteLine("Bienvenido");
        }
        void TiempoDespliegue()
        {
            Thread.Sleep(3000);
            Console.Clear();
        }

        string MostrarCodigo()
        {
            Console.WriteLine(" 1A: Doritos \n 2A: Takis   ");
            Console.WriteLine("Ingresa el código del producto ");
            string codigo = Console.ReadLine();
            return codigo;
        }
        

        void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "1A":
                    Console.WriteLine("Precio: ${0}", precio+2);
                    break;
                case "2A":
                    Console.WriteLine("Precio: ${0}", precio);
                    break;
            }
        }

        #endregion

    }
}
