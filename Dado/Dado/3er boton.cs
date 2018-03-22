using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dado
{
    class _3er_boton
    {

       private  int[] dado;
        private int  valor,n1,n2;

        
         public _3er_boton()
        {
            dado = new int[11];
            Thread.Sleep(1);
        }

        Random rdm = new Random(DateTime.Now.Millisecond);
        Random rnd = new Random(DateTime.Now.Millisecond);

        public void lanzardado1()
        {
                n1= rdm.Next(1, 7); 
                n2= rnd.Next( 1,7);
                valor = n1 + n2;
        }
        public void comparar()
        {
        
            switch (valor)
            {
                case 2:
                    dado[0] += 1;
                    break;
                case 3:
                    dado[1] += 1;
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
            string cadena = "";
            for (int c= 0; c<11; c++)
            {
                cadena += "el resultado " + (c + 2) + "cayo " + dado[c]+ Environment.NewLine;
            }
            return cadena;
        }
    }
}
