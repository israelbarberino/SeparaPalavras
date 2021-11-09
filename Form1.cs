using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeparaPalavras
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            if (Confirma())
            {
                Application.Exit();
            }

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (txbFrase.Text == "")
            {
                MessageBox.Show("Digite uma frase antes de processar.", "Orientação",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                AlimentaLista();
            }
        }

        private void AlimentaLista()
        {
            char[] letra = new char[200];
            int pos, max;
            string palavra="";
            letra = txbFrase.Text.ToCharArray();
            max = letra.Length;
            for (pos = 0; pos < max; pos++)
            {
                palavra = palavra + letra[pos].ToString(); 
                if (letra[pos] == ' ' || pos == max-1)
                {
                    ltbPalavras.Items.Add(palavra);
                    palavra = "";
                }
            }
        }

        static bool Confirma()
        {
            if (MessageBox.Show("Deseja realmente sair desde programa?", "Confirmação", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            else return false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (Dialogo())
            {
                txbFrase.Clear();
                ltbPalavras.Items.Clear();
            }
            
        }
        static bool Dialogo()
        {
            if (MessageBox.Show("Deseja realmente sair desde programa?", "Confirmação", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            else return false;
        }

        private void txbFrase_TextChanged(object sender, EventArgs e)
        {
            ltbPalavras.Items.Clear();

        }
    }
}
