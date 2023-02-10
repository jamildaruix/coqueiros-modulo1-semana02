using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana_02_POO
{
    ///Aula sobrecarga (overload)
    public class Funcionario
    {
        public string ParametroUm { get; set; }
        public string ParametroDois { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string parametroUm)
        {
            ParametroUm = parametroUm;
        }

        public Funcionario(string parametroUm, string parametroDois)
        {
            ParametroUm = parametroUm;
            ParametroDois = parametroDois;
        }

        public void TextoSalario(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public void TextoSalario(bool condicao)
        {
            Console.WriteLine(condicao);
        }

        public void TextoSalario(string mensagem, decimal valor)
        {
            TextoSalario(mensagem);
            Console.WriteLine(valor);
        }

        public void TextoSalario(string mensagem, decimal valor, bool condicao)
        {
            TextoSalario(mensagem, valor);
            Console.WriteLine(condicao);
        }
    }
}