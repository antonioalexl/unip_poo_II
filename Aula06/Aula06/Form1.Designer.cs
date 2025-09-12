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
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(222, 271);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 29);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(335, 271);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(94, 29);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(458, 271);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(94, 29);
            btnDeletar.TabIndex = 2;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(574, 269);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(94, 29);
            btnSelecionar.TabIndex = 3;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelecionar);
            Controls.Add(btnDeletar);
            Controls.Add(btnAlterar);
            Controls.Add(btnInserir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInserir;
        private Button btnAlterar;
        private Button btnDeletar;
        private Button btnSelecionar;
    }
}
