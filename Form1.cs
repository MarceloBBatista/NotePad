using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AVALIAÇÃO_N2_OFICIAL
{
    public partial class FormPrincipal : Form
    {
        public object GetColor { get; private set; }
        public Color Red { get; private set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void NovoClick(object sender, EventArgs e)
        {
            if (txtbox.Text.Length > 0)
            {
                DialogResult dr = MessageBox.Show("Deseja salvar seu Arquivo?", "Quetão", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    Salvar();
                }
                txtbox.Text = "";
            }
            else
            {
                txtbox.Text = "";
            }
        }

        private void AbrirClick(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Abrir";
            op.Filter = "Texto, DOcumento(*.txt) |*.txt|All Files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                txtbox.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
            this.Text = op.FileName;
        }

        private void SalvarClick(object sender, EventArgs e)
        {
            Salvar();
        }

        public void Salvar()
        {
            SaveFileDialog op = new SaveFileDialog();
            op.Title = "Salvar";
            op.Filter = "Texto, DOcumento(*.txt) |*.txt|All Files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                txtbox.SaveFile(op.FileName, RichTextBoxStreamType.PlainText);
            this.Text = op.FileName;
        }

        private void SairClick(object sender, EventArgs e)
        {
            Close();
        }

        private void DesfazerClick(object sender, EventArgs e)
        {
            txtbox.Undo();
        }

        private void RefazerClick(object sender, EventArgs e)
        {
            txtbox.Redo();
        }

        private void CopiarClick(object sender, EventArgs e)
        {
            txtbox.Copy();
        }

        private void ColarClick(object sender, EventArgs e)
        {
            txtbox.Paste();
        }

        private void CortarClick(object sender, EventArgs e)
        {
            txtbox.Cut();
        }

        private void AllSelect(object sender, EventArgs e)
        {
            txtbox.SelectAll();
        }

        private void DataTempo(object sender, EventArgs e)
        {
            txtbox.Text = System.DateTime.Now.ToString();
        }

        private void FonteClick(object sender, EventArgs e)
        {
            FontDialog op = new FontDialog();
            if (op.ShowDialog() == DialogResult.OK)
                txtbox.Font = op.Font;
        }

       

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtbox.Text.Length > 0)
            {
                DialogResult dr = MessageBox.Show("Deseja salvar seu Arquivo?", "Quetão", MessageBoxButtons.YesNoCancel);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    Salvar();
                }
                if (dr == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa feito por Marcelo Bezerra, para apresentação do projeto N2!");
        }

        private void PageClick(object sender, EventArgs e)
        {
            PageSetup.Document = PrintDocument;
            PageSetup.Document.DefaultPageSettings.Color = false;
            PageSetup.ShowDialog();
        }

        private void btimp_Click(object sender, EventArgs e)
        {
            PrintDialog.Document = PrintDocument;
            PrintDialog.ShowDialog();
        }

        private void esconderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtbox.Hide();
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtbox.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnprevia_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = PrintDocument;
            printPreviewDialog.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            statusdata.Text = DateTime.Now.ToString("HH:mm:ss") + " | " + DateTime.Now.ToString("dd/MM/yyyy");        
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtbox.Text, txtbox.Font, Brushes.Black, 12, 10);
        }

        private void printPreviewDialog_Load(object sender, EventArgs e)
        {
            printPreviewDialog.Document = PrintDocument;
            
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void marcadorDeTextoToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            txtbox.SelectionBackColor = Color.Green;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            int index = 0;
            txtbox.SelectAll();
            while (index < txtbox.Text.LastIndexOf(textBox1.Text))
            {
                txtbox.Find(textBox1.Text, index, txtbox.TextLength, RichTextBoxFinds.MatchCase);
                index = txtbox.Text.IndexOf(textBox1.Text, index) + 1;
                txtbox.SelectionBackColor = Color.Red;
            }

        }

        private void Colores(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtbox.SelectionColor = colorDialog1.Color;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbox.SelectionStart = 0;
            txtbox.SelectAll();
            txtbox.SelectionBackColor = Color.Black;
        }
    }

}
