namespace GerenciadorLivro.View
{
    partial class TelaBuscarCod
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
            System.Windows.Forms.Label label1;
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResul = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(82, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Código do livro";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(200, 19);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(100, 23);
            this.textBoxCod.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(172, 232);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblResul
            // 
            this.lblResul.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblResul.Location = new System.Drawing.Point(43, 67);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(308, 137);
            this.lblResul.TabIndex = 3;
            // 
            // TelaBuscarCod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 267);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(label1);
            this.MaximizeBox = false;
            this.Name = "TelaBuscarCod";
            this.ShowIcon = false;
            this.Text = "Buscar por código >>>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxCod;
        private Button btnBuscar;
        private Label lblResul;
    }
}