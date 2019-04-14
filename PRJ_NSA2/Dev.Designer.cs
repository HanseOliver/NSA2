namespace Prj_NSA2
{
    partial class Dev
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
            this.lbl_DevNotas_Dev = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_DevNotas_Dev
            // 
            this.lbl_DevNotas_Dev.AutoSize = true;
            this.lbl_DevNotas_Dev.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DevNotas_Dev.Location = new System.Drawing.Point(12, 86);
            this.lbl_DevNotas_Dev.Name = "lbl_DevNotas_Dev";
            this.lbl_DevNotas_Dev.Size = new System.Drawing.Size(361, 23);
            this.lbl_DevNotas_Dev.TabIndex = 0;
            this.lbl_DevNotas_Dev.Text = "Programa desenvolvido por Ighor Alves ";
            // 
            // Dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(401, 183);
            this.Controls.Add(this.lbl_DevNotas_Dev);
            this.Name = "Dev";
            this.Text = "Informações Sobre o Desenvolvimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DevNotas_Dev;
    }
}