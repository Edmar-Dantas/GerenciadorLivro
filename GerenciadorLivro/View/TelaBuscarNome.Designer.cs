namespace GerenciadorLivro.View
{
    partial class TelaBuscarNome
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridLivro = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Livro";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(131, 22);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(264, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridLivro
            // 
            this.dataGridLivro.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.autor,
            this.genero,
            this.editora,
            this.ano});
            this.dataGridLivro.Location = new System.Drawing.Point(29, 86);
            this.dataGridLivro.Name = "dataGridLivro";
            this.dataGridLivro.RowTemplate.Height = 25;
            this.dataGridLivro.Size = new System.Drawing.Size(546, 231);
            this.dataGridLivro.TabIndex = 3;
            // 
            // nome
            // 
            this.nome.FillWeight = 150F;
            this.nome.HeaderText = "Nome do livro";
            this.nome.Name = "nome";
            // 
            // autor
            // 
            this.autor.FillWeight = 150F;
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            // 
            // genero
            // 
            this.genero.FillWeight = 150F;
            this.genero.HeaderText = "Gênero";
            this.genero.Name = "genero";
            // 
            // editora
            // 
            this.editora.FillWeight = 150F;
            this.editora.HeaderText = "Editora";
            this.editora.Name = "editora";
            // 
            // ano
            // 
            this.ano.FillWeight = 50F;
            this.ano.HeaderText = "Ano de lançamento";
            this.ano.Name = "ano";
            // 
            // TelaBuscarNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 329);
            this.Controls.Add(this.dataGridLivro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaBuscarNome";
            this.ShowIcon = false;
            this.Text = "Buscar por nome >>>";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private Button btnBuscar;
        private DataGridView dataGridLivro;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn genero;
        private DataGridViewTextBoxColumn editora;
        private DataGridViewTextBoxColumn ano;
    }
}