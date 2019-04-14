namespace Prj_NSA2
{
    partial class frm_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Data_Menu = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Hora_Menu = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Dev_Menu = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.analiticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.analiticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mençãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.boletimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_CadDisc_Menu = new System.Windows.Forms.ToolStripButton();
            this.tsb_CadAl_Menu = new System.Windows.Forms.ToolStripButton();
            this.tsb_Sair_Menu = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Data_Menu,
            this.lbl_Hora_Menu,
            this.lbl_Dev_Menu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1186, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Data_Menu
            // 
            this.lbl_Data_Menu.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Data_Menu.Name = "lbl_Data_Menu";
            this.lbl_Data_Menu.Size = new System.Drawing.Size(31, 17);
            this.lbl_Data_Menu.Text = "Data";
            // 
            // lbl_Hora_Menu
            // 
            this.lbl_Hora_Menu.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Hora_Menu.Name = "lbl_Hora_Menu";
            this.lbl_Hora_Menu.Size = new System.Drawing.Size(33, 17);
            this.lbl_Hora_Menu.Text = "Hora";
            // 
            // lbl_Dev_Menu
            // 
            this.lbl_Dev_Menu.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Dev_Menu.Name = "lbl_Dev_Menu";
            this.lbl_Dev_Menu.Size = new System.Drawing.Size(85, 17);
            this.lbl_Dev_Menu.Text = "Desenvolvedor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.lançarNotasToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.disciplinasToolStripMenuItem});
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.aliunosToolStripMenuItem_Click);
            // 
            // disciplinasToolStripMenuItem
            // 
            this.disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            this.disciplinasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.disciplinasToolStripMenuItem.Text = "Disciplinas";
            this.disciplinasToolStripMenuItem.Click += new System.EventHandler(this.disciplinasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastralToolStripMenuItem,
            this.analiticaToolStripMenuItem});
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // cadastralToolStripMenuItem
            // 
            this.cadastralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinaToolStripMenuItem,
            this.alunosToolStripMenuItem1});
            this.cadastralToolStripMenuItem.Name = "cadastralToolStripMenuItem";
            this.cadastralToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.cadastralToolStripMenuItem.Text = "Cadastral";
            // 
            // disciplinaToolStripMenuItem
            // 
            this.disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            this.disciplinaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.disciplinaToolStripMenuItem.Text = "Disciplina";
            this.disciplinaToolStripMenuItem.Click += new System.EventHandler(this.disciplinaToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem1
            // 
            this.alunosToolStripMenuItem1.Name = "alunosToolStripMenuItem1";
            this.alunosToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.alunosToolStripMenuItem1.Text = "Alunos";
            this.alunosToolStripMenuItem1.Click += new System.EventHandler(this.alunosToolStripMenuItem1_Click);
            // 
            // analiticaToolStripMenuItem
            // 
            this.analiticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinaToolStripMenuItem1,
            this.alunosToolStripMenuItem2,
            this.mençãoToolStripMenuItem});
            this.analiticaToolStripMenuItem.Name = "analiticaToolStripMenuItem";
            this.analiticaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.analiticaToolStripMenuItem.Text = "Analitica";
            // 
            // disciplinaToolStripMenuItem1
            // 
            this.disciplinaToolStripMenuItem1.Name = "disciplinaToolStripMenuItem1";
            this.disciplinaToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.disciplinaToolStripMenuItem1.Text = "Disciplina";
            this.disciplinaToolStripMenuItem1.Click += new System.EventHandler(this.disciplinaToolStripMenuItem1_Click);
            // 
            // alunosToolStripMenuItem2
            // 
            this.alunosToolStripMenuItem2.Name = "alunosToolStripMenuItem2";
            this.alunosToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.alunosToolStripMenuItem2.Text = "Alunos";
            this.alunosToolStripMenuItem2.Click += new System.EventHandler(this.alunosToolStripMenuItem2_Click);
            // 
            // mençãoToolStripMenuItem
            // 
            this.mençãoToolStripMenuItem.Name = "mençãoToolStripMenuItem";
            this.mençãoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.mençãoToolStripMenuItem.Text = "Menção";
            this.mençãoToolStripMenuItem.Click += new System.EventHandler(this.mençãoToolStripMenuItem_Click);
            // 
            // lançarNotasToolStripMenuItem
            // 
            this.lançarNotasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lançarNotasToolStripMenuItem.Name = "lançarNotasToolStripMenuItem";
            this.lançarNotasToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.lançarNotasToolStripMenuItem.Text = "Lançar Notas";
            this.lançarNotasToolStripMenuItem.Click += new System.EventHandler(this.lançarNotasToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastraisToolStripMenuItem,
            this.analiticoToolStripMenuItem});
            this.relatoriosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // cadastraisToolStripMenuItem
            // 
            this.cadastraisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem3,
            this.alunosToolStripMenuItem4});
            this.cadastraisToolStripMenuItem.Name = "cadastraisToolStripMenuItem";
            this.cadastraisToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.cadastraisToolStripMenuItem.Text = "Cadastrais";
            // 
            // alunosToolStripMenuItem3
            // 
            this.alunosToolStripMenuItem3.Name = "alunosToolStripMenuItem3";
            this.alunosToolStripMenuItem3.Size = new System.Drawing.Size(130, 22);
            this.alunosToolStripMenuItem3.Text = "Disciplinas";
            this.alunosToolStripMenuItem3.Click += new System.EventHandler(this.alunosToolStripMenuItem3_Click);
            // 
            // alunosToolStripMenuItem4
            // 
            this.alunosToolStripMenuItem4.Name = "alunosToolStripMenuItem4";
            this.alunosToolStripMenuItem4.Size = new System.Drawing.Size(130, 22);
            this.alunosToolStripMenuItem4.Text = "Alunos";
            this.alunosToolStripMenuItem4.Click += new System.EventHandler(this.alunosToolStripMenuItem4_Click);
            // 
            // analiticoToolStripMenuItem
            // 
            this.analiticoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mençãoToolStripMenuItem1,
            this.disciplinaToolStripMenuItem2,
            this.boletimToolStripMenuItem});
            this.analiticoToolStripMenuItem.Name = "analiticoToolStripMenuItem";
            this.analiticoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.analiticoToolStripMenuItem.Text = "Analitico";
            // 
            // mençãoToolStripMenuItem1
            // 
            this.mençãoToolStripMenuItem1.Name = "mençãoToolStripMenuItem1";
            this.mençãoToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.mençãoToolStripMenuItem1.Text = "Menção";
            this.mençãoToolStripMenuItem1.Click += new System.EventHandler(this.mençãoToolStripMenuItem1_Click);
            // 
            // disciplinaToolStripMenuItem2
            // 
            this.disciplinaToolStripMenuItem2.Name = "disciplinaToolStripMenuItem2";
            this.disciplinaToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.disciplinaToolStripMenuItem2.Text = "Disciplina";
            this.disciplinaToolStripMenuItem2.Click += new System.EventHandler(this.disciplinaToolStripMenuItem2_Click);
            // 
            // boletimToolStripMenuItem
            // 
            this.boletimToolStripMenuItem.Name = "boletimToolStripMenuItem";
            this.boletimToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.boletimToolStripMenuItem.Text = "Boletim";
            this.boletimToolStripMenuItem.Click += new System.EventHandler(this.boletimToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desenvolvedorToolStripMenuItem});
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // desenvolvedorToolStripMenuItem
            // 
            this.desenvolvedorToolStripMenuItem.Name = "desenvolvedorToolStripMenuItem";
            this.desenvolvedorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.desenvolvedorToolStripMenuItem.Text = "Desenvolvedor";
            this.desenvolvedorToolStripMenuItem.Click += new System.EventHandler(this.desenvolvedorToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_CadDisc_Menu,
            this.tsb_CadAl_Menu,
            this.tsb_Sair_Menu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1186, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_CadDisc_Menu
            // 
            this.tsb_CadDisc_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_CadDisc_Menu.Image = ((System.Drawing.Image)(resources.GetObject("tsb_CadDisc_Menu.Image")));
            this.tsb_CadDisc_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_CadDisc_Menu.Name = "tsb_CadDisc_Menu";
            this.tsb_CadDisc_Menu.Size = new System.Drawing.Size(23, 22);
            this.tsb_CadDisc_Menu.Text = "Cadastro de Disciplina";
            this.tsb_CadDisc_Menu.ToolTipText = "Cadastro de Disciplinas";
            this.tsb_CadDisc_Menu.Click += new System.EventHandler(this.tsb_CadDisc_Menu_Click);
            // 
            // tsb_CadAl_Menu
            // 
            this.tsb_CadAl_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_CadAl_Menu.Image = ((System.Drawing.Image)(resources.GetObject("tsb_CadAl_Menu.Image")));
            this.tsb_CadAl_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_CadAl_Menu.Name = "tsb_CadAl_Menu";
            this.tsb_CadAl_Menu.Size = new System.Drawing.Size(23, 22);
            this.tsb_CadAl_Menu.Text = "toolStripButton2";
            this.tsb_CadAl_Menu.ToolTipText = "Cadastro de Alunos";
            this.tsb_CadAl_Menu.Click += new System.EventHandler(this.tsb_CadAl_Menu_Click);
            // 
            // tsb_Sair_Menu
            // 
            this.tsb_Sair_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Sair_Menu.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Sair_Menu.Image")));
            this.tsb_Sair_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Sair_Menu.Name = "tsb_Sair_Menu";
            this.tsb_Sair_Menu.Size = new System.Drawing.Size(23, 22);
            this.tsb_Sair_Menu.Text = "toolStripButton3";
            this.tsb_Sair_Menu.ToolTipText = "Sair";
            this.tsb_Sair_Menu.Click += new System.EventHandler(this.tsb_Sair_Menu_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1186, 634);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NSA2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_menu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_CadDisc_Menu;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Data_Menu;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Hora_Menu;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Dev_Menu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsb_CadAl_Menu;
        private System.Windows.Forms.ToolStripButton tsb_Sair_Menu;
        private System.Windows.Forms.ToolStripMenuItem cadastralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem analiticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem analiticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mençãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem boletimToolStripMenuItem;
    }
}

