using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> historico;
        private string data;
        public Calculadora(string data)
        {
            historico = new List<string>();
            this.data = data;
        }
        public int Somar(int val1, int val2)
        {
            int soma = val1 + val2;
            historico.Insert(0, "Res: " +soma + "Data: " + data);
            return soma;
        }
        public int Subtrair(int val1, int val2)
        {
            int subtrair = val1 - val2;
            historico.Insert(0, "Res: " + subtrair + "Data: " + data);
            return subtrair;
        }
        public int Dividir(int val1, int val2)
        {
            int dividir = val1 / val2;
            historico.Insert(0, "Res: " + dividir + "Data: " + data);
            return dividir;
        }
        public int Multiplicar(int val1, int val2)
        {
            int multiplicar = val1 * val2;
            historico.Insert(0, "Res: " + multiplicar + "Data: " + data);
            return multiplicar;
        }
        public List<string> Historico()
        {
            //List<string> hist;
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}
