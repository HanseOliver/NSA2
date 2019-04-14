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
    public partial class frm_Cons_Ana_Disciplina : Form
    {
        OleDbConnection conn = Conexao.obterConexao();

        OleDbDataReader dr_disc;
        BindingSource bs_disc = new BindingSource();

        OleDbDataReader dr_reg_notas;
        BindingSource bs_reg_notas = new BindingSource();

        String _query;

        int controle = 0;

        public frm_Cons_Ana_Disciplina()
        {
            InitializeComponent();
        }

        private void frm_Cons_Ana_Disciplina_Load(object sender, EventArgs e)
        {
            carregar_disc();
            carregar_grid();
            controle = 1;
        }

        private void carregar_disc()
        {
            _query = "Select * from Disciplinas order by cod_disciplina";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_disc = _dataCommand.ExecuteReader();

            if (dr_disc.HasRows == true)
            {

                bs_disc.DataSource = dr_disc;
                cmb_discAn.DataSource = bs_disc;
                cmb_discAn.DisplayMember = "sigla";
                cmb_discAn.ValueMember = "cod_disciplina";
                lbl_siglaValue.Text = cmb_discAn.SelectedValue.ToString();

            }
            else
            {

                MessageBox.Show("Não temos disciplinas cadastradas !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void lbl_siglaValue_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_discAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controle == 1)
            {
                lbl_siglaValue.Text = cmb_discAn.SelectedValue.ToString();

                _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina where Disciplinas.sigla like '" + cmb_discAn.Text + "'";/*
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