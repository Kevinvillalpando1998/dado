using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Dado
    {
        private int[] vec;               
        public Dado()
        {
            vec = new int[6];                             
        }

        Random rmd = new Random();
        Random rnm = new Random();
        public void lanzardado()
        {
            int dado;
            dado = rmd.Next(1, 7);

        }
        

        public void lanzar1()
        {
            
        }

        public void lanzar()
        {
            int p;
            
            
                p = rmd.Next(1, 7);
            if (p == 1)
            {
                vec[0] += 1;
            }

            else if (p == 2)
            {
                vec[1] +=  1;
            }
            else if (p == 3)
            {
                vec[2] += 1;
            }
                else if (p == 4)
            {
                vec[3] += 1;
            }
                else if (p == 5)
            {
                vec[4] += 1;
                
            }
              else if  (p== 6)
            {
                vec[5] += 1;
            }          
                          
        }
        public override string ToString()
        {
            string lil = "";
            for (int c = 0; c < 6; c++)
            {
                lil += "cara " + (c + 1) + " cayo " + vec[c] + " veces"+ Environment.NewLine;
                
               
            }
            return lil;
        }
    }
}
