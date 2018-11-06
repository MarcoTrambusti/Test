using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrovaMaxMin
{
    public partial class Form1 : Form
    {
        int i = 0;
        int[] iArray = new int[10];
        public Form1()
        {
            InitializeComponent();
            btnCarica.Text = "Carica (" + (10 - i) + ")";

        }
        private void aggiungi()
        {
            btnCarica.Text = "Carica (" + (9 - i) + ")";
            iArray[i] = (int)nupNumero.Value;
            i++;
            nupNumero.Value = 0;
        }
        private void btnCarica_Click(object sender, EventArgs e)
        {
         
            if (i < 9)
            {
                aggiungi();
            }
            else if(i == 9)
            {
                aggiungi();
                btnCarica.Enabled = false;
                lblMax.Text+=iArray.Max();
                lblMin.Text += iArray.Min();
                Array.Sort(iArray);           
                 foreach (var i in iArray)
                {
                    lblArray.Text += i + ";";
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            i = 0;
            nupNumero.Value = 0;
            iArray = new int[10];
            btnCarica.Enabled = true;
            btnCarica.Text = "Carica (" + (10-i) + ")";
            lblMax.Text = "Max :";
            lblMin.Text = "Min :";
            lblArray.Text = "Array ordinato :";
        }
    }
}
