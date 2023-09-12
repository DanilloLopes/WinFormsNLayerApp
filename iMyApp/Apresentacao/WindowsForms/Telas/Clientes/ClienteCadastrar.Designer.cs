namespace WindowsForms.Telas.Clientes
{
    partial class ClienteCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteCadastrar));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpNascimento = new DateTimePicker();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            cmbBolsaEstudos = new ComboBox();
            chkEhResponsavel = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 21);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 70);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 21);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "CPF";
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(141, 88);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(131, 23);
            dtpNascimento.TabIndex = 3;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(396, 39);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(178, 23);
            txtCpf.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(141, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(249, 23);
            txtNome.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(141, 139);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(192, 23);
            txtTelefone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 121);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(371, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 23);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 121);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(141, 173);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 11;
            label6.Text = "Bolsa de Estudos";
            // 
            // cmbBolsaEstudos
            // 
            cmbBolsaEstudos.FormattingEnabled = true;
            cmbBolsaEstudos.Location = new Point(141, 191);
            cmbBolsaEstudos.Name = "cmbBolsaEstudos";
            cmbBolsaEstudos.Size = new Size(192, 23);
            cmbBolsaEstudos.TabIndex = 12;
            // 
            // chkEhResponsavel
            // 
            chkEhResponsavel.AutoSize = true;
            chkEhResponsavel.Location = new Point(141, 239);
            chkEhResponsavel.Name = "chkEhResponsavel";
            chkEhResponsavel.Size = new Size(180, 19);
            chkEhResponsavel.TabIndex = 13;
            chkEhResponsavel.Text = "Cliente é o responsável legal?";
            chkEhResponsavel.UseVisualStyleBackColor = true;
            // 
            // ClienteCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 318);
            Controls.Add(chkEhResponsavel);
            Controls.Add(cmbBolsaEstudos);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtTelefone);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(txtCpf);
            Controls.Add(dtpNascimento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteCadastrar";
            Text = "ClienteCadastrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpNascimento;
        private TextBox txtCpf;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private ComboBox cmbBolsaEstudos;
        private CheckBox chkEhResponsavel;
    }
}