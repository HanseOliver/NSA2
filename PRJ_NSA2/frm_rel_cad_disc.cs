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
    public partial class frm_rel_cad_disc : Form
    {

        OleDbConnection conn = Conexao.obterConexao();
        //Declarando o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_disc; //pega uma copia pra leitura
        //Declarando o BindingSource -- tabela virtual editável
        BindingSource bs_disc = new BindingSource();
        // criando a variavel que receberá a query (comando sql)
        String _query;

        public int pag = 1; // variável para controlar o salto de página
        int registro, linha = 0; //variável contadora de registros e linhas impressas, 
        int fim = 0;    //variável que controla o fim da impressão


        public frm_rel_cad_disc()
        {
            InitializeComponent();
        }

        private void frm_rel_cad_disc_Load(object sender, EventArgs e)
        {
            carregar_grid();
            fim = bs_disc.Count;

        }

        private void carregar_grid()
        {
            // Comando desejado
            _query = "Select * from Disciplinas order by cod_disciplina";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_disc = _dataCommand.ExecuteReader();
            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
                dgv_Relatorio.DataSource = bs_disc;
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
           

            e.Graphics.DrawImage(Image.FromFile("p5_logo.PNG"), 50, 25); // colocar imagens na pasta debug
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("RELATÓRIO GERAL DE DISCIPLINAS", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 300, 50);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)

            linha = 100;

            // cabeçalho de colunas
            e.Graphics.DrawString("Cód  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, linha);
            e.Graphics.DrawString("Descrição   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 100, linha);
            e.Graphics.DrawString("Sigla ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 500, linha);
           
            linha = 130;

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 75, 800, 75);

            while ((linha < 1075) & (registro != fim)) // folha modo terato possui 1200 linhas
            {
                // código
                e.Graphics.DrawString(reg_grid.Cells["cod_disciplina"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular ), Brushes.Black, 50, linha);
                // descrição
                e.Graphics.DrawString(reg_grid.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular ), Brushes.Black, 100, linha);
                // sigla
                e.Graphics.DrawString(reg_grid.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular ), Brushes.Black, 500, linha);

                bs_disc.MoveNext(); // movendo para o próximo registro

                reg_grid = dgv_Relatorio.CurrentRow;  // atualizando a linha da grid para impressão

                registro += 1;   // incrementando a variável contadora de registros

                linha += 20; // incrementando a variável para pular linha

            }


            //***************************** 
            //imprime o rodapé do relatório 
            //***************************** 
            e.Graphics.DrawString("Total de Registros: " + registro.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 550, 1100);
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 1), 50, 1115, 800, 1115);
            e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 50, 1120);
            e.Graphics.DrawString("Pág: " + pag.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 550, 1120);

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
                bs_disc.MoveFirst();
                
            }
            // Enquanto e.HasMorePages==true toda programação dentro do “PrintDocument” será reiniciada. 
	    // Quando e.HasMorePages==false a programação do “PrintDocument” será encerrada.  
        


        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDocument1.Print();   

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

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
