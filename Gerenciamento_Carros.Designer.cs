namespace Sitema2
{
    partial class Gerenciamento_Carros
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.button_pesquisarCliente = new System.Windows.Forms.Button();
            this.button_removerCliente = new System.Windows.Forms.Button();
            this.button_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gerenciamento de Carros";
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(32, 125);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.Size = new System.Drawing.Size(529, 316);
            this.dgvCarros.TabIndex = 7;
            // 
            // button_pesquisarCliente
            // 
            this.button_pesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisarCliente.Location = new System.Drawing.Point(645, 125);
            this.button_pesquisarCliente.Name = "button_pesquisarCliente";
            this.button_pesquisarCliente.Size = new System.Drawing.Size(227, 57);
            this.button_pesquisarCliente.TabIndex = 8;
            this.button_pesquisarCliente.Text = "Pesquisar";
            this.button_pesquisarCliente.UseVisualStyleBackColor = true;
            this.button_pesquisarCliente.Click += new System.EventHandler(this.button_pesquisarCliente_Click);
            // 
            // button_removerCliente
            // 
            this.button_removerCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removerCliente.Location = new System.Drawing.Point(645, 198);
            this.button_removerCliente.Name = "button_removerCliente";
            this.button_removerCliente.Size = new System.Drawing.Size(227, 57);
            this.button_removerCliente.TabIndex = 9;
            this.button_removerCliente.Text = "Remover";
            this.button_removerCliente.UseVisualStyleBackColor = true;
            this.button_removerCliente.Click += new System.EventHandler(this.button_removerCliente_Click);
            // 
            // button_fechar
            // 
            this.button_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fechar.Location = new System.Drawing.Point(645, 384);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(227, 57);
            this.button_fechar.TabIndex = 10;
            this.button_fechar.Text = "Fechar";
            this.button_fechar.UseVisualStyleBackColor = true;
            this.button_fechar.Click += new System.EventHandler(this.button_fechar_Click);
            // 
            // Gerenciamento_Carros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 506);
            this.Controls.Add(this.button_fechar);
            this.Controls.Add(this.button_removerCliente);
            this.Controls.Add(this.button_pesquisarCliente);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gerenciamento_Carros";
            this.Text = "Gerenciamento_Carros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Button button_pesquisarCliente;
        private System.Windows.Forms.Button button_removerCliente;
        private System.Windows.Forms.Button button_fechar;
    }
}