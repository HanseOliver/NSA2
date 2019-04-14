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
    public partial class frm_rel_ana_Boletim : Form
    {
        OleDbConnection conn = Conexao.obterConexao();
        //Declarando o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_Bol; //pega uma copia pra leitura
        //Declarando o BindingSource -- tabela virtual editável
        BindingSource bs_Bol = new BindingSource();
        // criando a variavel que receberá a query (comando sql)
        String _query;

        string anterior = "Z";
        int contador_grupo = 0;

        public int pag = 1; // variável para controlar o salto de página
        int registro, linha = 0; //variável contadora de registros e linhas impressas, 
        int fim = 0;    //variável que controla o fim da impressão

        public frm_rel_ana_Boletim()
        {
            InitializeComponent();
        }

        private void frm_rel_ana_Boletim_Load(object sender, EventArgs e)
        {
            carregar_grid();
            fim = bs_Bol.Count;
        }
        private void carregar_grid()
        {
            // Comando desejado
            _query = "SELECT Registro_Mencoes.mencao, Alunos.Nome, Alunos.Matricula, Disciplinas.sigla, Disciplinas.descricao FROM Mencao, Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina order by Alunos.Nome;";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_Bol = _dataCommand.ExecuteReader();
            if (dr_Bol.HasRows == true)
            {
                bs_Bol.DataSource = dr_Bol;
                dgv_Relatorio.DataSource = bs_Bol;
            }
            else
            {
                MessageBox.Show("Não temos dados cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDocument1.Print();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow reg_grid;
            reg_grid = dgv_Relatorio.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("p5_logo.PNG"), 50, 25); // colocar imagens na pasta debug
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("BOLETIM", new System.Drawing.Font("Times new roman", 18, FontStyle.Bold), Brushes.Black, 300, 25);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)

            //dps de fazer o cabeçalho da pag pula a linha
            linha = 100;

            linha = 120;//250

            while ((linha < 900) & (registro != fim))
            {

                linha += 20;

                if (reg_grid.Cells["Nome"].Value.ToString() != anterior)
                {
                    e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, linha, 800, linha);

                    linha += 10;

                    e.Graphics.DrawString("Nome  ", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 120, linha);

                    e.Graphics.DrawString(reg_grid.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, 230, linha);

                    e.Graphics.DrawString("Matricula  ", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 420, linha);

                    e.Graphics.DrawString(reg_grid.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, 550, linha);

                    linha += 30;

                    e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, linha, 800, linha);

                    linha += 20;

                    e.Graphics.DrawString("Sigla   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Blue, 100, linha);
                    e.Graphics.DrawString("Descrição ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Blue, 200, linha);
                    e.Graphics.DrawString("Menção ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Blue, 530, linha);

                    linha += 40;

                }

                pag += 1;

                e.Graphics.DrawString(reg_grid.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 100, linha);

                e.Graphics.DrawString(reg_grid.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 200, linha);

                e.Graphics.DrawString(reg_grid.Cells["mencao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 530, linha);

                anterior = reg_grid.Cells["nome"].Value.ToString();

                bs_Bol.MoveNext(); // movendo para o próximo registro

                reg_grid = dgv_Relatorio.CurrentRow;  // atualizando a linha da grid para impressão

                registro += 1;   // incrementando a variável contadora de registros

                if (reg_grid.Cells["Nome"].Value.ToString() != anterior)
                {
                    linha = 1000;
                }

            }

            linha += 20;

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 1100, 800, 1100);
            e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Blue, 300, 1110);
            e.Graphics.DrawString(DateTime.Now.ToString("HH:mm:ss"), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Blue, 450, 1110);

            // trocando de página
            if ((pag > 1) & (registro < fim))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;

                pag = 1;
                registro = 0;
                bs_Bol.MoveFirst();
            }


          
            }
        }
    }
