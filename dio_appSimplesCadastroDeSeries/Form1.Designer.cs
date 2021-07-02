
namespace dio_appSimplesCadastroDeSeries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.seriesName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboGeneros = new System.Windows.Forms.ComboBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.seriesStart = new System.Windows.Forms.TextBox();
            this.seriesDescription = new System.Windows.Forms.TextBox();
            this.visualizarSerie = new System.Windows.Forms.Button();
            this.visualizaSerie = new System.Windows.Forms.GroupBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.comboNames = new System.Windows.Forms.ComboBox();
            this.contagem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.excluir = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.visualizaSerie.SuspendLayout();
            this.SuspendLayout();
            // 
            // seriesName
            // 
            this.seriesName.AccessibleName = "Nome da série";
            this.seriesName.Location = new System.Drawing.Point(22, 22);
            this.seriesName.Name = "seriesName";
            this.seriesName.PlaceholderText = "Nome";
            this.seriesName.Size = new System.Drawing.Size(148, 23);
            this.seriesName.TabIndex = 1;
            this.seriesName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboGeneros);
            this.groupBox1.Controls.Add(this.btRegister);
            this.groupBox1.Controls.Add(this.seriesStart);
            this.groupBox1.Controls.Add(this.seriesName);
            this.groupBox1.Controls.Add(this.seriesDescription);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Série";
            // 
            // comboGeneros
            // 
            this.comboGeneros.FormattingEnabled = true;
            this.comboGeneros.Location = new System.Drawing.Point(22, 109);
            this.comboGeneros.Name = "comboGeneros";
            this.comboGeneros.Size = new System.Drawing.Size(148, 23);
            this.comboGeneros.TabIndex = 4;
            this.comboGeneros.Text = "Genero";
            this.comboGeneros.SelectedIndexChanged += new System.EventHandler(this.comboGeneros_SelectedIndexChanged);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(47, 179);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(99, 23);
            this.btRegister.TabIndex = 4;
            this.btRegister.Text = "Cadastrar série";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // seriesStart
            // 
            this.seriesStart.Location = new System.Drawing.Point(22, 80);
            this.seriesStart.Name = "seriesStart";
            this.seriesStart.PlaceholderText = "Início da série";
            this.seriesStart.Size = new System.Drawing.Size(148, 23);
            this.seriesStart.TabIndex = 5;
            // 
            // seriesDescription
            // 
            this.seriesDescription.Location = new System.Drawing.Point(22, 51);
            this.seriesDescription.Name = "seriesDescription";
            this.seriesDescription.PlaceholderText = "Descrição da série";
            this.seriesDescription.Size = new System.Drawing.Size(148, 23);
            this.seriesDescription.TabIndex = 4;
            // 
            // visualizarSerie
            // 
            this.visualizarSerie.Location = new System.Drawing.Point(19, 71);
            this.visualizarSerie.Name = "visualizarSerie";
            this.visualizarSerie.Size = new System.Drawing.Size(75, 23);
            this.visualizarSerie.TabIndex = 4;
            this.visualizarSerie.Text = "Visualizar série";
            this.visualizarSerie.UseVisualStyleBackColor = true;
            this.visualizarSerie.Click += new System.EventHandler(this.visualizarSerie_Click);
            // 
            // visualizaSerie
            // 
            this.visualizaSerie.Controls.Add(this.excluir);
            this.visualizaSerie.Controls.Add(this.btEdit);
            this.visualizaSerie.Controls.Add(this.comboNames);
            this.visualizaSerie.Controls.Add(this.visualizarSerie);
            this.visualizaSerie.Location = new System.Drawing.Point(26, 288);
            this.visualizaSerie.Name = "visualizaSerie";
            this.visualizaSerie.Size = new System.Drawing.Size(200, 100);
            this.visualizaSerie.TabIndex = 5;
            this.visualizaSerie.TabStop = false;
            this.visualizaSerie.Text = "Opções série";
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(104, 71);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "Editar";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // comboNames
            // 
            this.comboNames.FormattingEnabled = true;
            this.comboNames.Location = new System.Drawing.Point(19, 22);
            this.comboNames.Name = "comboNames";
            this.comboNames.Size = new System.Drawing.Size(160, 23);
            this.comboNames.TabIndex = 6;
            this.comboNames.Text = "Nome";
            // 
            // contagem
            // 
            this.contagem.AutoSize = true;
            this.contagem.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contagem.Location = new System.Drawing.Point(563, 82);
            this.contagem.Name = "contagem";
            this.contagem.Size = new System.Drawing.Size(88, 72);
            this.contagem.TabIndex = 6;
            this.contagem.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(273, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contagem de séries cadastradas:";
            // 
            // excluir
            // 
            this.excluir.AutoSize = true;
            this.excluir.Location = new System.Drawing.Point(76, 48);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(42, 15);
            this.excluir.TabIndex = 8;
            this.excluir.TabStop = true;
            this.excluir.Text = "Excluir";
            this.excluir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.excluir_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contagem);
            this.Controls.Add(this.visualizaSerie);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.visualizaSerie.ResumeLayout(false);
            this.visualizaSerie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox seriesName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox seriesStart;
        private System.Windows.Forms.TextBox seriesDescription;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.ComboBox comboGeneros;
        private System.Windows.Forms.Button visualizarSerie;
        private System.Windows.Forms.GroupBox visualizaSerie;
        private System.Windows.Forms.ComboBox comboNames;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Label contagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel excluir;
    }
}

