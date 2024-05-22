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
    public partial class frmReservar : Form
    {
        public frmReservar()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                cboxV1.Enabled = false;
                cboxV2.Enabled = false;
                cboxA1.Enabled = true;
                cboxA2.Enabled = true;
            }
            if(radioButton2.Checked == true)
            {
                cboxV1.Enabled = true;
                cboxV2.Enabled = true;
                cboxA1.Enabled = false;
                cboxA2.Enabled = false;
            }

            if(comboBox1.SelectedItem.ToString() == "Quenaken")
            {
                cboxA1.Items.Clear();
                cboxA2.Items.Clear();
                cboxV1.Items.Clear();
                cboxV2.Items.Clear();

                for(int a1 = 1; a1 < 21;  a1++)
                {
                    cboxA1.Items.Add(a1);
                }
                for(int a2 = 1; a2 < 6; a2++)
                {
                    cboxA2.Items.Add(a2);
                }

                for(int v1 = 1; v1 < 21;  v1++)
                {
                    cboxV1.Items.Add(v1);
                }
                for(int v2 = 1; v2 < 6; v2++)
                {
                    cboxV2.Items.Add(v2);
                }
            }

            if(comboBox1.SelectedItem.ToString() == "Onas")
            {
                cboxA1.Items.Clear();
                cboxA2.Items.Clear();
                cboxV1.Items.Clear();
                cboxV2.Items.Clear();

                for (int a1 = 1; a1 < 41;  a1++)
                {
                    cboxA1.Items.Add(a1);
                }
                for(int a2 = 1; a2 < 5; a2++)
                {
                    cboxA2.Items.Add(a2);
                }

                for(int v1 = 1; v1 < 21; v1++)
                {
                    cboxV1.Items.Add(v1);
                }
                for(int v2 = 1; v2 < 6; v2++)
                {
                    cboxV2.Items.Add(v2);
                }
            }

            if(comboBox1.SelectedItem.ToString() == "Tobas")
            {
                cboxA1.Items.Clear();
                cboxA2.Items.Clear();
                cboxV1.Items.Clear();
                cboxV2.Items.Clear();

                for (int a1 = 1; a1 < 11; a1++)
                {
                    cboxA1.Items.Add(a1);
                }
                for(int a2 = 1; a2 < 4; a2++)
                {
                    cboxA2.Items.Add(a2);
                }

                for(int v1 = 1; v1 < 16; v1++)
                {
                    cboxV1.Items.Add(v1);
                }
                for(int v2 = 1; v2 < 6; v2++)
                {
                    cboxV2.Items.Add(v2);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reservación Realizada con Éxito.");
        }
    }
}
