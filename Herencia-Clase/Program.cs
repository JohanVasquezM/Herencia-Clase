using Herencia_Clase;

Vertebrado vertebrado = new Vertebrado();
vertebrado.Nombre = "Perro";
vertebrado.Color = "Blanco";
vertebrado.Tamano = "Pequeño";
vertebrado.Familia.Nombre = "Husky";
vertebrado.Tipo = "Siberiano";
vertebrado.EsDomestico = true;
vertebrado.EsHerbivoro = false;
vertebrado.Imprimir();

Invertebrado invertebrado = new Invertebrado();
invertebrado.Nombre = "Caracol";
invertebrado.Color = "Varios";
invertebrado.Tamano = "Pequeño";
invertebrado.Familia.Nombre = "Moluscos";
invertebrado.Tipo = "Molusco";
invertebrado.TieneConcha = true;
invertebrado.Imprimir();