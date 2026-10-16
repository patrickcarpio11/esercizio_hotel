using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio_hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float camera=0, stagione=0;
        int parcheggio;
        private void btn_n1_Click(object sender, EventArgs e)
        {
            //Calcolo Stagione
            if (cmb_n1.SelectedIndex == 0)
            {
                stagione = 0;
            }


            if (cmb_n1.SelectedIndex == 1)
            {
                stagione = 5;
            }

            if (cmb_n1.SelectedIndex == 2)
            {
                stagione = 10;
            }
            //Calcolo camera
            if (cmb_n2.SelectedIndex == 0)
            {
                camera = 0;
            }


            if (cmb_n2.SelectedIndex == 1)
            {
                camera = 15;
            }

            if (cmb_n2.SelectedIndex == 2)
            {
                camera = 30;
            }

            //Parcheggio
            if (chk_n1.Checked)
            {
                parcheggio = 5;
            }
            else
            {
                parcheggio = 0;
            }
        }

       
    }
}
