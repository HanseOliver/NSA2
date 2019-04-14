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
    public partial class frm_Cons_Ana_Alunos : Form
    {
        OleDbConnection conn = Conexao.obterConexao();

        OleDbDataReader dr_alu;
        BindingSource bs_alu = new BindingSource();

        OleDbDataReader dr_reg_notas;
        BindingSource bs_reg_notas = new BindingSource();

        String _query;

        int controle = 0;


        public frm_Cons_Ana_Alunos()
        {
            InitializeComponent();
        }

        private void frm_Cons_Ana_Alunos_Load(object sender, EventArgs e)
        {
            carregar_aluno();
            carregar_grid();
            controle = 1;
        }

        private void carregar_aluno()
        {
            _query = "Select * from Alunos order by Nome";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_alu = _dataCommand.ExecuteReader();

            if (dr_alu.HasRows == true)
            {

                bs_alu.DataSource = dr_alu;
                cmb_alAn.DataSource = bs_alu;
                cmb_alAn.DisplayMember = "Nome";
                cmb_alAn.ValueMember = "Matricula";
                lbl_nomeValue.Text = cmb_alAn.SelectedValue.ToString();

            }
            else
            {

                MessageBox.Show("Não temos alunos cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void carregar_grid()
        {
            // Comando desejado
            _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina  ORDER BY Alunos.Nome ";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_reg_notas = _dataCommand.ExecuteReader();
            if (dr_reg_notas.HasRows == true)
            {
                bs_reg_notas.DataSource = dr_reg_notas;
                dgv_Dados.DataSource = bs_reg_notas;
            }
            else
            {
                MessageBox.Show("Não temos dados cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmb_alAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controle == 1)
            {
                lbl_nomeValue.Text = cmb_alAn.SelectedValue.ToString();

                _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina where Alunos.Nome like '" + cmb_alAn.Text + "'";/*
                _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina ORDER BY Alunos.Nome";*/

                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                dr_reg_notas = _dataCommand.ExecuteReader();
                if (dr_reg_notas.HasRows == true)
                {
                    bs_reg_notas.DataSource = dr_reg_notas;
                    dgv_Dados.DataSource = bs_reg_notas;
                }
                else
                {
                    MessageBox.Show("Não temos dados cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
