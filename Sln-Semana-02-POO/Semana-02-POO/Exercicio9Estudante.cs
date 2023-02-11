using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_02_POO
{
    public class Exercicio9Estudante
    {
        public string Materia { get; set; }
        public int Nota { get; set; }

        public Exercicio9Estudante(string materia, int nota)
        {
            Materia = materia;
            Nota = nota;
        }

        public void ImprimirMaiorNota()
        {
            Console.WriteLine($"materia {Materia} nota {Nota}");
        }
    }
}
