using System;
using System.Threading;

namespace ExpendedoraProyectoG4
{
    abstract class Expendedora
    {
        #region Atributos o Campos
    private string marca;
    private byte ancho;
    private byte alto;
    private byte fondo;
    private ushort peso;    
    private float precio;
    private ushort cantProductos;


    private byte temperatura;

        public byte Temperatura { 
            get => temperatura;
            set { 
                if ( value < 14 || value > 20  )
                {
                    temperatura = 14;
                }
                else
                {
                    temperatura = value;
                }
                
            }
        }

        public string Marca { get => marca; set => marca = value; }
        public byte Ancho { get => ancho; set => ancho = value; }
        public byte Alto { get => alto; set => alto = value; }
        public byte Fondo { get => fondo; set => fondo = value; }
        public ushort Peso { get => peso; set => peso = value; }
        public float Precio { get => precio; set => precio = value; }
        public ushort CantProductos { get => cantProductos; set => cantProductos = value; }
        #endregion

        public Expendedora()
        {
            
        }

        #region Métodos
        public void Saludar()
        {
            Console.WriteLine("Bienvenido");
        }
        public void TiempoDespliegue()
        {
            Thread.Sleep(3000);
            Console.Clear();
        }

        public void ElevarTemperatura()
        {
            Temperatura++;
        }
        public void MostrarTemperatura()
        {
            Console.WriteLine(Temperatura);
        }


        public string MostrarCodigo()
        {
            Console.WriteLine(" 1A: Doritos \n 2A: Takis   ");
            Console.WriteLine("Ingresa el código del producto ");
            string codigo = Console.ReadLine();
            return codigo;
        }
        

        public void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "1A":
                    Console.WriteLine("Precio: ${0}", Precio+2);
                    break;
                case "2A":
                    Console.WriteLine("Precio: ${0}", Precio);
                    break;
            }
        }

        #endregion

    }
}
