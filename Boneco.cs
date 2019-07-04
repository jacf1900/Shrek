using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shrek
{
    class Boneco
    {
        public string nome="";
        public int ano;
        public string concelho;
        public double avenca;
        public bool radio1;
        public bool box1;
        public bool box2;
        public bool box3;
        public double resultado;

        public void Set_nome(string novo_nome)
        {
            nome = novo_nome;
        }
        public void Set_ano(int novo_ano)
        {
            ano = novo_ano;
        }
        public void Set_avenca(double nova_avenca)
        {
            avenca = nova_avenca;
            resultado = avenca;
        }
        public void Set_conselho(string novo_conselho)
        {
            concelho = novo_conselho;
        }
               
        public void Calcular()
        {
               resultado = avenca;
           
            if (ano > 2000) {resultado = resultado - avenca * 0.1; }
            if (box1 == true) { resultado = resultado - avenca * 0.1; }
            if (box2 == true) { resultado = resultado - avenca * 0.05; }
            if (box3 == true) { resultado = resultado + 12; }
            if (radio1 == true) { resultado = resultado - avenca * 0.01; }
            if (concelho == "Amares") { resultado = resultado - avenca * 0.2; }


        }


    }
}
