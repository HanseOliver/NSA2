namespace Prj_NSA2
{
    partial class frm_Cons_Ana_Alunos
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
            this.dgv_Dados = new System.Windows.Forms.DataGridView();
            this.lbl_nomeValue = new System.Windows.Forms.Label();
            this.cmb_alAn = new System.Windows.Forms.ComboBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Dados
            // 
            this.dgv_Dados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dados.Location = new System.Drawing.Point(116, 179);
            this.dgv_Dados.Name = "dgv_Dados";
            this.dgv_Dados.Size = new System.Drawing.Size(480, 289);
            this.dgv_Dados.TabIndex = 7;
            // 
            // lbl_nomeValue
            // 
            this.lbl_nomeValue.AutoSize = true;
            this.lbl_nomeValue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_nomeValue.Location = new System.Drawing.Point(429, 101);
            this.lbl_nomeValue.Name = "lbl_nomeValue";
            this.lbl_nomeValue.Size = new System.Drawing.Size(13, 13);
            this.lbl_nomeValue.TabIndex = 6;
            this.lbl_nomeValue.Text = "_";
            // 
            // cmb_alAn
            // 
            this.cmb_alAn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_alAn.FormattingEnabled = true;
            this.cmb_alAn.Location = new System.Drawing.Point(248, 98);
            this.cmb_alAn.Name = "cmb_alAn";
            this.cmb_alAn.Size = new System.Drawing.Size(121, 21);
            this.cmb_alAn.TabIndex = 5;
            this.cmb_alAn.SelectedIndexChanged += new System.EventHandler(this.cmb_alAn_SelectedIndexChanged);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(148, 101);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(47, 13);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "Nome::";
            // 
            // frm_Cons_Ana_Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(713, 567);
            this.Controls.Add(this.dgv_Dados);
            this.Controls.Add(this.lbl_nomeValue);
            this.Controls.Add(this.cmb_alAn);
            this.Controls.Add(this.lbl_nome);
            this.Name = "frm_Cons_Ana_Alunos";
            this.Text = "Consulta Analitica de Alunos";
            this.Load += new System.EventHandler(this.frm_Cons_Ana_Alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Dados;
        private System.Windows.Forms.Label lbl_nomeValue;
        private System.Windows.Forms.ComboBox cmb_alAn;
        private System.Windows.Forms.Label lbl_nome;
    }
}