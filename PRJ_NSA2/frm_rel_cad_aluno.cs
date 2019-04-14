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
    public partial class frm_rel_cad_aluno : Form
    {
        OleDbConnection conn = Conexao.obterConexao();
        //Declarando o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_alu; //pega uma copia pra leitura
        //Declarando o BindingSource -- tabela virtual editável
        BindingSource bs_alu = new BindingSource();
        // criando a variavel que receberá a query (comando sql)
        String _query;

        public int pag = 1; // variável para controlar o salto de página
        int registro, linha = 0; //variável contadora de registros e linhas impressas, 
        int fim = 0;    //variável que controla o fim da impressão


        public frm_rel_cad_aluno()
        {
            InitializeComponent();
        }

        private void frm_rel_cad_aluno_Load(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            carregar_grid();
            fim = bs_alu.Count;
        }

        private void carregar_grid()
        {
            // Comando desejado
            _query = "Select * from Alunos order by Matricula";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_alu = _dataCommand.ExecuteReader();
            if (dr_alu.HasRows == true)
            {
                bs_alu.DataSource = dr_alu;
                dgv_Relatorio.DataSource = bs_alu;
            }
            else
            {
                MessageBox.Show("Não temos dados cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow reg_grid;
            reg_grid = dgv_Relatorio.CurrentRow;
            //registro = 0;
            //int oi;


            e.Graphics.DrawImage(Image.FromFile("p5_logo.PNG"), 50, 25); // colocar imagens na pasta debug
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("RELATÓRIO GERAL DE ALUNOS", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 300, 50);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)

            linha = 100;

            // cabeçalho de colunas
            e.Graphics.DrawString("Matricula  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, linha);
            e.Graphics.DrawString("Nome   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 120, linha);
            e.Graphics.DrawString("Nasc ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 250, linha);
            e.Graphics.DrawString("End  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 350, linha);

            e.Graphics.DrawString("Numero  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 550, linha);
            e.Graphics.DrawString("Bairro  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 650, linha);

            e.Graphics.DrawString("Cidade  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 750, linha);
            e.Graphics.DrawString("CEP  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 850, linha);

            e.Graphics.DrawString("RG  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 950, linha);
            e.Graphics.DrawString("Fone  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 1050, linha);

            linha = 130;

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 75, 1115, 75);

            while ((linha < 730) & (registro != fim)) // folha modo terato possui 1200 linhas
            {
                // código
                e.Graphics.DrawString(reg_grid.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 50, linha);
                // descrição
                e.Graphics.DrawString(reg_grid.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 120, linha);
                // sigla
                e.Graphics.DrawString(String.Format("{0:dd/MM/yyyy}", reg_grid.Cells["nasc"].Value), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 250, linha);

                e.Graphics.DrawString(reg_grid.Cells["Endereco"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 350, linha);

                e.Graphics.DrawString(reg_grid.Cells["numero"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 550, linha);

                e.Graphics.DrawString(reg_grid.Cells["bairro"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 650, linha);

                e.Graphics.DrawString(reg_grid.Cells["cidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 750, linha);

                e.Graphics.DrawString(reg_grid.Cells["cep"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 850, linha);

                e.Graphics.DrawString(reg_grid.Cells["RG"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 950, linha);

                e.Graphics.DrawString(reg_grid.Cells["telefone"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 1050, linha);

                bs_alu.MoveNext(); // movendo para o próximo registro

                reg_grid = dgv_Relatorio.CurrentRow;  // atualizando a linha da grid para impressão

                registro += 1;   // incrementando a variável contadora de registros

                linha += 20; // incrementando a variável para pular linha


                //***************************** 
                //imprime o rodapé do relatório 
                //***************************** 
                e.Graphics.DrawString("Total de Registros: " + registro.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 800, 750);
                e.Graphics.DrawLine(new Pen(Color.DarkBlue, 1), 50, 770, 1115, 770);
                e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 50, 780);
                e.Graphics.DrawString("Pág: " + pag.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 800, 780);

                pag += 1; // reajustando contadores de pag

                // trocando de página
                if ((pag > 1) & (registro < fim))
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;

                    registro = 0;
                    linha = 0;
                    bs_alu.MoveFirst();

                }
                // Enquanto e.HasMorePages==true toda programação dentro do “PrintDocument” será reiniciada. 
                // Quando e.HasMorePages==false a programação do “PrintDocument” será encerrada.  


            }
        }
        

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDocument1.Print();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_vizualizar_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Text = " Visualizando a impressão";   // título da janela
            printPreviewDialog1.WindowState = FormWindowState.Maximized;  // status da janela do preview
            printPreviewDialog1.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            printPreviewDialog1.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            printPreviewDialog1.ShowDialog();
            pag = 1;
        }
    }
}
