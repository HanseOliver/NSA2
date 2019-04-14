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
    public partial class CadAlunosForm : Form
    {
        public CadAlunosForm()
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
                dgv_Al_CadAlForm.DataSource = bs_al;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos Al cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void igualar_text()
        {
            //apresentando no grid
            lbl_Pk_CadAlForm.DataBindings.Add("Text", bs_al, "Matricula");
            lbl_Pk_CadAlForm.DataBindings.Clear();
            txt_nome_CadAlForm.DataBindings.Add("Text", bs_al, "Nome");
            txt_nome_CadAlForm.DataBindings.Clear();
            dtp_Nasc_CadAlForm.DataBindings.Add("Text", bs_al, "Nasc");
            dtp_Nasc_CadAlForm.DataBindings.Clear();
            txt_Endereco_CadAlForm.DataBindings.Add("Text", bs_al, "Endereco");
            txt_Endereco_CadAlForm.DataBindings.Clear();
            txt_Numero_CadAlForm.DataBindings.Add("Text", bs_al, "numero");
            txt_Numero_CadAlForm.DataBindings.Clear();
            txt_Bairro_CadAlForm.DataBindings.Add("Text", bs_al, "bairro");
            txt_Bairro_CadAlForm.DataBindings.Clear();
            txt_Cidade_CadAlForm.DataBindings.Add("Text", bs_al, "cidade");
            txt_Cidade_CadAlForm.DataBindings.Clear();
            mtx_CEP_CadAlunosForm.DataBindings.Add("Text", bs_al, "cep");
            mtx_CEP_CadAlunosForm.DataBindings.Clear();
            mtx_Rg_CadAlunosForm.DataBindings.Add("Text", bs_al, "rg");
            mtx_Rg_CadAlunosForm.DataBindings.Clear();
            txt_tel_CadAlForm.DataBindings.Add("Text", bs_al, "telefone");
            txt_tel_CadAlForm.DataBindings.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CadAlForm_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Alunos where nome like '" + txt_Pesquisa_CadAlForm.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_al = _dataCommand.ExecuteReader();

            if (dr_al.HasRows == true)
            {
                bs_al.DataSource = dr_al;
            }
            else
            {
                MessageBox.Show("Não temos alunos cadastradas com esse nome!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Pesquisa_CadAlForm.Text = "";
            }
        }

        private void dgv_Al_CadAlForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CadAlunosForm_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void dgv_Al_CadAlForm_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        private void dgv_Al_CadAlForm_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bs_al.MoveFirst();
            igualar_text();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bs_al.MoveLast();
            igualar_text();
        }

        private void btn_Proximo_CadAlForm_Click(object sender, EventArgs e)
        {
            if (bs_al.Count == bs_al.Position + 1)
                MessageBox.Show("Fim de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_al.MoveNext();
            igualar_text();
        }

        private void btn_Anterior_CadAlForm_Click(object sender, EventArgs e)
        {
            if (bs_al.Position == 0)
                MessageBox.Show("Começo de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_al.MovePrevious();
            igualar_text();
        }

        private void btn_Limpar_CadDiscForm_Click(object sender, EventArgs e)
        {
            limpar();
            //txt_disc_CadDiscForm.Focus();
        }

        private void limpar()
        {
            lbl_Pk_CadAlForm.Text = "";
            mtx_Rg_CadAlunosForm.Clear();
            mtx_CEP_CadAlunosForm.Clear();
            txt_Bairro_CadAlForm.Clear();
            txt_Cidade_CadAlForm.Clear();
            txt_Endereco_CadAlForm.Clear();
            txt_nome_CadAlForm.Clear();
            txt_Numero_CadAlForm.Clear();

            txt_tel_CadAlForm.Clear();
            dtp_Nasc_CadAlForm.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void CadAlunosForm_FormClosing(object sender, FormClosingEventArgs e)
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
            txt_nome_CadAlForm.Focus();
        }
        private bool valida()
        {
            bool erro = true;
            if (mtx_Rg_CadAlunosForm.MaskFull == false)
            {
                MessageBox.Show("RG inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtx_Rg_CadAlunosForm.Focus();
            }

            else if (dtp_Nasc_CadAlForm.Text == ""){
                MessageBox.Show("Data inválida. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtp_Nasc_CadAlForm.Focus();
            }

            else if (txt_nome_CadAlForm.Text == "")
            {
                MessageBox.Show("Nome inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nome_CadAlForm.Focus();
            }

            else if (txt_tel_CadAlForm.Text == "")
            {
                MessageBox.Show("Numero inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_tel_CadAlForm.Focus();
            }

            else if (txt_Endereco_CadAlForm.Text == "")
            {
                MessageBox.Show("Endereço inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Endereco_CadAlForm.Focus();
            }

            else if (txt_Numero_CadAlForm.Text == "")
            {
                MessageBox.Show("Numero da residencia inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Numero_CadAlForm.Focus();
            }

            else if (mtx_CEP_CadAlunosForm.MaskFull == false)
            {
                MessageBox.Show("CEP inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtx_CEP_CadAlunosForm.Focus();
            }

            else if (txt_Cidade_CadAlForm.Text == "")
            {
                MessageBox.Show("Cidade inválida. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Cidade_CadAlForm.Focus();
            }

            else if (txt_Bairro_CadAlForm.Text == "")
            {
                MessageBox.Show("Bairro inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Bairro_CadAlForm.Focus();
            }
            else
            {
                erro = false;
            }
            return erro;
            /**/
        }


        private void btn_Incluir_CaDiscForm_Click(object sender, EventArgs e)
        {
            bool teste; // variável para receber o valor de "erro" após executar valida
            teste = valida(); // executando "valida" e armazenando o resultado na variável "erro"
            if (teste == false)
            {
                _query = "Insert into Alunos (Nome,Nasc,Endereco,numero,bairro,cidade,cep,RG,telefone) Values ";
                _query += "('" + txt_nome_CadAlForm.Text + "','" + dtp_Nasc_CadAlForm.Text + "','" + txt_Endereco_CadAlForm.Text + "','" + txt_Numero_CadAlForm.Text + "','" + txt_Bairro_CadAlForm.Text + "','" + txt_Cidade_CadAlForm.Text + "','" + mtx_CEP_CadAlunosForm.Text + "','" + mtx_Rg_CadAlunosForm.Text + "','" + txt_tel_CadAlForm.Text + "')";
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

        private void btn_Alterar_CaDiscForm_Click(object sender, EventArgs e)
        {
            bool teste; // variável para receber o valor de "erro" após executar valida
            teste = valida(); // executando "valida" e armazenando o resultado na variável "erro"
            if (teste == false)
            {
                _query = "Update Alunos set Nome ='" + txt_nome_CadAlForm.Text + "',";
                _query += "Nasc = '" + dtp_Nasc_CadAlForm.Text + "',";
                _query += "Endereco = '" + txt_Endereco_CadAlForm.Text + "',";
                _query += "numero = '" + txt_Numero_CadAlForm.Text + "',";
                _query += "bairro = '" + txt_Bairro_CadAlForm.Text + "',";
                _query += "cidade = '" + txt_Cidade_CadAlForm.Text + "',";
                _query += "cep = '" + mtx_CEP_CadAlunosForm.Text + "',";
                _query += "RG = '" + mtx_Rg_CadAlunosForm.Text + "',";
                _query += "telefone = '" + txt_tel_CadAlForm.Text + "'";

                _query += "where Matricula like '" + lbl_Pk_CadAlForm.Text + "'";
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
            _query = "delete from Alunos where Matricula like '" + lbl_Pk_CadAlForm.Text + "'";
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

        private void lbl_Pk_CadAlForm_Click(object sender, EventArgs e)
        {

        }

        private void txt_tel_CadAlForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtx_Rg_CadAlunosForm_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
