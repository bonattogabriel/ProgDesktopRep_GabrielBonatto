namespace GabrielBonatto_MacxRoberto_ProjetoFinal.View {
  partial class CadEmpresa {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ED_EMPRESA = new System.Windows.Forms.TextBox();
            this.ED_RAZAO = new System.Windows.Forms.TextBox();
            this.ED_FONE = new System.Windows.Forms.MaskedTextBox();
            this.ED_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razão Social:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fone:";
            // 
            // ED_EMPRESA
            // 
            this.ED_EMPRESA.Location = new System.Drawing.Point(116, 40);
            this.ED_EMPRESA.Name = "ED_EMPRESA";
            this.ED_EMPRESA.ReadOnly = true;
            this.ED_EMPRESA.Size = new System.Drawing.Size(100, 22);
            this.ED_EMPRESA.TabIndex = 1;
            // 
            // ED_RAZAO
            // 
            this.ED_RAZAO.Location = new System.Drawing.Point(116, 68);
            this.ED_RAZAO.MaxLength = 300;
            this.ED_RAZAO.Name = "ED_RAZAO";
            this.ED_RAZAO.Size = new System.Drawing.Size(460, 22);
            this.ED_RAZAO.TabIndex = 1;
            // 
            // ED_FONE
            // 
            this.ED_FONE.Location = new System.Drawing.Point(116, 124);
            this.ED_FONE.Mask = "(999) 00000-0000";
            this.ED_FONE.Name = "ED_FONE";
            this.ED_FONE.Size = new System.Drawing.Size(110, 22);
            this.ED_FONE.TabIndex = 4;
            // 
            // ED_CNPJ
            // 
            this.ED_CNPJ.Location = new System.Drawing.Point(116, 96);
            this.ED_CNPJ.Mask = "99.999.999/9999-99";
            this.ED_CNPJ.Name = "ED_CNPJ";
            this.ED_CNPJ.Size = new System.Drawing.Size(122, 22);
            this.ED_CNPJ.TabIndex = 5;
            // 
            // CadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 196);
            this.Controls.Add(this.ED_CNPJ);
            this.Controls.Add(this.ED_FONE);
            this.Controls.Add(this.ED_RAZAO);
            this.Controls.Add(this.ED_EMPRESA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadEmpresa";
            this.Text = "Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ED_EMPRESA;
        private System.Windows.Forms.TextBox ED_RAZAO;
        private System.Windows.Forms.MaskedTextBox ED_FONE;
        private System.Windows.Forms.MaskedTextBox ED_CNPJ;
    }
}