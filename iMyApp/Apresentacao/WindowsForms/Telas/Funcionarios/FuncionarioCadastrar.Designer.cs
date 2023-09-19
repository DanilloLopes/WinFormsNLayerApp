namespace WindowsForms.Telas.Funcionarios
{
    partial class FuncionarioCadastrar
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
            lblNome = new Label();
            txtNome = new TextBox();
            mtxtCpf = new MaskedTextBox();
            btnBuscar = new Button();
            label2 = new Label();
            label1 = new Label();
            mtxtCep = new MaskedTextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            dtpDataNascimento = new DateTimePicker();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            btnSalvar = new Button();
            textBox7 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            comboBox3 = new ComboBox();
            label14 = new Label();
            dtpDataAdmissao = new DateTimePicker();
            chkStatus = new CheckBox();
            textBox8 = new TextBox();
            gvCargos = new DataGridView();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvCargos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(43, 41);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(116, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Completo";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(43, 64);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(285, 25);
            txtNome.TabIndex = 1;
            // 
            // mtxtCpf
            // 
            mtxtCpf.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtCpf.Location = new Point(339, 64);
            mtxtCpf.Mask = "000,000,000-00";
            mtxtCpf.Name = "mtxtCpf";
            mtxtCpf.Size = new Size(162, 25);
            mtxtCpf.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(181, 180);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(73, 25);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(339, 41);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 4;
            label2.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 157);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 6;
            label1.Text = "CEP";
            // 
            // mtxtCep
            // 
            mtxtCep.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtCep.Location = new Point(42, 180);
            mtxtCep.Mask = "00000-000";
            mtxtCep.Name = "mtxtCep";
            mtxtCep.Size = new Size(133, 25);
            mtxtCep.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(42, 242);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 25);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 219);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Logradouro";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(44, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 25);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 95);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 9;
            label4.Text = "RG";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(507, 63);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(141, 25);
            dtpDataNascimento.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(507, 39);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 12;
            label5.Text = "Data Nascimento";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(355, 241);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 25);
            textBox3.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(355, 218);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 13;
            label6.Text = "Número";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(495, 241);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 25);
            textBox4.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(495, 218);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 15;
            label7.Text = "Bairro";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(42, 303);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(265, 25);
            textBox5.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(42, 280);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 17;
            label8.Text = "Cidade";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(313, 300);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(313, 277);
            label9.Name = "label9";
            label9.Size = new Size(27, 20);
            label9.TabIndex = 20;
            label9.Text = "UF";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(207, 118);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(216, 25);
            textBox6.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(207, 95);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 21;
            label10.Text = "Telefone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(723, 97);
            label11.Name = "label11";
            label11.Size = new Size(48, 20);
            label11.TabIndex = 24;
            label11.Text = "Cargo";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(1040, 558);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(141, 30);
            btnSalvar.TabIndex = 25;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(429, 118);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(145, 25);
            textBox7.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(429, 95);
            label12.Name = "label12";
            label12.Size = new Size(101, 20);
            label12.TabIndex = 26;
            label12.Text = "Nacionalidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(723, 38);
            label13.Name = "label13";
            label13.Size = new Size(85, 20);
            label13.TabIndex = 29;
            label13.Text = "Estado Civil";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(723, 61);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 28);
            comboBox3.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(864, 40);
            label14.Name = "label14";
            label14.Size = new Size(127, 20);
            label14.TabIndex = 31;
            label14.Text = "Data de Admissão";
            // 
            // dtpDataAdmissao
            // 
            dtpDataAdmissao.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataAdmissao.Format = DateTimePickerFormat.Short;
            dtpDataAdmissao.Location = new Point(864, 64);
            dtpDataAdmissao.Name = "dtpDataAdmissao";
            dtpDataAdmissao.Size = new Size(156, 25);
            dtpDataAdmissao.TabIndex = 30;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkStatus.Location = new Point(1038, 65);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(143, 24);
            chkStatus.TabIndex = 32;
            chkStatus.Text = "Funcionario Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(723, 120);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(145, 25);
            textBox8.TabIndex = 34;
            // 
            // gvCargos
            // 
            gvCargos.AllowUserToOrderColumns = true;
            gvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCargos.Location = new Point(723, 166);
            gvCargos.Name = "gvCargos";
            gvCargos.RowTemplate.Height = 25;
            gvCargos.Size = new Size(458, 218);
            gvCargos.TabIndex = 35;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 354);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(602, 234);
            dataGridView1.TabIndex = 36;
            // 
            // FuncionarioCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 600);
            Controls.Add(dataGridView1);
            Controls.Add(gvCargos);
            Controls.Add(textBox8);
            Controls.Add(chkStatus);
            Controls.Add(label14);
            Controls.Add(dtpDataAdmissao);
            Controls.Add(label13);
            Controls.Add(comboBox3);
            Controls.Add(textBox7);
            Controls.Add(label12);
            Controls.Add(btnSalvar);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpDataNascimento);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(mtxtCep);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(mtxtCpf);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FuncionarioCadastrar";
            Load += FuncionarioCadastrar_Load;
            ((System.ComponentModel.ISupportInitialize)gvCargos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private MaskedTextBox mtxtCpf;
        private Button btnBuscar;
        private Label label2;
        private Label label1;
        private MaskedTextBox mtxtCep;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private DateTimePicker dtpDataNascimento;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private Label label11;
        private ComboBox comboBox2;
        private Button btnSalvar;
        private TextBox textBox7;
        private Label label12;
        private Label label13;
        private ComboBox comboBox3;
        private Label label14;
        private DateTimePicker dtpDataAdmissao;
        private CheckBox chkStatus;
        private TextBox textBox8;
        private DataGridView gvCargos;
        private DataGridView dataGridView1;
    }
}