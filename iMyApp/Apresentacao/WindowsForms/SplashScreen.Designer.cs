namespace WindowsForms
{
    partial class SplashScreen
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
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 158);
            label1.Name = "label1";
            label1.Size = new Size(439, 86);
            label1.TabIndex = 0;
            label1.Text = "Carregando...";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1, 403);
            label2.Name = "label2";
            label2.Size = new Size(532, 25);
            label2.TabIndex = 3;
            label2.Text = "Aguarde um instante, estamos carregando às informações.";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.SpringGreen;
            progressBar1.Location = new Point(1, 431);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(798, 19);
            progressBar1.TabIndex = 4;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SplashScreen";
            Text = "SplashScreen";
            Shown += SplashScreen_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
    }
}