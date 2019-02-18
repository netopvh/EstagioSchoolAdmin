namespace SchoolAdmin.View
{
    partial class frmMenuFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuFinanceiro));
            this.btnLancarContasPagar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarContasPagar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLancarContasPagar
            // 
            this.btnLancarContasPagar.Location = new System.Drawing.Point(11, 29);
            this.btnLancarContasPagar.Name = "btnLancarContasPagar";
            this.btnLancarContasPagar.Size = new System.Drawing.Size(160, 23);
            this.btnLancarContasPagar.TabIndex = 0;
            this.btnLancarContasPagar.Text = "Lançar Contas a Pagar";
            this.btnLancarContasPagar.UseVisualStyleBackColor = true;
            this.btnLancarContasPagar.Click += new System.EventHandler(this.btnLancarContasPagar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitarContasPagar);
            this.groupBox1.Controls.Add(this.btnLancarContasPagar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Módulo Financeiro";
            // 
            // btnQuitarContasPagar
            // 
            this.btnQuitarContasPagar.Location = new System.Drawing.Point(11, 58);
            this.btnQuitarContasPagar.Name = "btnQuitarContasPagar";
            this.btnQuitarContasPagar.Size = new System.Drawing.Size(160, 23);
            this.btnQuitarContasPagar.TabIndex = 1;
            this.btnQuitarContasPagar.Text = "Quitar Contas a Pagar";
            this.btnQuitarContasPagar.UseVisualStyleBackColor = true;
            this.btnQuitarContasPagar.Click += new System.EventHandler(this.btnQuitarContasPagar_Click);
            // 
            // frmMenuFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 337);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "School Admin - Financeiro";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLancarContasPagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuitarContasPagar;
    }
}