using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Exercicio.Escola.ClassEscola
{
    public class Professor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Materia> Materias { get; set; }
        public Professor()
        {
            Materias = new List<Materia>();
        }
    }

}
