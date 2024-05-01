namespace Herencia_Clase
{
    public class Invertebrado : Animal
    {
       
        public string Tipo { get; set; }

        public bool TienePatas { get; set; }

        public int NumeroPatas { get; set; }

        public bool TieneConcha { get; set; }

        public Invertebrado()
        {
            TienePatas = false;
            NumeroPatas = 0;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia.Nombre}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Tiene concha: {(TieneConcha ? "Sí" : "No")}");
            Console.WriteLine($"Tiene Patas: {(TienePatas ? "Sí" : "No")}");
            Console.WriteLine($"{(TienePatas ? $"Número de patas: {NumeroPatas}" : "")}");
        }
    }
}
