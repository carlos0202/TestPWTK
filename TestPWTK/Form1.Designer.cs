namespace TestPWTK
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reglas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinChars = new System.Windows.Forms.TextBox();
            this.txtNonAlpha = new System.Windows.Forms.TextBox();
            this.txtUppercase = new System.Windows.Forms.TextBox();
            this.TxtMaxChars = new System.Windows.Forms.TextBox();
            this.txtNumerics = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(249, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña";
            // 
            // Reglas
            // 
            this.Reglas.AutoSize = true;
            this.Reglas.Location = new System.Drawing.Point(293, 164);
            this.Reglas.Name = "Reglas";
            this.Reglas.Size = new System.Drawing.Size(40, 13);
            this.Reglas.TabIndex = 2;
            this.Reglas.Text = "Reglas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minimo caracteres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Maximo caracteres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mayuscula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "No alfanumericos";
            // 
            // txtMinChars
            // 
            this.txtMinChars.Location = new System.Drawing.Point(250, 200);
            this.txtMinChars.Name = "txtMinChars";
            this.txtMinChars.Size = new System.Drawing.Size(173, 20);
            this.txtMinChars.TabIndex = 8;
            // 
            // txtNonAlpha
            // 
            this.txtNonAlpha.Location = new System.Drawing.Point(250, 329);
            this.txtNonAlpha.Name = "txtNonAlpha";
            this.txtNonAlpha.Size = new System.Drawing.Size(173, 20);
            this.txtNonAlpha.TabIndex = 9;
            // 
            // txtUppercase
            // 
            this.txtUppercase.Location = new System.Drawing.Point(250, 286);
            this.txtUppercase.Name = "txtUppercase";
            this.txtUppercase.Size = new System.Drawing.Size(173, 20);
            this.txtUppercase.TabIndex = 10;
            // 
            // TxtMaxChars
            // 
            this.TxtMaxChars.Location = new System.Drawing.Point(250, 243);
            this.TxtMaxChars.Name = "TxtMaxChars";
            this.TxtMaxChars.Size = new System.Drawing.Size(173, 20);
            this.TxtMaxChars.TabIndex = 11;
            // 
            // txtNumerics
            // 
            this.txtNumerics.Location = new System.Drawing.Point(250, 372);
            this.txtNumerics.Name = "txtNumerics";
            this.txtNumerics.Size = new System.Drawing.Size(173, 20);
            this.txtNumerics.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Numericos";
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(82, 457);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(469, 92);
            this.rtbResultado.TabIndex = 14;
            this.rtbResultado.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 586);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.txtNumerics);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtMaxChars);
            this.Controls.Add(this.txtUppercase);
            this.Controls.Add(this.txtNonAlpha);
            this.Controls.Add(this.txtMinChars);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Reglas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Name = "Form1";
            this.Text = "Prueba PWDTK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Reglas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinChars;
        private System.Windows.Forms.TextBox txtNonAlpha;
        private System.Windows.Forms.TextBox txtUppercase;
        private System.Windows.Forms.TextBox TxtMaxChars;
        private System.Windows.Forms.TextBox txtNumerics;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label label7;

    }
}

