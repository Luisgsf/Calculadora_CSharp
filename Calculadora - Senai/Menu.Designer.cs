namespace Calculadora___Senai
{
    partial class FormMenu
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
            this.lbRecursos = new System.Windows.Forms.Label();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnCalcIMC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRecursos
            // 
            this.lbRecursos.AutoSize = true;
            this.lbRecursos.Font = new System.Drawing.Font("Tw Cen MT Condensed", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecursos.Location = new System.Drawing.Point(70, 33);
            this.lbRecursos.Name = "lbRecursos";
            this.lbRecursos.Size = new System.Drawing.Size(212, 34);
            this.lbRecursos.TabIndex = 0;
            this.lbRecursos.Text = "Recursos do Programa";
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Location = new System.Drawing.Point(101, 132);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(150, 23);
            this.btnCalculadora.TabIndex = 1;
            this.btnCalculadora.Text = "Calculadora Comum";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnCalcIMC
            // 
            this.btnCalcIMC.Location = new System.Drawing.Point(101, 176);
            this.btnCalcIMC.Name = "btnCalcIMC";
            this.btnCalcIMC.Size = new System.Drawing.Size(150, 23);
            this.btnCalcIMC.TabIndex = 2;
            this.btnCalcIMC.Text = "Calculadora IMC";
            this.btnCalcIMC.UseVisualStyleBackColor = true;
            this.btnCalcIMC.Click += new System.EventHandler(this.btnCalcIMC_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 245);
            this.Controls.Add(this.btnCalcIMC);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.lbRecursos);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecursos;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnCalcIMC;
    }
}