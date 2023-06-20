namespace Trabalho_2C
{
    partial class FormMacaco
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CbAtacar1 = new System.Windows.Forms.CheckBox();
            this.CbDefender2 = new System.Windows.Forms.CheckBox();
            this.CbDefender1 = new System.Windows.Forms.CheckBox();
            this.CbRecarregar1 = new System.Windows.Forms.CheckBox();
            this.CbAtacar2 = new System.Windows.Forms.CheckBox();
            this.CbRecarregar2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbVida1 = new System.Windows.Forms.Label();
            this.LbMunição1 = new System.Windows.Forms.Label();
            this.LbVida2 = new System.Windows.Forms.Label();
            this.LbMunição2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "proximo player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "ação";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CbAtacar1
            // 
            this.CbAtacar1.AutoSize = true;
            this.CbAtacar1.Location = new System.Drawing.Point(136, 143);
            this.CbAtacar1.Name = "CbAtacar1";
            this.CbAtacar1.Size = new System.Drawing.Size(67, 20);
            this.CbAtacar1.TabIndex = 10;
            this.CbAtacar1.Text = "atacar";
            this.CbAtacar1.UseVisualStyleBackColor = true;
            // 
            // CbDefender2
            // 
            this.CbDefender2.AutoSize = true;
            this.CbDefender2.Location = new System.Drawing.Point(529, 218);
            this.CbDefender2.Name = "CbDefender2";
            this.CbDefender2.Size = new System.Drawing.Size(83, 20);
            this.CbDefender2.TabIndex = 11;
            this.CbDefender2.Text = "defender";
            this.CbDefender2.UseVisualStyleBackColor = true;
            this.CbDefender2.Visible = false;
            // 
            // CbDefender1
            // 
            this.CbDefender1.AutoSize = true;
            this.CbDefender1.Location = new System.Drawing.Point(136, 218);
            this.CbDefender1.Name = "CbDefender1";
            this.CbDefender1.Size = new System.Drawing.Size(83, 20);
            this.CbDefender1.TabIndex = 12;
            this.CbDefender1.Text = "defender";
            this.CbDefender1.UseVisualStyleBackColor = true;
            // 
            // CbRecarregar1
            // 
            this.CbRecarregar1.AutoSize = true;
            this.CbRecarregar1.Location = new System.Drawing.Point(136, 298);
            this.CbRecarregar1.Name = "CbRecarregar1";
            this.CbRecarregar1.Size = new System.Drawing.Size(92, 20);
            this.CbRecarregar1.TabIndex = 13;
            this.CbRecarregar1.Text = "recarregar";
            this.CbRecarregar1.UseVisualStyleBackColor = true;
            // 
            // CbAtacar2
            // 
            this.CbAtacar2.AutoSize = true;
            this.CbAtacar2.Location = new System.Drawing.Point(529, 143);
            this.CbAtacar2.Name = "CbAtacar2";
            this.CbAtacar2.Size = new System.Drawing.Size(67, 20);
            this.CbAtacar2.TabIndex = 14;
            this.CbAtacar2.Text = "atacar";
            this.CbAtacar2.UseVisualStyleBackColor = true;
            this.CbAtacar2.Visible = false;
            // 
            // CbRecarregar2
            // 
            this.CbRecarregar2.AutoSize = true;
            this.CbRecarregar2.Location = new System.Drawing.Point(529, 298);
            this.CbRecarregar2.Name = "CbRecarregar2";
            this.CbRecarregar2.Size = new System.Drawing.Size(92, 20);
            this.CbRecarregar2.TabIndex = 15;
            this.CbRecarregar2.Text = "recarregar";
            this.CbRecarregar2.UseVisualStyleBackColor = true;
            this.CbRecarregar2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "vida do macaco 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "munição do macaco 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "vida do macaco 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "munição do macaco 2";
            this.label4.Visible = false;
            // 
            // LbVida1
            // 
            this.LbVida1.AutoSize = true;
            this.LbVida1.Location = new System.Drawing.Point(133, 36);
            this.LbVida1.Name = "LbVida1";
            this.LbVida1.Size = new System.Drawing.Size(14, 16);
            this.LbVida1.TabIndex = 22;
            this.LbVida1.Text = "3";
            // 
            // LbMunição1
            // 
            this.LbMunição1.AutoSize = true;
            this.LbMunição1.Location = new System.Drawing.Point(133, 91);
            this.LbMunição1.Name = "LbMunição1";
            this.LbMunição1.Size = new System.Drawing.Size(14, 16);
            this.LbMunição1.TabIndex = 23;
            this.LbMunição1.Text = "0";
            // 
            // LbVida2
            // 
            this.LbVida2.AutoSize = true;
            this.LbVida2.Location = new System.Drawing.Point(517, 36);
            this.LbVida2.Name = "LbVida2";
            this.LbVida2.Size = new System.Drawing.Size(14, 16);
            this.LbVida2.TabIndex = 24;
            this.LbVida2.Text = "3";
            // 
            // LbMunição2
            // 
            this.LbMunição2.AutoSize = true;
            this.LbMunição2.Location = new System.Drawing.Point(517, 91);
            this.LbMunição2.Name = "LbMunição2";
            this.LbMunição2.Size = new System.Drawing.Size(14, 16);
            this.LbMunição2.TabIndex = 25;
            this.LbMunição2.Text = "0";
            this.LbMunição2.Visible = false;
            // 
            // FormMacaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 479);
            this.Controls.Add(this.LbMunição2);
            this.Controls.Add(this.LbVida2);
            this.Controls.Add(this.LbMunição1);
            this.Controls.Add(this.LbVida1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbRecarregar2);
            this.Controls.Add(this.CbAtacar2);
            this.Controls.Add(this.CbRecarregar1);
            this.Controls.Add(this.CbDefender1);
            this.Controls.Add(this.CbDefender2);
            this.Controls.Add(this.CbAtacar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormMacaco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMacaco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox CbAtacar1;
        private System.Windows.Forms.CheckBox CbDefender2;
        private System.Windows.Forms.CheckBox CbDefender1;
        private System.Windows.Forms.CheckBox CbRecarregar1;
        private System.Windows.Forms.CheckBox CbAtacar2;
        private System.Windows.Forms.CheckBox CbRecarregar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbVida1;
        private System.Windows.Forms.Label LbMunição1;
        private System.Windows.Forms.Label LbVida2;
        private System.Windows.Forms.Label LbMunição2;
    }
}