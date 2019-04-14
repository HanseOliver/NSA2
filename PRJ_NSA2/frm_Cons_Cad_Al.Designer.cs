namespace Prj_NSA2
{
    partial class frm_Cons_Cad_Al
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cons_Cad_Al));
            this.btn_Qntd_ConsAl = new System.Windows.Forms.Button();
            this.btn_vizualizar_ConsCadAl = new System.Windows.Forms.Button();
            this.btn_imprimir_ConsCadAl = new System.Windows.Forms.Button();
            this.dgv_DiscConsulta_ConsAl = new System.Windows.Forms.DataGridView();
            this.txt_Pesq_ConsAl = new System.Windows.Forms.TextBox();
            this.cmb_Escolha_ConsAl = new System.Windows.Forms.ComboBox();
            this.lbl_Texto_ConsDisc = new System.Windows.Forms.Label();
            this.printDialog1_ConsCadAl = new System.Windows.Forms.PrintDialog();
            this.printDocument1_ConsCadAl = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1_ConsCadAl = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DiscConsulta_ConsAl)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Qntd_ConsAl
            // 
            this.btn_Qntd_ConsAl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Qntd_ConsAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Qntd_ConsAl.Location = new System.Drawing.Point(558, 388);
            this.btn_Qntd_ConsAl.Name = "btn_Qntd_ConsAl";
            this.btn_Qntd_ConsAl.Size = new System.Drawing.Size(95, 69);
            this.btn_Qntd_ConsAl.TabIndex = 13;
            this.btn_Qntd_ConsAl.Text = "Quantidade de Selecionados";
            this.btn_Qntd_ConsAl.UseVisualStyleBackColor = false;
            this.btn_Qntd_ConsAl.Click += new System.EventHandler(this.btn_Qntd_ConsAl_Click);
            // 
            // btn_vizualizar_ConsCadAl
            // 
            this.btn_vizualizar_ConsCadAl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_vizualizar_ConsCadAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vizualizar_ConsCadAl.Location = new System.Drawing.Point(120, 434);
            this.btn_vizualizar_ConsCadAl.Name = "btn_vizualizar_ConsCadAl";
            this.btn_vizualizar_ConsCadAl.Size = new System.Drawing.Size(84, 23);
            this.btn_vizualizar_ConsCadAl.TabIndex = 12;
            this.btn_vizualizar_ConsCadAl.Text = "Visualizar";
            this.btn_vizualizar_ConsCadAl.UseVisualStyleBackColor = false;
            this.btn_vizualizar_ConsCadAl.Click += new System.EventHandler(this.btn_vizualizar_ConsCadAl_Click);
            // 
            // btn_imprimir_ConsCadAl
            // 
            this.btn_imprimir_ConsCadAl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_imprimir_ConsCadAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_ConsCadAl.Location = new System.Drawing.Point(120, 388);
            this.btn_imprimir_ConsCadAl.Name = "btn_imprimir_ConsCadAl";
            this.btn_imprimir_ConsCadAl.Size = new System.Drawing.Size(84, 23);
            this.btn_imprimir_ConsCadAl.TabIndex = 11;
            this.btn_imprimir_ConsCadAl.Text = "Imprimir";
            this.btn_imprimir_ConsCadAl.UseVisualStyleBackColor = false;
            this.btn_imprimir_ConsCadAl.Click += new System.EventHandler(this.btn_imprimir_ConsCadAl_Click);
            // 
            // dgv_DiscConsulta_ConsAl
            // 
            this.dgv_DiscConsulta_ConsAl.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_DiscConsulta_ConsAl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DiscConsulta_ConsAl.Location = new System.Drawing.Point(12, 92);
            this.dgv_DiscConsulta_ConsAl.Name = "dgv_DiscConsulta_ConsAl";
            this.dgv_DiscConsulta_ConsAl.Size = new System.Drawing.Size(737, 279);
            this.dgv_DiscConsulta_ConsAl.TabIndex = 10;
            // 
            // txt_Pesq_ConsAl
            // 
            this.txt_Pesq_ConsAl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_Pesq_ConsAl.Location = new System.Drawing.Point(506, 28);
            this.txt_Pesq_ConsAl.Name = "txt_Pesq_ConsAl";
            this.txt_Pesq_ConsAl.Size = new System.Drawing.Size(138, 20);
            this.txt_Pesq_ConsAl.TabIndex = 9;
            this.txt_Pesq_ConsAl.TextChanged += new System.EventHandler(this.txt_Pesq_ConsDisc_TextChanged);
            // 
            // cmb_Escolha_ConsAl
            // 
            this.cmb_Escolha_ConsAl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Escolha_ConsAl.FormattingEnabled = true;
            this.cmb_Escolha_ConsAl.Items.AddRange(new object[] {
            "Matricula",
            "Nome",
            "Data de Nascimento",
            "Endereço",
            "Numero",
            "Bairro",
            "Cidade",
            "CEP",
            "RG",
            "Telefone"});
            this.cmb_Escolha_ConsAl.Location = new System.Drawing.Point(295, 28);
            this.cmb_Escolha_ConsAl.Name = "cmb_Escolha_ConsAl";
            this.cmb_Escolha_ConsAl.Size = new System.Drawing.Size(180, 21);
            this.cmb_Escolha_ConsAl.TabIndex = 8;
            // 
            // lbl_Texto_ConsDisc
            // 
            this.lbl_Texto_ConsDisc.AutoSize = true;
            this.lbl_Texto_ConsDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto_ConsDisc.Location = new System.Drawing.Point(85, 31);
            this.lbl_Texto_ConsDisc.Name = "lbl_Texto_ConsDisc";
            this.lbl_Texto_ConsDisc.Size = new System.Drawing.Size(204, 13);
            this.lbl_Texto_ConsDisc.TabIndex = 7;
            this.lbl_Texto_ConsDisc.Text = "Escolha o campo a ser pesquisado";
            this.lbl_Texto_ConsDisc.Click += new System.EventHandler(this.lbl_Texto_ConsDisc_Click);
            // 
            // printDialog1_ConsCadAl
            // 
            this.printDialog1_ConsCadAl.Document = this.printDocument1_ConsCadAl;
            this.printDialog1_ConsCadAl.UseEXDialog = true;
            // 
            // printDocument1_ConsCadAl
            // 
            this.printDocument1_ConsCadAl.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_ConsCadAl_PrintPage);
            // 
            // printPreviewDialog1_ConsCadAl
            // 
            this.printPreviewDialog1_ConsCadAl.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1_ConsCadAl.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1_ConsCadAl.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1_ConsCadAl.Document = this.printDocument1_ConsCadAl;
            this.printPreviewDialog1_ConsCadAl.Enabled = true;
            this.printPreviewDialog1_ConsCadAl.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1_ConsCadAl.Icon")));
            this.printPreviewDialog1_ConsCadAl.Name = "printPreviewDialog1_ConsCadAl";
            this.printPreviewDialog1_ConsCadAl.Visible = false;
            // 
            // frm_Cons_Cad_Al
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(761, 485);
            this.Controls.Add(this.btn_Qntd_ConsAl);
            this.Controls.Add(this.btn_vizualizar_ConsCadAl);
            this.Controls.Add(this.btn_imprimir_ConsCadAl);
            this.Controls.Add(this.dgv_DiscConsulta_ConsAl);
            this.Controls.Add(this.txt_Pesq_ConsAl);
            this.Controls.Add(this.cmb_Escolha_ConsAl);
            this.Controls.Add(this.lbl_Texto_ConsDisc);
            this.Name = "frm_Cons_Cad_Al";
            this.Text = "Consulta Cadastral de Alunos";
            this.Load += new System.EventHandler(this.frm_Cons_Cad_Al_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DiscConsulta_ConsAl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Qntd_ConsAl;
        private System.Windows.Forms.Button btn_vizualizar_ConsCadAl;
        private System.Windows.Forms.Button btn_imprimir_ConsCadAl;
        private System.Windows.Forms.DataGridView dgv_DiscConsulta_ConsAl;
        private System.Windows.Forms.TextBox txt_Pesq_ConsAl;
        private System.Windows.Forms.ComboBox cmb_Escolha_ConsAl;
        private System.Windows.Forms.Label lbl_Texto_ConsDisc;
        private System.Windows.Forms.PrintDialog printDialog1_ConsCadAl;
        private System.Drawing.Printing.PrintDocument printDocument1_ConsCadAl;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1_ConsCadAl;

    }
}