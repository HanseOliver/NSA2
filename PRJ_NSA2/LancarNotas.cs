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
    public partial class LancarNotas : Form
    {
        OleDbConnection conn = Conexao.obterConexao();

        OleDbDataReader dr_alu;
        BindingSource bs_alu = new BindingSource();

        OleDbDataReader dr_disc;
        BindingSource bs_disc = new BindingSource();

        OleDbDataReader dr_menc;
        BindingSource bs_menc = new BindingSource();

        OleDbDataReader dr_reg_notas;
        BindingSource bs_reg_notas = new BindingSource();

        String _query;

        public LancarNotas()
        {
            InitializeComponent();
        }

        private void LancarNotas_Load(object sender, EventArgs e)
        {
            carregar_grid();
            carregar_menc();
            carregar_disc();
            carregar_aluno();
        }

        private void carregar_aluno()
        {
            _query = "Select * from Alunos order by Nome";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_alu = _dataCommand.ExecuteReader();

            if (dr_alu.HasRows == true)
            {

                bs_alu.DataSource = dr_alu;
                cmb_alunos.DataSource = bs_alu;
                cmb_alunos.DisplayMember = "Nome";
                cmb_alunos.ValueMember = "Matricula";
                lbl_alunoMatricula.Text = cmb_alunos.SelectedValue.ToString();

            }
            else
            {

                MessageBox.Show("Não temos alunos cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void carregar_disc()
        {
            _query = "Select * from Disciplinas order by cod_disciplina";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_disc = _dataCommand.ExecuteReader();

            if (dr_disc.HasRows == true)
            {

                bs_disc.DataSource = dr_disc;
                cmb_disc.DataSource = bs_disc;
                cmb_disc.DisplayMember = "sigla";
                cmb_disc.ValueMember = "cod_disciplina";
                lbl_discCod.Text = cmb_disc.SelectedValue.ToString();

            }
            else
            {

                MessageBox.Show("Não temos disciplinas cadastradas !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void carregar_menc()
        {
            _query = "Select * from Mencao order by Mencao";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_menc = _dataCommand.ExecuteReader();

            if (dr_menc.HasRows == true)
            {

                bs_menc.DataSource = dr_menc;
                cmb_menc.DataSource = bs_menc;
                cmb_menc.DisplayMember = "Mencao";

            }
            else
            {

                MessageBox.Show("Não temos menções cadastradas !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void carregar_grid()
        {
            // Comando desejado
            _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina ORDER BY Alunos.Nome";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_reg_notas = _dataCommand.ExecuteReader();
            if (dr_reg_notas.HasRows == true)
            {
                bs_reg_notas.DataSource = dr_reg_notas;
                dgv_Show.DataSource = bs_reg_notas;
            }
            else
            {
                MessageBox.Show("Não temos dados cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {             _query = "Insert into Registro_Mencoes (matricula,cod_disciplina,mencao) Values ";
                    _query += "('" + lbl_alunoMatricula.Text + "','" + lbl_discCod.Text + "','" + cmb_menc.Text + "')";
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

        private void cmb_disc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_discCod.Text = cmb_disc.SelectedValue.ToString();
        }

        private void cmb_alunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        }
    }
