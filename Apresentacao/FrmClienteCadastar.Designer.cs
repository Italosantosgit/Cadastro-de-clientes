namespace Apresentacao
{
    partial class FrmClienteCadastrar
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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxLimiteCompra = new System.Windows.Forms.TextBox();
            this.dateDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelLimiteCompra = new System.Windows.Forms.Label();
            this.radioSexoMasculino = new System.Windows.Forms.RadioButton();
            this.radioSexoFeminino = new System.Windows.Forms.RadioButton();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(22, 9);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(22, 62);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(22, 115);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(102, 13);
            this.labelDataNascimento.TabIndex = 4;
            this.labelDataNascimento.Text = "Data de nascimento";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(19, 179);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 6;
            this.labelSexo.Text = "Sexo";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(22, 30);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(58, 20);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(22, 83);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(203, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // textBoxLimiteCompra
            // 
            this.textBoxLimiteCompra.Location = new System.Drawing.Point(19, 261);
            this.textBoxLimiteCompra.Name = "textBoxLimiteCompra";
            this.textBoxLimiteCompra.Size = new System.Drawing.Size(80, 20);
            this.textBoxLimiteCompra.TabIndex = 10;
            this.textBoxLimiteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateDataNascimento
            // 
            this.dateDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataNascimento.Location = new System.Drawing.Point(22, 144);
            this.dateDataNascimento.Name = "dateDataNascimento";
            this.dateDataNascimento.Size = new System.Drawing.Size(102, 20);
            this.dateDataNascimento.TabIndex = 5;
            // 
            // labelLimiteCompra
            // 
            this.labelLimiteCompra.AutoSize = true;
            this.labelLimiteCompra.Location = new System.Drawing.Point(19, 232);
            this.labelLimiteCompra.Name = "labelLimiteCompra";
            this.labelLimiteCompra.Size = new System.Drawing.Size(73, 13);
            this.labelLimiteCompra.TabIndex = 9;
            this.labelLimiteCompra.Text = "Limite Compra";
            // 
            // radioSexoMasculino
            // 
            this.radioSexoMasculino.AutoSize = true;
            this.radioSexoMasculino.Checked = true;
            this.radioSexoMasculino.Location = new System.Drawing.Point(19, 200);
            this.radioSexoMasculino.Name = "radioSexoMasculino";
            this.radioSexoMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioSexoMasculino.TabIndex = 7;
            this.radioSexoMasculino.TabStop = true;
            this.radioSexoMasculino.Text = "Masculino";
            this.radioSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // radioSexoFeminino
            // 
            this.radioSexoFeminino.AutoSize = true;
            this.radioSexoFeminino.Location = new System.Drawing.Point(101, 200);
            this.radioSexoFeminino.Name = "radioSexoFeminino";
            this.radioSexoFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioSexoFeminino.TabIndex = 8;
            this.radioSexoFeminino.Text = "Feminino";
            this.radioSexoFeminino.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(150, 294);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(251, 294);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FrmClienteCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 329);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.radioSexoFeminino);
            this.Controls.Add(this.radioSexoMasculino);
            this.Controls.Add(this.labelLimiteCompra);
            this.Controls.Add(this.dateDataNascimento);
            this.Controls.Add(this.textBoxLimiteCompra);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxLimiteCompra;
        private System.Windows.Forms.DateTimePicker dateDataNascimento;
        private System.Windows.Forms.Label labelLimiteCompra;
        private System.Windows.Forms.RadioButton radioSexoMasculino;
        private System.Windows.Forms.RadioButton radioSexoFeminino;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}