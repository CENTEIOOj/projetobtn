namespace projetobtn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrpicrelogio = new System.Windows.Forms.Timer(this.components);
            this.lblDataText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.picexclamcao = new System.Windows.Forms.PictureBox();
            this.picPergunta = new System.Windows.Forms.PictureBox();
            this.picStop = new System.Windows.Forms.PictureBox();
            this.rbtSTOP = new System.Windows.Forms.RadioButton();
            this.rbtPergunta = new System.Windows.Forms.RadioButton();
            this.rbtExclamacao = new System.Windows.Forms.RadioButton();
            this.rbtInfo = new System.Windows.Forms.RadioButton();
            this.rbtOkOnly = new System.Windows.Forms.RadioButton();
            this.rbtOKCancel = new System.Windows.Forms.RadioButton();
            this.rbtYNCancel = new System.Windows.Forms.RadioButton();
            this.rbtYesNo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltitulomsg = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.picStoptimer = new System.Windows.Forms.PictureBox();
            this.picQuestiontimer = new System.Windows.Forms.PictureBox();
            this.picExclamacaotimer = new System.Windows.Forms.PictureBox();
            this.picInfotimer = new System.Windows.Forms.PictureBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnFECHAR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexclamcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPergunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStoptimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestiontimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExclamacaotimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfotimer)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrpicrelogio
            // 
            this.tmrpicrelogio.Enabled = true;
            this.tmrpicrelogio.Interval = 200;
            this.tmrpicrelogio.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDataText
            // 
            this.lblDataText.AutoSize = true;
            this.lblDataText.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataText.Location = new System.Drawing.Point(802, 9);
            this.lblDataText.Name = "lblDataText";
            this.lblDataText.Size = new System.Drawing.Size(68, 24);
            this.lblDataText.TabIndex = 0;
            this.lblDataText.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picInfo);
            this.groupBox1.Controls.Add(this.picexclamcao);
            this.groupBox1.Controls.Add(this.picPergunta);
            this.groupBox1.Controls.Add(this.picStop);
            this.groupBox1.Controls.Add(this.rbtSTOP);
            this.groupBox1.Controls.Add(this.rbtPergunta);
            this.groupBox1.Controls.Add(this.rbtExclamacao);
            this.groupBox1.Controls.Add(this.rbtInfo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(63, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 337);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SIMBOLOS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // picInfo
            // 
            this.picInfo.Image = ((System.Drawing.Image)(resources.GetObject("picInfo.Image")));
            this.picInfo.Location = new System.Drawing.Point(183, 232);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(60, 50);
            this.picInfo.TabIndex = 9;
            this.picInfo.TabStop = false;
            // 
            // picexclamcao
            // 
            this.picexclamcao.Image = ((System.Drawing.Image)(resources.GetObject("picexclamcao.Image")));
            this.picexclamcao.Location = new System.Drawing.Point(187, 156);
            this.picexclamcao.Name = "picexclamcao";
            this.picexclamcao.Size = new System.Drawing.Size(56, 50);
            this.picexclamcao.TabIndex = 9;
            this.picexclamcao.TabStop = false;
            // 
            // picPergunta
            // 
            this.picPergunta.Image = ((System.Drawing.Image)(resources.GetObject("picPergunta.Image")));
            this.picPergunta.Location = new System.Drawing.Point(187, 91);
            this.picPergunta.Name = "picPergunta";
            this.picPergunta.Size = new System.Drawing.Size(52, 50);
            this.picPergunta.TabIndex = 9;
            this.picPergunta.TabStop = false;
            // 
            // picStop
            // 
            this.picStop.Image = ((System.Drawing.Image)(resources.GetObject("picStop.Image")));
            this.picStop.Location = new System.Drawing.Point(187, 21);
            this.picStop.Name = "picStop";
            this.picStop.Size = new System.Drawing.Size(53, 50);
            this.picStop.TabIndex = 9;
            this.picStop.TabStop = false;
            // 
            // rbtSTOP
            // 
            this.rbtSTOP.AutoSize = true;
            this.rbtSTOP.ForeColor = System.Drawing.Color.Black;
            this.rbtSTOP.Location = new System.Drawing.Point(21, 40);
            this.rbtSTOP.Name = "rbtSTOP";
            this.rbtSTOP.Size = new System.Drawing.Size(66, 20);
            this.rbtSTOP.TabIndex = 2;
            this.rbtSTOP.Text = "STOP";
            this.rbtSTOP.UseVisualStyleBackColor = true;
            this.rbtSTOP.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtPergunta
            // 
            this.rbtPergunta.AutoSize = true;
            this.rbtPergunta.ForeColor = System.Drawing.Color.Black;
            this.rbtPergunta.Location = new System.Drawing.Point(21, 105);
            this.rbtPergunta.Name = "rbtPergunta";
            this.rbtPergunta.Size = new System.Drawing.Size(87, 20);
            this.rbtPergunta.TabIndex = 3;
            this.rbtPergunta.Text = "Pergunta";
            this.rbtPergunta.UseVisualStyleBackColor = true;
            // 
            // rbtExclamacao
            // 
            this.rbtExclamacao.AutoSize = true;
            this.rbtExclamacao.ForeColor = System.Drawing.Color.Black;
            this.rbtExclamacao.Location = new System.Drawing.Point(21, 177);
            this.rbtExclamacao.Name = "rbtExclamacao";
            this.rbtExclamacao.Size = new System.Drawing.Size(110, 20);
            this.rbtExclamacao.TabIndex = 4;
            this.rbtExclamacao.Text = "Exclamacão";
            this.rbtExclamacao.UseVisualStyleBackColor = true;
            // 
            // rbtInfo
            // 
            this.rbtInfo.AutoSize = true;
            this.rbtInfo.ForeColor = System.Drawing.Color.Black;
            this.rbtInfo.Location = new System.Drawing.Point(21, 244);
            this.rbtInfo.Name = "rbtInfo";
            this.rbtInfo.Size = new System.Drawing.Size(102, 20);
            this.rbtInfo.TabIndex = 2;
            this.rbtInfo.Text = "Informacao";
            this.rbtInfo.UseVisualStyleBackColor = true;
            this.rbtInfo.CheckedChanged += new System.EventHandler(this.rbtInfo_CheckedChanged);
            // 
            // rbtOkOnly
            // 
            this.rbtOkOnly.AutoSize = true;
            this.rbtOkOnly.ForeColor = System.Drawing.Color.Black;
            this.rbtOkOnly.Location = new System.Drawing.Point(20, 52);
            this.rbtOkOnly.Name = "rbtOkOnly";
            this.rbtOkOnly.Size = new System.Drawing.Size(80, 19);
            this.rbtOkOnly.TabIndex = 5;
            this.rbtOkOnly.Text = "OKONLY";
            this.rbtOkOnly.UseVisualStyleBackColor = true;
            // 
            // rbtOKCancel
            // 
            this.rbtOKCancel.AutoSize = true;
            this.rbtOKCancel.ForeColor = System.Drawing.Color.Black;
            this.rbtOKCancel.Location = new System.Drawing.Point(20, 106);
            this.rbtOKCancel.Name = "rbtOKCancel";
            this.rbtOKCancel.Size = new System.Drawing.Size(86, 19);
            this.rbtOKCancel.TabIndex = 6;
            this.rbtOKCancel.Text = "OkCancel";
            this.rbtOKCancel.UseVisualStyleBackColor = true;
            // 
            // rbtYNCancel
            // 
            this.rbtYNCancel.AutoSize = true;
            this.rbtYNCancel.ForeColor = System.Drawing.Color.Black;
            this.rbtYNCancel.Location = new System.Drawing.Point(20, 177);
            this.rbtYNCancel.Name = "rbtYNCancel";
            this.rbtYNCancel.Size = new System.Drawing.Size(110, 19);
            this.rbtYNCancel.TabIndex = 7;
            this.rbtYNCancel.Text = "YesNoCancel";
            this.rbtYNCancel.UseVisualStyleBackColor = true;
            // 
            // rbtYesNo
            // 
            this.rbtYesNo.AutoSize = true;
            this.rbtYesNo.ForeColor = System.Drawing.Color.Black;
            this.rbtYesNo.Location = new System.Drawing.Point(20, 245);
            this.rbtYesNo.Name = "rbtYesNo";
            this.rbtYesNo.Size = new System.Drawing.Size(66, 19);
            this.rbtYesNo.TabIndex = 8;
            this.rbtYesNo.Text = "YesNo";
            this.rbtYesNo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.rbtOkOnly);
            this.groupBox2.Controls.Add(this.rbtYesNo);
            this.groupBox2.Controls.Add(this.rbtOKCancel);
            this.groupBox2.Controls.Add(this.rbtYNCancel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(371, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 337);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BOTÕES";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(147, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 50);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(148, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 50);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(148, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 39);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(133, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "MENSAGEM:";
            // 
            // labeltitulomsg
            // 
            this.labeltitulomsg.AutoSize = true;
            this.labeltitulomsg.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulomsg.ForeColor = System.Drawing.Color.Lime;
            this.labeltitulomsg.Location = new System.Drawing.Point(161, 456);
            this.labeltitulomsg.Name = "labeltitulomsg";
            this.labeltitulomsg.Size = new System.Drawing.Size(84, 21);
            this.labeltitulomsg.TabIndex = 11;
            this.labeltitulomsg.Text = "TITULO:";
            this.labeltitulomsg.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(260, 422);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(433, 20);
            this.txtMensagem.TabIndex = 12;
            this.txtMensagem.TextChanged += new System.EventHandler(this.txtMensagem_TextChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(260, 459);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(437, 20);
            this.txtTitulo.TabIndex = 13;
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.Location = new System.Drawing.Point(133, 9);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(643, 24);
            this.labeltitulo.TabIndex = 14;
            this.labeltitulo.Text = "MessageBox.Show (MENSAGEM, TÍTULO , BOTÕES, SIMBOLO)";
            // 
            // picStoptimer
            // 
            this.picStoptimer.Image = ((System.Drawing.Image)(resources.GetObject("picStoptimer.Image")));
            this.picStoptimer.Location = new System.Drawing.Point(59, -4);
            this.picStoptimer.Name = "picStoptimer";
            this.picStoptimer.Size = new System.Drawing.Size(53, 50);
            this.picStoptimer.TabIndex = 10;
            this.picStoptimer.TabStop = false;
            // 
            // picQuestiontimer
            // 
            this.picQuestiontimer.Image = ((System.Drawing.Image)(resources.GetObject("picQuestiontimer.Image")));
            this.picQuestiontimer.Location = new System.Drawing.Point(59, -4);
            this.picQuestiontimer.Name = "picQuestiontimer";
            this.picQuestiontimer.Size = new System.Drawing.Size(52, 50);
            this.picQuestiontimer.TabIndex = 10;
            this.picQuestiontimer.TabStop = false;
            this.picQuestiontimer.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // picExclamacaotimer
            // 
            this.picExclamacaotimer.Image = ((System.Drawing.Image)(resources.GetObject("picExclamacaotimer.Image")));
            this.picExclamacaotimer.Location = new System.Drawing.Point(55, -4);
            this.picExclamacaotimer.Name = "picExclamacaotimer";
            this.picExclamacaotimer.Size = new System.Drawing.Size(56, 50);
            this.picExclamacaotimer.TabIndex = 10;
            this.picExclamacaotimer.TabStop = false;
            // 
            // picInfotimer
            // 
            this.picInfotimer.Image = ((System.Drawing.Image)(resources.GetObject("picInfotimer.Image")));
            this.picInfotimer.Location = new System.Drawing.Point(52, -4);
            this.picInfotimer.Name = "picInfotimer";
            this.picInfotimer.Size = new System.Drawing.Size(60, 50);
            this.picInfotimer.TabIndex = 10;
            this.picInfotimer.TabStop = false;
            this.picInfotimer.Click += new System.EventHandler(this.picInfotimer_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(715, 422);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(87, 24);
            this.btnResultado.TabIndex = 15;
            this.btnResultado.Text = "MOSTRAR RESULTADO";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnFECHAR
            // 
            this.btnFECHAR.Location = new System.Drawing.Point(727, 455);
            this.btnFECHAR.Name = "btnFECHAR";
            this.btnFECHAR.Size = new System.Drawing.Size(75, 23);
            this.btnFECHAR.TabIndex = 16;
            this.btnFECHAR.Text = "FECHAR";
            this.btnFECHAR.UseVisualStyleBackColor = true;
            this.btnFECHAR.Click += new System.EventHandler(this.btnFECHAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 531);
            this.Controls.Add(this.btnFECHAR);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.picInfotimer);
            this.Controls.Add(this.picExclamacaotimer);
            this.Controls.Add(this.picQuestiontimer);
            this.Controls.Add(this.picStoptimer);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.labeltitulomsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDataText);
            this.Name = "Form1";
            this.Text = "FORM MSGBOX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexclamcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPergunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStoptimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestiontimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExclamacaotimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfotimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrpicrelogio;
        private System.Windows.Forms.Label lblDataText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtSTOP;
        private System.Windows.Forms.RadioButton rbtPergunta;
        private System.Windows.Forms.RadioButton rbtExclamacao;
        private System.Windows.Forms.RadioButton rbtInfo;
        private System.Windows.Forms.RadioButton rbtOkOnly;
        private System.Windows.Forms.RadioButton rbtOKCancel;
        private System.Windows.Forms.RadioButton rbtYNCancel;
        private System.Windows.Forms.RadioButton rbtYesNo;
        private System.Windows.Forms.PictureBox picStop;
        private System.Windows.Forms.PictureBox picPergunta;
        private System.Windows.Forms.PictureBox picexclamcao;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltitulomsg;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.PictureBox picStoptimer;
        private System.Windows.Forms.PictureBox picQuestiontimer;
        private System.Windows.Forms.PictureBox picExclamacaotimer;
        private System.Windows.Forms.PictureBox picInfotimer;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnFECHAR;
    }
}

