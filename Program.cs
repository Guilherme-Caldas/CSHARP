using System;

namespace Revisão
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[30];
            int indiceAluno = 0;

            int opcaoUsuario = NewMethod();

            while (opcaoUsuario >= 1 && opcaoUsuario < 4)
            {
                switch (opcaoUsuario)
                {
                    case 1:
                        // Adicionar aluno
                        Console.WriteLine();
                        Console.WriteLine(" Você selecionou o 1. ");
                        Console.WriteLine();
                        Console.WriteLine(" Informe o nome do aluno: ");
                        Console.WriteLine();
                        // Aluno aluno = new Aluno();
                        string nome = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine(" Informe a nota do aluno: ");
                        Console.WriteLine();
                        decimal nota = Decimal.Parse(Console.ReadLine());

                        Aluno al = new Aluno(nome, nota);
                        
                        Console.WriteLine();
                        Console.WriteLine(" Nome do aluno: " + al.Nome);
                        Console.WriteLine();
                        Console.WriteLine(" Nota do aluno: " + al.Nota);
                        Console.WriteLine();
                        
                        alunos [indiceAluno] = al;
                        indiceAluno++;

                        opcaoUsuario = NewMethod();

                    break;

                    case 2:
                        // Listar alunos
                        Console.WriteLine();
                        Console.WriteLine(" Você selecionou o 2. ");
                        Console.WriteLine();

                        for (int i = 0; i < indiceAluno; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Aluno: " + alunos[i].Nome + " , Nota: " + alunos[i].Nota);
                            Console.WriteLine();
                        }

                        opcaoUsuario = NewMethod();

                    break;

                    case 3:
                        // Cálculo da média
                        Console.WriteLine();
                        Console.WriteLine(" Você selecionou o 3. ");
                        Console.WriteLine();
                        decimal notaTotal = 0;
                        int nrAlunos = 0;

                        for (int i = 0; i < indiceAluno; i++)
                        {
                            notaTotal = notaTotal + alunos[i].Nota;
                            nrAlunos++;
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        
                        Enum conceitoGeral;

                        if ( mediaGeral > 0 && mediaGeral < 2 )
                        {
                            conceitoGeral = Enum.E;
                            Console.WriteLine(conceitoGeral);
                        }
                        else if ( mediaGeral <= 2 && mediaGeral < 4 )
                        {
                            conceitoGeral = Enum.D;
                            Console.WriteLine("Conceito: " + conceitoGeral);
                        }
                        else if ( mediaGeral <= 4 && mediaGeral < 6 )
                        {
                            conceitoGeral = Enum.C;
                            Console.WriteLine("Conceito: " + conceitoGeral);
                        }
                        else if ( mediaGeral <= 6 && mediaGeral < 8 )
                        {
                            conceitoGeral = Enum.B;
                            Console.WriteLine("Conceito: " + conceitoGeral);
                        }
                        else if ( mediaGeral <= 8 && mediaGeral <= 10 )
                        {
                            conceitoGeral = Enum.A;
                            Console.WriteLine("Conceito: " + conceitoGeral);
                        }

                        Console.WriteLine();
                        Console.WriteLine($" Media geral: {mediaGeral}");
                        Console.WriteLine();

                        opcaoUsuario = NewMethod();

                    break;

                    case 4:
                        // Sair
                        Console.WriteLine();
                        Console.WriteLine(" Você selecionou o 4. Saindo do programa. ");
                        Console.WriteLine();

                    break;
                }
            }

        }

        private static int NewMethod()
        {
            Console.WriteLine();
            Console.WriteLine(" Informe a opção desejada: ");
            Console.WriteLine(" (1) Inserir novo aluno. ");
            Console.WriteLine(" (2) - Listar alunos. ");
            Console.WriteLine(" (3) - Calcular Média Geral. ");
            Console.WriteLine(" (4) - Sair. ");
            Console.WriteLine();

            int opcaoUsuario = Int32.Parse(Console.ReadLine());

            while (opcaoUsuario < 1 || opcaoUsuario > 4)
            {
                Console.WriteLine(" Número inválido. Digite novamente: ");
                opcaoUsuario = Int32.Parse(Console.ReadLine());
            }

            return opcaoUsuario;
        }
    }
}
