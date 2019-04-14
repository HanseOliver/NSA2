using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Prj_NSA2
{
    public partial class frm_Cons_Cad_Al : Form
    {
        public frm_Cons_Cad_Al()
        {
            InitializeComponent();
        }
        //Conecta através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //Declarando o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_al; //pega uma copia pra leitura
        //Declarando o BindingSource -- tabela virtual editável

        BindingSource bs_al = new BindingSource();

        // criando a variavel que receberá a query (comando sql)
        String _query;

        private void carregar_grid()
        {
            //Determinando a query desejada
            _query = "Select * from Alunos";
            //declarando o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //executando o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_al = _dataCommand.ExecuteReader();
            //executando
            if (dr_al.HasRows == true)
            {
                bs_al.DataSource = dr_al;
                dgv_DiscConsulta_ConsAl.DataSource = bs_al;
            }
            else
            {
                MessageBox.Show("Não temos Al cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void frm_Cons_Cad_Al_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void txt_Pesq_ConsDisc_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Escolha_ConsAl.Text == "Matricula")
            {
                _query = "Select * from Alunos where Matricula like '" + txt_Pesq_ConsAl.Text + "%'";
            }
            else if (cmb_Escolha_ConsAl.Text == "Nome")
            {
                _query = "Select * from Alunos where Nome like '" + txt_Pesq_ConsAl.Text + "%'";
            }
            else if (cmb_Escolha_ConsAl.Text == "Data de Nascimento")
            {
                _query = "Select * from Alunos where Nasc like '" + txt_Pesq_ConsAl.Text + "%'";
            }
            else if (cmb_Escolha_ConsAl.Text == "Endereço")
            {
                _query = "Select * from Alunos where Endereco like '" + txt_Pesq_ConsAl.Text + "%'";
            }
            else if (cmb_Escolha_ConsAl.Text == "Numero")
            {
                _query = "Select * from Alunos where numero like '" + txt_Pesq_ConsAl.Text + "%'";
            }
            else if (cmb_Escolha_ConsAl.Text == "Bairro")
            {
                _query = "Select * from Alunos where bairro like '" + txt_Pesq_ConsAl.Text + "%'";
            }
            else if (cmb_Escolha_ConsAl.Text == "Cidade")
            {
                _query = "Select * from Alunos where cidade like '" + txt_Pesq_ConsAl.Text + "%'";
            }
            else if (cmb_Escolha_ConsAl.Text == "CEP")
            {
                _query = "Select * from Alunos where cep like '" + txt_Pesq_ConsAl.Text + "%'";
            }
            else if (cmb_Escolha_ConsAl.Text == "RG")
            {
                _query = "Select * from Alunos where RG like '" + txt_Pesq_ConsAl.Text + "%'";
            }
            else if (cmb_Escolha_ConsAl.Text == "Telefone")
            {
                _query = "Select * from Alunos where telefone like '" + txt_Pesq_ConsAl.Text + "%'";
            }
            else {
                MessageBox.Show("Escolha um campo para pesquisar!!", "atenção", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                cmb_Escolha_ConsAl.Focus();
            }

            txt_Pesq_ConsAl.Focus();
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_al = _dataCommand.ExecuteReader();

            if (dr_al.HasRows == true)
            {
                bs_al.DataSource = dr_al;
            }
            else {

                MessageBox.Show("Não temos alunos cadastrados com este parametro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        
        }

        private void btn_Qntd_ConsAl_Click(object sender, EventArgs e)
        {
            int a = bs_al.Count;
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_imprimir_ConsCadAl_Click(object sender, EventArgs e)
        {
            printDialog1_ConsCadAl.ShowDialog();// mostra a vizualização da impressão
            printDocument1_ConsCadAl.Print();// impressão em si
        }

        private void btn_vizualizar_ConsCadAl_Click(object sender, EventArgs e)
        {
            printPreviewDialog1_ConsCadAl.Text = " Visualizando a impressão";   // título da janela
            printPreviewDialog1_ConsCadAl.WindowState = FormWindowState.Maximized;  // status da janela do preview
            printPreviewDialog1_ConsCadAl.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            printPreviewDialog1_ConsCadAl.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            printPreviewDialog1_ConsCadAl.ShowDialog();
        }

        private void printDocument1_ConsCadAl_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;// uma variável tipo vetor q vai conter vários campos com as informações de cada campo 
            linha = dgv_DiscConsulta_ConsAl.CurrentRow;// a variável vai conter a linha atual

            e.Graphics.DrawImage(Image.FromFile("P5_logo.PNG"), 50, 35); //informações da folha
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("FICHA INDIVIDUAL DE ALUNOS", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 400, 50);//uma letra equivale a 20 linhas

            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 75, 800, 75);
            e.Graphics.DrawString("MATRICULA DO ALUNO:  " + linha.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 120);

            // descrição
            e.Graphics.DrawString("NOME:   " + linha.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 140);

            // sigla
            e.Graphics.DrawString("DATA DE NASCIMENTO : " + linha.Cells["Nasc"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 160);// pega informações da tabela

            e.Graphics.DrawString("ENDEREÇO : " + linha.Cells["Endereco"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 180);// pega informações da tabela

            e.Graphics.DrawString("NUMERO DA CASA : " + linha.Cells["numero"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 200);// pega informações da tabela

            e.Graphics.DrawString("BAIRRO : " + linha.Cells["bairro"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 220);// pega informações da tabela

            e.Graphics.DrawString("CIDADE : " + linha.Cells["cidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 240);// pega informações da tabela

            e.Graphics.DrawString("CEP : " + linha.Cells["cep"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 260);// pega informações da tabela

            e.Graphics.DrawString("RG : " + linha.Cells["RG"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 280);// pega informações da tabela

            e.Graphics.DrawString("TELEFONE : " + linha.Cells["telefone"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 300);// pega informações da tabela

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 1100, 800, 1100); // linha azul no fim do documento

        }

        private void lbl_Texto_ConsDisc_Click(object sender, EventArgs e)
        {

        }

   }
}

