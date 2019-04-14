namespace Prj_NSA2
{
    partial class frm_Cons_Cad_Disc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cons_Cad_Disc));
            this.lbl_Texto_ConsDisc = new System.Windows.Forms.Label();
            this.cmb_Escolha_ConsDisc = new System.Windows.Forms.ComboBox();
            this.txt_Pesq_ConsDisc = new System.Windows.Forms.TextBox();
            this.dgv_DiscConsulta_ConsDisc = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_visualizar_ConsDisc = new System.Windows.Forms.Button();
            this.btn_Qntd_ConsDisc = new System.Windows.Forms.Button();
            this.printDialog1_ConsCadDisc = new System.Windows.Forms.PrintDialog();
            this.printDocument1_ConsCadDisc = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1_ConsCadDisc = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DiscConsulta_ConsDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Texto_ConsDisc
            // 
            this.lbl_Texto_ConsDisc.AutoSize = true;
            this.lbl_Texto_ConsDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto_ConsDisc.Location = new System.Drawing.Point(37, 65);
            this.lbl_Texto_ConsDisc.Name = "lbl_Texto_ConsDisc";
            this.lbl_Texto_ConsDisc.Size = new System.Drawing.Size(204, 13);
            this.lbl_Texto_ConsDisc.TabIndex = 0;
            this.lbl_Texto_ConsDisc.Text = "Escolha o campo a ser pesquisado";
            // 
            // cmb_Escolha_ConsDisc
            // 
            this.cmb_Escolha_ConsDisc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Escolha_ConsDisc.FormattingEnabled = true;
            this.cmb_Escolha_ConsDisc.Items.AddRange(new object[] {
            "Codigo da Disciplina",
            "Descrição",
            "Sigla"});
            this.cmb_Escolha_ConsDisc.Location = new System.Drawing.Point(247, 62);
            this.cmb_Escolha_ConsDisc.Name = "cmb_Escolha_ConsDisc";
            this.cmb_Escolha_ConsDisc.Size = new System.Drawing.Size(180, 21);
            this.cmb_Escolha_ConsDisc.TabIndex = 1;
            // 
            // txt_Pesq_ConsDisc
            // 
            this.txt_Pesq_ConsDisc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_Pesq_ConsDisc.Location = new System.Drawing.Point(458, 62);
            this.txt_Pesq_ConsDisc.Name = "txt_Pesq_ConsDisc";
            this.txt_Pesq_ConsDisc.Size = new System.Drawing.Size(138, 20);
            this.txt_Pesq_ConsDisc.TabIndex = 2;
            this.txt_Pesq_ConsDisc.TextChanged += new System.EventHandler(this.txt_Pesq_ConsDisc_TextChanged);
            // 
            // dgv_DiscConsulta_ConsDisc
            // 
            this.dgv_DiscConsulta_ConsDisc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_DiscConsulta_ConsDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DiscConsulta_ConsDisc.Location = new System.Drawing.Point(12, 126);
            this.dgv_DiscConsulta_ConsDisc.Name = "dgv_DiscConsulta_ConsDisc";
            this.dgv_DiscConsulta_ConsDisc.Size = new System.Drawing.Size(657, 279);
            this.dgv_DiscConsulta_ConsDisc.TabIndex = 3;
            this.dgv_DiscConsulta_ConsDisc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DiscConsulta_ConsDisc_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_visualizar_ConsDisc
            // 
            this.btn_visualizar_ConsDisc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_visualizar_ConsDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizar_ConsDisc.Location = new System.Drawing.Point(72, 468);
            this.btn_visualizar_ConsDisc.Name = "btn_visualizar_ConsDisc";
            this.btn_visualizar_ConsDisc.Size = new System.Drawing.Size(75, 23);
            this.btn_visualizar_ConsDisc.TabIndex = 5;
            this.btn_visualizar_ConsDisc.Text = "Visualizar";
            this.btn_visualizar_ConsDisc.UseVisualStyleBackColor = false;
            this.btn_visualizar_ConsDisc.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Qntd_ConsDisc
            // 
            this.btn_Qntd_ConsDisc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Qntd_ConsDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Qntd_ConsDisc.Location = new System.Drawing.Point(510, 422);
            this.btn_Qntd_ConsDisc.Name = "btn_Qntd_ConsDisc";
            this.btn_Qntd_ConsDisc.Size = new System.Drawing.Size(93, 69);
            this.btn_Qntd_ConsDisc.TabIndex = 6;
            this.btn_Qntd_ConsDisc.Text = "Quantidade de Selecionados";
            this.btn_Qntd_ConsDisc.UseVisualStyleBackColor = false;
            this.btn_Qntd_ConsDisc.Click += new System.EventHandler(this.button3_Click);
            // 
            // printDialog1_ConsCadDisc
            // 
            this.printDialog1_ConsCadDisc.Document = this.printDocument1_ConsCadDisc;
            this.printDialog1_ConsCadDisc.UseEXDialog = true;
            // 
            // printDocument1_ConsCadDisc
            // 
            this.printDocument1_ConsCadDisc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_ConsCadDisc_PrintPage);
            // 
            // printPreviewDialog1_ConsCadDisc
            // 
            this.printPreviewDialog1_ConsCadDisc.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1_ConsCadDisc.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1_ConsCadDisc.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1_ConsCadDisc.Document = this.printDocument1_ConsCadDisc;
            this.printPreviewDialog1_ConsCadDisc.Enabled = true;
            this.printPreviewDialog1_ConsCadDisc.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1_ConsCadDisc.Icon")));
            this.printPreviewDialog1_ConsCadDisc.Name = "printPreviewDialog1_ConsCadDisc";
            this.printPreviewDialog1_ConsCadDisc.Visible = false;
            // 
            // frm_Cons_Cad_Disc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(681, 543);
            this.Controls.Add(this.btn_Qntd_ConsDisc);
            this.Controls.Add(this.btn_visualizar_ConsDisc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_DiscConsulta_ConsDisc);
            this.Controls.Add(this.txt_Pesq_ConsDisc);
            this.Controls.Add(this.cmb_Escolha_ConsDisc);
            this.Controls.Add(this.lbl_Texto_ConsDisc);
            this.Name = "frm_Cons_Cad_Disc";
            this.Text = "Consulta Cadastral de Disiplinas";
            this.Load += new System.EventHandler(this.frm_Cons_Cad_Disc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DiscConsulta_ConsDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Texto_ConsDisc;
        private System.Windows.Forms.ComboBox cmb_Escolha_ConsDisc;
        private System.Windows.Forms.TextBox txt_Pesq_ConsDisc;
        private System.Windows.Forms.DataGridView dgv_DiscConsulta_ConsDisc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_visualizar_ConsDisc;
        private System.Windows.Forms.Button btn_Qntd_ConsDisc;
        private System.Windows.Forms.PrintDialog printDialog1_ConsCadDisc;
        private System.Drawing.Printing.PrintDocument printDocument1_ConsCadDisc;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1_ConsCadDisc;
    }
}