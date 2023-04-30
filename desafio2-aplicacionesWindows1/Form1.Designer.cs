namespace desafio2_aplicacionesWindows1
{
    partial class practica1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(practica1));
            this.btnRun = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCaracteres = new System.Windows.Forms.TextBox();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.Location = new System.Drawing.Point(193, 158);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(411, 116);
            this.btnRun.TabIndex = 0;
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Gilroy-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblTitulo.Location = new System.Drawing.Point(372, 95);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(81, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "A correr!";
            this.lblTitulo.MouseLeave += new System.EventHandler(this.lblTitulo_MouseLeave);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(324, 329);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 20);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtCaracteres
            // 
            this.txtCaracteres.Location = new System.Drawing.Point(324, 366);
            this.txtCaracteres.Multiline = true;
            this.txtCaracteres.Name = "txtCaracteres";
            this.txtCaracteres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCaracteres.Size = new System.Drawing.Size(195, 20);
            this.txtCaracteres.TabIndex = 3;
            this.txtCaracteres.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(266, 332);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(52, 13);
            this.lblNumeros.TabIndex = 4;
            this.lblNumeros.Text = "Numeros:";
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Location = new System.Drawing.Point(196, 369);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(122, 13);
            this.lblCaracteres.TabIndex = 5;
            this.lblCaracteres.Text = "Contador de Caracteres:";
            // 
            // practica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCaracteres);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.txtCaracteres);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnRun);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "practica1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Primera Aplicación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.practica1_FormClosed);
            this.Load += new System.EventHandler(this.practica1_Load);
            this.Click += new System.EventHandler(this.practica1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCaracteres;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Label lblCaracteres;
    }
}

