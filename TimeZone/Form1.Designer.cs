namespace TimeZone
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTimeZone = new System.Windows.Forms.ListBox();
            this.lbDataHora = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTimeZone
            // 
            this.lbTimeZone.FormattingEnabled = true;
            this.lbTimeZone.Location = new System.Drawing.Point(12, 12);
            this.lbTimeZone.Name = "lbTimeZone";
            this.lbTimeZone.Size = new System.Drawing.Size(514, 407);
            this.lbTimeZone.TabIndex = 0;
            // 
            // lbDataHora
            // 
            this.lbDataHora.FormattingEnabled = true;
            this.lbDataHora.Location = new System.Drawing.Point(581, 12);
            this.lbDataHora.Name = "lbDataHora";
            this.lbDataHora.Size = new System.Drawing.Size(514, 407);
            this.lbDataHora.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(514, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listar Time Zone";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(514, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Obter Data e Hora para o Fuso Horário selecionado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDataHora);
            this.Controls.Add(this.lbTimeZone);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTimeZone;
        private System.Windows.Forms.ListBox lbDataHora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

