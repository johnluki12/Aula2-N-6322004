using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_N_6322004
{
    internal class Entrada
    {
        double valor;
        string pol;
        string data;
        string hora;
        public void SetValor(double valor)
        {
            this.valor = valor;
        }
        public double GetValor()
        {
            return valor;
        }
        public void SetPol(string pol)
        {
            this.pol = pol;
        }
        public string GetPol()
        {
            return pol;
        }
        public void SetData(string data)
        {
            this.data = data;
        }
        public string GetData()
        {
            return data;
        }
        public void SetHora(string hora)
        {
            this.hora = hora;
        }
        public string GetHora()
        {
            return hora;
        }
    }
}
