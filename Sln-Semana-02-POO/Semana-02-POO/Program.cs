// See https://aka.ms/new-console-template for more information
using Semana_02_POO;

Console.WriteLine("Hello, World!");

//Declaro uma variavel com instancia da minha classe
CentroDeCusto nomeVariavel = new CentroDeCusto(5958, "Teste", DateTime.Now, 1500.0M, 2023);
nomeVariavel.CalcularCustoReal(10);