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
            gvCargos = new DataGridView();
            btnNovoCargo = new Button();
            groupBoxCargo = new GroupBox();
            btnSalvar = new Button();
            chkStatus = new CheckBox();
            txtCargo = new TextBox();
            btnRecarregar = new Button();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)gvCargos).BeginInit();
            groupBoxCargo.SuspendLayout();
            SuspendLayout();
            // 
            // gvCargos
            // 
            gvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCargos.Location = new Point(13, 155);
            gvCargos.Name = "gvCargos";
            gvCargos.RowTemplate.Height = 25;
            gvCargos.Size = new Size(776, 234);
            gvCargos.TabIndex = 0;
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
            btnSalvar.Location = new Point(667, 19);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 31);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(546, 23);
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
            txtCargo.Size = new Size(521, 25);
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
            Controls.Add(gvCargos);
            Name = "CargoView";
            Text = "CargoView";
            ((System.ComponentModel.ISupportInitialize)gvCargos).EndInit();
            groupBoxCargo.ResumeLayout(false);
            groupBoxCargo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvCargos;
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