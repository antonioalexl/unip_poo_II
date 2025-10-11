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
            Nascimento = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Remover = new DataGridViewButtonColumn();
            btnNovo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // dgvContatos
            // 
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Columns.AddRange(new DataGridViewColumn[] { Id_Contato, Nome, Telefone, Email, Nascimento, Editar, Remover });
            dgvContatos.Location = new Point(12, 56);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.ReadOnly = true;
            dgvContatos.RowHeadersWidth = 51;
            dgvContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContatos.Size = new Size(953, 436);
            dgvContatos.TabIndex = 0;
            dgvContatos.CellContentClick += dgvContatos_CellContentClick;
            // 
            // Id_Contato
            // 
            Id_Contato.DataPropertyName = "Id_Contato";
            Id_Contato.HeaderText = "Id";
            Id_Contato.MinimumWidth = 6;
            Id_Contato.Name = "Id_Contato";
            Id_Contato.ReadOnly = true;
            Id_Contato.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 125;
            // 
            // Telefone
            // 
            Telefone.DataPropertyName = "Telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.MinimumWidth = 6;
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            Telefone.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // Nascimento
            // 
            Nascimento.DataPropertyName = "DataNascimento";
            Nascimento.HeaderText = "Nascimento";
            Nascimento.MinimumWidth = 6;
            Nascimento.Name = "Nascimento";
            Nascimento.ReadOnly = true;
            Nascimento.Width = 125;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 125;
            // 
            // Remover
            // 
            Remover.HeaderText = "Remover";
            Remover.MinimumWidth = 6;
            Remover.Name = "Remover";
            Remover.ReadOnly = true;
            Remover.Text = "Remover";
            Remover.UseColumnTextForButtonValue = true;
            Remover.Width = 125;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(12, 21);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // FrmContatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 504);
            Controls.Add(btnNovo);
            Controls.Add(dgvContatos);
            Name = "FrmContatos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmContatos";
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContatos;
        private Button btnNovo;
        private DataGridViewTextBoxColumn Id_Contato;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn Editar;
        private DataGridViewTextBoxColumn Nascimento;
        private DataGridViewButtonColumn Remover;
    }
}