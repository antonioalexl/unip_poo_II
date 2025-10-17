namespace Desktop
{
    partial class FrmContato
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
            lblId = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblDataNascimento = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            dtpDataNascimento = new DateTimePicker();
            mTxtTelefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(31, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(31, 81);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(31, 148);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 20);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(31, 215);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(31, 280);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(88, 20);
            lblDataNascimento.TabIndex = 4;
            lblDataNascimento.Text = "Nascimento";
            // 
            // txtId
            // 
            txtId.Location = new Point(31, 47);
            txtId.Name = "txtId";
            txtId.Size = new Size(88, 27);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(31, 104);
            txtNome.MaxLength = 255;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(365, 27);
            txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(31, 238);
            txtEmail.MaxLength = 255;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(352, 27);
            txtEmail.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(119, 379);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(109, 54);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(234, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 54);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(31, 303);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(135, 27);
            dtpDataNascimento.TabIndex = 5;
            // 
            // mTxtTelefone
            // 
            mTxtTelefone.Location = new Point(31, 171);
            mTxtTelefone.Mask = "(99) 00000-0000";
            mTxtTelefone.Name = "mTxtTelefone";
            mTxtTelefone.Size = new Size(125, 27);
            mTxtTelefone.TabIndex = 3;
            // 
            // FrmContato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 445);
            Controls.Add(mTxtTelefone);
            Controls.Add(dtpDataNascimento);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "FrmContato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmContato";
            Load += FrmContato_Load;
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblDataNascimento;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Button btnSalvar;
        private Button btnCancelar;
        private DateTimePicker dtpDataNascimento;
        private MaskedTextBox mTxtTelefone;
    }
}