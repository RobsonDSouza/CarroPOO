namespace UIWinFormsApp1
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLigar = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.textBoxImpulso = new System.Windows.Forms.TextBox();
            this.textBoxExibir = new System.Windows.Forms.TextBox();
            this.buttonFrear = new System.Windows.Forms.Button();
            this.buttonTrocarPneu = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPneuDianteiroEsquerdo = new System.Windows.Forms.TextBox();
            this.textBoxPneuTraseiroEsquerdo = new System.Windows.Forms.TextBox();
            this.textBoxPneuDianteiroDireito = new System.Windows.Forms.TextBox();
            this.textBoxPneuTraseiroDireito = new System.Windows.Forms.TextBox();
            this.textBoxPneuDeEstepe = new System.Windows.Forms.TextBox();
            this.comboBoxPneu = new System.Windows.Forms.ComboBox();
            this.Pneu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLigar
            // 
            this.buttonLigar.Location = new System.Drawing.Point(11, 551);
            this.buttonLigar.Name = "buttonLigar";
            this.buttonLigar.Size = new System.Drawing.Size(94, 29);
            this.buttonLigar.TabIndex = 0;
            this.buttonLigar.Text = "Ligar";
            this.buttonLigar.UseVisualStyleBackColor = true;
            this.buttonLigar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Location = new System.Drawing.Point(111, 551);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(107, 29);
            this.buttonAcelerar.TabIndex = 1;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // textBoxImpulso
            // 
            this.textBoxImpulso.Location = new System.Drawing.Point(12, 497);
            this.textBoxImpulso.Multiline = true;
            this.textBoxImpulso.Name = "textBoxImpulso";
            this.textBoxImpulso.Size = new System.Drawing.Size(320, 34);
            this.textBoxImpulso.TabIndex = 2;
            // 
            // textBoxExibir
            // 
            this.textBoxExibir.Location = new System.Drawing.Point(11, 42);
            this.textBoxExibir.Multiline = true;
            this.textBoxExibir.Name = "textBoxExibir";
            this.textBoxExibir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExibir.Size = new System.Drawing.Size(321, 385);
            this.textBoxExibir.TabIndex = 3;
            // 
            // buttonFrear
            // 
            this.buttonFrear.Location = new System.Drawing.Point(224, 551);
            this.buttonFrear.Name = "buttonFrear";
            this.buttonFrear.Size = new System.Drawing.Size(107, 29);
            this.buttonFrear.TabIndex = 1;
            this.buttonFrear.Text = "Frear";
            this.buttonFrear.UseVisualStyleBackColor = true;
            this.buttonFrear.Click += new System.EventHandler(this.buttonFrear_Click);
            // 
            // buttonTrocarPneu
            // 
            this.buttonTrocarPneu.Location = new System.Drawing.Point(173, 596);
            this.buttonTrocarPneu.Name = "buttonTrocarPneu";
            this.buttonTrocarPneu.Size = new System.Drawing.Size(159, 29);
            this.buttonTrocarPneu.TabIndex = 1;
            this.buttonTrocarPneu.Text = "Trocar pneu";
            this.buttonTrocarPneu.UseVisualStyleBackColor = true;
            this.buttonTrocarPneu.Click += new System.EventHandler(this.buttonTrocarPneu_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 474);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 20);
            this.label.TabIndex = 4;
            this.label.Text = "Impulso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detalhes do carro";
            // 
            // textBoxPneuDianteiroEsquerdo
            // 
            this.textBoxPneuDianteiroEsquerdo.Location = new System.Drawing.Point(780, 42);
            this.textBoxPneuDianteiroEsquerdo.Multiline = true;
            this.textBoxPneuDianteiroEsquerdo.Name = "textBoxPneuDianteiroEsquerdo";
            this.textBoxPneuDianteiroEsquerdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuDianteiroEsquerdo.Size = new System.Drawing.Size(229, 298);
            this.textBoxPneuDianteiroEsquerdo.TabIndex = 3;
            // 
            // textBoxPneuTraseiroEsquerdo
            // 
            this.textBoxPneuTraseiroEsquerdo.Location = new System.Drawing.Point(780, 383);
            this.textBoxPneuTraseiroEsquerdo.Multiline = true;
            this.textBoxPneuTraseiroEsquerdo.Name = "textBoxPneuTraseiroEsquerdo";
            this.textBoxPneuTraseiroEsquerdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuTraseiroEsquerdo.Size = new System.Drawing.Size(229, 303);
            this.textBoxPneuTraseiroEsquerdo.TabIndex = 3;
            // 
            // textBoxPneuDianteiroDireito
            // 
            this.textBoxPneuDianteiroDireito.Location = new System.Drawing.Point(1062, 42);
            this.textBoxPneuDianteiroDireito.Multiline = true;
            this.textBoxPneuDianteiroDireito.Name = "textBoxPneuDianteiroDireito";
            this.textBoxPneuDianteiroDireito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuDianteiroDireito.Size = new System.Drawing.Size(229, 298);
            this.textBoxPneuDianteiroDireito.TabIndex = 3;
            // 
            // textBoxPneuTraseiroDireito
            // 
            this.textBoxPneuTraseiroDireito.Location = new System.Drawing.Point(1062, 388);
            this.textBoxPneuTraseiroDireito.Multiline = true;
            this.textBoxPneuTraseiroDireito.Name = "textBoxPneuTraseiroDireito";
            this.textBoxPneuTraseiroDireito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuTraseiroDireito.Size = new System.Drawing.Size(229, 298);
            this.textBoxPneuTraseiroDireito.TabIndex = 3;
            // 
            // textBoxPneuDeEstepe
            // 
            this.textBoxPneuDeEstepe.Location = new System.Drawing.Point(525, 383);
            this.textBoxPneuDeEstepe.Multiline = true;
            this.textBoxPneuDeEstepe.Name = "textBoxPneuDeEstepe";
            this.textBoxPneuDeEstepe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuDeEstepe.Size = new System.Drawing.Size(229, 303);
            this.textBoxPneuDeEstepe.TabIndex = 3;
            this.textBoxPneuDeEstepe.TextChanged += new System.EventHandler(this.textBoxEstepe_TextChanged);
            // 
            // comboBoxPneu
            // 
            this.comboBoxPneu.FormattingEnabled = true;
            this.comboBoxPneu.Items.AddRange(new object[] {
            "PneuDianteiroEsquerdo",
            "PneuDianteiroDireito",
            "PneuTraseiroEsquerdo",
            "PneuTraseiroDireito"});
            this.comboBoxPneu.Location = new System.Drawing.Point(11, 596);
            this.comboBoxPneu.Name = "comboBoxPneu";
            this.comboBoxPneu.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPneu.TabIndex = 5;
            // 
            // Pneu
            // 
            this.Pneu.AutoSize = true;
            this.Pneu.Location = new System.Drawing.Point(780, 12);
            this.Pneu.Name = "Pneu";
            this.Pneu.Size = new System.Drawing.Size(171, 20);
            this.Pneu.TabIndex = 4;
            this.Pneu.Text = "Pneu dianteiro esquerdo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1062, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pneu dianteiro direito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(780, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pneu traseiro esquerdo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1062, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pneu traseiro direito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pneu de estepe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 711);
            this.Controls.Add(this.comboBoxPneu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pneu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxPneuTraseiroDireito);
            this.Controls.Add(this.textBoxPneuDianteiroDireito);
            this.Controls.Add(this.textBoxPneuTraseiroEsquerdo);
            this.Controls.Add(this.textBoxPneuDeEstepe);
            this.Controls.Add(this.textBoxPneuDianteiroEsquerdo);
            this.Controls.Add(this.textBoxExibir);
            this.Controls.Add(this.textBoxImpulso);
            this.Controls.Add(this.buttonTrocarPneu);
            this.Controls.Add(this.buttonFrear);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonLigar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLigar;
        private Button buttonAcelerar;
        private TextBox textBoxImpulso;
        private TextBox textBoxExibir;
        private Button buttonFrear;
        private Button buttonTrocarPneu;
        private Label label;
        private Label label1;
        private TextBox textBoxPneuTraseiroEsquerdo;
        private TextBox textBoxPneuDianteiroDireito;
        private TextBox textBoxPneuTraseiroDireito;
        private TextBox textBoxPneuDeEstepe;
        private TextBox textBoxPneuDianteiroEsquerdo;
        private ComboBox comboBoxPneu;
        private Label Pneu;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}