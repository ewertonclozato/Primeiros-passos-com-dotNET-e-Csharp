using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                // if (opcaoUsuario == "1")
                // {
                //     Console.ReadKey();
                // }
                // else if (opcaoUsuario == "2")
                // {

                // }
                // else if (opcaoUsuario == "3")
                // {

                // }
                // else
                // {
                //     Console.WriteLine("Slecione 1, 2, 3 ou X");
                //     Console.WriteLine("1 - Inserir novo aluno");
                //     Console.WriteLine("2 - Listar alunos");
                //     Console.WriteLine("3 - Calcular media geral");
                //     Console.WriteLine("X - Sair\n");
                //     Console.ReadLine();
                //         if (opcaoUsuario == "1")
                //         {

                //         }
                //         else if (opcaoUsuario == "2")
                //         {

                //         }
                //         else if (opcaoUsuario == "3")
                //         {

                //         }
                //         else if (opcaoUsuario.ToUpper() == "x")
                //         {
                //             break;
                //         }
                // }
                switch (opcaoUsuario)
                {
                    case "1":
                        //adicionar aluno
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.nome = Console.ReadLine();
                    nota:
                        Console.WriteLine("Informe a nota do aluno: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.nota = nota;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Coloque uma nota existente.");
                            goto nota;
                        }
                        if (indiceAluno < alunos.Length)
                        {
                            alunos[indiceAluno] = aluno;
                            indiceAluno++;
                        }
                        else
                        {
                            Console.WriteLine("Não cabem mais alunos");
                        }


                        break;
                    case "2":
                        //listar aluno
                        foreach (var a in alunos)
                        {
                            if (a.nome != null)
                            {
                                Console.WriteLine($"ALUNO: {a.nome} - NOTA: {a.nota}");
                                //Console.WriteLine(a.nome);
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        //media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = obterOpcaoUsuario();
            }
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media geral");
            Console.WriteLine("X - Sair\n");
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
