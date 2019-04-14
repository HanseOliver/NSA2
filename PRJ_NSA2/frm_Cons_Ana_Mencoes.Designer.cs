namespace Prj_NSA2
{
    partial class frm_Cons_Ana_Mencoes
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
            this.cmb_MencAn = new System.Windows.Forms.ComboBox();
            this.lbl_mencao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Dados
            // 
            this.dgv_Dados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dados.Location = new System.Drawing.Point(100, 161);
            this.dgv_Dados.Name = "dgv_Dados";
            this.dgv_Dados.Size = new System.Drawing.Size(480, 289);
            this.dgv_Dados.TabIndex = 11;
            // 
            // cmb_MencAn
            // 
            this.cmb_MencAn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_MencAn.FormattingEnabled = true;
            this.cmb_MencAn.Location = new System.Drawing.Point(232, 80);
            this.cmb_MencAn.Name = "cmb_MencAn";
            this.cmb_MencAn.Size = new System.Drawing.Size(121, 21);
            this.cmb_MencAn.TabIndex = 9;
            this.cmb_MencAn.SelectedIndexChanged += new System.EventHandler(this.cmb_MencAn_SelectedIndexChanged);
            // 
            // lbl_mencao
            // 
            this.lbl_mencao.AutoSize = true;
            this.lbl_mencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mencao.Location = new System.Drawing.Point(132, 83);
            this.lbl_mencao.Name = "lbl_mencao";
            this.lbl_mencao.Size = new System.Drawing.Size(60, 13);
            this.lbl_mencao.TabIndex = 8;
            this.lbl_mencao.Text = "Menção::";
            // 
            // frm_Cons_Ana_Mencoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(680, 531);
            this.Controls.Add(this.dgv_Dados);
            this.Controls.Add(this.cmb_MencAn);
            this.Controls.Add(this.lbl_mencao);
            this.Name = "frm_Cons_Ana_Mencoes";
            this.Text = "Consulta Analitica de Menções";
            this.Load += new System.EventHandler(this.frm_Cons_Ana_Mencoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Dados;
        private System.Windows.Forms.ComboBox cmb_MencAn;
        private System.Windows.Forms.Label lbl_mencao;
    }
}