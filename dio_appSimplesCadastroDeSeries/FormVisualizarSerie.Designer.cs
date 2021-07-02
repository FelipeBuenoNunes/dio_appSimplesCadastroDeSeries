
namespace dio_appSimplesCadastroDeSeries
{
    partial class FormVisualizarSerie
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
            this.visualizaId = new System.Windows.Forms.Label();
            this.visualizaName = new System.Windows.Forms.Label();
            this.visualizaDescricao = new System.Windows.Forms.Label();
            this.visualizaStartSerie = new System.Windows.Forms.Label();
            this.visualizarGenero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // visualizaId
            // 
            this.visualizaId.AutoSize = true;
            this.visualizaId.Location = new System.Drawing.Point(40, 42);
            this.visualizaId.Name = "visualizaId";
            this.visualizaId.Size = new System.Drawing.Size(18, 15);
            this.visualizaId.TabIndex = 0;
            this.visualizaId.Text = "ID";
            // 
            // visualizaName
            // 
            this.visualizaName.AutoSize = true;
            this.visualizaName.Location = new System.Drawing.Point(40, 66);
            this.visualizaName.Name = "visualizaName";
            this.visualizaName.Size = new System.Drawing.Size(39, 15);
            this.visualizaName.TabIndex = 9;
            this.visualizaName.Text = "Name";
            // 
            // visualizaDescricao
            // 
            this.visualizaDescricao.AutoSize = true;
            this.visualizaDescricao.Location = new System.Drawing.Point(40, 90);
            this.visualizaDescricao.Name = "visualizaDescricao";
            this.visualizaDescricao.Size = new System.Drawing.Size(58, 15);
            this.visualizaDescricao.TabIndex = 10;
            this.visualizaDescricao.Text = "Descrição";
            // 
            // visualizaStartSerie
            // 
            this.visualizaStartSerie.AutoSize = true;
            this.visualizaStartSerie.Location = new System.Drawing.Point(40, 138);
            this.visualizaStartSerie.Name = "visualizaStartSerie";
            this.visualizaStartSerie.Size = new System.Drawing.Size(79, 15);
            this.visualizaStartSerie.TabIndex = 11;
            this.visualizaStartSerie.Text = "Início da série";
            // 
            // visualizarGenero
            // 
            this.visualizarGenero.AutoSize = true;
            this.visualizarGenero.Location = new System.Drawing.Point(40, 114);
            this.visualizarGenero.Name = "visualizarGenero";
            this.visualizarGenero.Size = new System.Drawing.Size(45, 15);
            this.visualizarGenero.TabIndex = 12;
            this.visualizarGenero.Text = "Genero";
            // 
            // FormVisualizarSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(253, 213);
            this.Controls.Add(this.visualizarGenero);
            this.Controls.Add(this.visualizaStartSerie);
            this.Controls.Add(this.visualizaDescricao);
            this.Controls.Add(this.visualizaName);
            this.Controls.Add(this.visualizaId);
            this.Name = "FormVisualizarSerie";
            this.Text = "Visualizar Serie";
            this.Load += new System.EventHandler(this.VisualizarSerie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label visualizaId;
        private System.Windows.Forms.Label visualizaName;
        private System.Windows.Forms.Label visualizaDescricao;
        private System.Windows.Forms.Label visualizaStartSerie;
        private System.Windows.Forms.Label visualizarGenero;
    }
}