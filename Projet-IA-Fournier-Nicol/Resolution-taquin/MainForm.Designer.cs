namespace Resolution_taquin
{
    partial class MainForm
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
            this.btnTaquin3X3 = new System.Windows.Forms.Button();
            this.btnTaquin5X5 = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTaquin3X3
            // 
            this.btnTaquin3X3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTaquin3X3.Location = new System.Drawing.Point(74, 97);
            this.btnTaquin3X3.Name = "btnTaquin3X3";
            this.btnTaquin3X3.Size = new System.Drawing.Size(150, 50);
            this.btnTaquin3X3.TabIndex = 0;
            this.btnTaquin3X3.Text = "Taquin 3x3";
            this.btnTaquin3X3.UseVisualStyleBackColor = true;
            this.btnTaquin3X3.Click += new System.EventHandler(this.btnTaquin3X3_Click);
            // 
            // btnTaquin5X5
            // 
            this.btnTaquin5X5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTaquin5X5.Location = new System.Drawing.Point(74, 172);
            this.btnTaquin5X5.Name = "btnTaquin5X5";
            this.btnTaquin5X5.Size = new System.Drawing.Size(150, 50);
            this.btnTaquin5X5.TabIndex = 1;
            this.btnTaquin5X5.Text = "Taquin 5x5";
            this.btnTaquin5X5.UseVisualStyleBackColor = true;
            this.btnTaquin5X5.Click += new System.EventHandler(this.btnTaquin5X5_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitre.Location = new System.Drawing.Point(56, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(180, 52);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Résolution du jeu\r\nde taquin par A*";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnTaquin5X5);
            this.Controls.Add(this.btnTaquin3X3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Projet IA - Fournier Nicol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaquin3X3;
        private System.Windows.Forms.Button btnTaquin5X5;
        private System.Windows.Forms.Label lblTitre;
    }
}