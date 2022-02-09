
namespace WindowsFormsApp2
{
    partial class AdicionarQuestoes
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNumQuestao = new System.Windows.Forms.Label();
            this.txtNumQuestao = new System.Windows.Forms.TextBox();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.txtAltA = new System.Windows.Forms.TextBox();
            this.lblAltA = new System.Windows.Forms.Label();
            this.txtAltB = new System.Windows.Forms.TextBox();
            this.lblAltB = new System.Windows.Forms.Label();
            this.txtAltC = new System.Windows.Forms.TextBox();
            this.lblAltC = new System.Windows.Forms.Label();
            this.txtAltD = new System.Windows.Forms.TextBox();
            this.lblAltD = new System.Windows.Forms.Label();
            this.txtAltE = new System.Windows.Forms.TextBox();
            this.lblAltE = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.txtProva = new System.Windows.Forms.TextBox();
            this.lblProva = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.checkLimpar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(620, 339);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(95, 41);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNumQuestao
            // 
            this.lblNumQuestao.AutoSize = true;
            this.lblNumQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumQuestao.Location = new System.Drawing.Point(574, 33);
            this.lblNumQuestao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumQuestao.Name = "lblNumQuestao";
            this.lblNumQuestao.Size = new System.Drawing.Size(136, 17);
            this.lblNumQuestao.TabIndex = 1;
            this.lblNumQuestao.Text = "Número da Questão";
            // 
            // txtNumQuestao
            // 
            this.txtNumQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumQuestao.Location = new System.Drawing.Point(578, 52);
            this.txtNumQuestao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumQuestao.Name = "txtNumQuestao";
            this.txtNumQuestao.Size = new System.Drawing.Size(29, 23);
            this.txtNumQuestao.TabIndex = 2;
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnunciado.Location = new System.Drawing.Point(44, 52);
            this.txtEnunciado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(451, 82);
            this.txtEnunciado.TabIndex = 4;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(41, 33);
            this.lblEnunciado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(75, 17);
            this.lblEnunciado.TabIndex = 3;
            this.lblEnunciado.Text = "Enunciado";
            // 
            // txtAltA
            // 
            this.txtAltA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltA.Location = new System.Drawing.Point(44, 154);
            this.txtAltA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAltA.Multiline = true;
            this.txtAltA.Name = "txtAltA";
            this.txtAltA.Size = new System.Drawing.Size(451, 82);
            this.txtAltA.TabIndex = 6;
            // 
            // lblAltA
            // 
            this.lblAltA.AutoSize = true;
            this.lblAltA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltA.Location = new System.Drawing.Point(41, 136);
            this.lblAltA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltA.Name = "lblAltA";
            this.lblAltA.Size = new System.Drawing.Size(88, 17);
            this.lblAltA.TabIndex = 5;
            this.lblAltA.Text = "Alternativa A";
            // 
            // txtAltB
            // 
            this.txtAltB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltB.Location = new System.Drawing.Point(44, 257);
            this.txtAltB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAltB.Multiline = true;
            this.txtAltB.Name = "txtAltB";
            this.txtAltB.Size = new System.Drawing.Size(451, 82);
            this.txtAltB.TabIndex = 8;
            // 
            // lblAltB
            // 
            this.lblAltB.AutoSize = true;
            this.lblAltB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltB.Location = new System.Drawing.Point(40, 238);
            this.lblAltB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltB.Name = "lblAltB";
            this.lblAltB.Size = new System.Drawing.Size(88, 17);
            this.lblAltB.TabIndex = 7;
            this.lblAltB.Text = "Alternativa B";
            // 
            // txtAltC
            // 
            this.txtAltC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltC.Location = new System.Drawing.Point(43, 359);
            this.txtAltC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAltC.Multiline = true;
            this.txtAltC.Name = "txtAltC";
            this.txtAltC.Size = new System.Drawing.Size(451, 82);
            this.txtAltC.TabIndex = 10;
            // 
            // lblAltC
            // 
            this.lblAltC.AutoSize = true;
            this.lblAltC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltC.Location = new System.Drawing.Point(40, 340);
            this.lblAltC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltC.Name = "lblAltC";
            this.lblAltC.Size = new System.Drawing.Size(88, 17);
            this.lblAltC.TabIndex = 9;
            this.lblAltC.Text = "Alternativa C";
            // 
            // txtAltD
            // 
            this.txtAltD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltD.Location = new System.Drawing.Point(44, 462);
            this.txtAltD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAltD.Multiline = true;
            this.txtAltD.Name = "txtAltD";
            this.txtAltD.Size = new System.Drawing.Size(451, 82);
            this.txtAltD.TabIndex = 12;
            // 
            // lblAltD
            // 
            this.lblAltD.AutoSize = true;
            this.lblAltD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltD.Location = new System.Drawing.Point(40, 443);
            this.lblAltD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltD.Name = "lblAltD";
            this.lblAltD.Size = new System.Drawing.Size(89, 17);
            this.lblAltD.TabIndex = 11;
            this.lblAltD.Text = "Alternativa D";
            // 
            // txtAltE
            // 
            this.txtAltE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltE.Location = new System.Drawing.Point(44, 564);
            this.txtAltE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAltE.Multiline = true;
            this.txtAltE.Name = "txtAltE";
            this.txtAltE.Size = new System.Drawing.Size(451, 82);
            this.txtAltE.TabIndex = 14;
            // 
            // lblAltE
            // 
            this.lblAltE.AutoSize = true;
            this.lblAltE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltE.Location = new System.Drawing.Point(41, 545);
            this.lblAltE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltE.Name = "lblAltE";
            this.lblAltE.Size = new System.Drawing.Size(88, 17);
            this.lblAltE.TabIndex = 13;
            this.lblAltE.Text = "Alternativa E";
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(574, 162);
            this.lblResp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(119, 17);
            this.lblResp.TabIndex = 15;
            this.lblResp.Text = "Resposta Correta";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(578, 183);
            this.comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(104, 21);
            this.comboBox.TabIndex = 16;
            // 
            // txtProva
            // 
            this.txtProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProva.Location = new System.Drawing.Point(578, 232);
            this.txtProva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProva.Name = "txtProva";
            this.txtProva.Size = new System.Drawing.Size(143, 23);
            this.txtProva.TabIndex = 18;
            // 
            // lblProva
            // 
            this.lblProva.AutoSize = true;
            this.lblProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProva.Location = new System.Drawing.Point(574, 214);
            this.lblProva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProva.Name = "lblProva";
            this.lblProva.Size = new System.Drawing.Size(45, 17);
            this.lblProva.TabIndex = 17;
            this.lblProva.Text = "Prova";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(620, 384);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 41);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // checkLimpar
            // 
            this.checkLimpar.AutoSize = true;
            this.checkLimpar.Location = new System.Drawing.Point(724, 232);
            this.checkLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkLimpar.Name = "checkLimpar";
            this.checkLimpar.Size = new System.Drawing.Size(57, 17);
            this.checkLimpar.TabIndex = 20;
            this.checkLimpar.Text = "Limpar";
            this.checkLimpar.UseVisualStyleBackColor = true;
            // 
            // AdicionarQuestoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 666);
            this.Controls.Add(this.checkLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtProva);
            this.Controls.Add(this.lblProva);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.txtAltE);
            this.Controls.Add(this.lblAltE);
            this.Controls.Add(this.txtAltD);
            this.Controls.Add(this.lblAltD);
            this.Controls.Add(this.txtAltC);
            this.Controls.Add(this.lblAltC);
            this.Controls.Add(this.txtAltB);
            this.Controls.Add(this.lblAltB);
            this.Controls.Add(this.txtAltA);
            this.Controls.Add(this.lblAltA);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.txtNumQuestao);
            this.Controls.Add(this.lblNumQuestao);
            this.Controls.Add(this.btnCadastrar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdicionarQuestoes";
            this.Text = "AdicionarQuestoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNumQuestao;
        private System.Windows.Forms.TextBox txtNumQuestao;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.TextBox txtAltA;
        private System.Windows.Forms.Label lblAltA;
        private System.Windows.Forms.TextBox txtAltB;
        private System.Windows.Forms.Label lblAltB;
        private System.Windows.Forms.TextBox txtAltC;
        private System.Windows.Forms.Label lblAltC;
        private System.Windows.Forms.TextBox txtAltD;
        private System.Windows.Forms.Label lblAltD;
        private System.Windows.Forms.TextBox txtAltE;
        private System.Windows.Forms.Label lblAltE;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox txtProva;
        private System.Windows.Forms.Label lblProva;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox checkLimpar;
    }
}