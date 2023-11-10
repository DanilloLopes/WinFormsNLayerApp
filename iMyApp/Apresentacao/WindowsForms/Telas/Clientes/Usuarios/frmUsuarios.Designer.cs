namespace WindowsForms.Telas.Clientes.Usuarios
{
    partial class frmUsuarios
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
            txtTo = new TextBox();
            txtFrom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSubject = new TextBox();
            label4 = new Label();
            txtMessage = new TextBox();
            frmEnviar = new Button();
            SuspendLayout();
            // 
            // txtTo
            // 
            txtTo.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTo.Location = new Point(112, 151);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(362, 25);
            txtTo.TabIndex = 0;
            // 
            // txtFrom
            // 
            txtFrom.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFrom.Location = new Point(112, 81);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(362, 25);
            txtFrom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(112, 58);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 2;
            label1.Text = "De";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(112, 128);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 3;
            label2.Text = "Para";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(112, 202);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Assunto";
            // 
            // txtSubject
            // 
            txtSubject.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubject.Location = new Point(112, 225);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(362, 25);
            txtSubject.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(112, 280);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 7;
            label4.Text = "Mensagem";
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.Location = new Point(112, 303);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(362, 164);
            txtMessage.TabIndex = 6;
            // 
            // frmEnviar
            // 
            frmEnviar.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            frmEnviar.Location = new Point(376, 473);
            frmEnviar.Name = "frmEnviar";
            frmEnviar.Size = new Size(98, 37);
            frmEnviar.TabIndex = 8;
            frmEnviar.Text = "Enviar";
            frmEnviar.UseVisualStyleBackColor = true;
            frmEnviar.Click += frmEnviar_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 540);
            Controls.Add(frmEnviar);
            Controls.Add(label4);
            Controls.Add(txtMessage);
            Controls.Add(label3);
            Controls.Add(txtSubject);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFrom);
            Controls.Add(txtTo);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTo;
        private TextBox txtFrom;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSubject;
        private Label label4;
        private TextBox txtMessage;
        private Button frmEnviar;
    }
}