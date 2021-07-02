
namespace dio_appSimplesCadastroDeSeries
{
    partial class FormEditar
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
            this.btSave = new System.Windows.Forms.Button();
            this.newName = new System.Windows.Forms.TextBox();
            this.newStartSerie = new System.Windows.Forms.TextBox();
            this.newDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oldName = new System.Windows.Forms.Label();
            this.oldDescription = new System.Windows.Forms.Label();
            this.oldGenero = new System.Windows.Forms.Label();
            this.oldStartSerie = new System.Windows.Forms.Label();
            this.comboNewGenero = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(62, 182);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(119, 23);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Salvar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(62, 46);
            this.newName.Name = "newName";
            this.newName.PlaceholderText = "Novo nome";
            this.newName.Size = new System.Drawing.Size(119, 23);
            this.newName.TabIndex = 1;
            // 
            // newStartSerie
            // 
            this.newStartSerie.Location = new System.Drawing.Point(62, 133);
            this.newStartSerie.Name = "newStartSerie";
            this.newStartSerie.PlaceholderText = "Nova data de início";
            this.newStartSerie.Size = new System.Drawing.Size(119, 23);
            this.newStartSerie.TabIndex = 2;
            // 
            // newDescription
            // 
            this.newDescription.Location = new System.Drawing.Point(62, 75);
            this.newDescription.Name = "newDescription";
            this.newDescription.PlaceholderText = "Nova Descrição";
            this.newDescription.Size = new System.Drawing.Size(119, 23);
            this.newDescription.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dados Antigos";
            // 
            // oldName
            // 
            this.oldName.AutoSize = true;
            this.oldName.Location = new System.Drawing.Point(187, 54);
            this.oldName.Name = "oldName";
            this.oldName.Size = new System.Drawing.Size(79, 15);
            this.oldName.TabIndex = 6;
            this.oldName.Text = "Nome Antigo";
            // 
            // oldDescription
            // 
            this.oldDescription.AutoSize = true;
            this.oldDescription.Location = new System.Drawing.Point(187, 83);
            this.oldDescription.Name = "oldDescription";
            this.oldDescription.Size = new System.Drawing.Size(94, 15);
            this.oldDescription.TabIndex = 7;
            this.oldDescription.Text = "Descricao antiga";
            // 
            // oldGenero
            // 
            this.oldGenero.AutoSize = true;
            this.oldGenero.Location = new System.Drawing.Point(187, 112);
            this.oldGenero.Name = "oldGenero";
            this.oldGenero.Size = new System.Drawing.Size(82, 15);
            this.oldGenero.TabIndex = 8;
            this.oldGenero.Text = "Ganero antigo";
            // 
            // oldStartSerie
            // 
            this.oldStartSerie.AutoSize = true;
            this.oldStartSerie.Location = new System.Drawing.Point(187, 141);
            this.oldStartSerie.Name = "oldStartSerie";
            this.oldStartSerie.Size = new System.Drawing.Size(116, 15);
            this.oldStartSerie.TabIndex = 9;
            this.oldStartSerie.Text = "Antiga data de início";
            // 
            // comboNewGenero
            // 
            this.comboNewGenero.FormattingEnabled = true;
            this.comboNewGenero.Location = new System.Drawing.Point(62, 104);
            this.comboNewGenero.Name = "comboNewGenero";
            this.comboNewGenero.Size = new System.Drawing.Size(121, 23);
            this.comboNewGenero.TabIndex = 10;
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(436, 248);
            this.Controls.Add(this.comboNewGenero);
            this.Controls.Add(this.oldStartSerie);
            this.Controls.Add(this.oldGenero);
            this.Controls.Add(this.oldDescription);
            this.Controls.Add(this.oldName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newDescription);
            this.Controls.Add(this.newStartSerie);
            this.Controls.Add(this.newName);
            this.Controls.Add(this.btSave);
            this.Name = "FormEditar";
            this.Text = "Editar Serie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.TextBox newStartSerie;
        private System.Windows.Forms.TextBox newDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oldName;
        private System.Windows.Forms.Label oldDescription;
        private System.Windows.Forms.Label oldGenero;
        private System.Windows.Forms.Label oldStartSerie;
        private System.Windows.Forms.ComboBox comboNewGenero;
    }
}