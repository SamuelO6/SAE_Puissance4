

namespace TD4
{
    partial class FormParametrage
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
            this.btnJouer = new System.Windows.Forms.Button();
            this.grpAdv = new System.Windows.Forms.GroupBox();
            this.pnlAdv = new System.Windows.Forms.Panel();
            this.rdoAdvIA = new System.Windows.Forms.RadioButton();
            this.rdoAdvJoueur = new System.Windows.Forms.RadioButton();
            this.grpTaille = new System.Windows.Forms.GroupBox();
            this.pnlTaille = new System.Windows.Forms.Panel();
            this.rdoTaille9x10 = new System.Windows.Forms.RadioButton();
            this.rdoTaille7x8 = new System.Windows.Forms.RadioButton();
            this.rdoTaille8x9 = new System.Windows.Forms.RadioButton();
            this.rdoTaille6x7 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAdv.SuspendLayout();
            this.pnlAdv.SuspendLayout();
            this.grpTaille.SuspendLayout();
            this.pnlTaille.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJouer
            // 
            this.btnJouer.Location = new System.Drawing.Point(47, 230);
            this.btnJouer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(78, 20);
            this.btnJouer.TabIndex = 0;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            // 
            // grpAdv
            // 
            this.grpAdv.Controls.Add(this.pnlAdv);
            this.grpAdv.Location = new System.Drawing.Point(8, 49);
            this.grpAdv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAdv.Name = "grpAdv";
            this.grpAdv.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAdv.Size = new System.Drawing.Size(161, 76);
            this.grpAdv.TabIndex = 1;
            this.grpAdv.TabStop = false;
            this.grpAdv.Text = "Choix de l\'adversaire";
            // 
            // pnlAdv
            // 
            this.pnlAdv.Controls.Add(this.rdoAdvIA);
            this.pnlAdv.Controls.Add(this.rdoAdvJoueur);
            this.pnlAdv.Location = new System.Drawing.Point(4, 18);
            this.pnlAdv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAdv.Name = "pnlAdv";
            this.pnlAdv.Size = new System.Drawing.Size(138, 49);
            this.pnlAdv.TabIndex = 0;
            // 
            // rdoAdvIA
            // 
            this.rdoAdvIA.AutoSize = true;
            this.rdoAdvIA.Location = new System.Drawing.Point(10, 26);
            this.rdoAdvIA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoAdvIA.Name = "rdoAdvIA";
            this.rdoAdvIA.Size = new System.Drawing.Size(36, 19);
            this.rdoAdvIA.TabIndex = 1;
            this.rdoAdvIA.Text = "IA";
            this.rdoAdvIA.UseVisualStyleBackColor = true;
            // 
            // rdoAdvJoueur
            // 
            this.rdoAdvJoueur.AutoSize = true;
            this.rdoAdvJoueur.Checked = true;
            this.rdoAdvJoueur.Location = new System.Drawing.Point(10, 5);
            this.rdoAdvJoueur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoAdvJoueur.Name = "rdoAdvJoueur";
            this.rdoAdvJoueur.Size = new System.Drawing.Size(117, 19);
            this.rdoAdvJoueur.TabIndex = 0;
            this.rdoAdvJoueur.TabStop = true;
            this.rdoAdvJoueur.Text = "Joueur VS. Joueur";
            this.rdoAdvJoueur.UseVisualStyleBackColor = true;
            // 
            // grpTaille
            // 
            this.grpTaille.Controls.Add(this.pnlTaille);
            this.grpTaille.Location = new System.Drawing.Point(8, 139);
            this.grpTaille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTaille.Name = "grpTaille";
            this.grpTaille.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTaille.Size = new System.Drawing.Size(161, 77);
            this.grpTaille.TabIndex = 3;
            this.grpTaille.TabStop = false;
            this.grpTaille.Text = "Taille de la grille";
            // 
            // pnlTaille
            // 
            this.pnlTaille.Controls.Add(this.rdoTaille9x10);
            this.pnlTaille.Controls.Add(this.rdoTaille7x8);
            this.pnlTaille.Controls.Add(this.rdoTaille8x9);
            this.pnlTaille.Controls.Add(this.rdoTaille6x7);
            this.pnlTaille.Location = new System.Drawing.Point(4, 18);
            this.pnlTaille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTaille.Name = "pnlTaille";
            this.pnlTaille.Size = new System.Drawing.Size(138, 52);
            this.pnlTaille.TabIndex = 0;
            // 
            // rdoTaille9x10
            // 
            this.rdoTaille9x10.AutoSize = true;
            this.rdoTaille9x10.Location = new System.Drawing.Point(70, 26);
            this.rdoTaille9x10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTaille9x10.Name = "rdoTaille9x10";
            this.rdoTaille9x10.Size = new System.Drawing.Size(49, 19);
            this.rdoTaille9x10.TabIndex = 3;
            this.rdoTaille9x10.Text = "9x10";
            this.rdoTaille9x10.UseVisualStyleBackColor = true;
            // 
            // rdoTaille7x8
            // 
            this.rdoTaille7x8.AutoSize = true;
            this.rdoTaille7x8.Location = new System.Drawing.Point(10, 26);
            this.rdoTaille7x8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTaille7x8.Name = "rdoTaille7x8";
            this.rdoTaille7x8.Size = new System.Drawing.Size(43, 19);
            this.rdoTaille7x8.TabIndex = 2;
            this.rdoTaille7x8.Text = "7x8";
            this.rdoTaille7x8.UseVisualStyleBackColor = true;
            // 
            // rdoTaille8x9
            // 
            this.rdoTaille8x9.AutoSize = true;
            this.rdoTaille8x9.Location = new System.Drawing.Point(70, 5);
            this.rdoTaille8x9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTaille8x9.Name = "rdoTaille8x9";
            this.rdoTaille8x9.Size = new System.Drawing.Size(43, 19);
            this.rdoTaille8x9.TabIndex = 1;
            this.rdoTaille8x9.Text = "8x9";
            this.rdoTaille8x9.UseVisualStyleBackColor = true;
            // 
            // rdoTaille6x7
            // 
            this.rdoTaille6x7.AutoSize = true;
            this.rdoTaille6x7.Checked = true;
            this.rdoTaille6x7.Location = new System.Drawing.Point(10, 5);
            this.rdoTaille6x7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTaille6x7.Name = "rdoTaille6x7";
            this.rdoTaille6x7.Size = new System.Drawing.Size(43, 19);
            this.rdoTaille6x7.TabIndex = 0;
            this.rdoTaille6x7.TabStop = true;
            this.rdoTaille6x7.Text = "6x7";
            this.rdoTaille6x7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paramètres";
            // 
            // FormParametrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpTaille);
            this.Controls.Add(this.grpAdv);
            this.Controls.Add(this.btnJouer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormParametrage";
            this.Text = "FormParametrage";
            this.grpAdv.ResumeLayout(false);
            this.pnlAdv.ResumeLayout(false);
            this.pnlAdv.PerformLayout();
            this.grpTaille.ResumeLayout(false);
            this.pnlTaille.ResumeLayout(false);
            this.pnlTaille.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnJouer;
        private GroupBox grpAdv;
        private GroupBox grpTaille;
        private RadioButton rdoAdvIA;
        private RadioButton rdoAdvJoueur;
        private Panel pnlTaille;
        private RadioButton rdoTaille8x9;
        private RadioButton rdoTaille6x7;
        private Panel pnlAdv;
        private RadioButton rdoTaille7x8;
        private RadioButton rdoTaille9x10;
        private Label label1;
    }
}