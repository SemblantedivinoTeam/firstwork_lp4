namespace Trabalho_2C
{
    partial class FormInserir
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
            this.lbldisciplina = new System.Windows.Forms.Label();
            this.cmbdisciplinas = new System.Windows.Forms.ComboBox();
            this.lblenunciado = new System.Windows.Forms.Label();
            this.txtenunciado = new System.Windows.Forms.TextBox();
            this.btninserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldisciplina
            // 
            this.lbldisciplina.AutoSize = true;
            this.lbldisciplina.Location = new System.Drawing.Point(13, 13);
            this.lbldisciplina.Name = "lbldisciplina";
            this.lbldisciplina.Size = new System.Drawing.Size(50, 13);
            this.lbldisciplina.TabIndex = 0;
            this.lbldisciplina.Text = "disciplina";
            // 
            // cmbdisciplinas
            // 
            this.cmbdisciplinas.FormattingEnabled = true;
            this.cmbdisciplinas.Location = new System.Drawing.Point(69, 10);
            this.cmbdisciplinas.Name = "cmbdisciplinas";
            this.cmbdisciplinas.Size = new System.Drawing.Size(174, 21);
            this.cmbdisciplinas.TabIndex = 2;
            this.cmbdisciplinas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblenunciado
            // 
            this.lblenunciado.AutoSize = true;
            this.lblenunciado.Location = new System.Drawing.Point(12, 42);
            this.lblenunciado.Name = "lblenunciado";
            this.lblenunciado.Size = new System.Drawing.Size(57, 13);
            this.lblenunciado.TabIndex = 3;
            this.lblenunciado.Text = "enunciado";
            // 
            // txtenunciado
            // 
            this.txtenunciado.Location = new System.Drawing.Point(12, 58);
            this.txtenunciado.Multiline = true;
            this.txtenunciado.Name = "txtenunciado";
            this.txtenunciado.Size = new System.Drawing.Size(622, 137);
            this.txtenunciado.TabIndex = 4;
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(12, 228);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(622, 23);
            this.btninserir.TabIndex = 6;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // FormInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.txtenunciado);
            this.Controls.Add(this.lblenunciado);
            this.Controls.Add(this.cmbdisciplinas);
            this.Controls.Add(this.lbldisciplina);
            this.Name = "FormInserir";
            this.Text = "Aplicativo de inserção de Questões CPII";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldisciplina;
        private System.Windows.Forms.ComboBox cmbdisciplinas;
        private System.Windows.Forms.Label lblenunciado;
        private System.Windows.Forms.TextBox txtenunciado;
        private System.Windows.Forms.Button btninserir;
    }
}