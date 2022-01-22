using System;
using POO.Exercicio.Escola.ClassEscola;
namespace POO.Exercicio.Escola
{
    class Principal
    {
        static void Main(string[] args)
        {
            Professor objeto = new Professor();
            objeto.Nome = "Marcelo";
            objeto.Idade = 26;

            Materia materia = new Materia();
            materia.Nome = "Geografia";
            materia.AlterarMetodologia("ead");
            objeto.Materias.Add(materia);

            Console.WriteLine($"{objeto.Nome} é professor de {materia.Nome} da aula na modalidade {objeto.Materias[0].Metodologia}.");
        }
    }
}
