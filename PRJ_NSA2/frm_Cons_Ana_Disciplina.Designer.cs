namespace Prj_NSA2
{
    partial class frm_Cons_Ana_Disciplina
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
            this.lbl_sigla = new System.Windows.Forms.Label();
            this.cmb_discAn = new System.Windows.Forms.ComboBox();
            this.lbl_siglaValue = new System.Windows.Forms.Label();
            this.dgv_Dados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_sigla
            // 
            this.lbl_sigla.AutoSize = true;
            this.lbl_sigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sigla.Location = new System.Drawing.Point(139, 71);
            this.lbl_sigla.Name = "lbl_sigla";
            this.lbl_sigla.Size = new System.Drawing.Size(43, 13);
            this.lbl_sigla.TabIndex = 0;
            this.lbl_sigla.Text = "Sigla::";
            // 
            // cmb_discAn
            // 
            this.cmb_discAn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_discAn.FormattingEnabled = true;
            this.cmb_discAn.Location = new System.Drawing.Point(239, 68);
            this.cmb_discAn.Name = "cmb_discAn";
            this.cmb_discAn.Size = new System.Drawing.Size(121, 21);
            this.cmb_discAn.TabIndex = 1;
            this.cmb_discAn.SelectedIndexChanged += new System.EventHandler(this.cmb_discAn_SelectedIndexChanged);
            // 
            // lbl_siglaValue
            // 
            this.lbl_siglaValue.AutoSize = true;
            this.lbl_siglaValue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_siglaValue.Location = new System.Drawing.Point(420, 71);
            this.lbl_siglaValue.Name = "lbl_siglaValue";
            this.lbl_siglaValue.Size = new System.Drawing.Size(13, 13);
            this.lbl_siglaValue.TabIndex = 2;
            this.lbl_siglaValue.Text = "_";
            this.lbl_siglaValue.TabIndexChanged += new System.EventHandler(this.lbl_siglaValue_TabIndexChanged);
            // 
            // dgv_Dados
            // 
            this.dgv_Dados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dados.Location = new System.Drawing.Point(107, 149);
            this.dgv_Dados.Name = "dgv_Dados";
            this.dgv_Dados.Size = new System.Drawing.Size(480, 289);
            this.dgv_Dados.TabIndex = 3;
            // 
            // frm_Cons_Ana_Disciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(706, 483);
            this.Controls.Add(this.dgv_Dados);
            this.Controls.Add(this.lbl_siglaValue);
            this.Controls.Add(this.cmb_discAn);
            this.Controls.Add(this.lbl_sigla);
            this.Name = "frm_Cons_Ana_Disciplina";
            this.Text = "Consulta Analitica de Disciplinas";
            this.Load += new System.EventHandler(this.frm_Cons_Ana_Disciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sigla;
        private System.Windows.Forms.ComboBox cmb_discAn;
        private System.Windows.Forms.Label lbl_siglaValue;
        private System.Windows.Forms.DataGridView dgv_Dados;
    }
}