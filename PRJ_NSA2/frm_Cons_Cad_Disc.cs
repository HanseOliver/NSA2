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
    public partial class frm_Cons_Cad_Disc : Form
    {
        public frm_Cons_Cad_Disc()
        {
            InitializeComponent();
        }

        //Conecta através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //Declarando o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_disc; //pega uma copia pra leitura
        //Declarando o BindingSource -- tabela virtual editável
        
        BindingSource bs_disc = new BindingSource();

        // criando a variavel que receberá a query (comando sql)
        String _query;

        private void carregar_grid()
        {
            //Determinando a query desejada
            _query = "Select * from Disciplinas";
            //declarando o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //executando o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_disc = _dataCommand.ExecuteReader();
            //executando
            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
                dgv_DiscConsulta_ConsDisc.DataSource = bs_disc;
            }
            else
            {
                MessageBox.Show("Não temos Al cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frm_Cons_Cad_Disc_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void dgv_DiscConsulta_ConsDisc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Pesq_ConsDisc_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Escolha_ConsDisc.Text == "Sigla")
            {
                _query = "Select * from Disciplinas where sigla like '" + txt_Pesq_ConsDisc.Text + "%'";
            }
            else if (cmb_Escolha_ConsDisc.Text == "Descrição")
            {
                _query = "Select * from Disciplinas where descricao like '" + txt_Pesq_ConsDisc.Text + "%'";
            }
            else if (cmb_Escolha_ConsDisc.Text == "Codigo da Disciplina")
            {
                _query = "Select * from Disciplinas where cod_disciplina like '" + txt_Pesq_ConsDisc.Text + "%'";
            }
            else {
                MessageBox.Show("Escolha um campo para pesquisar!!", "atenção", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                cmb_Escolha_ConsDisc.Focus();
            }

            txt_Pesq_ConsDisc.Focus();
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_disc = _dataCommand.ExecuteReader();

            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
            }
            else {

                MessageBox.Show("Não temos disciplinas cadastradas com este parametro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = bs_disc.Count;
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void printDocument1_ConsCadDisc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;// uma variável tipo vetor q vai conter vários campos com as informações de cada campo 
            linha = dgv_DiscConsulta_ConsDisc.CurrentRow;// a variável vai conter a linha atual

            e.Graphics.DrawImage(Image.FromFile("P5_logo.PNG"), 50 , 25); //informações da folha
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("FICHA INDIVIDUAL DE DISCIPLINA", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 400, 50);//uma letra equivale a 20 linhas

            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 75, 800, 75);

            // código
            e.Graphics.DrawString("CÓDIGO DA DISCIPLINA:  " + linha.Cells["cod_disciplina"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 120);

            // descrição
            e.Graphics.DrawString("DESCRIÇÃO:   " + linha.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 140);

            // sigla
            e.Graphics.DrawString("SIGLA : " + linha.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 160);// pega informações da tabela

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 1100, 800, 1100); // linha azul no fim do documento

        }

        private void button2_Click(object sender, EventArgs e)//botão visualizar
        {
            printPreviewDialog1_ConsCadDisc.Text = " Visualizando a impressão";   // título da janela
            printPreviewDialog1_ConsCadDisc.WindowState = FormWindowState.Maximized;  // status da janela do preview
            printPreviewDialog1_ConsCadDisc.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            printPreviewDialog1_ConsCadDisc.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            printPreviewDialog1_ConsCadDisc.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)// botão de impressão
        {
            printDialog1_ConsCadDisc.ShowDialog();// mostra a vizualização da impressão
            printDocument1_ConsCadDisc.Print();// impressão em si

        }
    }
}
