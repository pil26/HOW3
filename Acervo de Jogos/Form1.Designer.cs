
namespace Acervo_de_Jogos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbPlataforma = new System.Windows.Forms.TextBox();
            this.tbMidia = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbCondic = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgAcervo = new System.Windows.Forms.DataGridView();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMidia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAcervo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plataforma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo da Mídia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Condição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data da Compra";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(88, 23);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(178, 20);
            this.tbNome.TabIndex = 7;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(88, 49);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(178, 20);
            this.tbCategoria.TabIndex = 8;
            // 
            // tbPlataforma
            // 
            this.tbPlataforma.Location = new System.Drawing.Point(88, 75);
            this.tbPlataforma.Name = "tbPlataforma";
            this.tbPlataforma.Size = new System.Drawing.Size(178, 20);
            this.tbPlataforma.TabIndex = 9;
            // 
            // tbMidia
            // 
            this.tbMidia.Location = new System.Drawing.Point(351, 23);
            this.tbMidia.Name = "tbMidia";
            this.tbMidia.Size = new System.Drawing.Size(178, 20);
            this.tbMidia.TabIndex = 10;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(351, 49);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(178, 20);
            this.tbValor.TabIndex = 11;
            // 
            // tbCondic
            // 
            this.tbCondic.Location = new System.Drawing.Point(351, 75);
            this.tbCondic.Name = "tbCondic";
            this.tbCondic.Size = new System.Drawing.Size(178, 20);
            this.tbCondic.TabIndex = 12;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(634, 23);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(178, 20);
            this.tbData.TabIndex = 13;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(28, 115);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 14;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgAcervo
            // 
            this.dgAcervo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAcervo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colNome,
            this.colCategoria,
            this.colPlataforma,
            this.colMidia,
            this.colValor,
            this.colCondicao,
            this.colData});
            this.dgAcervo.Location = new System.Drawing.Point(28, 185);
            this.dgAcervo.Name = "dgAcervo";
            this.dgAcervo.Size = new System.Drawing.Size(840, 252);
            this.dgAcervo.TabIndex = 15;
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Cod.";
            this.colCod.Name = "colCod";
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            // 
            // colPlataforma
            // 
            this.colPlataforma.HeaderText = "Plataforma";
            this.colPlataforma.Name = "colPlataforma";
            // 
            // colMidia
            // 
            this.colMidia.HeaderText = "Mídia";
            this.colMidia.Name = "colMidia";
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            // 
            // colCondicao
            // 
            this.colCondicao.HeaderText = "Condição";
            this.colCondicao.Name = "colCondicao";
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(147, 114);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 16;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 472);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.dgAcervo);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbCondic);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbMidia);
            this.Controls.Add(this.tbPlataforma);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Acervo de Jogos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAcervo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbPlataforma;
        private System.Windows.Forms.TextBox tbMidia;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbCondic;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMidia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.Button btInserir;
    }
}

