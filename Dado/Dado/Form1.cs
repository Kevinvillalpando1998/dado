using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dado dado1,dado2,dado3;
        _3er_boton dosdados;
        private void button1_Click(object sender, EventArgs e)
        {
            dado1 = new Dado();
           for (int c=0;  c<100; c++)
            {
                dado1.lanzar();
                
            }



            txtmontrar.Text = dado1.ToString();

        }
        Sumas dado;
        private void button2_Click(object sender, EventArgs e)
        {
            dado = new Sumas();
            for ( int c=0;  c<100; c++)
            {
                dado.lanzar();
            }
            txtmontrar.Text = dado.ToString();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            txtmontrar.Clear();
            dosdados = new _3er_boton();
            for ( int c=0; c<100; c++)
            {
                dosdados.lanzardado1();
                dosdados.comparar();

                
            }
            txtmontrar.Text += dosdados.ToString();
        }
    }
}
