namespace VisualCalculadora
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            textBox1 = new TextBox();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnSoma = new Button();
            btnPonto = new Button();
            btnIgual = new Button();
            btnMultiplicacao = new Button();
            btnDelete = new Button();
            btnSubtracao = new Button();
            btnZero = new Button();
            btnDivisao = new Button();
            btnApagar = new Button();
            btnOperacao = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MidnightBlue;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 107);
            textBox1.TabIndex = 14;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.Visible = false;
            // 
            // btnUm
            // 
            btnUm.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnUm.Location = new Point(11, 425);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(86, 69);
            btnUm.TabIndex = 0;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            // 
            // btnDois
            // 
            btnDois.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnDois.Location = new Point(103, 425);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(86, 69);
            btnDois.TabIndex = 1;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnTres.Location = new Point(195, 425);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(86, 69);
            btnTres.TabIndex = 2;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            // 
            // btnQuatro
            // 
            btnQuatro.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnQuatro.Location = new Point(12, 334);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(86, 69);
            btnQuatro.TabIndex = 4;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnCinco.Location = new Point(103, 334);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(86, 69);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnSeis.Location = new Point(195, 334);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(86, 69);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            // 
            // btnSete
            // 
            btnSete.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnSete.Location = new Point(12, 242);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(86, 69);
            btnSete.TabIndex = 7;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnOito.Location = new Point(103, 242);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(86, 69);
            btnOito.TabIndex = 8;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            // 
            // btnNove
            // 
            btnNove.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnNove.Location = new Point(195, 242);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(86, 69);
            btnNove.TabIndex = 9;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnSoma.Location = new Point(287, 517);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(86, 69);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            // 
            // btnPonto
            // 
            btnPonto.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnPonto.Location = new Point(103, 517);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(86, 69);
            btnPonto.TabIndex = 10;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnIgual.Location = new Point(195, 517);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(86, 69);
            btnIgual.TabIndex = 11;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnMultiplicacao.Location = new Point(287, 334);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(86, 69);
            btnMultiplicacao.TabIndex = 12;
            btnMultiplicacao.Text = "*";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Center;
            btnDelete.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnDelete.Location = new Point(235, 151);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 70);
            btnDelete.TabIndex = 13;
            btnDelete.UseCompatibleTextRendering = true;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnApagar_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnSubtracao.Location = new Point(287, 425);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(86, 69);
            btnSubtracao.TabIndex = 15;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnZero.Location = new Point(11, 517);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(86, 69);
            btnZero.TabIndex = 16;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            btnDivisao.Location = new Point(287, 242);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(86, 69);
            btnDivisao.TabIndex = 17;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            btnApagar.Font = new Font("Verdana", 32.3F, FontStyle.Bold);
            btnApagar.Location = new Point(12, 151);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(136, 70);
            btnApagar.TabIndex = 18;
            btnApagar.Text = "c";
            btnApagar.TextAlign = ContentAlignment.TopCenter;
            btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnOperacao
            // 
            btnOperacao.AutoSize = true;
            btnOperacao.BackColor = Color.GhostWhite;
            btnOperacao.Font = new Font("Segoe UI", 20F);
            btnOperacao.Location = new Point(23, 52);
            btnOperacao.Name = "btnOperacao";
            btnOperacao.Size = new Size(132, 37);
            btnOperacao.TabIndex = 19;
            btnOperacao.Text = "Operacao";
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(385, 619);
            Controls.Add(btnOperacao);
            Controls.Add(btnApagar);
            Controls.Add(btnDivisao);
            Controls.Add(btnZero);
            Controls.Add(btnSubtracao);
            Controls.Add(textBox1);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnIgual);
            Controls.Add(btnPonto);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnSoma);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnDelete);
            ForeColor = Color.MidnightBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Calculadora";
            Text = "Calculadora";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnSoma;
        private Button btnPonto;
        private Button btnIgual;
        private Button btnMultiplicacao;
        private Button btnDelete;
        private Button btnSubtracao;
        private Button btnZero;
        private Button btnDivisao;
        private Button btnApagar;
        private Label btnOperacao;
    }
}
