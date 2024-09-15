using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa.Exercicios.DicionarioEAvaliacaoDeBandas
{
    public class DicionarioEAvaliacaoDeBandas
    {
        public DicionarioEAvaliacaoDeBandas()
        {
            Exercicio1();

        }

        void Exercicio1()
        {
            /*
             * Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
             */

            Dictionary<string, Dictionary<string, List<int>>> alunosMateriasNotas = new Dictionary<string, Dictionary<string, List<int>>>();

            alunosMateriasNotas.Add("Kelvin", new Dictionary<string, List<int>> {
                { "Português", new List<int> { 10, 5 } },
                { "Geografia", new List<int> { 10, 5 } } });

            string aluno = "Kelvin";
            string materia = "Geografia";

            if (alunosMateriasNotas.ContainsKey(aluno))
            {
                if (alunosMateriasNotas[aluno].ContainsKey(materia))
                {
                    Console.WriteLine($"A nota do Aluno: {aluno} em {materia} é: {alunosMateriasNotas["Kelvin"]["Geografia"].Average()}");
                }
            }
        }

    }
}
