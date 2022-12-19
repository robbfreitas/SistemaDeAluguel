namespace SistemaDeAluguel
{
    public class Program
    {
        static void Main(string[] args)
        {

            Estudante[] vect = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados? ");
            Console.WriteLine("Somente opções de  0 - 9");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Alguel #{i}:");
                Console.Write("Nome do estudante: ");
                string nome = Console.ReadLine();
                Console.Write("Email do estudante: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}