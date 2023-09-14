using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Dado
    {
        private int nFace;
        private String upFace;

        //construtor com parâmetros
        public Dado(int iN, String iUp)
        {
            nFace = iN;
            upFace = iUp;
        }
        //construtor por defeito
        public Dado()
        {
            nFace = 6;
            upFace = "AS";
        }

        //Exrecicio 1.a) 
        public String getFace() { return upFace; }

        //Exercicio 1. b)
        public String lancaDado()
        {
            int face = gerador(6);
            switch (face)
            {
                case 1: upFace = "AS"; break;
                case 2: upFace = "REI"; break;
                case 3: upFace = "DAMA"; break;
                case 4: upFace = "VALETE"; break;
                case 5: upFace = "DEZ"; break;
                case 6: upFace = "NOVE"; break;
                default: upFace = "ERRO"; break;
            }
            return getFace();
        }

        //Exercicio 1. c)
        public int calcPontos()
        {

            if (upFace.Equals("AS"))
            {
                return 10;
            }
            else if (upFace.Equals("REI"))
            {
                return 8;
            }
            else if (upFace.Equals("DAMA"))
            {
                return 7;
            }
            else if (upFace.Equals("VALETE"))
            {
                return 6;
            }
            else if (upFace.Equals("DEZ"))
            {
                return 2;
            }
            else if (upFace.Equals("NOVE"))
            {
                return 1;
            }
            return 0;
        }
        //Método fornecido
        private int gerador(int max)
        {
            Random numAleatorio = new Random();
            // gera um número aleatório entre 1 e max
            return numAleatorio.Next(max) + 1;
        }

    }

}

