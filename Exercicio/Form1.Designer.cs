namespace Exercicio
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
            lblNomeAluno = new Label();
            txtNomeAluno = new TextBox();
            lblProfessor = new Label();
            lblAula = new Label();
            txtProfessor = new TextBox();
            txtAula = new TextBox();
            lblDataAula = new Label();
            dtpDataAula = new DateTimePicker();
            gpbAlunosCadastrados = new GroupBox();
            lblCPF = new Label();
            txtCpf = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblAltura = new Label();
            txtAltura = new TextBox();
            lblPeso = new Label();
            txtPeso = new TextBox();
            txtEndereço = new TextBox();
            lblEndereço = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblNomeAluno
            // 
            lblNomeAluno.AutoSize = true;
            lblNomeAluno.Location = new Point(12, 9);
            lblNomeAluno.Name = "lblNomeAluno";
            lblNomeAluno.Size = new Size(75, 15);
            lblNomeAluno.TabIndex = 0;
            lblNomeAluno.Text = "Nome Aluno";
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(12, 27);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(235, 23);
            txtNomeAluno.TabIndex = 1;
            // 
            // lblProfessor
            // 
            lblProfessor.AutoSize = true;
            lblProfessor.Location = new Point(270, 9);
            lblProfessor.Name = "lblProfessor";
            lblProfessor.Size = new Size(56, 15);
            lblProfessor.TabIndex = 2;
            lblProfessor.Text = "Professor";
            // 
            // lblAula
            // 
            lblAula.AutoSize = true;
            lblAula.Location = new Point(270, 62);
            lblAula.Name = "lblAula";
            lblAula.Size = new Size(31, 15);
            lblAula.TabIndex = 3;
            lblAula.Text = "Aula";
            // 
            // txtProfessor
            // 
            txtProfessor.Location = new Point(270, 27);
            txtProfessor.Name = "txtProfessor";
            txtProfessor.Size = new Size(235, 23);
            txtProfessor.TabIndex = 4;
            // 
            // txtAula
            // 
            txtAula.Location = new Point(270, 80);
            txtAula.Name = "txtAula";
            txtAula.Size = new Size(235, 23);
            txtAula.TabIndex = 5;
            // 
            // lblDataAula
            // 
            lblDataAula.AutoSize = true;
            lblDataAula.Location = new Point(270, 112);
            lblDataAula.Name = "lblDataAula";
            lblDataAula.Size = new Size(74, 15);
            lblDataAula.TabIndex = 6;
            lblDataAula.Text = "Data da Aula";
            // 
            // dtpDataAula
            // 
            dtpDataAula.Location = new Point(270, 130);
            dtpDataAula.Name = "dtpDataAula";
            dtpDataAula.Size = new Size(235, 23);
            dtpDataAula.TabIndex = 7;
            // 
            // gpbAlunosCadastrados
            // 
            gpbAlunosCadastrados.Location = new Point(543, 27);
            gpbAlunosCadastrados.Name = "gpbAlunosCadastrados";
            gpbAlunosCadastrados.Size = new Size(200, 100);
            gpbAlunosCadastrados.TabIndex = 8;
            gpbAlunosCadastrados.TabStop = false;
            gpbAlunosCadastrados.Text = "Aulunos Cadastrados";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(12, 62);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 9;
            lblCPF.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 80);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(235, 23);
            txtCpf.TabIndex = 10;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(12, 112);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 11;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 126);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(235, 23);
            txtTelefone.TabIndex = 12;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(12, 160);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(39, 15);
            lblAltura.TabIndex = 13;
            lblAltura.Text = "Altura";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(12, 178);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(235, 23);
            txtAltura.TabIndex = 14;
            txtAltura.TextChanged += textBox3_TextChanged;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(13, 216);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 15;
            lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(12, 234);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(235, 23);
            txtPeso.TabIndex = 16;
            // 
            // txtEndereço
            // 
            txtEndereço.Location = new Point(12, 290);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(235, 23);
            txtEndereço.TabIndex = 17;
            // 
            // lblEndereço
            // 
            lblEndereço.AutoSize = true;
            lblEndereço.Location = new Point(13, 272);
            lblEndereço.Name = "lblEndereço";
            lblEndereço.Size = new Size(56, 15);
            lblEndereço.TabIndex = 18;
            lblEndereço.Text = "Endereço";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(668, 374);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 19;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(lblEndereço);
            Controls.Add(txtEndereço);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(txtAltura);
            Controls.Add(lblAltura);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtCpf);
            Controls.Add(lblCPF);
            Controls.Add(gpbAlunosCadastrados);
            Controls.Add(dtpDataAula);
            Controls.Add(lblDataAula);
            Controls.Add(txtAula);
            Controls.Add(txtProfessor);
            Controls.Add(lblAula);
            Controls.Add(lblProfessor);
            Controls.Add(txtNomeAluno);
            Controls.Add(lblNomeAluno);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeAluno;             
        private TextBox txtNomeAluno;
        private Label lblProfessor;
        private Label lblAula;
        private TextBox txtProfessor;
        private TextBox txtAula;
        private Label lblDataAula;
        private DateTimePicker dtpDataAula;
        private GroupBox gpbAlunosCadastrados;
        private Label lblCPF;
        private TextBox txtCpf;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblAltura;
        private TextBox txtAltura;
        private Label lblPeso;
        private TextBox txtPeso;
        private TextBox txtEndereço;
        private Label lblEndereço;
        private Button btnCadastrar;
    }
}