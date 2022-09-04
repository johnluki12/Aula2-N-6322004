using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_N_6322004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme fil = new Filme();
            Entrada en = new Entrada();
            Console.Write(" Digite o titulo do filme: ");
            string titulo=Console.ReadLine();
            Console.Write(" Digite a sinopse do filme: ");
            string sinopse =Console.ReadLine();
            Console.Write(" Digite o genero do filme: ");
            string genero =Console.ReadLine();
            Console.Write(" Digite a classificação do filme: ");
            string classificacao =Console.ReadLine();
            fil.Receber(titulo, sinopse, genero, classificacao );
            Console.WriteLine(fil.Mostrar());
            Console.ReadLine();

            Console.Write(" Digite o valor do filme: ");
            en.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.Write(" Digite a poltrona que deseja: ");
            en.SetPol(Console.ReadLine());
            Console.Write(" Digite a Data que deseja assistir o filme: ");
            en.SetData(Console.ReadLine());
            Console.Write(" Digite a hora que deseja assistir o filme: ");
            en.SetHora(Console.ReadLine());
            Console.WriteLine("Valor: "+ en.GetValor().ToString("C")+"\nPoltrona: "+ en.GetPol()+"\nData: "+en.GetData()+"\nHora: "+en.GetHora());
            Console.ReadKey();

        }
    }
}
