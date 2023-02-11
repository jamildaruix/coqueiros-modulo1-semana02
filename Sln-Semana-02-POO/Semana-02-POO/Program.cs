// See https://aka.ms/new-console-template for more information
using Semana_02_POO;

Console.WriteLine("Hello, World!");



//Declaro uma variavel com instancia da minha classe
DateTime data = new DateTime(2023, 2, 1);
CentroDeCusto nomeVariavel = new CentroDeCusto(5958, "Teste", data, 1500.0M, 2023);
nomeVariavel.CalcularCustoReal(10);

Pagamento instanciaPagamento = new Pagamento(1, 15.59M);
instanciaPagamento.EfetuarCalculo();
string mensagem = instanciaPagamento.MostrarTextoCalculo();
Console.WriteLine(mensagem);
Console.WriteLine(instanciaPagamento.PropMostrarTexto);

Funcionario funcionario = new Funcionario();
funcionario.TextoSalario("Teste Um");
funcionario.TextoSalario("Teste Um", 15.99M);
funcionario.TextoSalario("Teste Um", 15.99M, true);

Exercicio7.Animacao();
Exercicio7.Animacao("Divertidamente");
Exercicio7.Animacao("Yuyu Hakusho");
Exercicio7.Animacao("Bela e Fera");

Exercicio9Estudante exercicio9Estudante = new Exercicio9Estudante("geografia", 7);
exercicio9Estudante.ImprimirMaiorNota();

exercicio9Estudante = new Exercicio9Estudante("historia", 9);
exercicio9Estudante.ImprimirMaiorNota();