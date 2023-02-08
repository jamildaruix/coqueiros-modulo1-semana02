using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_02_POO
{
    /// Aqui criou uma classe
    /// Foi Criado um Enpacsulamento
    public class CentroDeCusto
    {
        /// Criação de propriedades públicas
        public int Id { get; set; } // Default 0
        public string Descricao { get; set; } // Null 
        public DateTime DataCriacao { get; set; } // 01/01/0001 00:00:00
        public decimal VerbaLiberada { get; set; } // 0.0
        public int AnoVerbaLiberada { get; set; } // = 0

        //Variavél privada
        private static decimal custoReal;

        //Construtor Statico
        static CentroDeCusto()
        {
            custoReal = 1500M;
        }

        // Construtor com parametros
        public CentroDeCusto(int id, 
                             string descricao, 
                             DateTime dataCriacao,
                             decimal verbaLiberada, 
                             int anoVerbaLiberada)
        {
            /*
             * Preencher as propriedades com os 
             * parametros recebidos do construtor
             */
            Id = id;
            Descricao = descricao;
            DataCriacao = dataCriacao;
            VerbaLiberada = verbaLiberada;
            AnoVerbaLiberada = anoVerbaLiberada;
        }

        //Novo Método que vai preencher a variavel 
        //privada chamda custoReal com o valor do parametro recebido (custoRealNovo)
        public void CalcularCustoReal(decimal custoRealNovo)
        {
            custoReal = custoRealNovo;

            Console.WriteLine($"O novo custo real do centro de custo {Descricao}, com o id {Id} é {custoReal}");
        }
    }
}
