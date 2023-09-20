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
            gvCargos = new DataGridView();
            dataGridView1 = new DataGridView();
            cmbCargo = new ComboBox();
            label15 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label16 = new Label();
            dateTimePicker2 = new DateTimePicker();
            checkBox1 = new CheckBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)gvCargos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(7, 21);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(116, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Completo";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(7, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(285, 25);
            txtNome.TabIndex = 1;
            // 
            // mtxtCpf
            // 
            mtxtCpf.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtCpf.Location = new Point(303, 44);
            mtxtCpf.Mask = "000,000,000-00";
            mtxtCpf.Name = "mtxtCpf";
            mtxtCpf.Size = new Size(162, 25);
            mtxtCpf.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(145, 160);
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
            label2.Location = new Point(303, 21);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 4;
            label2.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 137);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 6;
            label1.Text = "CEP";
            // 
            // mtxtCep
            // 
            mtxtCep.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtCep.Location = new Point(6, 160);
            mtxtCep.Mask = "00000-000";
            mtxtCep.Name = "mtxtCep";
            mtxtCep.Size = new Size(133, 25);
            mtxtCep.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(6, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 25);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 199);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Logradouro";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(8, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 25);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 75);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 9;
            label4.Text = "RG";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(471, 43);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(141, 25);
            dtpDataNascimento.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(471, 19);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 12;
            label5.Text = "Data Nascimento";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(319, 221);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 25);
            textBox3.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(319, 198);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 13;
            label6.Text = "Número";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(459, 221);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 25);
            textBox4.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(459, 198);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 15;
            label7.Text = "Bairro";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(6, 283);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(265, 25);
            textBox5.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 260);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 17;
            label8.Text = "Cidade";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(277, 280);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(277, 257);
            label9.Name = "label9";
            label9.Size = new Size(27, 20);
            label9.TabIndex = 20;
            label9.Text = "UF";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(171, 98);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(216, 25);
            textBox6.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(171, 75);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 21;
            label10.Text = "Telefone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 78);
            label11.Name = "label11";
            label11.Size = new Size(48, 20);
            label11.TabIndex = 24;
            label11.Text = "Cargo";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(1035, 576);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(141, 30);
            btnSalvar.TabIndex = 25;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(393, 98);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(145, 25);
            textBox7.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(393, 75);
            label12.Name = "label12";
            label12.Size = new Size(101, 20);
            label12.TabIndex = 26;
            label12.Text = "Nacionalidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(6, 19);
            label13.Name = "label13";
            label13.Size = new Size(85, 20);
            label13.TabIndex = 29;
            label13.Text = "Estado Civil";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(6, 42);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 28);
            comboBox3.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(147, 21);
            label14.Name = "label14";
            label14.Size = new Size(127, 20);
            label14.TabIndex = 31;
            label14.Text = "Data de Admissão";
            // 
            // dtpDataAdmissao
            // 
            dtpDataAdmissao.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataAdmissao.Format = DateTimePickerFormat.Short;
            dtpDataAdmissao.Location = new Point(147, 45);
            dtpDataAdmissao.Name = "dtpDataAdmissao";
            dtpDataAdmissao.Size = new Size(156, 25);
            dtpDataAdmissao.TabIndex = 30;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkStatus.Location = new Point(321, 47);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(143, 24);
            chkStatus.TabIndex = 32;
            chkStatus.Text = "Funcionario Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // gvCargos
            // 
            gvCargos.AllowUserToOrderColumns = true;
            gvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCargos.Location = new Point(718, 320);
            gvCargos.Name = "gvCargos";
            gvCargos.RowTemplate.Height = 25;
            gvCargos.Size = new Size(458, 218);
            gvCargos.TabIndex = 35;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 388);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(602, 234);
            dataGridView1.TabIndex = 36;
            // 
            // cmbCargo
            // 
            cmbCargo.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(6, 101);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(172, 28);
            cmbCargo.TabIndex = 37;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(6, 161);
            label15.Name = "label15";
            label15.Size = new Size(127, 20);
            label15.TabIndex = 39;
            label15.Text = "Data de Admissão";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(6, 185);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 25);
            dateTimePicker1.TabIndex = 38;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(189, 163);
            label16.Name = "label16";
            label16.Size = new Size(127, 20);
            label16.TabIndex = 41;
            label16.Text = "Data de Admissão";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(189, 186);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(156, 25);
            dateTimePicker2.TabIndex = 40;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(4, 216);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(143, 24);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "Funcionario Ativo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(42, 8);
            button1.Name = "button1";
            button1.Size = new Size(141, 30);
            button1.TabIndex = 43;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(mtxtCpf);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(mtxtCep);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(dtpDataNascimento);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(42, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 326);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbCargo);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(dtpDataAdmissao);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(chkStatus);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new Point(712, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(467, 261);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // FuncionarioCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 650);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(gvCargos);
            Controls.Add(btnSalvar);
            Name = "FuncionarioCadastrar";
            Load += FuncionarioCadastrar_Load;
            ((System.ComponentModel.ISupportInitialize)gvCargos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
        private ComboBox cmbCargo;
        private Button btnSalvar;
        private TextBox textBox7;
        private Label label12;
        private Label label13;
        private ComboBox comboBox3;
        private Label label14;
        private DateTimePicker dtpDataAdmissao;
        private CheckBox chkStatus;
        private DataGridView gvCargos;
        private DataGridView dataGridView1;
        private Label label15;
        private DateTimePicker dateTimePicker1;
        private Label label16;
        private DateTimePicker dateTimePicker2;
        private CheckBox checkBox1;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}