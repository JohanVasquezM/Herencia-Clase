namespace Herencia_Clase
{
    public class Vertebrado : Animal
    {
        
        public string Tipo { get; set; }

        public bool TienePatas { get; set; }

        public bool EsDomestico { get; set; } 

        public bool EsHerbivoro { get; set; } 

        public bool EsCarnivoro { get; set; }

        public Vertebrado()
        {
            TienePatas = true;
            EsCarnivoro = true;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia.Nombre}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Tiene Patas: {(TienePatas ? "Sí" : "No")}");
            Console.WriteLine($"Es Doméstico: {(EsDomestico ? "Sí" : "No")}");
            Console.WriteLine($"Es Herbívoro: {(EsHerbivoro ? "Sí" : "No")}");
            Console.WriteLine($"Es Carnívoro: {(EsCarnivoro ? "Sí" : "No")}");
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
