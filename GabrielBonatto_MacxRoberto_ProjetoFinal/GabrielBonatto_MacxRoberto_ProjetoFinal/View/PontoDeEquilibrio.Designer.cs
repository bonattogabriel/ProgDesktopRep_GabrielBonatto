namespace GabrielBonatto_MacxRoberto_ProjetoFinal.View {
  partial class PontoDeEquilibrio {
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtCustoTotal = new System.Windows.Forms.TextBox();
      this.txtCustoVariável = new System.Windows.Forms.TextBox();
      this.txtPreçoVenda = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(577, 310);
      this.dataGridView1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(92, 315);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(133, 18);
      this.label1.TabIndex = 1;
      this.label1.Text = "Custo Fixo Total";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 338);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(213, 18);
      this.label2.TabIndex = 2;
      this.label2.Text = "Custo Variável por Unidade";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(4, 363);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(223, 18);
      this.label3.TabIndex = 3;
      this.label3.Text = "Preço de Venda por Unidade";
      // 
      // txtCustoTotal
      // 
      this.txtCustoTotal.Location = new System.Drawing.Point(231, 315);
      this.txtCustoTotal.Name = "txtCustoTotal";
      this.txtCustoTotal.Size = new System.Drawing.Size(133, 20);
      this.txtCustoTotal.TabIndex = 4;
      // 
      // txtCustoVariável
      // 
      this.txtCustoVariável.Location = new System.Drawing.Point(231, 339);
      this.txtCustoVariável.Name = "txtCustoVariável";
      this.txtCustoVariável.Size = new System.Drawing.Size(133, 20);
      this.txtCustoVariável.TabIndex = 5;
      // 
      // txtPreçoVenda
      // 
      this.txtPreçoVenda.Location = new System.Drawing.Point(231, 364);
      this.txtPreçoVenda.Name = "txtPreçoVenda";
      this.txtPreçoVenda.Size = new System.Drawing.Size(133, 20);
      this.txtPreçoVenda.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(370, 319);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(161, 12);
      this.label4.TabIndex = 7;
      this.label4.Text = "Legenda: linha do ponto de equilíbrio ->";
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.pictureBox1.Location = new System.Drawing.Point(537, 315);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(32, 27);
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      // 
      // PontoDeEquilibrio
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(573, 387);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtPreçoVenda);
      this.Controls.Add(this.txtCustoVariável);
      this.Controls.Add(this.txtCustoTotal);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "PontoDeEquilibrio";
      this.Text = "PontoDeEquilibrio";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtCustoTotal;
    private System.Windows.Forms.TextBox txtCustoVariável;
    private System.Windows.Forms.TextBox txtPreçoVenda;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}