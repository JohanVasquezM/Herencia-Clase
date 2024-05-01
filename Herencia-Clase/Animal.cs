namespace Herencia_Clase

{
    public class Animal
    {
       
        public string Nombre { get; set; }

        public string Color { get; set; }

        public string Tamano { get; set; }

        public Familia Familia { get; set; }

        public Animal()
        {
            Familia = new Familia();
        }

    }
}
