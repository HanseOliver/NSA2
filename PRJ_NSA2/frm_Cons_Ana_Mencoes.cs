using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Prj_NSA2
{
    public partial class frm_Cons_Ana_Mencoes : Form
    {
        OleDbConnection conn = Conexao.obterConexao();

        OleDbDataReader dr_menc;
        BindingSource bs_menc = new BindingSource();

        OleDbDataReader dr_reg_notas;
        BindingSource bs_reg_notas = new BindingSource();

        String _query;

        int controle = 0;

        public frm_Cons_Ana_Mencoes()
        {
            InitializeComponent();
        }

        private void cmb_MencAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controle == 1)
            {
                _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina where Registro_Mencoes.mencao like '" + cmb_MencAn.Text + "'";/*
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

        private void frm_Cons_Ana_Mencoes_Load(object sender, EventArgs e)
        {
            carregar_menc();
            carregar_grid();
            controle = 1;
        }

        private void carregar_menc()
        {
            _query = "Select * from Mencao order by Mencao";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_menc = _dataCommand.ExecuteReader();

            if (dr_menc.HasRows == true)
            {

                bs_menc.DataSource = dr_menc;
                cmb_MencAn.DataSource = bs_menc;
                cmb_MencAn.DisplayMember = "Mencao";

            }
            else
            {

                MessageBox.Show("Não temos menções cadastradas !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
