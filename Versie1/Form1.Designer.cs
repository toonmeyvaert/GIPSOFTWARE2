namespace Versie1
{
    partial class Form1
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
            this.lstAankopen = new System.Windows.Forms.ListBox();
            this.btnKnop = new System.Windows.Forms.Button();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.txtVoorwerp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAankopen
            // 
            this.lstAankopen.FormattingEnabled = true;
            this.lstAankopen.Location = new System.Drawing.Point(270, 37);
            this.lstAankopen.Name = "lstAankopen";
            this.lstAankopen.Size = new System.Drawing.Size(258, 121);
            this.lstAankopen.TabIndex = 15;
            // 
            // btnKnop
            // 
            this.btnKnop.Location = new System.Drawing.Point(21, 119);
            this.btnKnop.Name = "btnKnop";
            this.btnKnop.Size = new System.Drawing.Size(234, 36);
            this.btnKnop.TabIndex = 14;
            this.btnKnop.Text = "Registreer aankoop";
            this.btnKnop.UseVisualStyleBackColor = true;
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(109, 93);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(145, 20);
            this.txtAantal.TabIndex = 13;
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(109, 65);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(145, 20);
            this.txtPrijs.TabIndex = 12;
            // 
            // txtVoorwerp
            // 
            this.txtVoorwerp.Location = new System.Drawing.Point(109, 37);
            this.txtVoorwerp.Name = "txtVoorwerp";
            this.txtVoorwerp.Size = new System.Drawing.Size(145, 20);
            this.txtVoorwerp.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Aantal stuks: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prijs voorwerp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Voorwerp: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 183);
            this.Controls.Add(this.lstAankopen);
            this.Controls.Add(this.btnKnop);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.txtVoorwerp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAankopen;
        private System.Windows.Forms.Button btnKnop;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.TextBox txtVoorwerp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

