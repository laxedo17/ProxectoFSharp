using System;

namespace ProxectoCSharp
{
    public class Persona
    {
        public string Nome { get; private set; } //Read-only public
        public Persona (string nome) //Constructor
        {
            Nome = nome;
        }

        public void ImprimirNome() //Metodo publico
        {
            Console.WriteLine($"Meu nome e {Nome}");
        }
    }
}
