namespace Prj_NSA2
{
    partial class LancarNotas
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
            this.dgv_Show = new System.Windows.Forms.DataGridView();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.lbl_discCod = new System.Windows.Forms.Label();
            this.lbl_alunoMatricula = new System.Windows.Forms.Label();
            this.cmb_menc = new System.Windows.Forms.ComboBox();
            this.lbl_menc = new System.Windows.Forms.Label();
            this.cmb_disc = new System.Windows.Forms.ComboBox();
            this.lbl_disc = new System.Windows.Forms.Label();
            this.cmb_alunos = new System.Windows.Forms.ComboBox();
            this.lbl_alunos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Show
            // 
            this.dgv_Show.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Show.Location = new System.Drawing.Point(209, 284);
            this.dgv_Show.Name = "dgv_Show";
            this.dgv_Show.Size = new System.Drawing.Size(522, 255);
            this.dgv_Show.TabIndex = 19;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_registrar.Location = new System.Drawing.Point(775, 262);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 18;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // lbl_discCod
            // 
            this.lbl_discCod.AutoSize = true;
            this.lbl_discCod.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_discCod.Location = new System.Drawing.Point(795, 142);
            this.lbl_discCod.Name = "lbl_discCod";
            this.lbl_discCod.Size = new System.Drawing.Size(25, 13);
            this.lbl_discCod.TabIndex = 17;
            this.lbl_discCod.Text = "___";
            // 
            // lbl_alunoMatricula
            // 
            this.lbl_alunoMatricula.AutoSize = true;
            this.lbl_alunoMatricula.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_alunoMatricula.Location = new System.Drawing.Point(795, 65);
            this.lbl_alunoMatricula.Name = "lbl_alunoMatricula";
            this.lbl_alunoMatricula.Size = new System.Drawing.Size(25, 13);
            this.lbl_alunoMatricula.TabIndex = 16;
            this.lbl_alunoMatricula.Text = "___";
            // 
            // cmb_menc
            // 
            this.cmb_menc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_menc.FormattingEnabled = true;
            this.cmb_menc.Location = new System.Drawing.Point(243, 215);
            this.cmb_menc.Name = "cmb_menc";
            this.cmb_menc.Size = new System.Drawing.Size(363, 21);
            this.cmb_menc.TabIndex = 15;
            // 
            // lbl_menc
            // 
            this.lbl_menc.AutoSize = true;
            this.lbl_menc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menc.Location = new System.Drawing.Point(151, 218);
            this.lbl_menc.Name = "lbl_menc";
            this.lbl_menc.Size = new System.Drawing.Size(60, 13);
            this.lbl_menc.TabIndex = 14;
            this.lbl_menc.Text = "Menção::";
            // 
            // cmb_disc
            // 
            this.cmb_disc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_disc.FormattingEnabled = true;
            this.cmb_disc.Location = new System.Drawing.Point(243, 139);
            this.cmb_disc.Name = "cmb_disc";
            this.cmb_disc.Size = new System.Drawing.Size(363, 21);
            this.cmb_disc.TabIndex = 13;
            this.cmb_disc.SelectedIndexChanged += new System.EventHandler(this.cmb_disc_SelectedIndexChanged);
            // 
            // lbl_disc
            // 
            this.lbl_disc.AutoSize = true;
            this.lbl_disc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disc.Location = new System.Drawing.Point(151, 142);
            this.lbl_disc.Name = "lbl_disc";
            this.lbl_disc.Size = new System.Drawing.Size(70, 13);
            this.lbl_disc.TabIndex = 12;
            this.lbl_disc.Text = "Disciplina::";
            // 
            // cmb_alunos
            // 
            this.cmb_alunos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_alunos.FormattingEnabled = true;
            this.cmb_alunos.Location = new System.Drawing.Point(243, 62);
            this.cmb_alunos.Name = "cmb_alunos";
            this.cmb_alunos.Size = new System.Drawing.Size(363, 21);
            this.cmb_alunos.TabIndex = 11;
            this.cmb_alunos.SelectedIndexChanged += new System.EventHandler(this.cmb_alunos_SelectedIndexChanged);
            // 
            // lbl_alunos
            // 
            this.lbl_alunos.AutoSize = true;
            this.lbl_alunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alunos.Location = new System.Drawing.Point(151, 65);
            this.lbl_alunos.Name = "lbl_alunos";
            this.lbl_alunos.Size = new System.Drawing.Size(47, 13);
            this.lbl_alunos.TabIndex = 10;
            this.lbl_alunos.Text = "Aluno::";
            // 
            // LancarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1090, 673);
            this.Controls.Add(this.dgv_Show);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.lbl_discCod);
            this.Controls.Add(this.lbl_alunoMatricula);
            this.Controls.Add(this.cmb_menc);
            this.Controls.Add(this.lbl_menc);
            this.Controls.Add(this.cmb_disc);
            this.Controls.Add(this.lbl_disc);
            this.Controls.Add(this.cmb_alunos);
            this.Controls.Add(this.lbl_alunos);
            this.Name = "LancarNotas";
            this.Text = "Registro de Notas no Sistema";
            this.Load += new System.EventHandler(this.LancarNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Show;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label lbl_discCod;
        private System.Windows.Forms.Label lbl_alunoMatricula;
        private System.Windows.Forms.ComboBox cmb_menc;
        private System.Windows.Forms.Label lbl_menc;
        private System.Windows.Forms.ComboBox cmb_disc;
        private System.Windows.Forms.Label lbl_disc;
        private System.Windows.Forms.ComboBox cmb_alunos;
        private System.Windows.Forms.Label lbl_alunos;
    }
}