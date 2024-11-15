using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetobtn
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblDataText.Text = DateTime.Now.ToString("HH.mm.ss ");
            switch (i)
            {
                case 1:
                    i++;
                    picQuestiontimer.Visible = true;
                    picStoptimer.Visible = false;
                    picInfotimer.Visible = false;
                    picExclamacaotimer.Visible = false;
                    break;
                case 2:
                    i++;
                    picQuestiontimer.Visible = false;
                    picStoptimer.Visible = true;
                    picInfotimer.Visible = false;
                    picExclamacaotimer.Visible = false;
                    break;
                case 3:
                    i++;
                    picQuestiontimer.Visible = false;
                    picStoptimer.Visible = false;
                    picInfotimer.Visible = true;
                    picExclamacaotimer.Visible = false;
                    break;
                case 4:
                    i = 1;
                    picQuestiontimer.Visible = false;
                    picStoptimer.Visible = false;
                    picInfotimer.Visible = false;
                    picExclamacaotimer.Visible = true;
                    break;


            }




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtInfo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnFECHAR_Click(object sender, EventArgs e)
        {
            string message = "Tem a certeza que quer fechar o formulário? ";
            string title = "Fechar Formulário: ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            } else
            {

            }

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
             
            if (rbtSTOP.Checked && rbtOkOnly.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text,MessageBoxButtons.OK, MessageBoxIcon.Stop);}
            if (rbtSTOP.Checked && rbtYNCancel.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop); }
            if (rbtSTOP.Checked && rbtOKCancel.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Stop); }
            if (rbtSTOP.Checked && rbtYesNo.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop); }
            if (rbtPergunta.Checked && rbtOkOnly.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.OK, MessageBoxIcon.Question); }
            if (rbtPergunta.Checked && rbtYNCancel.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); }
            if (rbtPergunta.Checked && rbtOKCancel.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question); }
            if (rbtPergunta.Checked && rbtYesNo.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question); }
            if (rbtExclamacao.Checked && rbtOkOnly.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            if (rbtExclamacao.Checked && rbtYNCancel.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation); }
            if (rbtExclamacao.Checked && rbtOKCancel.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation); }
            if (rbtExclamacao.Checked && rbtYesNo.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); }
            if (rbtInfo.Checked && rbtOkOnly.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.OK, MessageBoxIcon.Information); }
            if (rbtInfo.Checked && rbtYNCancel.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information); }
            if (rbtInfo.Checked && rbtOKCancel.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information); }
            if (rbtInfo.Checked && rbtYesNo.Checked) { MessageBox.Show(txtMensagem.Text, txtTitulo.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information); }
            

        }

        private void picInfotimer_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
