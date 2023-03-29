
namespace DadosGeracaoArquivo
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
            this.tbxNumFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarRegistro = new System.Windows.Forms.Button();
            this.dgvApresentacao = new System.Windows.Forms.DataGridView();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.sfdGravarArquivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApresentacao)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNumFunc
            // 
            this.tbxNumFunc.Location = new System.Drawing.Point(135, 23);
            this.tbxNumFunc.Name = "tbxNumFunc";
            this.tbxNumFunc.Size = new System.Drawing.Size(100, 20);
            this.tbxNumFunc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nr. de Funcionarios:";
            // 
            // btnCriarRegistro
            // 
            this.btnCriarRegistro.Location = new System.Drawing.Point(257, 21);
            this.btnCriarRegistro.Name = "btnCriarRegistro";
            this.btnCriarRegistro.Size = new System.Drawing.Size(190, 23);
            this.btnCriarRegistro.TabIndex = 2;
            this.btnCriarRegistro.Text = "Criar Linhas para Registro";
            this.btnCriarRegistro.UseVisualStyleBackColor = true;
            this.btnCriarRegistro.Click += new System.EventHandler(this.btnCriarRegistro_Click);
            // 
            // dgvApresentacao
            // 
            this.dgvApresentacao.AllowUserToAddRows = false;
            this.dgvApresentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApresentacao.Location = new System.Drawing.Point(30, 55);
            this.dgvApresentacao.Name = "dgvApresentacao";
            this.dgvApresentacao.Size = new System.Drawing.Size(417, 284);
            this.dgvApresentacao.TabIndex = 3;
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Location = new System.Drawing.Point(30, 358);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(234, 23);
            this.btnCriarArquivo.TabIndex = 4;
            this.btnCriarArquivo.Text = "Criar Arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(270, 358);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(177, 23);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // sfdGravarArquivo
            // 
            this.sfdGravarArquivo.DefaultExt = "*.txt";
            this.sfdGravarArquivo.Filter = "Arquivos textos|*.txt";
            this.sfdGravarArquivo.Title = "Dados para geração de arquivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 393);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.dgvApresentacao);
            this.Controls.Add(this.btnCriarRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNumFunc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApresentacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriarRegistro;
        private System.Windows.Forms.DataGridView dgvApresentacao;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.SaveFileDialog sfdGravarArquivo;
    }
}

