using System;
using Revisao.Classes;

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
                        aluno.Nome = Console.ReadLine();
                    nota:
                        Console.WriteLine("Informe a nota do aluno: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
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
                            if (a.Nome != null)
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                                //Console.WriteLine(a.nome);
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        //media geral
                        decimal notaTotal = 0;
                        var nmrAlunos = 0;
                        decimal resulado = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (alunos[i].Nome != null)
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nmrAlunos++;
                            }
                        }
                        resulado = notaTotal / nmrAlunos;
                        ConceitoEnum conceitoGeral;

                        if (resulado < 2)
                        {
                            conceitoGeral = ConceitoEnum.E;
                        }
                        else if (resulado < 4)
                        {
                            conceitoGeral = ConceitoEnum.D;
                        }
                        else if (resulado < 6)
                        {
                            conceitoGeral = ConceitoEnum.C;
                        }
                        else if (resulado < 8)
                        {
                            conceitoGeral = ConceitoEnum.B;
                        }
                        else
                        {
                            conceitoGeral = ConceitoEnum.A;
                        }


                        Console.WriteLine($"Media: {resulado} - Conceito: {conceitoGeral}");
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
