namespace ProjetoCalculadora
{
    partial class frmCadastro
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.chkCinema = new System.Windows.Forms.CheckBox();
            this.chkDormir = new System.Windows.Forms.CheckBox();
            this.chkFerias = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(37, 219);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(203, 219);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calculadora";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(48, 20);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(35, 13);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "label1";
            // 
            // chkCinema
            // 
            this.chkCinema.AutoSize = true;
            this.chkCinema.Location = new System.Drawing.Point(89, 70);
            this.chkCinema.Name = "chkCinema";
            this.chkCinema.Size = new System.Drawing.Size(61, 17);
            this.chkCinema.TabIndex = 3;
            this.chkCinema.Text = "Cinema";
            this.chkCinema.UseVisualStyleBackColor = true;
            // 
            // chkDormir
            // 
            this.chkDormir.AutoSize = true;
            this.chkDormir.Location = new System.Drawing.Point(89, 93);
            this.chkDormir.Name = "chkDormir";
            this.chkDormir.Size = new System.Drawing.Size(56, 17);
            this.chkDormir.TabIndex = 4;
            this.chkDormir.Text = "Dormir";
            this.chkDormir.UseVisualStyleBackColor = true;
            this.chkDormir.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkFerias
            // 
            this.chkFerias.AutoSize = true;
            this.chkFerias.Location = new System.Drawing.Point(89, 117);
            this.chkFerias.Name = "chkFerias";
            this.chkFerias.Size = new System.Drawing.Size(54, 17);
            this.chkFerias.TabIndex = 5;
            this.chkFerias.Text = "Férias";
            this.chkFerias.UseVisualStyleBackColor = true;
            this.chkFerias.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chkFerias);
            this.Controls.Add(this.chkDormir);
            this.Controls.Add(this.chkCinema);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnEnviar);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.CheckBox chkCinema;
        private System.Windows.Forms.CheckBox chkDormir;
        private System.Windows.Forms.CheckBox chkFerias;
    }
}

