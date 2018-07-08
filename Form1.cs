using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Barberos
{
    public partial class Form1 : Form
    {
        PictureBox[] Clientes = new PictureBox[12];
        int i = 0;
        public Form1()
        {

            

            InitializeComponent();
            Clientes[0] = Cliente1;
            Clientes[1] = Cliente2;
            Clientes[2] = Cliente3;
            Clientes[3] = Cliente4;
            Clientes[4] = Cliente5;
            Clientes[5] = Cliente6;
            Clientes[6] = Cliente7;
            Clientes[7] = Cliente8;
            Clientes[8] = Cliente9;
            Clientes[9] = Cliente10;
            Clientes[10] = Cliente11;
            Clientes[11] = Cliente12;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            Clientes[i].Image = null;
            Clientes[i].Image = Properties.Resources.pelo_largo;

            i++;
            if(i == 12)
            {
                btnAC.Enabled = false;
            }
        }
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            btnAC.Enabled = false;
            Thread Barbero1 = new Thread(corte);  
            Barbero1.Start();
            btnAC.Enabled = true;
            
        }

        private void corte()
        {
            Random rnd = new Random();
            for (int j = 0; j < i; j++)
            {
      
                int corte = rnd.Next(1, 3);
                corte = corte * 1000;

                picCliente.Image = Properties.Resources.pelo_largo;
                Clientes[j].Image = null;              
                Thread.Sleep(1000);
                picCliente.Image = Properties.Resources.pelo_largo;   
                Thread.Sleep(corte);
                picCliente.Image = null;
                picCliente.Image = Properties.Resources.pelo_corto;
                Thread.Sleep(1000);
                if(j == i-1)
                {
                    picCliente.Image = null;
                    i = 0;
                }
            }
        }

    }
}
