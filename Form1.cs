using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTP
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboxLocales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboxLocales.SelectedItem.ToString() == "Quenaken")
            {
                txtAzul.Text = "20";
                txtFila1.Text = "5";

                txtVerde.Text = "20";
                txtFila2.Text = "5";
            }
            
            if(cboxLocales.SelectedItem.ToString() == "Onas")
            {
                txtAzul.Text = "40";
                txtFila1.Text = "4";

                txtVerde.Text = "20";
                txtFila2.Text = "5";
            }

            if(cboxLocales.SelectedItem.ToString() == "Tobas")
            {
                txtAzul.Text = "10";
                txtFila1.Text = "3";

                txtVerde.Text = "15";
                txtFila2.Text = "5";
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            frmReservar r  = new frmReservar();
            r.ShowDialog();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
        }
    }
}
