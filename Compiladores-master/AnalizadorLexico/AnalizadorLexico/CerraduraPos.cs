using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    public partial class CerraduraPos : Form
    {
        public CerraduraPos()
        {
            InitializeComponent();
            this.ActualizarListas();
        }

        public void ActualizarListas()
        {
            this.comboBox1.Text = "";
            this.comboBox1.Items.Clear();
            
            foreach (AFN f in AFN.ConjuntoAFNs)
            {
                this.comboBox1.Items.Add(f.idAFN);
                
            }
        }
        private void Mensaje(String mensaje)
        {
            this.label4.Text = mensaje;
            this.label4.ForeColor = Color.Green;
            this.label4.BackColor = Color.FromArgb(125, 255, 125);
            this.label4.Visible = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label4.Visible = false;
            this.label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex < 0)
            {
                this.label3.Text = "Seleccione un automata";
                this.label3.ForeColor = Color.Red;
                this.label3.Visible = true;
                return;
            }

            Program.CerraduraPos(this.comboBox1.Text);
            this.ActualizarListas();
            this.Mensaje("Creada Cerradura Positiva");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CerraduraPos_Load(object sender, EventArgs e)
        {

        }
    }
}
