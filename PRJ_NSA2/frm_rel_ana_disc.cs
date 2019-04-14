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
    public partial class frm_rel_ana_disc : Form
    {
        OleDbConnection conn = Conexao.obterConexao();
        //Declarando o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_Disc; //pega uma copia pra leitura
        //Declarando o BindingSource -- tabela virtual editável
        BindingSource bs_Disc = new BindingSource();
        // criando a variavel que receberá a query (comando sql)
        String _query;

        string anterior = "Z";
        int contador_grupo = 0;

        public int pag = 1; // variável para controlar o salto de página
        int registro, linha = 0; //variável contadora de registros e linhas impressas, 
        int fim = 0;    //variável que controla o fim da impressão

        public frm_rel_ana_disc()
        {
            InitializeComponent();
        }

        private void frm_rel_ana_disc_Load(object sender, EventArgs e)
        {
            carregar_grid();
            fim = bs_Disc.Count;
        }

        private void carregar_grid()
        {
            // Comando desejado
            _query = "SELECT Registro_Mencoes.mencao, Alunos.Nome, Alunos.Matricula, Disciplinas.sigla, Disciplinas.descricao FROM Mencao, Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina order by Disciplinas.sigla;";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_Disc = _dataCommand.ExecuteReader();
            if (dr_Disc.HasRows == true)
            {
                bs_Disc.DataSource = dr_Disc;
                dgv_Relatorio.DataSource = bs_Disc;
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow reg_grid;
            reg_grid = dgv_Relatorio.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("p5_logo.PNG"), 50, 25); // colocar imagens na pasta debug
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("RELATÓRIO AGRUPADO POR DISCIPLINA", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 300, 25);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)

            //dps de fazer o cabeçalho da pag pula a linha
            linha = 100;




            while ((linha < 1000) & (registro != fim))
            {
                if (reg_grid.Cells["sigla"].Value.ToString() != anterior /*&& linha < 800*/)
                {
                    if (contador_grupo != 0 && linha > 1000)
                    {
                        e.HasMorePages = true;

                    }
                    else if (contador_grupo != 0 && linha < 800)
                    {

                        linha += 20;
                        e.Graphics.DrawString("Total de Alunos por Disciplina:: " + contador_grupo, new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 470, linha);
                        contador_grupo = 0;
                        linha += 25;
                        //}
                    }
                    else { 
                    
                    }




                    linha += 40; //140

                    //parte do cabeçalho
                    e.Graphics.DrawString("Sigla: " + reg_grid.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Arial", 15, FontStyle.Bold), Brushes.Black, 120, linha);
                    e.Graphics.DrawString("Disciplina: " + reg_grid.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Arial", 15, FontStyle.Bold), Brushes.Black, 300, linha);
                    linha -= 20;//130
                    e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, linha, 750, linha);
                    linha += 55;//175
                    e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, linha, 750, linha);

                    linha += 35;//210
                    //relatorio em si
                    e.Graphics.DrawString("Matricula ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 75, linha);
                    e.Graphics.DrawString("Nome  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 200, linha);
                    e.Graphics.DrawString("Mençao ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 400, linha);
                    //e.Graphics.DrawString("Descrição ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 450, linha);
                    linha += 50;//250
                    //}
                }

                anterior = reg_grid.Cells["sigla"].Value.ToString();

                e.Graphics.DrawString(reg_grid.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 75, linha);

                e.Graphics.DrawString(reg_grid.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 200, linha);

                e.Graphics.DrawString(reg_grid.Cells["mencao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 400, linha);


                bs_Disc.MoveNext(); // movendo para o próximo registro

                reg_grid = dgv_Relatorio.CurrentRow;  // atualizando a linha da grid para impressão

                contador_grupo += 1;

                registro += 1;   // incrementando a variável contadora de registros

                linha += 20; // incrementando a variável para pular linha


            }

            linha += 20;
            e.Graphics.DrawString("Total de Alunos por Disciplina:: " + contador_grupo, new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 470, linha);
            contador_grupo = 0;
            linha += 25;

            //Rodape
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 1), 50, 1100, 750, 1100);
            e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 350, 1110);
            e.Graphics.DrawString(DateTime.Now.ToString("HH:mm:ss"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 450, 1110);
            e.Graphics.DrawString("Pág: " + pag.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 50, 1110);

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
                bs_Disc.MoveFirst();

            }
        }
    }
}
