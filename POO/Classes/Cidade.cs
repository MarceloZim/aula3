using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Classes
{
    public class Cidade
    {
        //ATRIBUTOS
        public double Extensao { get; set; }
        public decimal Populacao { get; set; }
        public string nome { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public decimal Temperatura { get; set; }
        public string Relevo { get; set; }
        public List<string> Normas { get; set; }

        //COMPORTAMENTOS (Propriedade)
        public void CriarNormas(string novaNorma)
        {
            if (Normas == null)
                Normas = new List<string>();
            Normas.Add(novaNorma);
        }


        //CONSTRUTOR

        public void AumentarTemperatura(decimal aumentar)
        {
            Temperatura += aumentar;
        }
        public void DiminuirTemperatura(decimal diminuir)
        {
            Temperatura += diminuir;
        }


    }
}
