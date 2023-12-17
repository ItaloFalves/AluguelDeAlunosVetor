

namespace AluguelDeAlunosVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos vão ser alugados? ");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            Aluno[] alunos = new Aluno[10];


            for (int i = 0; i < quantidadeQuartos; i++)
            {
                Console.Write("Qual o nome do aluno? ");
                string nome = Console.ReadLine();
                Console.Write("Qual o email do aluno? ");
                string email = Console.ReadLine();
                Console.Write("Qual quarto vai ser alugado? ");
                int quarto = int.Parse(Console.ReadLine());
                alunos[quarto] = new Aluno(nome, email);

                Console.WriteLine();

            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if(alunos[i] != null)
                {
                    Console.WriteLine( i + ": " + alunos[i]);
                }
            }
        }
    }
}