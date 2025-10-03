namespace Desktop
{
    partial class FrmContatos
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
            dgvContatos = new DataGridView();
            Id_Contato = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnNovoContato = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // dgvContatos
            // 
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Columns.AddRange(new DataGridViewColumn[] { Id_Contato, Nome, Telefone, Email });
            dgvContatos.Location = new Point(12, 79);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.RowHeadersWidth = 51;
            dgvContatos.Size = new Size(835, 422);
            dgvContatos.TabIndex = 0;
            // 
            // Id_Contato
            // 
            Id_Contato.DataPropertyName = "Id_Contato";
            Id_Contato.HeaderText = "ID";
            Id_Contato.MinimumWidth = 6;
            Id_Contato.Name = "Id_Contato";
            Id_Contato.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 125;
            // 
            // Telefone
            // 
            Telefone.DataPropertyName = "Telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.MinimumWidth = 6;
            Telefone.Name = "Telefone";
            Telefone.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // btnNovoContato
            // 
            btnNovoContato.Location = new Point(12, 28);
            btnNovoContato.Name = "btnNovoContato";
            btnNovoContato.Size = new Size(94, 29);
            btnNovoContato.TabIndex = 1;
            btnNovoContato.Text = "Novo";
            btnNovoContato.UseVisualStyleBackColor = true;
            btnNovoContato.Click += btnNovoContato_Click;
            // 
            // FrmContatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 513);
            Controls.Add(btnNovoContato);
            Controls.Add(dgvContatos);
            Name = "FrmContatos";
            Text = "FrmContatos";
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContatos;
        private Button btnNovoContato;
        private DataGridViewTextBoxColumn Id_Contato;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
    }
}