using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana_02_POO
{
    //Estrutura feita sobre encapsulamento
    public class Pagamento 
    {
        public int IdFuncionario { get; set; }
        public decimal Valor { get; set; }

        private string mostrarTexto;

        public string PropMostrarTexto { get { return mostrarTexto ;} }

        public Pagamento(int idFuncionario, decimal valor)
        {
            IdFuncionario = idFuncionario;
            Valor = valor;
            mostrarTexto = "Sem Divida";
        }


        //Criar método privado chamado CalcularImposto
        private void CalcularImposto()
        {
            decimal simular = Valor * 0.50M;
            mostrarTexto = $"Com Divida, valor do imposto {simular}";
        }

        //Chamar o método publico no program.cs
        public void EfetuarCalculo()
        {
            if(Valor > 50)
            {
                CalcularImposto();
            }
        }

        public string MostrarTextoCalculo() 
        {
            return mostrarTexto;
        }
    }
}