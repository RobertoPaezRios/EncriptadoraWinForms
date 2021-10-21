using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncriptadoraWindowsForms
{
    public partial class Form1 : Form
    {
        string textoEncriptado = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            bool todoBien = true;
            if (txtTexto.Text == "")
            {
                MessageBox.Show("Tienes que escribir un texto",
                "Ventana Emergente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todoBien = false;
            }
            if (txtClaveDes.Text == "")
            {
                MessageBox.Show("Tienes que escribir una clave de encriptacion",
                "Ventana Emergente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todoBien = false;
            }
            if (todoBien == true)
            {
                Desencriptar(textoEncriptado);
            }

        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "")
            {
                MessageBox.Show("Tienes que escribir un texto",
                "Ventana Emergente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtClaveDes.Text == "")
            {
                MessageBox.Show("Tienes que escribir una clave de encriptacion",
                "Ventana Emergente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string FraseConvertida = "";
            FraseConvertida = Encriptar(txtTexto.Text.ToString());
            textoEncriptado = Encriptar(txtTexto.Text.ToString());
            MessageBox.Show(FraseConvertida);
            //Encriptar(FraseConvertida);
        }

        public static string Encriptar(string str)
        {
            string fraseConvertida = "";
            string fraseDesencriptada = "";
            int num = 0, resultado = 0, numAux = 0, resultadoAux = 0, resultadoFinal = 0;

            foreach (var c in str)
            {
                num = ((int)c);
                resultado = (num * 3) / 5 + ((num * 3) % 5);
                fraseConvertida += resultado.ToString();
                //DESENCRIPTAR//
                numAux = num;
                resultadoAux = (numAux / 3) * 5 - ((numAux / 3) 5);
            }

            return fraseConvertida;
        }
        public static string Desencriptar (string str)
        {
            string fraseNormal = "";
            int resultado = 0, num = 0;
            
            


            return fraseNormal;
        }
    }
}
