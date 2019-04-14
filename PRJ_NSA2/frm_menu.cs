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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Hora_Menu.Text = "Hora " + DateTime.Now.ToString("HH:mm:ss"); //atualiza o horario
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Data_Menu.Text = "Data " + DateTime.Now.ToString("dd/MM/yyyy");//relaciona a data com a label desejada
            lbl_Hora_Menu.Text = "Hora " + DateTime.Now.ToString("HH:mm:ss");//relaciona a hora com a label desejada
            lbl_Dev_Menu.Text = "Ighor Alves de Oliveira";//mostra o nome do desenvolvedor
        }

        private void desenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)//chama o formlario do desenvolvedor
        {
            Dev c = new Dev();
            c.MdiParent = this;
            c.Show();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e) //chama o formulario de cadastro de disciplina
        {
            CadDisciForm cad = new CadDisciForm();
            cad.MdiParent = this;
            cad.Show();

        }

        private void tsb_Sair_Menu_Click(object sender, EventArgs e)//fecha o formulario
        {
            this.Close();
        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)//mensagem de confirmação
        {
            if (MessageBox.Show("Deseja Sair??", "Título ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }

        }

        private void tsb_CadDisc_Menu_Click(object sender, EventArgs e)
        {
            CadDisciForm cadDisci = new CadDisciForm();
            cadDisci.MdiParent = this;
            cadDisci.Show();
        }

        private void aliunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadAlunosForm CadAl = new CadAlunosForm();
            CadAl.MdiParent = this;
            CadAl.Show();
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cons_Cad_Disc ConsDisc = new frm_Cons_Cad_Disc();
            ConsDisc.MdiParent = this;
            ConsDisc.Show();
        }

        private void alunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Cons_Cad_Al ConsAl = new frm_Cons_Cad_Al();
            ConsAl.MdiParent = this;
            ConsAl.Show();
        }

        private void lançarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LancarNotas lancarNotas = new LancarNotas();
            lancarNotas.MdiParent = this;
            lancarNotas.Show();
        }

        private void disciplinaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Cons_Ana_Disciplina consAnDisc = new frm_Cons_Ana_Disciplina();
            consAnDisc.MdiParent = this;
            consAnDisc.Show();
        }

        private void alunosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Cons_Ana_Alunos consAnAlu = new frm_Cons_Ana_Alunos();
            consAnAlu.MdiParent = this;
            consAnAlu.Show();

        }

        private void mençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cons_Ana_Mencoes consAnMenc = new frm_Cons_Ana_Mencoes();
            consAnMenc.MdiParent = this;
            consAnMenc.Show();
        }

        private void alunosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_rel_cad_disc relCad = new frm_rel_cad_disc();
            relCad.MdiParent = this;
            relCad.Show();
        }

        private void alunosToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_rel_cad_aluno relAl = new frm_rel_cad_aluno();
            relAl.MdiParent = this;
            relAl.Show();
        }

        private void mençãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_rel_an_menc relMenc = new frm_rel_an_menc();
            relMenc.MdiParent = this;
            relMenc.Show();
        }

        private void disciplinaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_rel_ana_disc relDisc = new frm_rel_ana_disc();
            relDisc.MdiParent = this;
            relDisc.Show();
        }

        private void boletimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rel_ana_Boletim relBol = new frm_rel_ana_Boletim();
            relBol.MdiParent = this;
            relBol.Show();
        }

        private void tsb_CadAl_Menu_Click(object sender, EventArgs e)
        {
            frm_rel_ana_Boletim relBol = new frm_rel_ana_Boletim();
            relBol.MdiParent = this;
            relBol.Show();
        }
    }
}
