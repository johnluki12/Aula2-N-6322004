using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_N_6322004
{
    internal class Filme
    {
        string titulo;
        string sinopse;
        string genero;
        string classificacao;

      public void Receber(string ti,string sin,string gen,string clas)
        {
            this.titulo = ti;
            this.sinopse = sin;
            this.genero = gen;
            this.classificacao = clas;

        }
        public string Mostrar()
        {
            return "\nTitulo: "+this.titulo+ " \nSinopse: "+this.sinopse+"\nGenero: "+ this.genero+"\nClassificação: "+this.classificacao;
        }
    }
}
