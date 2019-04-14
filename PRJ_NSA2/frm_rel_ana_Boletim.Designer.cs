namespace Prj_NSA2
{
    partial class frm_rel_ana_Boletim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rel_ana_Boletim));
            this.btn_vizualizar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.dgv_Relatorio = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Relatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_vizualizar
            // 
            this.btn_vizualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_vizualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vizualizar.Location = new System.Drawing.Point(438, 381);
            this.btn_vizualizar.Name = "btn_vizualizar";
            this.btn_vizualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_vizualizar.TabIndex = 13;
            this.btn_vizualizar.Text = "Vizualizar";
            this.btn_vizualizar.UseVisualStyleBackColor = false;
            this.btn_vizualizar.Click += new System.EventHandler(this.btn_vizualizar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(248, 381);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 12;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // dgv_Relatorio
            // 
            this.dgv_Relatorio.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Relatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Relatorio.Location = new System.Drawing.Point(102, 40);
            this.dgv_Relatorio.Name = "dgv_Relatorio";
            this.dgv_Relatorio.Size = new System.Drawing.Size(570, 292);
            this.dgv_Relatorio.TabIndex = 11;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // frm_rel_ana_Boletim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(774, 445);
            this.Controls.Add(this.btn_vizualizar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.dgv_Relatorio);
            this.Name = "frm_rel_ana_Boletim";
            this.Text = "Boletins";
            this.Load += new System.EventHandler(this.frm_rel_ana_Boletim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Relatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_vizualizar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DataGridView dgv_Relatorio;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Timer timer1;

    }
}