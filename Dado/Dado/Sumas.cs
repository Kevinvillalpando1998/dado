using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Sumas
    {
        private int[] dado;
  
       public Sumas()
        {
            dado = new int[11];
        }
        
        Random rdm = new Random();

        
        

        public void lanzar()
        {
            int n1, n2,r;
            n1 = rdm.Next(1, 7);
            n2 = rdm.Next(1, 7);
            r = n1 + n2;
        
            switch (r)
            {
                  case 2:
                    dado[0] += 1;
                    break;
                case 3:
                    dado[1]+= 1;
                    break;
                case 4:
                    dado[2] += 1;
                    break;
                case 5:
                    dado[3] += 1;
                    break;
                case 6:
                    dado[4] += 1;
                    break;
                case 7:
                    dado[5] += 1;
                    break;
                case 8:
                    dado[6] += 1;
                    break;
                case 9:
                    dado[7] += 1;
                    break;
                case 10:
                    dado[8] += 1;
                    break;
                case 11:
                    dado[9] += 1;
                    break;
                case 12:
                    dado[10] += 1;
                    break;
            }
            }
        public override string ToString()
        {
            string lil = "";
            for (int c=0; c<11; c++)
            {
             
               lil += "el resultado " + (c + 2) + "salio " + dado[c] + " veces" + Environment.NewLine;
            }
            
            return lil;
            //return "2 se repite " + resultado1 + "veces" +Environment.NewLine + "3 se repite " + resultado2 + "veces" + Environment.NewLine + "4 se repite " + resultado3 + "veces" + Environment.NewLine + "5 se repite " + resultado4 + "veces" + Environment.NewLine + "6 se repite " + resultado5 + "veces" + Environment.NewLine + "7 se repite " + resultado6 + "veces" + Environment.NewLine + "8 se repite " + resultado7 + "veces" + Environment.NewLine + "9 se repite " + resultado8 + "veces" + Environment.NewLine + "10 se repite " + resultado9 + "veces" + Environment.NewLine + "11 se repite " + resultado10 + "veces" + Environment.NewLine + "12 se repite " + resultado11 + "veces" + Environment.NewLine;
        }

    }
}
