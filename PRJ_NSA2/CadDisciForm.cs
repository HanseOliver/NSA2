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
    public partial class CadDisciForm : Form
    {
       


        public CadDisciForm()
        {
            InitializeComponent();
        }

        private void dgv_Grid_CadForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Pk_CaDiscForm_Click(object sender, EventArgs e)
        {

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
                dgv_Disc_CadDiscForm.DataSource = bs_disc;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos clientes cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void igualar_text()
        {
            //apresentando no grid
            lbl_Pk_CadDiscForm.DataBindings.Add("Text", bs_disc, "cod_disciplina");
            lbl_Pk_CadDiscForm.DataBindings.Clear();
            txt_disc_CadDiscForm.DataBindings.Add("Text", bs_disc, "descricao");
            txt_disc_CadDiscForm.DataBindings.Clear();
            txt_Sigla_CadDiscForm.DataBindings.Add("Text", bs_disc, "sigla");
            txt_Sigla_CadDiscForm.DataBindings.Clear();
        }
        //tudo abaixo é para mostrar as informações no grid
        private void CadDiscForm_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void dgv_Disc_CadDiscForm_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        private void dgv_Disc_CadDiscForm_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        //para realizar a pesquisa
        private void txt_Pesquisa_CadDiscForm_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Disciplinas where descricao like '" + txt_Pesquisa_CadDiscForm.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_disc = _dataCommand.ExecuteReader();

            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
            }
            else
            {
                MessageBox.Show("Não temos disciplinas cadastradas com esse nome!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Pesquisa_CadDiscForm.Text = "";
            }

        }

        private void btn_Primeiro_CadDiscForm_Click(object sender, EventArgs e)
        {
            bs_disc.MoveFirst();
            igualar_text();

        }

        private void btn_Ultimo_CadDiscForm_Click(object sender, EventArgs e)
        {
            bs_disc.MoveLast();
            igualar_text();
        }

        private void btn_Proximo_CadDiscForm_Click(object sender, EventArgs e)
        {
            if (bs_disc.Count == bs_disc.Position + 1)
                MessageBox.Show("Fim de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_disc.MoveNext();
            igualar_text();

        }

        private void btn_Anterior_CadDiscForm_Click(object sender, EventArgs e)
        {
            if (bs_disc.Position == 0)
                MessageBox.Show("Começo de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_disc.MovePrevious();
            igualar_text();    

        }

        private void btn_Limpar_CadDiscForm_Click(object sender, EventArgs e)
        {
            limpar();
            //txt_disc_CadDiscForm.Focus();
            
        }

        private void limpar()
        {
            txt_disc_CadDiscForm.Clear();
            txt_Sigla_CadDiscForm.Clear();
            lbl_Pk_CadDiscForm.Text = "";
        }

        private void CadDisciForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (MessageBox.Show("Confirmação de Saida", "WARNING ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Conexao.fecharConexao();
            else
            {
                e.Cancel = true;
            } */                      

        }

        private void btn_Novo_CadDiscForm_Click(object sender, EventArgs e)
        {
            limpar();
            txt_disc_CadDiscForm.Focus();
        }

   
        private void btn_Incluir_CaDiscForm_Click(object sender, EventArgs e)
        {
            bool teste; // variável para receber o valor de "erro" após executar valida
            teste = valida(); // executando "valida" e armazenando o resultado na variável "erro"
            if (teste == false)
            {
                _query = "Insert into Disciplinas (descricao,sigla) Values ";
                _query += "('" + txt_disc_CadDiscForm.Text + "','" + txt_Sigla_CadDiscForm.Text+"')";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Incluido com sucesso !!!!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas com a Inclusão  !!!!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

       /**/ private bool valida()
        {
            bool erro = true;
            if (txt_disc_CadDiscForm.Text == "")
            {
                MessageBox.Show("Nome inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_disc_CadDiscForm.Focus();
            }

            else if (txt_Sigla_CadDiscForm.Text == "")
            {
                MessageBox.Show("Endereço inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Sigla_CadDiscForm.Focus();
            }
            
            else
            {
                erro = false;
            }
            return erro;
       /**/ }

       private void btn_Alterar_CaDiscForm_Click(object sender, EventArgs e)
       {
           bool teste; // variável para receber o valor de "erro" após executar valida
           teste = valida(); // executando "valida" e armazenando o resultado na variável "erro"
           if (teste == false)
           {
               _query = "Update Disciplinas set descricao ='" + txt_disc_CadDiscForm.Text + "',";
               _query += "sigla = '" + txt_Sigla_CadDiscForm.Text + "'";
               _query += "where cod_disciplina like '" + lbl_Pk_CadDiscForm.Text + "'";
               try
               {
                   OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                   _dataCommand.ExecuteNonQuery();
                   carregar_grid();
                   MessageBox.Show("Alterado com sucesso !!!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
               catch (Exception)
               {
                   MessageBox.Show("Problemas com a Alteração  !!!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
           }

       }

       private void btn_Deletar_CaDiscForm_Click(object sender, EventArgs e)
       {
           _query = "delete from Disciplinas where cod_disciplina like '" + lbl_Pk_CadDiscForm.Text + "'";
           try
           {
               OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
               _dataCommand.ExecuteNonQuery();
               carregar_grid();
               MessageBox.Show("Excluido com sucesso !!!!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
           catch (Exception)
           {
               MessageBox.Show("Problemas com a Exclusão  !!!!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }     

       }






    }
}