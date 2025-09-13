namespace Aula06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInserir = new Button();
            btnAlterar = new Button();
            btnDeletar = new Button();
            btnSelecionar = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            txtId = new TextBox();
            lblId = new Label();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(132, 332);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 29);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(242, 332);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(94, 29);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(357, 332);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(94, 29);
            btnDeletar.TabIndex = 2;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(469, 332);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(94, 29);
            btnSelecionar.TabIndex = 3;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(132, 131);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(331, 27);
            txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(331, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(132, 242);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(331, 27);
            txtTelefone.TabIndex = 6;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(131, 106);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(131, 167);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(131, 220);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 20);
            lblTelefone.TabIndex = 9;
            lblTelefone.Text = "Telefone";
            // 
            // txtId
            // 
            txtId.Location = new Point(132, 61);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 10;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(131, 38);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 11;
            lblId.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(btnSelecionar);
            Controls.Add(btnDeletar);
            Controls.Add(btnAlterar);
            Controls.Add(btnInserir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserir;
        private Button btnAlterar;
        private Button btnDeletar;
        private Button btnSelecionar;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label lblNome;
        private Label lblEmail;
        private Label lblTelefone;
        private TextBox txtId;
        private Label lblId;
    }
}
