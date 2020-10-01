namespace FormulairesSalaries
{
    partial class FrmModificationSalaire
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
            this.lbSalaire = new System.Windows.Forms.Label();
            this.tbSalaire = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAncienSalaire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSalaire
            // 
            this.lbSalaire.AutoSize = true;
            this.lbSalaire.Location = new System.Drawing.Point(108, 43);
            this.lbSalaire.Name = "lbSalaire";
            this.lbSalaire.Size = new System.Drawing.Size(39, 13);
            this.lbSalaire.TabIndex = 0;
            this.lbSalaire.Text = "Salaire";
            // 
            // tbSalaire
            // 
            this.tbSalaire.Location = new System.Drawing.Point(111, 71);
            this.tbSalaire.Name = "tbSalaire";
            this.tbSalaire.Size = new System.Drawing.Size(156, 20);
            this.tbSalaire.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(111, 170);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(85, 30);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            this.btnValider.Validating += new System.ComponentModel.CancelEventHandler(this.btnValider_Validating);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(202, 170);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(91, 30);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAncienSalaire
            // 
            this.btnAncienSalaire.Location = new System.Drawing.Point(12, 43);
            this.btnAncienSalaire.Name = "btnAncienSalaire";
            this.btnAncienSalaire.Size = new System.Drawing.Size(75, 23);
            this.btnAncienSalaire.TabIndex = 4;
            this.btnAncienSalaire.Text = "Ancien salaire";
            this.btnAncienSalaire.UseVisualStyleBackColor = true;
            this.btnAncienSalaire.Click += new System.EventHandler(this.btnAncienSalaire_Click);
            // 
            // FrmModificationSalaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 221);
            this.Controls.Add(this.btnAncienSalaire);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbSalaire);
            this.Controls.Add(this.lbSalaire);
            this.Name = "FrmModificationSalaire";
            this.Text = "FrmModificationSalaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSalaire;
        private System.Windows.Forms.TextBox tbSalaire;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAncienSalaire;
    }
}