namespace Prj_NSA2
{
    partial class CadDisciForm
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
            this.dgv_Disc_CadDiscForm = new System.Windows.Forms.DataGridView();
            this.lbl_CodDisc_CadDiscForm_ = new System.Windows.Forms.Label();
            this.lbl_desc_CadDiscForn = new System.Windows.Forms.Label();
            this.lbl_sigla_CadDiscForm = new System.Windows.Forms.Label();
            this.txt_disc_CadDiscForm = new System.Windows.Forms.TextBox();
            this.txt_Sigla_CadDiscForm = new System.Windows.Forms.TextBox();
            this.lbl_Pk_CadDiscForm = new System.Windows.Forms.Label();
            this.lbl_Pesquisar_CadDiscForm = new System.Windows.Forms.Label();
            this.txt_Pesquisa_CadDiscForm = new System.Windows.Forms.TextBox();
            this.grp_CaixeDeNavegação_CadDiscForm = new System.Windows.Forms.GroupBox();
            this.btn_Anterior_CadDiscForm = new System.Windows.Forms.Button();
            this.btn_Proximo_CadDiscForm = new System.Windows.Forms.Button();
            this.btn_Ultimo_CadDiscForm = new System.Windows.Forms.Button();
            this.btn_Primeiro_CadDiscForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Novo_CadDiscForm = new System.Windows.Forms.Button();
            this.btn_Limpar_CadDiscForm = new System.Windows.Forms.Button();
            this.grb_CaixaDeInserção_CadDiscForm = new System.Windows.Forms.GroupBox();
            this.btn_Deletar_CaDiscForm = new System.Windows.Forms.Button();
            this.btn_Alterar_CaDiscForm = new System.Windows.Forms.Button();
            this.btn_Incluir_CaDiscForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Disc_CadDiscForm)).BeginInit();
            this.grp_CaixeDeNavegação_CadDiscForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grb_CaixaDeInserção_CadDiscForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Disc_CadDiscForm
            // 
            this.dgv_Disc_CadDiscForm.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Disc_CadDiscForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Disc_CadDiscForm.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Disc_CadDiscForm.Location = new System.Drawing.Point(35, 296);
            this.dgv_Disc_CadDiscForm.Name = "dgv_Disc_CadDiscForm";
            this.dgv_Disc_CadDiscForm.Size = new System.Drawing.Size(656, 158);
            this.dgv_Disc_CadDiscForm.TabIndex = 0;
            this.dgv_Disc_CadDiscForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Grid_CadForm_CellContentClick);
            this.dgv_Disc_CadDiscForm.Click += new System.EventHandler(this.dgv_Disc_CadDiscForm_Click);
            this.dgv_Disc_CadDiscForm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_Disc_CadDiscForm_KeyUp);
            // 
            // lbl_CodDisc_CadDiscForm_
            // 
            this.lbl_CodDisc_CadDiscForm_.AutoSize = true;
            this.lbl_CodDisc_CadDiscForm_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodDisc_CadDiscForm_.Location = new System.Drawing.Point(32, 27);
            this.lbl_CodDisc_CadDiscForm_.Name = "lbl_CodDisc_CadDiscForm_";
            this.lbl_CodDisc_CadDiscForm_.Size = new System.Drawing.Size(127, 13);
            this.lbl_CodDisc_CadDiscForm_.TabIndex = 3;
            this.lbl_CodDisc_CadDiscForm_.Text = "Codigo da Disciplina:";
            this.lbl_CodDisc_CadDiscForm_.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_desc_CadDiscForn
            // 
            this.lbl_desc_CadDiscForn.AutoSize = true;
            this.lbl_desc_CadDiscForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc_CadDiscForn.Location = new System.Drawing.Point(32, 56);
            this.lbl_desc_CadDiscForn.Name = "lbl_desc_CadDiscForn";
            this.lbl_desc_CadDiscForn.Size = new System.Drawing.Size(145, 13);
            this.lbl_desc_CadDiscForn.TabIndex = 4;
            this.lbl_desc_CadDiscForn.Text = "Descrição da Disciplina:";
            // 
            // lbl_sigla_CadDiscForm
            // 
            this.lbl_sigla_CadDiscForm.AutoSize = true;
            this.lbl_sigla_CadDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sigla_CadDiscForm.Location = new System.Drawing.Point(32, 85);
            this.lbl_sigla_CadDiscForm.Name = "lbl_sigla_CadDiscForm";
            this.lbl_sigla_CadDiscForm.Size = new System.Drawing.Size(116, 13);
            this.lbl_sigla_CadDiscForm.TabIndex = 5;
            this.lbl_sigla_CadDiscForm.Text = "Sigla da Disciplina:";
            // 
            // txt_disc_CadDiscForm
            // 
            this.txt_disc_CadDiscForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_disc_CadDiscForm.Location = new System.Drawing.Point(183, 53);
            this.txt_disc_CadDiscForm.Name = "txt_disc_CadDiscForm";
            this.txt_disc_CadDiscForm.Size = new System.Drawing.Size(180, 20);
            this.txt_disc_CadDiscForm.TabIndex = 6;
            // 
            // txt_Sigla_CadDiscForm
            // 
            this.txt_Sigla_CadDiscForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_Sigla_CadDiscForm.Location = new System.Drawing.Point(183, 82);
            this.txt_Sigla_CadDiscForm.Name = "txt_Sigla_CadDiscForm";
            this.txt_Sigla_CadDiscForm.Size = new System.Drawing.Size(65, 20);
            this.txt_Sigla_CadDiscForm.TabIndex = 7;
            // 
            // lbl_Pk_CadDiscForm
            // 
            this.lbl_Pk_CadDiscForm.AutoSize = true;
            this.lbl_Pk_CadDiscForm.Location = new System.Drawing.Point(180, 27);
            this.lbl_Pk_CadDiscForm.Name = "lbl_Pk_CadDiscForm";
            this.lbl_Pk_CadDiscForm.Size = new System.Drawing.Size(246, 13);
            this.lbl_Pk_CadDiscForm.TabIndex = 8;
            this.lbl_Pk_CadDiscForm.Text = "A Chave Primaria de Sua Tabela Ira Aparecer Aqui";
            this.lbl_Pk_CadDiscForm.Click += new System.EventHandler(this.lbl_Pk_CaDiscForm_Click);
            // 
            // lbl_Pesquisar_CadDiscForm
            // 
            this.lbl_Pesquisar_CadDiscForm.AutoSize = true;
            this.lbl_Pesquisar_CadDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pesquisar_CadDiscForm.Location = new System.Drawing.Point(32, 517);
            this.lbl_Pesquisar_CadDiscForm.Name = "lbl_Pesquisar_CadDiscForm";
            this.lbl_Pesquisar_CadDiscForm.Size = new System.Drawing.Size(149, 13);
            this.lbl_Pesquisar_CadDiscForm.TabIndex = 13;
            this.lbl_Pesquisar_CadDiscForm.Text = "Pesquisar por Descrição:";
            // 
            // txt_Pesquisa_CadDiscForm
            // 
            this.txt_Pesquisa_CadDiscForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_Pesquisa_CadDiscForm.Location = new System.Drawing.Point(224, 514);
            this.txt_Pesquisa_CadDiscForm.Name = "txt_Pesquisa_CadDiscForm";
            this.txt_Pesquisa_CadDiscForm.Size = new System.Drawing.Size(250, 20);
            this.txt_Pesquisa_CadDiscForm.TabIndex = 14;
            this.txt_Pesquisa_CadDiscForm.TextChanged += new System.EventHandler(this.txt_Pesquisa_CadDiscForm_TextChanged);
            // 
            // grp_CaixeDeNavegação_CadDiscForm
            // 
            this.grp_CaixeDeNavegação_CadDiscForm.Controls.Add(this.btn_Anterior_CadDiscForm);
            this.grp_CaixeDeNavegação_CadDiscForm.Controls.Add(this.btn_Proximo_CadDiscForm);
            this.grp_CaixeDeNavegação_CadDiscForm.Controls.Add(this.btn_Ultimo_CadDiscForm);
            this.grp_CaixeDeNavegação_CadDiscForm.Controls.Add(this.btn_Primeiro_CadDiscForm);
            this.grp_CaixeDeNavegação_CadDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_CaixeDeNavegação_CadDiscForm.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.grp_CaixeDeNavegação_CadDiscForm.Location = new System.Drawing.Point(35, 198);
            this.grp_CaixeDeNavegação_CadDiscForm.Name = "grp_CaixeDeNavegação_CadDiscForm";
            this.grp_CaixeDeNavegação_CadDiscForm.Size = new System.Drawing.Size(672, 64);
            this.grp_CaixeDeNavegação_CadDiscForm.TabIndex = 30;
            this.grp_CaixeDeNavegação_CadDiscForm.TabStop = false;
            this.grp_CaixeDeNavegação_CadDiscForm.Text = "Navegação";
            // 
            // btn_Anterior_CadDiscForm
            // 
            this.btn_Anterior_CadDiscForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Anterior_CadDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anterior_CadDiscForm.Location = new System.Drawing.Point(523, 28);
            this.btn_Anterior_CadDiscForm.Name = "btn_Anterior_CadDiscForm";
            this.btn_Anterior_CadDiscForm.Size = new System.Drawing.Size(75, 23);
            this.btn_Anterior_CadDiscForm.TabIndex = 3;
            this.btn_Anterior_CadDiscForm.Text = "Anterior";
            this.btn_Anterior_CadDiscForm.UseVisualStyleBackColor = false;
            this.btn_Anterior_CadDiscForm.Click += new System.EventHandler(this.btn_Anterior_CadDiscForm_Click);
            // 
            // btn_Proximo_CadDiscForm
            // 
            this.btn_Proximo_CadDiscForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Proximo_CadDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proximo_CadDiscForm.Location = new System.Drawing.Point(364, 28);
            this.btn_Proximo_CadDiscForm.Name = "btn_Proximo_CadDiscForm";
            this.btn_Proximo_CadDiscForm.Size = new System.Drawing.Size(75, 23);
            this.btn_Proximo_CadDiscForm.TabIndex = 2;
            this.btn_Proximo_CadDiscForm.Text = "Proximo";
            this.btn_Proximo_CadDiscForm.UseVisualStyleBackColor = false;
            this.btn_Proximo_CadDiscForm.Click += new System.EventHandler(this.btn_Proximo_CadDiscForm_Click);
            // 
            // btn_Ultimo_CadDiscForm
            // 
            this.btn_Ultimo_CadDiscForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Ultimo_CadDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ultimo_CadDiscForm.Location = new System.Drawing.Point(206, 28);
            this.btn_Ultimo_CadDiscForm.Name = "btn_Ultimo_CadDiscForm";
            this.btn_Ultimo_CadDiscForm.Size = new System.Drawing.Size(75, 23);
            this.btn_Ultimo_CadDiscForm.TabIndex = 1;
            this.btn_Ultimo_CadDiscForm.Text = "Ultimo";
            this.btn_Ultimo_CadDiscForm.UseVisualStyleBackColor = false;
            this.btn_Ultimo_CadDiscForm.Click += new System.EventHandler(this.btn_Ultimo_CadDiscForm_Click);
            // 
            // btn_Primeiro_CadDiscForm
            // 
            this.btn_Primeiro_CadDiscForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Primeiro_CadDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Primeiro_CadDiscForm.Location = new System.Drawing.Point(57, 28);
            this.btn_Primeiro_CadDiscForm.Name = "btn_Primeiro_CadDiscForm";
            this.btn_Primeiro_CadDiscForm.Size = new System.Drawing.Size(75, 23);
            this.btn_Primeiro_CadDiscForm.TabIndex = 0;
            this.btn_Primeiro_CadDiscForm.Text = "Primeiro";
            this.btn_Primeiro_CadDiscForm.UseVisualStyleBackColor = false;
            this.btn_Primeiro_CadDiscForm.Click += new System.EventHandler(this.btn_Primeiro_CadDiscForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Novo_CadDiscForm);
            this.groupBox1.Controls.Add(this.btn_Limpar_CadDiscForm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 460);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 48);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formatação";
            // 
            // btn_Novo_CadDiscForm
            // 
            this.btn_Novo_CadDiscForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Novo_CadDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo_CadDiscForm.Location = new System.Drawing.Point(364, 19);
            this.btn_Novo_CadDiscForm.Name = "btn_Novo_CadDiscForm";
            this.btn_Novo_CadDiscForm.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo_CadDiscForm.TabIndex = 1;
            this.btn_Novo_CadDiscForm.Text = "Novo";
            this.btn_Novo_CadDiscForm.UseVisualStyleBackColor = false;
            this.btn_Novo_CadDiscForm.Click += new System.EventHandler(this.btn_Novo_CadDiscForm_Click);
            // 
            // btn_Limpar_CadDiscForm
            // 
            this.btn_Limpar_CadDiscForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Limpar_CadDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar_CadDiscForm.Location = new System.Drawing.Point(206, 19);
            this.btn_Limpar_CadDiscForm.Name = "btn_Limpar_CadDiscForm";
            this.btn_Limpar_CadDiscForm.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar_CadDiscForm.TabIndex = 0;
            this.btn_Limpar_CadDiscForm.Text = "Limpar";
            this.btn_Limpar_CadDiscForm.UseVisualStyleBackColor = false;
            this.btn_Limpar_CadDiscForm.Click += new System.EventHandler(this.btn_Limpar_CadDiscForm_Click);
            // 
            // grb_CaixaDeInserção_CadDiscForm
            // 
            this.grb_CaixaDeInserção_CadDiscForm.Controls.Add(this.btn_Deletar_CaDiscForm);
            this.grb_CaixaDeInserção_CadDiscForm.Controls.Add(this.btn_Alterar_CaDiscForm);
            this.grb_CaixaDeInserção_CadDiscForm.Controls.Add(this.btn_Incluir_CaDiscForm);
            this.grb_CaixaDeInserção_CadDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_CaixaDeInserção_CadDiscForm.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.grb_CaixaDeInserção_CadDiscForm.Location = new System.Drawing.Point(35, 117);
            this.grb_CaixaDeInserção_CadDiscForm.Name = "grb_CaixaDeInserção_CadDiscForm";
            this.grb_CaixaDeInserção_CadDiscForm.Size = new System.Drawing.Size(672, 64);
            this.grb_CaixaDeInserção_CadDiscForm.TabIndex = 31;
            this.grb_CaixaDeInserção_CadDiscForm.TabStop = false;
            this.grb_CaixaDeInserção_CadDiscForm.Text = "Inserção de Dados";
            // 
            // btn_Deletar_CaDiscForm
            // 
            this.btn_Deletar_CaDiscForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Deletar_CaDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar_CaDiscForm.Location = new System.Drawing.Point(441, 28);
            this.btn_Deletar_CaDiscForm.Name = "btn_Deletar_CaDiscForm";
            this.btn_Deletar_CaDiscForm.Size = new System.Drawing.Size(75, 23);
            this.btn_Deletar_CaDiscForm.TabIndex = 2;
            this.btn_Deletar_CaDiscForm.Text = "Deletar";
            this.btn_Deletar_CaDiscForm.UseVisualStyleBackColor = false;
            this.btn_Deletar_CaDiscForm.Click += new System.EventHandler(this.btn_Deletar_CaDiscForm_Click);
            // 
            // btn_Alterar_CaDiscForm
            // 
            this.btn_Alterar_CaDiscForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Alterar_CaDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar_CaDiscForm.Location = new System.Drawing.Point(279, 28);
            this.btn_Alterar_CaDiscForm.Name = "btn_Alterar_CaDiscForm";
            this.btn_Alterar_CaDiscForm.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar_CaDiscForm.TabIndex = 1;
            this.btn_Alterar_CaDiscForm.Text = "Alterar";
            this.btn_Alterar_CaDiscForm.UseVisualStyleBackColor = false;
            this.btn_Alterar_CaDiscForm.Click += new System.EventHandler(this.btn_Alterar_CaDiscForm_Click);
            // 
            // btn_Incluir_CaDiscForm
            // 
            this.btn_Incluir_CaDiscForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Incluir_CaDiscForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Incluir_CaDiscForm.Location = new System.Drawing.Point(138, 28);
            this.btn_Incluir_CaDiscForm.Name = "btn_Incluir_CaDiscForm";
            this.btn_Incluir_CaDiscForm.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir_CaDiscForm.TabIndex = 0;
            this.btn_Incluir_CaDiscForm.Text = "Inserir";
            this.btn_Incluir_CaDiscForm.UseVisualStyleBackColor = false;
            this.btn_Incluir_CaDiscForm.Click += new System.EventHandler(this.btn_Incluir_CaDiscForm_Click);
            // 
            // CadDisciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(732, 571);
            this.Controls.Add(this.grb_CaixaDeInserção_CadDiscForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_CaixeDeNavegação_CadDiscForm);
            this.Controls.Add(this.txt_Pesquisa_CadDiscForm);
            this.Controls.Add(this.lbl_Pesquisar_CadDiscForm);
            this.Controls.Add(this.lbl_Pk_CadDiscForm);
            this.Controls.Add(this.txt_Sigla_CadDiscForm);
            this.Controls.Add(this.txt_disc_CadDiscForm);
            this.Controls.Add(this.lbl_sigla_CadDiscForm);
            this.Controls.Add(this.lbl_desc_CadDiscForn);
            this.Controls.Add(this.lbl_CodDisc_CadDiscForm_);
            this.Controls.Add(this.dgv_Disc_CadDiscForm);
            this.Name = "CadDisciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Disciplinas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadDisciForm_FormClosing);
            this.Load += new System.EventHandler(this.CadDiscForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Disc_CadDiscForm)).EndInit();
            this.grp_CaixeDeNavegação_CadDiscForm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grb_CaixaDeInserção_CadDiscForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Disc_CadDiscForm;
        private System.Windows.Forms.Label lbl_CodDisc_CadDiscForm_;
        private System.Windows.Forms.Label lbl_desc_CadDiscForn;
        private System.Windows.Forms.Label lbl_sigla_CadDiscForm;
        private System.Windows.Forms.TextBox txt_disc_CadDiscForm;
        private System.Windows.Forms.TextBox txt_Sigla_CadDiscForm;
        private System.Windows.Forms.Label lbl_Pk_CadDiscForm;
        private System.Windows.Forms.Label lbl_Pesquisar_CadDiscForm;
        private System.Windows.Forms.TextBox txt_Pesquisa_CadDiscForm;
        private System.Windows.Forms.GroupBox grp_CaixeDeNavegação_CadDiscForm;
        private System.Windows.Forms.Button btn_Anterior_CadDiscForm;
        private System.Windows.Forms.Button btn_Proximo_CadDiscForm;
        private System.Windows.Forms.Button btn_Ultimo_CadDiscForm;
        private System.Windows.Forms.Button btn_Primeiro_CadDiscForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Novo_CadDiscForm;
        private System.Windows.Forms.Button btn_Limpar_CadDiscForm;
        private System.Windows.Forms.GroupBox grb_CaixaDeInserção_CadDiscForm;
        private System.Windows.Forms.Button btn_Deletar_CaDiscForm;
        private System.Windows.Forms.Button btn_Alterar_CaDiscForm;
        private System.Windows.Forms.Button btn_Incluir_CaDiscForm;
    }
}