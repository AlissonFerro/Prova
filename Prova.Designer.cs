namespace WindowsFormsApp2
{
    partial class Prova
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
            this.rButtonA = new System.Windows.Forms.RadioButton();
            this.rButtonB = new System.Windows.Forms.RadioButton();
            this.rButtonC = new System.Windows.Forms.RadioButton();
            this.rButtonD = new System.Windows.Forms.RadioButton();
            this.rButtonE = new System.Windows.Forms.RadioButton();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblEnunciado = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rButtonA
            // 
            this.rButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.rButtonA.Location = new System.Drawing.Point(90, 150);
            this.rButtonA.Name = "rButtonA";
            this.rButtonA.Size = new System.Drawing.Size(700, 20);
            this.rButtonA.TabIndex = 0;
            this.rButtonA.TabStop = true;
            this.rButtonA.Text = "Alternativa A";
            this.rButtonA.UseVisualStyleBackColor = true;
            this.rButtonA.Checked = true;
            // 
            // rButtonB
            // 
            this.rButtonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.rButtonB.Location = new System.Drawing.Point(90, 200);
            this.rButtonB.Name = "rButtonB";
            this.rButtonB.Size = new System.Drawing.Size(700, 20);
            this.rButtonB.TabIndex = 1;
            this.rButtonB.TabStop = true;
            this.rButtonB.Text = "Alternativa B";
            this.rButtonB.UseVisualStyleBackColor = true;
            // 
            // rButtonC
            // 
            this.rButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.rButtonC.Location = new System.Drawing.Point(90, 250);
            this.rButtonC.Name = "rButtonC";
            this.rButtonC.Size = new System.Drawing.Size(700, 20);
            this.rButtonC.TabIndex = 2;
            this.rButtonC.TabStop = true;
            this.rButtonC.Text = "Alternativa C";
            this.rButtonC.UseVisualStyleBackColor = true;
            // 
            // rButtonD
            // 
            this.rButtonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.rButtonD.Location = new System.Drawing.Point(90, 300);
            this.rButtonD.Name = "rButtonD";
            this.rButtonD.Size = new System.Drawing.Size(700, 20);
            this.rButtonD.TabIndex = 3;
            this.rButtonD.TabStop = true;
            this.rButtonD.Text = "Alternativa D";
            this.rButtonD.UseVisualStyleBackColor = true;
            // 
            // rButtonE
            // 
            this.rButtonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.rButtonE.Location = new System.Drawing.Point(90, 350);
            this.rButtonE.Name = "rButtonE";
            this.rButtonE.Size = new System.Drawing.Size(699, 20);
            this.rButtonE.TabIndex = 4;
            this.rButtonE.TabStop = true;
            this.rButtonE.Text = "Alternativa E";
            this.rButtonE.UseVisualStyleBackColor = true;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNum.Location = new System.Drawing.Point(90, 35);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(28, 17);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "01 ";
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(645, 400);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 7;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(745, 400);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click_1);
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblEnunciado.Location = new System.Drawing.Point(120, 35);
            this.lblEnunciado.Multiline = true;
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.ReadOnly = true;
            this.lblEnunciado.Size = new System.Drawing.Size(738, 105);
            this.lblEnunciado.TabIndex = 10;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(545, 400);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // Prova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 464);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.rButtonE);
            this.Controls.Add(this.rButtonD);
            this.Controls.Add(this.rButtonC);
            this.Controls.Add(this.rButtonB);
            this.Controls.Add(this.rButtonA);
            this.Name = "Prova";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rButtonA;
        private System.Windows.Forms.RadioButton rButtonB;
        private System.Windows.Forms.RadioButton rButtonC;
        private System.Windows.Forms.RadioButton rButtonD;
        private System.Windows.Forms.RadioButton rButtonE;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox lblEnunciado;
        private System.Windows.Forms.Button btnVoltar;
    }
}

