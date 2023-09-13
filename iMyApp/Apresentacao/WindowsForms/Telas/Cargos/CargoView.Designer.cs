namespace WindowsForms.Telas.Cargos
{
    partial class CargoView
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
            dataGridView1 = new DataGridView();
            btnNovoCargo = new Button();
            groupBoxCargo = new GroupBox();
            btnSalvar = new Button();
            chkStatus = new CheckBox();
            txtCargo = new TextBox();
            btnRecarregar = new Button();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxCargo.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 204);
            dataGridView1.TabIndex = 0;
            // 
            // btnNovoCargo
            // 
            btnNovoCargo.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovoCargo.Location = new Point(13, 12);
            btnNovoCargo.Name = "btnNovoCargo";
            btnNovoCargo.Size = new Size(132, 33);
            btnNovoCargo.TabIndex = 1;
            btnNovoCargo.Text = "Novo Cargo";
            btnNovoCargo.UseVisualStyleBackColor = true;
            btnNovoCargo.Click += btnNovoCargo_Click;
            // 
            // groupBoxCargo
            // 
            groupBoxCargo.Controls.Add(btnSalvar);
            groupBoxCargo.Controls.Add(chkStatus);
            groupBoxCargo.Controls.Add(txtCargo);
            groupBoxCargo.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxCargo.Location = new Point(12, 45);
            groupBoxCargo.Name = "groupBoxCargo";
            groupBoxCargo.Size = new Size(776, 63);
            groupBoxCargo.TabIndex = 2;
            groupBoxCargo.TabStop = false;
            groupBoxCargo.Text = "Novo Cargo";
            groupBoxCargo.Visible = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(652, 20);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(106, 31);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(520, 22);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(105, 24);
            chkStatus.TabIndex = 1;
            chkStatus.Text = "Cargo Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(6, 22);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(488, 25);
            txtCargo.TabIndex = 0;
            // 
            // btnRecarregar
            // 
            btnRecarregar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecarregar.Location = new Point(692, 123);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(87, 27);
            btnRecarregar.TabIndex = 4;
            btnRecarregar.Text = "Recarregar";
            btnRecarregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 132);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 5;
            label1.Text = "Todos os Cargos (GridView)";
            // 
            // CargoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 401);
            Controls.Add(label1);
            Controls.Add(btnRecarregar);
            Controls.Add(groupBoxCargo);
            Controls.Add(btnNovoCargo);
            Controls.Add(dataGridView1);
            Name = "CargoView";
            Text = "CargoView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxCargo.ResumeLayout(false);
            groupBoxCargo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnNovoCargo;
        private GroupBox groupBoxCargo;
        private Button btnSalvar;
        private CheckBox chkStatus;
        private TextBox txtCargo;
        private Button btnRecarregar;
        private Label label1;
        private ColorDialog colorDialog1;
    }
}