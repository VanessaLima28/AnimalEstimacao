using System;

namespace AnimaisEstimação
{
    class Program
    {
        static void Main(string[] args)
        {
            animal a1 = new animal();
            animal a2 = new animal();
            animal a3 = new animal();
            animal a4 = new animal();
            animal a5 = new animal();

            //contadores
            int contador_cachorro = 0;
            int contador_gato = 0;
            int contador_peixe = 0;

            //primeiro animal
            Console.WriteLine("Informe nome o primeiro animal: ");
            a1.nomeAnimal = Console.ReadLine();
            Console.WriteLine("Informe o tipo do primeiro animal (cachorro, gato ou peixe): ");
            a1.tipoAnimal = Console.ReadLine();

            //contador++ está acrescentando mais um item 
            if (a1.tipoAnimal == "cachorro") contador_cachorro++;
            if (a1.tipoAnimal == "gato") contador_gato++;
            if (a1.tipoAnimal == "peixe") contador_peixe++;

            //primeiro animal
            Console.WriteLine("Informe o nome do segundo animal: ");
            a2.nomeAnimal = Console.ReadLine();
            Console.WriteLine("Informe o tipo do segundo animal (cachorro, gato ou peixe): ");
            a2.tipoAnimal = Console.ReadLine();

            if (a2.tipoAnimal == "cachorro") contador_cachorro++;
            if (a2.tipoAnimal == "gato") contador_gato++;
            if (a2.tipoAnimal == "peixe") contador_peixe++;

            //sexto animal
            Console.WriteLine("Informe o nome do terceiro animal: ");
            a3.nomeAnimal = Console.ReadLine();
            Console.WriteLine("Informe o tipo do terceiro animal (cachorro, gato ou peixe): ");
            a3.tipoAnimal = Console.ReadLine();

            if (a3.tipoAnimal == "cachorro") contador_cachorro++;
            if (a3.tipoAnimal == "gato") contador_gato++;
            if (a3.tipoAnimal == "peixe") contador_peixe++;
            
            //quarto animal
            Console.WriteLine("Informe o nome do quarto animal: ");
            a4.nomeAnimal = Console.ReadLine();
            Console.WriteLine("Informe o tipo do quarto animal (cachorro, gato ou peixe): ");
            a4.tipoAnimal = Console.ReadLine();

            if (a4.tipoAnimal == "cachorro") contador_cachorro++;
            if (a4.tipoAnimal == "gato") contador_gato++;
            if (a4.tipoAnimal == "peixe") contador_peixe++;

            //quito animal
            Console.WriteLine("Informe o nome do quinto animal: ");
            a5.nomeAnimal = Console.ReadLine();
            Console.WriteLine("Informe o tipo do quinto animal (cachorro, gato ou peixe): ");
            a5.tipoAnimal = Console.ReadLine();

            if (a5.tipoAnimal == "cachorro") contador_cachorro++;
            if (a5.tipoAnimal == "gato") contador_gato++;
            if (a5.tipoAnimal == "peixe") contador_peixe++;

            //resultado na tela
            Console.WriteLine("\n Cachorros: {0}; \n Gatos: {1} \n Peixes: {2} \n", contador_cachorro, contador_gato, contador_peixe);
        }
    }
}
