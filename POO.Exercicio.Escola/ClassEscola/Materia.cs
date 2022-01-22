using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Exercicio.Escola.ClassEscola
{
    public class Materia
    {
        public string Nome { get; set; }
        public string Metodologia { get; private set; }

        public void AlterarMetodologia(string metodologia)
        {
            if (metodologia == "presencial" || metodologia == "ead")
            {
                Metodologia = metodologia;
            }
            else
            {
                Console.WriteLine("Metodologia não existente.");
            }

        }

    }
}
